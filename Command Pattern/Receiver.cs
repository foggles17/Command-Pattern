using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class Receiver
    {
        public string Text;
        private static char[][] BUTTON_OPTIONS = new char[][]
        {   
            new char[]{ ' ', '0' },
            new char[]{ '1' },
            new char[]{ 'A', 'B', 'C', 'a', 'b', 'c', '2' },
            new char[]{ 'D', 'E', 'F', 'd', 'e', 'f', '3' },
            new char[]{ 'G', 'H', 'I', 'g', 'h', 'i', '4' },
            new char[]{ 'J', 'K', 'L', 'j', 'k', 'l', '5' },
            new char[]{ 'M', 'N', 'O', 'm', 'n', 'o', '6' },
            new char[]{ 'P', 'Q', 'R', 'S', 'p', 'q', 'r', 's', '7' },
            new char[]{ 'T', 'U', 'V', 't', 'u', 'v', '8' },
            new char[]{ 'W', 'X', 'Y', 'Z', 'w', 'x', 'y', 'z', '9' }
        };
        public Receiver()
        {
            Text = "";
        }
        public void addLetter(int numberPressed)
        {
            Text += BUTTON_OPTIONS[numberPressed][0];
        }
        public void editLetter(int numberPressed)
        {
            int currentIndex = -1;
            for(int i = 0; i < BUTTON_OPTIONS[numberPressed].Length; i++)
            {
                if(BUTTON_OPTIONS[numberPressed][i] == Text.ToCharArray()[Text.Length-1])
                {
                    currentIndex = i;
                }
            }
            if (currentIndex != -1)
            {
                string output = Text.Substring(0, Text.Length - 1);
                char charToAdd;
                if (currentIndex == BUTTON_OPTIONS[numberPressed].Length - 1)
                    charToAdd = BUTTON_OPTIONS[numberPressed][0];
                else
                    charToAdd = BUTTON_OPTIONS[numberPressed][currentIndex + 1];
                output += charToAdd;
                Text = output;
            }
        }
        public void deleteLetter()
        {
            if (Text.Length > 0)
                Text = Text.Substring(0, Text.Length - 1);
        }
        public void undo(string previousState)
        {
            Text = previousState;
        }
    }
}
