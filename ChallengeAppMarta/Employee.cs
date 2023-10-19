
using System;

namespace ChallengeAppMarta
{
    public class Employee: Person
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, int age)
            :base (name,surname,sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public int Age { get; private set; }
               
        public void AddGrade(float grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception ("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                //var value = float.Parse(grade);
                //this.AddGrade(value);
                this.AddGrade(result);
            }
            else if (grade.Length==1)
            {
                char.TryParse(grade, out char CharResult);
                this.AddGrade(CharResult);
            }
            else
            {
                throw new Exception ("String is not float");
            }
        }

        public void AddGrade(long grade) 
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(double grade)
        { 
           float result = (float)Math.Round(grade, 2);
            this.AddGrade(result);
        }
        public void AddGrade(char grade)
        {
            switch(grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception ("Wrong letter");                   
            }
        }
        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades) 
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default: 
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
        
    }
}
