using System;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {

            var menu = new Menu();
            var order = new Order();

            while(true){                                        //Main loop
        
            menu.MainMenu();                                    //Print main menu, and store users input in "choice"
            string choice = Console.ReadLine();
        
            if(choice == "1" || choice == "2" || choice == "3"){    //If input is valid continue, else call BadInput() method.
                       
                if(choice == "1"){                              //If user selected "Beställ produkter"                        
                    menu.ProductMenu();
                    choice = Console.ReadLine();

                    if(choice == "1"){                          //Create order for Bil.
                        order.CreateOrder(1);
                    }
                    else if(choice == "2"){                     //Create order for Godis
                        order.CreateOrder(2);
                    }
                    else if(choice == "3"){                     //Create order for Rör
                        order.CreateOrder(3);
                    }
                    else if(choice == "4"){                     //Create order for Havremjölk.
                        order.CreateOrder(4);
                    }
                    else{                                       //If input is invalid.
                        menu.BadInput();
                        Console.ReadKey();
                    }
                }

                else if(choice == "2"){                         //If user chose "Visa beställda produkter".
                    menu.ShowProductsMenu();
                    Console.WriteLine("Du har " + order.products.Count + "st produkter beställda.\n");

                    foreach(Product i in order.products){       //Print every product i the products List.
                        i.showProducts();
                    }
                    Console.ReadKey();
                }

                else{                                           //If user chose "Avsluta"
                    Console.Clear();
                    Console.WriteLine("Multifabriken shutting down...");
                    return;
                }
            }

            else{                                               //If user input was invalid.
                menu.BadInput();
                Console.ReadKey();
            }
            }
        }
    }
}
