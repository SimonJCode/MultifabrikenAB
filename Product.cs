using System;

namespace Multifabriken{

    public abstract class Product{
        public abstract void showProducts();                //Method for printing placed orders.

    }   

    //----Subclass Bil----//
    class Bil : Product{

        public Bil(string brand, string color, string regNr){
            this.brand = brand;
            this.color = color;
            this.regNr = regNr;
        }

        public override void showProducts(){
            Console.WriteLine($"Bil:\nMärke: {brand}\nFärg: {color}\nRegnummer: {regNr}\n");
        }
        
        private string brand;
        private string color;
        private string regNr;

    }

    //----Subclass Godis----//
    class Godis : Product{

        public Godis(string smak, string antal){
            this.smak = smak;
            this.antal = antal;
        }

        public override void showProducts(){
            Console.WriteLine($"Godis:\nSmak: {smak}\nAntal: {antal}st\n");
        }

        private string smak;
        private string antal;

    }

    //----Subclass Rör----//
    class Rör : Product{

        public Rör(string diameter, string lenght){
            this.diameter = diameter;
            this.lenght = lenght;
        }

        public override void showProducts(){
            Console.WriteLine($"Rör:\nDiameter: {diameter}cm\nLängd: {lenght}cm\n");
        }

        private string diameter;
        private string lenght;

    }

    //----Subclass Havremjölk----//
    class Havremjölk : Product{

        public Havremjölk(string fat, string volume){
            this.fat = fat;
            this.volume = volume;
        }

        public override void showProducts(){
            Console.WriteLine($"Havremjölk:\nFetthalt: {fat}%\nLiter: {volume}liter\n");
        }

        private string fat;
        private string volume;

    }
}