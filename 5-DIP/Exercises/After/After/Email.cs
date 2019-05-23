using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    public class Email : IMessage
    {
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
