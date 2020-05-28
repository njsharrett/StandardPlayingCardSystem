KingsIsle Entertainment Programming Test by Nicholas Sharrett, May 2020

"KingsIsle Kards" was developed using Visual Studio Community 2019, and is written in C#. The playing card assets it utilizes were created using GIMP.

I decided that the most effective means of representing the playing cards would be as an object that supported fields to denote a card's suit, value, and (later) the image associated with the card. This allowed the cards to be easily manipulating for purposes such as storage and shuffling. An array serves as the master copy for all 52 cards so that each card only needs to be instantiated one time. Every time a new card game is created, these are shuffled into a stack using a version of the Fisher-Yates shuffling algorithm. I used this algorithm because it is the most effective one that I am aware of for these purposes, and I used a stack because it is the data structure that most closely emulates a physical deck of playing cards by allowing only the top card to be pulled whenever the Pop method is called and automatically resizing the deck appropriately whenever this occurs.

No directions were given as far as the means of input was concerned, so I decided to implement text-based user input because it would be the most flexible while allowing for a minimal and unobtrusive UI. The main issue with this approach is that it allows for the user to input any string of characters that they prefer, so it was necessary to give the player explicit directions for proper input, and a reminder whenever they chose not to follow the aforementioned directions. Interpretation of user input was done through a combination of flags to denote where in the program the user currently is and logic statements. For High Card specifically, there are no actions that the individual players perform beyond drawing and flipping a single card each. As such, I felt it would be repetitive and gratuitous to have the player input any commands beyond starting each game, and allowed the game to perform all of the choice-derived actions automatically.

Once the program and all bug testing was completed, I decided to give the project a protoype UI, just to make it a little more interesting to use. I created a series of standard-scale playing cards in GIMP (I hope you don't mind that I used your logo for the card backs) so that the players would have more to look at during the game than simple text. Each card face's bitmap is assigned dynamically to the card objects at runtime based on its value and suit, and is then able to be referenced as a property of the individual card.


Referenced:
Shuffling algorithm used: https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
General: https://docs.microsoft.com/en-us/dotnet/csharp/
Formatted strings in C#: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
TryParse method: https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=netcore-3.1
Working with PictureBox tool: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.picturebox?view=netcore-3.1
Assigning bitmaps to objects dynamically: https://stackoverflow.com/questions/1192054/load-image-from-resources-area-of-project-in-c-sharp