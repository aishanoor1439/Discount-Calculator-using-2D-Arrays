using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount_Calculator_using_2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());

            string[,] items = new string[numberOfItems, 3];

            for (int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine($"\nEnter details for Item {i + 1}:");

                Console.Write("Name: ");
                items[i, 0] = Console.ReadLine();

                Console.Write("Price: ");
                items[i, 1] = Console.ReadLine();

                Console.Write("Quantity: ");
                items[i, 2] = Console.ReadLine();
            }

            double totalPrice = 0;
            for (int i = 0; i < numberOfItems; i++)
            {
                double price = Convert.ToDouble(items[i, 1]);
                int quantity = Convert.ToInt32(items[i, 2]);
                totalPrice += price * quantity;
            }

            Console.Write("\nAre you from Bahria University? (yes/no): ");
            string isFromBahria = Console.ReadLine().ToLower();

            double discount = 0;
            if (isFromBahria == "yes")
            {
                discount = 0.30;
            }
            else if (totalPrice >= 50000 && totalPrice <= 100000)
            {
                discount = 0.20;
            }
            else if (totalPrice > 100000)
            {
                discount = 0.30;
            }

            double discountAmount = totalPrice * discount;
            double finalPrice = totalPrice - discountAmount;

            Console.WriteLine($"\nTotal Price: {totalPrice:F2}");
            Console.WriteLine($"Discount Applied: {discount * 100}%");
            Console.WriteLine($"Discount Amount: {discountAmount:F2}");
            Console.WriteLine($"Final Price after Discount: {finalPrice:F2}");
        }
    }
}
