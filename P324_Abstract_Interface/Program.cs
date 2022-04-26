using P324_Abstract_Interface.BaseEntity;
using System;

namespace P324_Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Elshan", "Aliyev",24,"Male",90);

            //Console.WriteLine(student);

            student.Iq = 90;
            Console.WriteLine(student.Iq);

            student.Sleep();

            //Human human = new Human("a","b",12,"okay");
        }
    }
}
