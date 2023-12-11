using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR2
{
    internal sealed class Message : BaseMessage
    {
        public string TextColor { get; set; }
        public Message(string textColor, string title, string message, double length, DateTime creationDate) 
            : base(title, message, length, creationDate)
        {
            TextColor = textColor;
        }

        public Message(string textColor = "Black") : base()
        {
            TextColor = textColor;
        }
    }
}
