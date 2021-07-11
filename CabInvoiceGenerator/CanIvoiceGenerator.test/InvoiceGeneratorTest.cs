using NUnit.Framework;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    /// <summary>
    /// class for test cases
    /// </summary>
    public class InvoiceGeneratorTests
    {
        //cab Invoice Generator Refrence
        InvoiceGenerator invoiceGenerator  = null;
        /// <summary>
        /// Test case for checking Caluclate fare function
        /// </summary>
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            //Creating instance of invoice Genertor for Normal Ride
            invoiceGenerator  = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            //Calculating the fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            //Assert values
            Assert.AreEqual(expected, fare);
        }
        
    }
}