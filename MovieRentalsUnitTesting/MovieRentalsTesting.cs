using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentals;
using System.Data;
using System.Configuration;

namespace MovieRentalsUnitTesting
{
    [TestClass]
    public class MovieRentalsTesting
    {
        Form1 myForm = new Form1();

        [TestMethod]
        public void TestConnection()
        {
            var actualDataString = myForm.HostConfigurations();
            
            var expectedDataString = @"Server=DESKTOP-HMKG4TD\SQLEXPRESS;Database=movie_rentals;Integrated Security=SSPI";
            Assert.AreEqual(expectedDataString, actualDataString);
        }

        [TestMethod]
        public void Test_Pricing_Calculations()
        {
            

            // Act
            var jatt = myForm.PriceCalculation(3, 5);

            // Assert
            Assert.AreEqual(expected: 15, actual: jatt);
        }

        [TestMethod]
        public void Test_User_Rented_Movies()
        {
            

            // Act
            var actual = myForm.GetUserRentedMovies(0);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_Rented_Movies_Count()
        {
            
            // Act
            var actual = myForm.GetRentedMoviesCount(0);

            // Assert
            Assert.AreEqual(0, actual);
        }

        

    }

}
    
        
    
