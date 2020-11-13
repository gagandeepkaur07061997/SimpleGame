using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_game
{
    [TestClass]
    public class UnitTest_game
    {
        Game_Class Class_obj = new Class_Game();

        [TestMethod]
        public void Test_spin1()
        {

            int spin_unit_data = Class_obj.spin();
            Assert.AreNotEqual(0, spin_unit_data);
        }

        [TestMethod]
        public void Test_spin2()
        {
            int spin_unit_data = Class_obj.spin();
            Assert.AreNotEqual(7, spin_unit_data);
        }
    }
}
