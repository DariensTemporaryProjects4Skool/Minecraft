using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class EventsAndStuff
    {
        public delegate void EventError();
        public delegate int IntDelegate(string input);
        public event EventError EventToBeCalled;
        public event IntDelegate IntDelegateCalled;
        public void Anything()
        {
            EventToBeCalled?.Invoke();
        }

        public int Something(string input)
        {
            if (IntDelegateCalled?.Invoke(input) != null)
            {
                Console.WriteLine("Parsing using event");
                return IntDelegateCalled.Invoke(input);
            }
            else
            {
                throw new Exception($"'{input}' ,input could not be checked, delegate is empty");
            };
        }
    }


}
