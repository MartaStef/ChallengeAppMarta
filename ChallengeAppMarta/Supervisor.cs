
namespace ChallengeAppMarta
{
    public class Supervisor: IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public char Sex { get; set; }

        public void AddGrade(float grade)
        {
            if (grade > 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {                  
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (grade.Length == 1) 
            {
                char.TryParse(grade, out char CharResult);
                this.AddGrade(CharResult);
            }
            else if (grade.Length == 2 && char.IsDigit(grade[0]) && grade[0] <='6' && grade[1] == '+' || grade[1] == '-')
            { 
                switch (grade[1])
                {
                    case '+':
                        this.AddGrade(5);
                        break;
                    case '-':
                        this.AddGrade(-5);
                        break;
                }
            }
            else
            {
                throw new Exception("String is not float");
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
            switch (grade)
            {
                case 'A':
                case 'a':
                case '6':
                    this.AddGrade (100);
                    break;
                case 'B':
                case 'b':
                case '5':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                case '4':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                case '3':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                case '2':
                    this.AddGrade(20);
                    break;
                case '1':
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception("Wrong letter");
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
            switch (statistics.Average)
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
