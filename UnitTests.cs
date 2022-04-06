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

}