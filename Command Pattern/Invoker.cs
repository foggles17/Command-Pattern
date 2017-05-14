using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class Invoker
    {
        private LinkedList<Command> commands = new LinkedList<Command>();
        private LinkedListNode<Command> dummyFirst = new LinkedListNode<Command>(new AddCommand(-1, new Receiver()));
        private LinkedListNode<Command> currentCommand;
        public Invoker()
        {
            currentCommand = dummyFirst;
        }
        public void invokeCommand( Command c )
        {
            if(commands.Count == 0 || currentCommand.Equals(dummyFirst))
            {
                commands.Clear();
                commands.AddLast(c);
                currentCommand = commands.First;
            }
            else
            {
                while(!currentCommand.Equals(commands.Last))
                {
                    commands.RemoveLast();
                }
                commands.AddAfter(currentCommand, c);
                currentCommand = currentCommand.Next;
            }
            currentCommand.Value.execute();
        }

        //canUndo must be true
        public void undo()
        {
            if (canUndo())
            {
                currentCommand.Value.unexecute();
                if (currentCommand.Equals(commands.First))
                {
                    currentCommand = dummyFirst;
                }
                else
                    currentCommand = currentCommand.Previous;
            }
        }

        //canRedo must be true
        public void redo()
        {
            if (canRedo())
            {
                if (currentCommand.Equals(dummyFirst))
                {
                    currentCommand = commands.First;
                }
                else
                    currentCommand = currentCommand.Next;
                currentCommand.Value.execute();
            }
        }
        public bool canUndo()
        {
            if (currentCommand.Equals(dummyFirst))
                return false;
            return true;
        }
        public bool canRedo()
        {
            if (currentCommand.Equals(commands.Last) || commands.Count == 0)
                return false;
            return true;
        }
    }
}
