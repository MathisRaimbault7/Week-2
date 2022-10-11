using System;

namespace Cours_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mathis";
            Console.WriteLine("My name is : " + name);
            Console.WriteLine("My name is : {0}", name);

            Student var = new Student (111, name, 20.0, 'F');
            Student var2 = new Student(112, name, 20.0);
            Student var3 = new Student(113, name);
            Student var4 = new Student();


            /*var.userName = 8387;
            var.name = name;
            var.score = 20;
            var.nationality = 'F';
            */

            var.DisplayDetails();
            var2.DisplayDetails();
            var3.DisplayDetails();
            var4.DisplayDetails();

            var4.Score = 13;
            double score = var4.Score;

            Console.WriteLine(score+"\n");

            var2.ChangeScore(7);
            var2.DisplayDetails();








        }
    }
}
