class Program
{
    static void Main(string[] args)
    {
     
        Console.WriteLine("Enter parcel height in cm:");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter parcel length in cm:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter parcel width in cm:");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter parcel weight in cm:");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("You have a " + calculateDimension(length, height, width, weight));
        Console.WriteLine("Do you want to add parcel to order? Yes/No");
        string addParcel = Console.ReadLine();
    }

    public static string calculateDimension(double length, double height, double width, double weight)
    {
        double dimension = length * height * width;
        if (weight > 50)
        {
            return "Heavy Parcel: $50.Total Cost: $50";
        }
        else if (dimension < 10)
        {
            return "Small Parcel: $3.Total Cost: $3";
        }
        else if (dimension < 50)
        {
            return "Medium Parcel: $8.Total Cost: $8";
        }
        else if (dimension < 100)
        {
            return "Large Parcel: $15.Total Cost: $15";
        }
        else if (dimension >= 100)
        {
            return "Extra Large Parcel: $25.Total Cost: $25";
        }

        else
        {
            return "invalid dimensions";

        }
    }
}