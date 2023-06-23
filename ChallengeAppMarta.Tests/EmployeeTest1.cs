namespace ChallengeAppMarta.Tests
{
    public class Tests
    {
        [Test]
        public void employeePointsSum()
        {
            //arange
            var employee = new Employee("Marta","Stefanska", 53);
            employee.AddGrade(9);
            employee.AddGrade(0);
            employee.AddGrade(10);
            employee.AddGrade(-1);
            //act
            var result = employee;
            
            //assert
            Assert.AreEqual(18,result);
        }
    }
}