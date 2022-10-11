using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_1
{
    public class Student
    {
        public int userName;
        public string name;
        public double score;
        public char nationality;

        public Student(int userName, string name, double score, char nationality='I')
        {
            this.userName = userName;
            this.name = name;
            this.score = score;
            this.nationality = nationality;

        }

        public Student():this(120,"Louis",10.0,'S')
        {
           
        }

        public Student(int userName, string name) :this(userName,name,0.0,'E')
        {

        }

        public void DisplayDetails()
        {
            Console.WriteLine("UserName: " + userName);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Nationality: " + nationality);
            Console.WriteLine("Score: " + score+"\n");
        }

        public int UserName
        {
            get
            {
                if (userName < 200)
                {
                    return userName;
                }
                else
                {
                    Console.WriteLine("Cannot display");
                    return 0;
                }

            }
            set
            {
                userName = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public char Nationality
        {
            get
            {
                return nationality;
            }
            set
            {
                nationality = value;
            }
        }

        public double Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public void ChangeScore(double newScore)
        {
            score = newScore;
        }
    }
}
