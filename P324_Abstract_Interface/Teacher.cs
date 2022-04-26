using P324_Abstract_Interface.BaseEntity;
using P324_Abstract_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Abstract_Interface
{
    class Teacher : Human, IMentalable
    {
        public string Profession;

        public Teacher(string name, string surname, byte age, string gender, string profession) : base(name, surname, age, gender)
        {
            Profession = profession;
        }

        public byte Iq
        {
            get => _iq;


            set
            {
                if (value > 110)
                {
                    _iq = value;
                }
            }
        }


        public override void Eat()
        {
            Console.WriteLine("Steak");
        }

        public override void Sleep()
        {
            Console.WriteLine("6 hours");
        }

        //public void Test()
        //{
        //    throw new NotImplementedException();
        //}
        //public abstract void Test();

        //public abstract void Test(); Abstract olmayan bir classin icerisinde abstract bir method yazila bilmez
    }
}

