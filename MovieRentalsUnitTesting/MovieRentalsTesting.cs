using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentals;

namespace MovieRentalsUnitTesting
{
    [TestClass]
    public class MovieRentalsTesting
    {
        [TestMethod]
        public void Test_Pricing_Calculations()
        {
            // Arrange
            var form = new Form1();

            // Act
            var jatt = form.PriceCalculation(3, 5);

            // Assert
            Assert.AreEqual(expected: 15, actual: jatt);
        }

        [TestMethod]
        public void Test_User_Rented_Movies()
        {
            // Arrange
            var form = new Form1();

            // Act
            var actual = form.GetUserRentedMovies(0);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_Rented_Movies_Count()
        {
            // Arrange
            var form = new Form1();

            // Act
            var actual = form.GetRentedMoviesCount(0);

            // Assert
            Assert.AreEqual(0, actual);
        }
    }
}
