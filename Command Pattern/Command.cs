using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public abstract class Command
    {
        public string initialString;
        public Receiver commandReceiver;
        public abstract void execute();
        public abstract void unexecute();
    }
    public class AddCommand : Command
    {
        public int numberPressed;
        public AddCommand(int nP, Receiver r)
        {
            initialString = r.Text;
            numberPressed = nP;
            commandReceiver = r;
        }
        public override void execute()
        {
            commandReceiver.addLetter(numberPressed);
        }
        public override void unexecute()
        {
            commandReceiver.undo(initialString);
        }
    }
    public class EditCommand : Command
    {
        public int numberPressed;
        public EditCommand(int nP, Receiver r)
        {
            initialString = r.Text;
            numberPressed = nP;
            commandReceiver = r;
        }
        public override void execute()
        {
            commandReceiver.editLetter(numberPressed);
        }
        public override void unexecute()
        {
            commandReceiver.undo(initialString);
        }
    }
    public class DeleteCommand : Command
    {
        public DeleteCommand(Receiver r)
        {
            commandReceiver = r;
            initialString = r.Text;
        }
        public override void execute()
        {
            commandReceiver.deleteLetter();
        }
        public override void unexecute()
        {
            commandReceiver.undo(initialString);
        }
    }
}
