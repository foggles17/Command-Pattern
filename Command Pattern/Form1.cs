using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command_Pattern
{
    public partial class Form1 : Form
    {
        private bool modifyLastLetter = false;
        private Invoker inv;
        private Receiver rec = new Receiver();
        public Form1()
        {
            InitializeComponent();
            inv = new Invoker();
        }
        private void updateTextBox()
        {
            outputTextBox.Text = rec.Text;
        }
        private void numberButtonPress(int number)
        {
            if(modifyLastLetter)
            {
                inv.invokeCommand(new EditCommand(number, rec));
            }
            else
            {
                inv.invokeCommand(new AddCommand(number, rec));
                modifyLastLetter = true;
            }
            updateTextBox();
        }

        //Input Buttons

        private void oneButton_Click  (object sender, EventArgs e) { numberButtonPress(1); }
        private void twoButton_Click  (object sender, EventArgs e) { numberButtonPress(2); }
        private void threeButton_Click(object sender, EventArgs e) { numberButtonPress(3); }
        private void fourButton_Click (object sender, EventArgs e) { numberButtonPress(4); }
        private void fiveButton_Click (object sender, EventArgs e) { numberButtonPress(5); }
        private void sixButton_Click  (object sender, EventArgs e) { numberButtonPress(6); }
        private void sevenButton_Click(object sender, EventArgs e) { numberButtonPress(7); }
        private void eightButton_Click(object sender, EventArgs e) { numberButtonPress(8); }
        private void nineButton_Click (object sender, EventArgs e) { numberButtonPress(9); }
        private void zeroButton_Click (object sender, EventArgs e) { numberButtonPress(0); }

        //Backspace button

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if(outputTextBox.Text.Length > 0)
                inv.invokeCommand(new DeleteCommand(rec));
            updateTextBox();
        }

        //Undo and Redo buttons

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (!inv.canUndo())
                MessageBox.Show("\" 'What's done can't be undone'\n\t-William Shakespeare\"\n\t\t-The Internet");
            inv.undo();
            updateTextBox();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            if (!inv.canRedo())
                MessageBox.Show("I'm sorry, Dave. I can't redo that.");
            inv.redo();
            updateTextBox();
        }

        //MouseLeave responses

        private void oneButton_MouseLeave(object sender, EventArgs e)
        {
            modifyLastLetter = false;
        }

        private void twoButton_MouseLeave(object sender, EventArgs e)
        {
            modifyLastLetter = false;
        }

        private void threeButton_MouseLeave(object sender, EventArgs e)
        {
            modifyLastLetter = false;
        }

        private void fourButton_MouseLeave(object sender, EventArgs e)
        {
            modifyLastLetter = false;
        }

        private void fiveButton_MouseLeave(object sender, EventArgs e)
        {
            modifyLastLetter = false;
        }

        private void sixButton_MouseLeave(object sender, EventArgs e)
        {
            modifyLastLetter = false;
        }

        private void sevenButton_MouseLeave(object sender, EventArgs e)
        {
            modifyLastLetter = false;
        }

        private void eightButton_MouseLeave(object sender, EventArgs e)
        {
            modifyLastLetter = false;
        }

        private void nineButton_MouseLeave(object sender, EventArgs e)
        {
            modifyLastLetter = false;
        }

        private void zeroButton_MouseLeave(object sender, EventArgs e)
        {
            modifyLastLetter = false;
        }
    }
}
