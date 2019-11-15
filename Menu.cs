using System;

namespace Multifabriken{

    class Menu{

        string banner = "****************************************\n***********-Multifabriken AB-***********\n****************************************\n";

        public Menu(){

        }
        public void MainMenu(){
            Console.Clear();
            Console.WriteLine(banner);
            Console.WriteLine("   [1]Beställ produkt.");
            Console.WriteLine("   [2]Visa beställda produkter.");
            Console.WriteLine("   [3]Avsluta.");
        }

        public void ProductMenu(){
            Console.Clear();
            Console.WriteLine(banner);
            Console.WriteLine("   [1]Bil.");
            Console.WriteLine("   [2]Godis.");
            Console.WriteLine("   [3]Rör.");
            Console.WriteLine("   [4]Havremjölk.");
        }

        public void BadInput(){
            Console.Clear();
            Console.WriteLine(banner);
            Console.WriteLine("  Välj ett av de listade alternativen");
            Console.WriteLine("              Try again.   ");
        }

        public void ShowProductsMenu(){
            Console.Clear();
            Console.WriteLine(banner);

        }
    }
}