using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageCode
{
    public abstract class Message
    {
        public abstract string MessageEncodé { get; }
        public string MessageNonEncodé { get; set; }
        public Message(string pMessageNonEncodé)
        {
            MessageNonEncodé = pMessageNonEncodé;
        }
        public override string ToString()
        {
            return MessageEncodé;
        }
    }
}
