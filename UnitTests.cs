using Xunit;

public class testclass
{
    [Fact]

    public void calculateDimensionTestSmallParcel()
    {
        double length = 2;
        double height = 1;
        double width = 3;
        double weight = 1;
        Assert.Equal("Small Parcel: $3.Total Cost: $3", Program.calculateDimension(length, height, width, weight));
    }
    [Fact]

    public void calculateDimensionTestMediumParcel()
    {
        double length = 4;
        double height = 4;
        double width = 3;
        double weight = 2;
        Assert.Equal("Medium Parcel: $8.Total Cost: $8", Program.calculateDimension(length, height, width, weight));
    }
    [Fact]
    public void calculateDimensionTestLargeParcel()
    {
        double length = 5;
        double height = 5;
        double width = 3;
        double weight = 2;
        Assert.Equal("Large Parcel: $15.Total Cost: $15", Program.calculateDimension(length, height, width, weight));
    }
    [Fact]
    public void calculateDimensionTestXLargeParcel()
    {
        double length = 19;
        double height = 12;
        double width = 10;
        double weight = 2;
        Assert.Equal("Extra Large Parcel: $25.Total Cost: $25", Program.calculateDimension(length, height, width, weight));
    }

    public void calculateDimensionTestHeavyParcel()
    {
        double length = 19;
        double height = 12;
        double width = 10;
        double weight = 55;
        Assert.Equal("Heavy Parcel: $50.Total Cost: $50", Program.calculateDimension(length, height, width, weight));
    }


    // [Fact]
    // //tests if the parcel is added to the order
    // public void EachOrderStartsWithNoItemsTest()
    // {
    //     Program order = new Program();
    //     Assert.Empty(order.cost);
    // }

    // [Fact]
    // //tests if the parcel is added to the order
    // public void addParcelTest()
    // {
    //     Program order = new Program();
    //     order.addParcel(("Heavy Parcel: $50.Total Cost: $50"));
    //     Assert.Equal(50, order.cost);
    // }

    // [Fact]
    // //tests the overall status of the order
    // public void getOrderSummaryTest()
    // {
    //     Program order = new Program();
    //     order.addParcel(("Heavy Parcel: $50.Total Cost: $50"));
    //     order.addParcel(("Extra Large Parcel: $25.Total Cost: $25"));
    //     Assert.Equal(75, order.cost);
    // }
    // [Fact]
    // //tests the overall status of the order
    // public void calculatesOverweightPerParcelTest()
    // {
    //     Order order = new Order();
    //     order.addParcel(("Heavy Parcel: $50.Total Cost: $50"));
    //     order.addParcel(("Extra Large Parcel: $25.Total Cost: $25"));
    //     Assert.Equal("Total Cost: $75", order);
    // }

    // [Fact]
    // //tests if the overall order cost doubles when speedy delivery is true(selected by user)
    // public void speedyDeliveryTest()
    // {
    //     Program order = new Program();
    //     order.addParcel(("Heavy Parcel: $50.Total Cost: $50"));
    //     order.SpeedyDelivery();
    //     Assert.Equal(100, order.cost);
    // }

}