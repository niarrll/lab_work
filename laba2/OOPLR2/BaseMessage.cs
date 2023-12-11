using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR2
{
    internal abstract class BaseMessage
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public double Length { get; set; }
        public DateTime CreationDate { get; set; }

        public BaseMessage(string title, string message, double length, DateTime creationDate)
        {
            this.Title = title;
            this.Message = message;
            this.Length = length;
            this.CreationDate = creationDate;
        }
        
        public BaseMessage() : this("Title", "Message", 1, DateTime.Now)
        {
        }

        public string Info()
        {
            return $"Лист із назвою {this.Title}, вмістом: {this.Message}, довжиною: {this.Length}, датою виготовлення: {this.CreationDate.ToShortDateString()}";
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public TimeSpan CountDeviceAge()
        {
            if(DateTime.Now > CreationDate)
                return DateTime.Now - CreationDate;
            else
                return TimeSpan.Zero;
        }
    }
}
