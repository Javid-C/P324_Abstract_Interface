using P324_Abstract_Interface.BaseEntity;
using P324_Abstract_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Abstract_Interface
{
    class Student : Human,IMentalable,IStudyable
    {
        public byte Point;

        public Student(string name, string surname, byte age, string gender, byte point) : base(name, surname, age, gender)
        {
            Point = point;
        }

        public byte Iq
        {
            get => _iq;
            set
            {
                if (value > 95)
                {
                    _iq = value;
                }
                else
                {
                    Console.WriteLine("95-den kicik ola bilmez");
                }
            }
        }

        public override void Eat()
        {
            Console.WriteLine("Makaran(Corey ile)");
        }

        public override void Sleep()
        {
            Console.WriteLine("2 hours");
        }

        public void Study()
        {
            Console.WriteLine("24 hours");
        }
    }
}
