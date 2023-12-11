using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR3
{
    internal class Message
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public double Length { get; set; }
        public static int Count { get; set; }
        public string Name { get; set; }
        public int Nomer { get; set; }
        public Message(string title = "Title", string text = "Text", double length = 1, string name = "Лист") 
        {
            Count++;
            Nomer = Count;
            Title = title;
            Text = text;
            Length = length;
            Name = name;
        }

        public string Info()
        {
            return $"Лист {Name}, із назвою {Title}, вмістом {Text}, кількістю сторінок {Length}, та номером {Nomer}";
        }
    }

    internal sealed class PostMessage : Message
    {
        public PostMessage(string title = "Title", string text = "Text", double length = 1, string name = "Поштовий лист") 
            : base(title, text, length, name)
        {

        }
    }

    internal sealed class EMessage : Message
    {
        public EMessage(string title = "Title", string text = "Text", double length = 1, string name = "Електронний лист")
             : base(title, text, length, name)
        {

        }
    }
}
