using System;

namespace _01.BlankReceipt
{
    public class BlankReceipt
    {
        public static void Main()
        {
            PrintingReceiptHeader();
            PrintingReceiptBody();
            PrintingReceiptFooter();
        }

        public static void PrintingReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void PrintingReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintingReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
