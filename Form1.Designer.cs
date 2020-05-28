namespace StandardPlayingCardSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_UserInput = new System.Windows.Forms.TextBox();
            this.label_DisplayText = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.picture_CardA = new System.Windows.Forms.PictureBox();
            this.picture_CardB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_CardA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_CardB)).BeginInit();
            this.SuspendLayout();
            // 
            // text_UserInput
            // 
            this.text_UserInput.BackColor = System.Drawing.SystemColors.Control;
            this.text_UserInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_UserInput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_UserInput.Location = new System.Drawing.Point(230, 283);
            this.text_UserInput.Name = "text_UserInput";
            this.text_UserInput.Size = new System.Drawing.Size(125, 22);
            this.text_UserInput.TabIndex = 0;
            this.text_UserInput.Text = "<Input>";
            this.text_UserInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userInput_KeyDown);
            // 
            // label_DisplayText
            // 
            this.label_DisplayText.BackColor = System.Drawing.SystemColors.Control;
            this.label_DisplayText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DisplayText.Location = new System.Drawing.Point(142, 130);
            this.label_DisplayText.MaximumSize = new System.Drawing.Size(300, 150);
            this.label_DisplayText.Name = "label_DisplayText";
            this.label_DisplayText.Size = new System.Drawing.Size(300, 150);
            this.label_DisplayText.TabIndex = 1;
            this.label_DisplayText.Text = "<Welcome>";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Queen of Camelot", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.Red;
            this.label_Title.Location = new System.Drawing.Point(151, 64);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(282, 36);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "KingsIsle Kards";
            this.label_Title.Visible = false;
            // 
            // picture_CardA
            // 
            this.picture_CardA.BackColor = System.Drawing.Color.Green;
            this.picture_CardA.Image = global::StandardPlayingCardSystem.Properties.Resources.back_card;
            this.picture_CardA.Location = new System.Drawing.Point(145, 359);
            this.picture_CardA.Name = "picture_CardA";
            this.picture_CardA.Size = new System.Drawing.Size(119, 190);
            this.picture_CardA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_CardA.TabIndex = 3;
            this.picture_CardA.TabStop = false;
            // 
            // picture_CardB
            // 
            this.picture_CardB.BackColor = System.Drawing.Color.Green;
            this.picture_CardB.Image = global::StandardPlayingCardSystem.Properties.Resources.back_card;
            this.picture_CardB.Location = new System.Drawing.Point(323, 359);
            this.picture_CardB.Name = "picture_CardB";
            this.picture_CardB.Size = new System.Drawing.Size(119, 190);
            this.picture_CardB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_CardB.TabIndex = 4;
            this.picture_CardB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Queen of Camelot", 26.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(151, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "KINGS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Queen of Camelot", 26.25F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(245, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "ISLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Queen of Camelot", 26.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(317, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "KARDS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_CardB);
            this.Controls.Add(this.picture_CardA);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_DisplayText);
            this.Controls.Add(this.text_UserInput);
            this.Name = "Form1";
            this.Text = "KingsIsle Kards";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_CardA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_CardB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_UserInput;
        private System.Windows.Forms.Label label_DisplayText;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox picture_CardA;
        private System.Windows.Forms.PictureBox picture_CardB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

