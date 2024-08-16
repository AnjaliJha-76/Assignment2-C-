using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q9
    {
        class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Item(string name, double price)
            {
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Name} - Rs. {Price}";
            }
        }

        class ShoppingCart
        {
            private List<Item> items;

            public ShoppingCart()
            {
                items = new List<Item>();
            }

            public void AddItem(string name, double price)
            {
                items.Add(new Item(name, price));
                Console.WriteLine($"{name} added to the cart.");
            }

            public void RemoveItem(string name)
            {
                Item itemToRemove = items.Find(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

                if (itemToRemove != null)
                {
                    items.Remove(itemToRemove);
                    Console.WriteLine($"{name} removed from the cart.");
                }
                else
                {
                    Console.WriteLine($"{name} not found in the cart.");
                }
            }

            public void ViewCart()
            {
                Console.WriteLine("\nItems in your cart:");
                if (items.Count == 0)
                {
                    Console.WriteLine("Your cart is empty.");
                }
                else
                {
                    foreach (Item item in items)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine($"Total Price: Rs. {GetTotalPrice()}\n");
                }
            }

            private double GetTotalPrice()
            {
                double total = 0;
                foreach (Item item in items)
                {
                    total += item.Price;
                }
                return total;
            }
        }

    
        
            public static void pqr()
            {
                ShoppingCart cart = new ShoppingCart();

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Shopping Cart Menu:");
                    Console.WriteLine("1. Add Item");
                    Console.WriteLine("2. Remove Item");
                    Console.WriteLine("3. View Cart");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter the item name: ");
                            string itemName = Console.ReadLine();
                            Console.Write("Enter the item price: ");
                            double itemPrice;
                            if (double.TryParse(Console.ReadLine(), out itemPrice) && itemPrice >= 0)
                            {
                                cart.AddItem(itemName, itemPrice);
                            }
                            else
                            {
                                Console.WriteLine("Invalid price. Please enter a valid number.");
                            }
                            break;

                        case "2":
                            Console.Write("Enter the item name to remove: ");
                            string itemToRemove = Console.ReadLine();
                            cart.RemoveItem(itemToRemove);
                            break;

                        case "3":
                            cart.ViewCart();
                            break;

                        case "4":
                            Console.WriteLine("Exiting the shopping cart. Goodbye!");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }

                    // Hold the console open
                    Console.WriteLine("Press Enter to return to the menu...");
                    Console.ReadLine();
                }
            }
        }
    }

   