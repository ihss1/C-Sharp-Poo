public class Car
{
    public string brand;
    public string model;
    public int year;
    public int price;


    public Car (string brand, string model, int year, int price)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.price = price;
    }


    public void Info()
    {
        Console.WriteLine("The infos of this car are:");
        Console.WriteLine(" Car brand: " + brand);
        Console.WriteLine(" Car model: " + model);
        Console.WriteLine(" Car year: " + year);
        Console.WriteLine(" Car price: " + price + " DH");
    }
}

