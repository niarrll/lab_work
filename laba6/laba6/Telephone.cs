using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

        public static bool operator==(Telephone t1, Telephone t2)
        {
            return t1.Name == t2.Name;
        }

        public static bool operator !=(Telephone t1, Telephone t2)
        {
            return !(t1==t2);
        }

        public static Telephone operator!(Telephone t1)
        {
            return new MobilePhone(name: new string(t1.Name.Reverse().ToArray()));
        }
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

    internal sealed class SmartPhone : Telephone
    {
        private double a, b, alfa;
        public SmartPhone(double a, double b, double alfa, double width = 0, double height = 0, double weight = 0, string name = "Мобільний телефон")
           : base(width, height, weight, name)
        {
            A = a;
            B = b;
            Alfa = alfa;
        }

        public double A
        {
            get { return a; }
            set { if (value >=0) a = value; }
        }

        public double B
        {
            get { return b; }
            set { if (value >= 0) b = value; }
        }

        public double Alfa
        {
            get { return alfa; }
            set
            {
                if(value >= 0)
                    alfa = value;  
            }
        }

        public Telephone this[int i]
        {
            get { return (i%2 == 0 ? new HomeTelephone() : new MobilePhone()); }
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
