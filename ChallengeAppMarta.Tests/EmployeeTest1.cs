namespace ChallengeAppMarta.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeColletScores_ShouldCorrectResult()
        {
            //arange
            var employee = new Employee("Marta","Wiedzma", 53);
            employee.AddScore(9);
            employee.AddScore(0);
            employee.AddScore(10);
            employee.AddScore(-1);
            //act
            var result = employee.Result;
            //assert
            Assert.AreEqual(18,result);
        }
    }
}