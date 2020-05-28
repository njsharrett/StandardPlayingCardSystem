//Developed by Nicholas James Sharrett for the purpose of applying to KingsIsle Entertainment, May 2020

using System;
using System.Collections;
using StandardPlayingCardSystem.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;

namespace StandardPlayingCardSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		enum Suits
        {
			Hearts,
			Diamonds,
			Clubs,
			Spades
		}
		enum Values
		{
			Jack = 11,
			Queen,
			King,
			Ace
		}

		Card[] cardDeck = new Card[52]; //master copy of deck
		Stack playDeck = new Stack(); //shuffled deck for use in play
		int gameState = 0; //used to track where the program currently is (0 = main menu, 1 = High Card)
		bool errorSet = false; //prevents spamming of the error message associated with an invalid entry
		bool useNonInt = false; //used to prevent menu commands other than those being displayed during High Card from being used

		private void Form1_Load(object sender, EventArgs e)
		{

			resize(false);
			label2.BackColor = System.Drawing.Color.Transparent;
			int deckIndex = 0;
			ResourceManager rm = Resources.ResourceManager;

			//generate master deck of 52 cards
			for (int i = 0; i <= 3; i++)
            {
				for(int j = 2; j <= 14; j++)
                {
					cardDeck[deckIndex] = new Card(Enum.GetName(typeof(Suits), i), j);
					deckIndex++;
                }
            }

			//assign each playing card their image (doing so in the prior for loop either at instantiation or immediately after throws a null reference exception)
			foreach(Card playingCard in cardDeck)
            {
				playingCard.setImage((Bitmap)rm.GetObject($"_{playingCard.getValue()}_{playingCard.getSuit()}_card"));
            }

			shuffle(cardDeck, playDeck);
			displayMenu(0);

			//=====================testing===============

			//Card testCard = new Card("Diamonds", 2);
			//Bitmap myImage = (Bitmap)rm.GetObject("_5_Hearts_card");
			//testCard.setImage(myImage);
			//picture_CardB.Image = testCard.getImage();
			//=====================end testing===========
		}

		//==================FUNCTIONS===================
		//this function employs the Fisher-Yates shuffling algorithm to shuffle the deck of cards, then place them into a stack
		public void shuffle(Card[] cardDeck, Stack targetDeck)
        {
			var rand = new Random();
			Card[] cardList = (Card[])cardDeck.Clone();
			targetDeck.Clear(); //empty out any leftover cards
			
			for(int i = 0; i < cardList.Length; i++)
            {
				int j = i + rand.Next(cardList.Length - i); //random number between index of card being shuffled and the total number of cards

				//swap cards i and j
				Card bucket = cardList[i];
				cardList[i] = cardList[j];
				cardList[j] = bucket;
            }

			foreach(Object obj in cardList)
            {
				targetDeck.Push(obj);
            }
        }


		//this function is used as a central storage and dispersal for program outputs to the user that are not game-specific
		public void displayMenu(int menuOption)
        {
            switch (menuOption)
            {
				case -1:
                    if (!errorSet) //prevent message spam
                    {
						label_DisplayText.Text += "\nInvalid entry. Type the number or letter corresponding to your choice, then press the Enter key.";
						errorSet = true; //won't rewrite the error message until a valid input has been entered
                    }
					break;
				case 0:
					label_DisplayText.Text = "Welcome to KingsIsle Kards!\nSelect what you would like to play by entering the corresponding number or letter from the choices below:" +
					"\n   1.) High Card" +
					"\n   2.) Quit";
					break;
				case 1:
					label_DisplayText.Text += "\n   1.) Play\n   2.) Rules\n   3.) Return to main menu\n   4.) Quit";
					break;
				default:
					System.Diagnostics.Debug.WriteLine("Error, impossible game state");
					break;

			}
			text_UserInput.Text = "";
			if (errorSet && menuOption != -1)
				errorSet = false;
        }

		//this method resizes the form so that the playing cards can be hiidden/shown
		public void resize(bool makeBigger)
        {
            if (makeBigger)
            {
				this.Height = 600;
				picture_CardA.Visible = true;
				picture_CardB.Visible = true;
			}
            else
            {
				this.Height = 450;
				picture_CardA.Visible = false;
				picture_CardB.Visible = false;
			}
        }

		//this function is used for playing the game High Card
		public void playHighCard(int inputValue)
        {
            switch (inputValue)
            {
				case 1:
					label_DisplayText.Text = ""; //clear out prior text
					Card[] dealtCards = {(Card)playDeck.Pop(), (Card)playDeck.Pop()};

					for(int i = 0; i <= 1; i++)
                    {
						if (dealtCards[i].getValue() >= 11 && dealtCards[i].getValue() <= 14) //exception handle 
						{
							label_DisplayText.Text += $"Player {i+1}: {Enum.GetName(typeof(Values), dealtCards[i].getValue())} of {dealtCards[i].getSuit()}";
						}
						else
						{
							label_DisplayText.Text += $"Player {i+1}: {dealtCards[i].getValue()} of {dealtCards[i].getSuit()}";
						}
						label_DisplayText.Text += "\n";
					}

					//reveal cards
					picture_CardA.Image = dealtCards[0].getImage();
					picture_CardB.Image = dealtCards[1].getImage();

					//determine winner
					if (dealtCards[0].getValue() > dealtCards[1].getValue())
                    {
						label_DisplayText.Text += "Player 1 Wins!";
                    } 
					else if(dealtCards[0].getValue() < dealtCards[1].getValue())
                    {
						label_DisplayText.Text += "Player 2 Wins!";
					}
                    else
                    {
						label_DisplayText.Text += "It's a Tie!";
                    }

					//prep for next game
					shuffle(cardDeck, playDeck);
					label_DisplayText.Text += "\n\nPlay again? (Y/N)";
					useNonInt = true;

					break;
				case 0:
					label_DisplayText.Text = "Welcome to High Card! Select from the choices below:";
					displayMenu(1);
					break;
				case 2:
					label_DisplayText.Text = "This is a 2 player game. One card for each player will be drawn randomly from the deck. Each card will then " +
						"be displayed, and whichever player has the highest value card wins.";
					displayMenu(1);
					break;
				case 3:
					gameState = 0;
					displayMenu(0);
					resize(false);
					break;
				case 4:
					Close();
					break;
				default:
					displayMenu(-1);
					break;
            }

			text_UserInput.ResetText(); //clear entry text after every input is resolved
		}

		//===================Classes===================
		//class used for playing cards, each card contains a value 1-14 and a suit (heart, spade, diamond, or club)
		public class Card
		{
			private String suit;
			private int value;
			private Bitmap image;

			//no arg, unused
			public Card()
            {

            }

			public Card(String suit, int value)
            {
				this.suit = suit;
				this.value = value;
            }

			public String getSuit()
            {
				return suit;
            }

			public int getValue()
            {
				return value;
            }

			public Bitmap getImage()
            {
				return image;
            }

			public void setImage(Bitmap img)
            {
				image = img;
            }
		}

		//===================EVENTS======================
		//occurs whenever the user hits the Enter key and they have a value in the textbox
        private void userInput_KeyDown(object sender, KeyEventArgs e)
        {
			if(e.KeyCode == Keys.Enter && text_UserInput.TextLength > 0)
            {
				text_UserInput.Text.Replace(" ", String.Empty); //allows user input to be valid even if they include whitespace
				e.SuppressKeyPress = true; //get rid of silly ping noise

				switch (gameState)  //remember to reorder cases based on most likely use
                {
					//player is at base menu
					case 0: 
						if(text_UserInput.Text.Equals("1")) //begin playing High Card
                        {
							gameState = 1;
							playHighCard(0);
							resize(true);
						} else if (text_UserInput.Text.Equals("2")) //quit application
                        {
							Close();
                        } else
                        {
							displayMenu(-1);
                        }
						break;
					//player is playing High Card
					case 1:
						int playerInValue;
						bool inputInt = Int32.TryParse(text_UserInput.Text, out playerInValue); //check to make sure user inputs an int
						if (inputInt && !useNonInt)
						{
							playHighCard(playerInValue);
						}
						else if(useNonInt && (text_UserInput.Text.Equals("Y") || text_UserInput.Text.Equals("y"))) //replay
                        {
							playHighCard(1);
							errorSet = false;
						}
						else if(useNonInt && (text_UserInput.Text.Equals("N") || text_UserInput.Text.Equals("n"))) //return to menu
                        {
							gameState = 0;
							useNonInt = false;
							displayMenu(0);

							//reset form
							resize(false);
							picture_CardA.Image = Properties.Resources.back_card;
							picture_CardB.Image = Properties.Resources.back_card;
                        }
						else
						{
							displayMenu(-1);
						}
						break;
					default:
						displayMenu(-1);
						break;
                }
			}
        }
    }
}
