using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);            
            invoiceGenerator.CalculateFare(2.0,5);
            Console.WriteLine("Normal Fare: " +invoiceGenerator.CalculateFare(2.0,5));
            InvoiceGenerator invoiceGenerator1 = new InvoiceGenerator(RideType.PREMIUM);
            invoiceGenerator1.CalculateFare(2.0, 5);
            Console.WriteLine("Premium Fare: " + invoiceGenerator1.CalculateFare(2.0, 5));

        }
    }
}
