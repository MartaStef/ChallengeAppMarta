namespace ChallengeAppMarta.Tests
{
    public class TypeTests
    {
        [Test]
        public void ThereAreDifferentEmployees()
        {
            //arange
            var employee1 = GetEmployee("Marta", "Stefanska", 53);
            var employee2 = GetEmployee("Kasia", "Paszkowska", 54);
            //act
            
            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void ThereAreSameScore() 
        {
            int score1 = 20;
            int score2 = 20;
            Assert.AreEqual(score1, score2);
        }

        [Test]
        public void ThereAreDifferentFloat()
        {
            float Pi = 3.14f;
            float goldenRatio = 1.61f;                       
            Assert.AreNotEqual(Pi, goldenRatio);
        }

        [Test]
        public void ThereAreTheSameName()
        {
            string name1 = "Marysia";
            string name2 = "Marysia";
            Assert.AreEqual(name1, name2);
        }
        private Employee GetEmployee(string name, string surname,int age)
        {
            return new Employee(name, surname,age);
        }
    }
}
