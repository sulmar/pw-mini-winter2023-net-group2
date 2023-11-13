using Domain.Model;

namespace Shopper.UnitTests
{
    [TestClass]
    public class RentTests
    {
        //[TestMethod]
        //public void Method_Scenario_ExpectedBehavior()
        //{
        //}

        // Scenario #1
        [TestMethod]
        public void CanReturn_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var rent = new Rent();

            // Act
            var result = rent.CanReturn(new User {  IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }

        // Scenario #2
        [TestMethod]
        public void CanReturn_UserIsRenteeAndIsAdult_ReturnsTrue()
        {
            // Arrange
            var rentee = new User();
            var rent = new Rent {  Rentee = rentee };

            // Act
            rentee.Age = User.AdultAge;
            var result = rent.CanReturn(rentee);

            // Assert
            Assert.IsTrue(result);
        }

        // Scenario #2
        [TestMethod]
        public void CanReturn_UserIsRenteeAndIsNotAdult_ReturnsFalse()
        {
            // Arrange
            var rentee = new User();
            var rent = new Rent { Rentee = rentee };

            // Act
            rentee.Age = 17;
            var result = rent.CanReturn(rentee);

            // Assert
            Assert.IsFalse(result);
        }   

        // Scenario #3
        [TestMethod]
        public void CanReturn_UserIsNotAdminOrRentee_ReturnsFalse()
        {
            // Arrange
            var rentee = new User();
            var rent = new Rent { Rentee = rentee };

            // Act
            var result = rent.CanReturn(new User());

            // Assert
            Assert.IsFalse(result);
        }

        // Scenario #4
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CanReturn_UserIsEmpty_ShouldThrowArgumentNullException()
        {
            // Arrange
            var rent = new Rent();

            // Act
            rent.CanReturn(null);

            // Assert
        }
    }
}