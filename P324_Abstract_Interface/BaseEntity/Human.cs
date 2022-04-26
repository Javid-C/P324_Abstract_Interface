//using System;
//using System.Collections.Generic;
//using System.Text;

namespace P324_Abstract_Interface.BaseEntity
{
    abstract class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;
        protected byte _iq;
        public Human(string name, string surname, byte age, string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        public abstract void Sleep();

        public abstract void Eat();

        //public abstract void Study(); Teacher-da study olmamalidir
    }
}
