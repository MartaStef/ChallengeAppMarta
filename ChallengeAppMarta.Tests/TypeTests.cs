namespace ChallengeAppMarta.Tests
{
    public class TypeTests
    {
        [Test]
        public void averageValueTest()
        {
            //arange
            var employee = GetEmployee("Marta", "Stefanska", 53);
            employee.AddGrade(8);
            employee.AddGrade(0);
            employee.AddGrade(10);
            employee.AddGrade(-1);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(4.25,statistics.Average);
        }

        [Test]
        public void maxValueTest() 
        {
            var employee = GetEmployee("Marta", "Stefanska", 53);
            employee.AddGrade(8);
            employee.AddGrade(0);
            employee.AddGrade(10);
            employee.AddGrade(-1);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void minValueTest()
        {
            var employee = GetEmployee("Marta", "Stefanska", 53);
            employee.AddGrade(8);
            employee.AddGrade(0);
            employee.AddGrade(10);
            employee.AddGrade(-1);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(-1, statistics.Min);
        }
            private Employee GetEmployee(string name, string surname,int age)
        {
            return new Employee(name, surname,age);
        }
    }
}
