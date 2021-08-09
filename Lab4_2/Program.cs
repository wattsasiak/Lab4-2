using System;
using System.Collections.Generic;

namespace Lab4_2
{

    //class Rectangle
    //{
    //    public int _Width;
    //    public int _Length;

    //    List<Rectangle> CalcRec = new List<Rectangle>();
    //    Rectangle r1 = new Rectangle();


      

    //}
        
    class MenuItem
    {

        //In this program Private fields start with  "_", renamed fields do not 

        //Create a class called MenuItem, Include fields: ID, Name, Descrip and Price. Make the fields provate. 
        private int _ID;
        private string _Name;
        private string _Description;
        private decimal _Price;

        //write a getter and setter method for each field. Make these fmethods public.


        //getand set ID
        public int getID()
        {
            return _ID;
        }
        public void SetID(int ID)
        {
           _ID = ID; 
        }

        //get and set Name

        public string GetName()
        {
            return _Name;
        }
        public void SetName(string Name)
        {
            if (!string.IsNullOrEmpty(_Name))
               _Name = Name;

        }


        //get and set Description
        public string GetDescription()
        {
            return _Description;
        }
        public void SetDescription(string Description)
        {
            if (!string.IsNullOrEmpty(_Description))
                _Description = Description;

        }




        //get and set Price

        public decimal GetPrice()
        {
            return _Price;
        }

        public void SetPrice(decimal Price)
        {
            if (_Price < 0.50m)
            {
                _Price = 0.50m;
            }

            if(_Price > 10.00m)
            {
               _Price = 10.00m;
            }

            _Price = Price;
        }



        //Constructor

        public MenuItem(int ID, string Name, string Description, decimal Price)
        {
            SetID(ID);
            SetName(Name);
            SetDescription(Description);
            SetPrice(Price);
        }



         public MenuItem(int ID, string Name, decimal Price)
        {
            SetID(ID);
            SetName(Name);
            SetPrice(Price);
            SetDescription("EMPTY");
        }

        public override string ToString()
        {
            return $"{_ID} {_Name} {_Price} {_Description}";
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
