namespace Command_Pattern
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
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 12);
            this.outputTextBox.MaxLength = 15;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(150, 20);
            this.outputTextBox.TabIndex = 0;
            // 
            // backspaceButton
            // 
            this.backspaceButton.Location = new System.Drawing.Point(12, 38);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(150, 50);
            this.backspaceButton.TabIndex = 1;
            this.backspaceButton.Text = "Backspace";
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(12, 88);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(50, 50);
            this.oneButton.TabIndex = 2;
            this.oneButton.Text = "1\r\n";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            this.oneButton.MouseLeave += new System.EventHandler(this.oneButton_MouseLeave);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(62, 88);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(50, 50);
            this.twoButton.TabIndex = 3;
            this.twoButton.Text = "2\r\nABC";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            this.twoButton.MouseLeave += new System.EventHandler(this.twoButton_MouseLeave);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(112, 88);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(50, 50);
            this.threeButton.TabIndex = 4;
            this.threeButton.Text = "3\r\nDEF";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            this.threeButton.MouseLeave += new System.EventHandler(this.threeButton_MouseLeave);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(12, 138);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(50, 50);
            this.fourButton.TabIndex = 5;
            this.fourButton.Text = "4\r\nGHI";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            this.fourButton.MouseLeave += new System.EventHandler(this.fourButton_MouseLeave);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(62, 138);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(50, 50);
            this.fiveButton.TabIndex = 6;
            this.fiveButton.Text = "5\r\nJKL";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            this.fiveButton.MouseLeave += new System.EventHandler(this.fiveButton_MouseLeave);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(112, 138);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(50, 50);
            this.sixButton.TabIndex = 7;
            this.sixButton.Text = "6\r\nMNO";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            this.sixButton.MouseLeave += new System.EventHandler(this.sixButton_MouseLeave);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(12, 188);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(50, 50);
            this.sevenButton.TabIndex = 8;
            this.sevenButton.Text = "7\r\nPQRS";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            this.sevenButton.MouseLeave += new System.EventHandler(this.sevenButton_MouseLeave);
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(62, 188);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(50, 50);
            this.eightButton.TabIndex = 9;
            this.eightButton.Text = "8\r\nTUV";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            this.eightButton.MouseLeave += new System.EventHandler(this.eightButton_MouseLeave);
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(112, 188);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(50, 50);
            this.nineButton.TabIndex = 10;
            this.nineButton.Text = "9\r\nWXYZ";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            this.nineButton.MouseLeave += new System.EventHandler(this.nineButton_MouseLeave);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(12, 238);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(50, 50);
            this.undoButton.TabIndex = 11;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(62, 238);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(50, 50);
            this.zeroButton.TabIndex = 12;
            this.zeroButton.Text = "0\r\nspace";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            this.zeroButton.MouseLeave += new System.EventHandler(this.zeroButton_MouseLeave);
            // 
            // redoButton
            // 
            this.redoButton.Location = new System.Drawing.Point(112, 238);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(50, 50);
            this.redoButton.TabIndex = 13;
            this.redoButton.Text = "Redo";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 300);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.outputTextBox);
            this.Name = "Form1";
            this.Text = "Text-Mext";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button redoButton;
    }
}

