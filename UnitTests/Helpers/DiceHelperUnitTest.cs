using Mine.Helpers;
using Mine.Models;
using NUnit.Framework;

namespace UnitTests.Helpers
{
    [TestFixture] 
    public class DiceHelperTests    
    {
        [Test]
        public void RollDice_Invalid_Roll_Zero_Should_Return_Zero()
        {
            // Arrange

            // Act
            var result = DiceHelper.RollDice(0, 1);

            // Reset

            // Assert             
            Assert.AreEqual(0, result);
        }
    }
}
