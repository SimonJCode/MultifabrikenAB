using System;
using System.Collections.Generic;

namespace Multifabriken{

    class Order{

        public List<Product> products = new List<Product>();            //List for ordered products.
        public Order(){

        }

        public void CreateOrder(int id){                                //Method to create new order.
            if(id == 1){                                                //id = type of product to order.
                Console.WriteLine("Vilket märke ska bilen ha?");
                string x = Console.ReadLine();

                Console.WriteLine("Vilken färg ska bilen ha?");
                string y = Console.ReadLine();

                Console.WriteLine("Vilket registreringsnummer ska bilen ha?");
                string z = Console.ReadLine();

                var car = new Bil(x, y, z);
                products.Add(car);

                Console.WriteLine($"\nEn {y} {x} med regnummer {z} beställd!");
                Console.ReadKey();
            }
            else if(id == 2){
                Console.WriteLine("Vilken smak ska godiset ha?");
                string x = Console.ReadLine();

                Console.WriteLine("Hur många godisar vill du ha?");
                string y = Console.ReadLine();

                var godis = new Godis(x, y);
                products.Add(godis);

                Console.WriteLine($"\n{y}st godisar med smaken {x} beställda!");
                Console.ReadKey();
            }
            else if(id == 3){
                Console.WriteLine("Ange rörets diameter i cm:");
                string x = Console.ReadLine();

                Console.WriteLine("Ange rörets längd i cm:");
                string y = Console.ReadLine();

                var rör = new Rör(x, y);
                products.Add(rör);

                Console.WriteLine($"\nEtt rör, {y}cm långt med {x}cm i diameter beställt!");
                Console.ReadKey();
            }
            else if(id == 4){
                Console.WriteLine("Ange havremjölkens fetthalt i %:");
                string x = Console.ReadLine();

                Console.WriteLine("Ange havremjölkens mängd i liter:");
                string y = Console.ReadLine();

                var hm = new Havremjölk(x, y);
                products.Add(hm);

                Console.WriteLine($"\n{y}liter havremjölk med {x}% fetthalt beställt!");
                Console.ReadKey();    
            }
        }
    }
}