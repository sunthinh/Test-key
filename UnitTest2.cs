using StudentServiceLib;


namespace TestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Value_10()
        {
            Student student = new Student();
            student.Score = 10;
            Assert.AreEqual(10, student.Score);
        }


    }
}