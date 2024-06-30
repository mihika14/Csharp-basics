using System;
using System.Collections.Generic;
using Products; 

namespace Products
{
    internal class Program
    {
        private static List<Product> products = new List<Product>();

        static void Main(string[] args)
        { 

            while (true)
            {
                Console.WriteLine("Who are you?");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AdminMenu();
                        break;
                    case 2:
                        CustomerMenu();
                        break;
                    case 3:
                        false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void AdminMenu()
        {
            Console.WriteLine("Admin Menu:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    DisplayAllProducts();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        static void AddProduct()
        {
            Console.Write("Enter Product Code (PCode): ");
            int pcode = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Name (PName): ");
            string pname = Console.ReadLine();
            Console.Write("Enter Quantity in Stock (QtyInStock): ");
            int qtyInStock = int.Parse(Console.ReadLine());
            Console.Write("Enter Discount Allowed (%): ");
            double discount = double.Parse(Console.ReadLine());

            Product newProduct = new Product(pcode, pname, qtyInStock, discount);
            products.Add(newProduct);

            Console.WriteLine("Product added successfully.");
        }
        static void DisplayAllProducts()
        {
            Console.WriteLine("All Products:");
            foreach (var product in products)
            {
                product.Display();
            }
        }

  
        static void CustomerMenu()
        {
            Console.Write("Enter Product Name to Purchase: ");
            string pname = Console.ReadLine();
            Product productToPurchase = products.Find(p => p.Pname == pname);

            if (productToPurchase != null)
            {
                Console.Write("Enter Quantity to Purchase: ");
                int qtyToPurchase = int.Parse(Console.ReadLine());

                if (qtyToPurchase <= productToPurchase.QtyInStock)
                {
                    double totalAmount = CalculateTotalAmount(productToPurchase, qtyToPurchase);
                    ProduceBill(productToPurchase, qtyToPurchase, totalAmount);
                }
                else
                {
                    Console.WriteLine("Insufficient stock.");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

       
        static double CalculateTotalAmount(Product product, int quantity)
        {
            double discount = 0.50; 
            double originalPrice = quantity * 100; 
            double discountedPrice = originalPrice * (1 - discount);
            return discountedPrice;
        }

     
        static void ProduceBill(Product product, int quantity, double totalAmount)
        {
            Console.WriteLine("\n--- Bill ---");
            Console.WriteLine($"Product Name: {product.Pname}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total Amount after Discount: ${totalAmount:F2}");
            Console.WriteLine("------------------\n");

            product.QtyInStock -= quantity; 
        }
    }
}
