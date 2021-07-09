using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {
        private String name;
        private int idNumber;
        private double averageScore;
        private double score1;
        private double score2;
        private double newScore1;
        private double newScore2;





        public Student()
        {



        }


        public Student(string text, int value)
        {
            this.name = text;
            this.idNumber = value;
        }

        public static void DoStuff()
        {
            Student molly = new Student();
            molly.name = "Molly";
            molly.idNumber = 42;
            Console.WriteLine("Molly: {0}", molly.name);
            Console.WriteLine("Molly: {0}", molly.idNumber);

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


        public int IdNumber
        {
            get
            {
                return idNumber;
            }


            set
            {
                idNumber = value;
            }

        }


        public double AverageScore
        {
            get
            {
                return averageScore;
            }

            private set
            {
                averageScore = (score1 + score2) / 2;
            }
        }


        public double Score1
        {
            get { return score1; }
            set { score1 = value; UpdateAverageScore(); }
        }


        public double Score2
        {
            get { return this.score2; }
            set { this.score2 = value; UpdateAverageScore(); }
        }



        public double HighScore
        {
            get
            {
                if (score1 > score2)
                {
                    return score1;
                }
                else
                {
                    return score2;
                }
            }
        }









        /*public void SetName(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetIdNumber(int newIdNumber)
        {
            idNumber = newIdNumber;
        }

        public int GetIdNumber()
        {
            return idNumber;
        }*/



        /* public double GetScore1()
         {
             return score1;
         }

         public void SetScore1(double newScore1)
         {
             score1 = newScore1;
             UpdateAverageScore();
         }

         public double GetScore2()
         {
             return score2;
         }

         public void SetScore2(double newScore2)
         {
             score2 = newScore2;
             UpdateAverageScore();
         }*/

        public double GetAverageScore()
        {
            UpdateAverageScore();
            return averageScore;
        }

        private void UpdateAverageScore()
        {
            averageScore = (score1 + score2) / 2;
        }

        /* public double GetHighScore()
         {
             if (score1 > score2)
             {
                 return score1;
             }
             else
             {
                 return score2;
             }


         }*/


    }

}

