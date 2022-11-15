using StudentServiceLib;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void A_When_Greater_Than_8()
        {
            Student student = new Student();
            { student.Score = 9; }

            char letter = student.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void A_When_Greater_Than_7()
        {
            Student student = new Student();
            { student.Score = 7; }

            char letter = student.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void A_When_Greater_Than_5()
        {
            Student student = new Student();
            { student.Score = 5; }

            char letter = student.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void A_When_Greater_Than_3_5()
        {
            Student student = new Student();
            { student.Score = 3.5; }

            char letter = student.getLetterScore();
            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void A_When_Greater_Less_3_5()
        {
            Student student = new Student();
            { student.Score = 3; }

            char letter = student.getLetterScore();
            Assert.AreEqual('E', letter);
        }

    }
}