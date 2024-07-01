using System;


namespace _01._07._2024
{
    public class Cars
    {
        public string Make { get; set; }

        public int Year { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public string Model { get; set; }
        public double PalletNo { get; set; }
        public string Color { get; set; }



        public Cars()
        {
            Make = "BMW";
            Year = 2020;
            Type = "Sedan";
            Price = "5000";
            Model = "Mustang";
            PalletNo = 211114;
            Color = "Black";
        }
        public Cars(string make, string type, string model, string color, string price, double palletNo, int year)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
        }

        public string StartEngine()
        {

            return "The engine car is now running.";
        }

        public string StopEngine()
        {

            return "The engine car has been stopped.";
        }
        public string InformationCar()
        {
            return $"The information Car: Make: {Make}, Type: {Type}, Model: {Model}, Color: {Color}, Price: {Price}, Year: {Year}, Pallet: {PalletNo}";

        }



    }

    public class BMW : Cars
    {

        public BMW(string make, string type, string model, string color, string price, double palletNo, int year)
              : base(make, type, model, color, price, palletNo, year)
        {


        }
    }
}
