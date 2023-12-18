using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR3
{
    internal abstract class Telephone
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public static int Count { get; set; }
        public string Name { get; set; }
        public int Nomer { get; set; }
        public Telephone(double width = 0, double height = 0, double weight = 0, string name = "Telephone") 
        {
            Count++;
            Nomer = Count;
            Width = width;
            Height = height;
            Weight = weight;
            Name = name;
        }

        public abstract string Info();

        public abstract string Volume();
    }

    internal sealed class HomeTelephone : Telephone
    {
        public HomeTelephone(double width = 0, double height = 0, double weight = 0, string name = "Стаціонарний телефон") 
            : base(width, height, weight, name)
        {
            
        }

        public override string Volume()
        {
            return "Volume home telephone";
        }

        public override string Info()
        {
            return $"Телефон {Name}, із шириною {Width}, висотою {Height}, вагою {Weight}, та номером {Nomer}";
        }
    }

    internal sealed class MobilePhone : Telephone
    {
        public MobilePhone(double width = 0, double height = 0, double weight = 0, string name = "Мобільний телефон")
            : base(width, height, weight, name)
        {

        }
        public override string Volume()
        {
            return "Volume mobile telephone";
        }

        public override string Info()
        {
            return $"Телефон {Name}, із шириною {Width}, висотою {Height}, вагою {Weight}, та номером {Nomer}";
        }
    }
}
