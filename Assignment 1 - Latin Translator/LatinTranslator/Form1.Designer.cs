namespace LatinTranslator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstWord = new Button();
            secondWord = new Button();
            thirdWord = new Button();
            title = new Label();
            translatedWord = new Label();
            SuspendLayout();
            // 
            // firstWord
            // 
            firstWord.Location = new Point(12, 31);
            firstWord.Name = "firstWord";
            firstWord.Size = new Size(75, 23);
            firstWord.TabIndex = 0;
            firstWord.Text = "autem";
            firstWord.UseVisualStyleBackColor = true;
            firstWord.Click += button1_Click;
            // 
            // secondWord
            // 
            secondWord.Location = new Point(93, 31);
            secondWord.Name = "secondWord";
            secondWord.Size = new Size(75, 23);
            secondWord.TabIndex = 1;
            secondWord.Text = "descendit";
            secondWord.UseVisualStyleBackColor = true;
            secondWord.Click += secondWord_Click;
            // 
            // thirdWord
            // 
            thirdWord.Location = new Point(174, 31);
            thirdWord.Name = "thirdWord";
            thirdWord.Size = new Size(75, 23);
            thirdWord.TabIndex = 2;
            thirdWord.Text = "medium";
            thirdWord.UseVisualStyleBackColor = true;
            thirdWord.Click += thirdWord_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(22, 9);
            title.Name = "title";
            title.Size = new Size(227, 15);
            title.TabIndex = 3;
            title.Text = "Click a word below to translate to English!";
            // 
            // translatedWord
            // 
            translatedWord.AutoSize = true;
            translatedWord.Location = new Point(111, 57);
            translatedWord.Name = "translatedWord";
            translatedWord.Size = new Size(0, 15);
            translatedWord.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 81);
            Controls.Add(translatedWord);
            Controls.Add(title);
            Controls.Add(thirdWord);
            Controls.Add(secondWord);
            Controls.Add(firstWord);
            Name = "Form1";
            Text = "Latin Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button firstWord;
        private Button secondWord;
        private Button thirdWord;
        private Label title;
        private Label translatedWord;
    }
}
