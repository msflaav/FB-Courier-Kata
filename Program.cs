class Program
{
    static void Main(string[] args)
    {
        double length = 5;
        double height = 8;
        double width = 7;
        double weight = 10;

        Console.WriteLine(calculateDimension(length, height, width, weight));
    }

    public static string calculateDimension(double length, double height, double width, double weight)
    {
        double dimension = length * height * width;

        if (dimension < 10)
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