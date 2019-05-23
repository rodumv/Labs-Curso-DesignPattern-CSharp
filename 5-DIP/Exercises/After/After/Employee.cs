using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    public class Employee
    {
        private List<IMessage> _messages;
        
        public Employee(List<IMessage> messages)
        {
            _messages = messages;
        }

        public void Send()
        {
            foreach(var message in _messages)
            {
                message.SendMessage();
            }
        }

    }
}
