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
            int cost = 50;
            string type = "Heavy ";
            return
            $"{type} Parcel: ${cost}.Total Cost: ${cost}";
        }
        else if (dimension < 10)
        {
            int cost = 3;
            string type = "Small ";
            return
            $"{type}Parcel: ${cost}.Total Cost: ${cost}";

        }
        else if (dimension < 50)
        {
            int cost = 8;
            string type = "Medium";
            return
            $"{type} Parcel: ${cost}.Total Cost: ${cost}";

        }
        else if (dimension < 100)
        {
            int cost = 15;
            string type = "Large";
            return
            $"{type} Parcel: ${cost}.Total Cost: ${cost}";

        }
        else if (dimension >= 100)
        {
            int cost = 25;
            string type = "Extra Large";
            return
            $"{type} Parcel: ${cost}.Total Cost: ${cost}";
        }

        else
        {
            return "invalid dimensions";

        }
    }
    public class Order
    {
        public string type;
        public int cost;
        public Order(string type, int cost)
        {
            this.type = type;
            this.cost = cost;
        }

    }

    // public static string addParcel(string name, int price)
    // {

    // }
}