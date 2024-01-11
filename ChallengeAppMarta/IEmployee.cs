using static ChallengeAppMarta.EmployeeBase;

namespace ChallengeAppMarta
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddGrade (float grade);
        void AddGrade (string grade);
        void AddGrade (long grade);
        void AddGrade (double grade);
        void AddGrade (char grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics ();
    }
}
