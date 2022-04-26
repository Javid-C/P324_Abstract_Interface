using P324_Abstract_Interface.BaseEntity;
using P324_Abstract_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Abstract_Interface
{
    class Worker :  Human, IStudyable
    {

        public double Power;

        public Worker(string name, string surname, byte age, string gender, double power):base(name,surname,age,gender)
        {
            
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Study()
        {
            Console.WriteLine("6 hours");
        }
    }
}
