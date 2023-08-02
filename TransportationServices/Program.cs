using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using TransportationServices;
double Total_Weight = new double();

Console.Write("How many products do you have ");
Console.ForegroundColor = ConsoleColor.Green;
int n = int.Parse(Console.ReadLine());
Console.ResetColor();
Product[] products = new Product[n];
for(int i = 0; i < products.Length; i++)
{
    Console.WriteLine();
    Console.Write($"what is your {i+1} product  ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;   
    products[i] = new Product(Console.ReadLine());
    Console.ResetColor();
    Console.Write("How many kilograms is your product? ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    double weight = double.Parse(Console.ReadLine());
    Console.ResetColor();
    products[i].Weight = weight / 1000;
    Total_Weight+= products[i].Weight;
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Great, you can choose Transportation Service");
Console.ResetColor();
Console.WriteLine();

Console.WriteLine("We can offer you 2 services .");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine();
Console.WriteLine("First: ABCTransportation Service.Max distance is 800 km (if you choose it you will click 1 )");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.WriteLine();
Console.WriteLine("Second: XYZTransportation Service .Max distance is 500km (if you choose it you will click 2)");
Console.WriteLine();
Console.ResetColor();
Console.Write("Wich service do you prefer , please click 1 or 2 :  ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
int p = int.Parse(Console.ReadLine());
Console.ResetColor();
Console.WriteLine();
Console.Write("Please insert distance: ");
int distance = int.Parse(Console.ReadLine());
Console.WriteLine();

if (p == 1)
{
    ABC();
}
if (p == 2)
 {
    XYZ();
}


void XYZ()
{

    XYZTransportationService xYZTransportationService = new XYZTransportationService();
    if (Total_Weight > xYZTransportationService.MaxWeight)
    {
        Console.WriteLine("The load is too much");
        Console.WriteLine("Thank you for your interest in our company:)");
        return;
    }
    else
    {
            xYZTransportationService.Transport(CreateVehicleArray("Mercedes",Total_Weight), products, distance);
    }
}

void ABC()
{
    ABCTransportationService aBCTransportationService = new ABCTransportationService();
    if (Total_Weight > aBCTransportationService.MaxWeight)
    {
        Console.WriteLine("The load is too much");
        Console.Write("Do you want to continue with another service:(yes or no ) ");
        if (Console.ReadLine() == "yes")
        {

            XYZ();
        }
        else
        {
            Console.WriteLine("Thank you for your interest in our company:)");
            return;
        }
    }
    else
    {
        aBCTransportationService.Transport(CreateVehicleArray("Volo",Total_Weight), products, distance);
    }
}


Vehicle [] CreateVehicleArray(string s  , double total_weight)
{
    Vehicle[] vehicles = new Vehicle[1];
    if (s == "Mercedes")
    {
        
        if (Total_Weight <= 3.5)
        {
            vehicles = new Vehicle[1];
            Vehicle Actros = new Mercedes("The Actros");
            Actros.Capacity = 3.5d;
            vehicles[0] = Actros;
        }
        else if (Total_Weight <= 4)
        {
            vehicles = new Vehicle[1];

            Vehicle Actros_L = new Mercedes("Actros L");
            Actros_L.Capacity = 4d;
            vehicles[0] = Actros_L;
        }

        else
        {
            vehicles = new Vehicle[2];

            Vehicle Actros = new Mercedes("The Actros");
            Actros.Capacity = 3.5d;

            Vehicle Actros_L = new Mercedes("Actros L");
            Actros_L.Capacity = 4d;

            vehicles[0] = Actros;
            vehicles[1] = Actros_L;

        }

    }
    else//Volvo
    {
        if (Total_Weight <= 0.5)
        {
            vehicles = new Vehicle[1];
            Vehicle Volvo_FM = new Volvo("FM");
            Volvo_FM.Capacity = 0.5d;
            vehicles[0] = Volvo_FM;
        }
        else if (Total_Weight <= 1.7)
        {
            vehicles = new Vehicle[2];
            Vehicle Volvo_FH = new Volvo("FH");
            Volvo_FH.Capacity = 1.2d;

            Vehicle Volvo_FM = new Volvo("FM");
            Volvo_FM.Capacity = 0.5d;

            vehicles[0] = Volvo_FH;
            vehicles[1] = Volvo_FM;

        }
        else if (Total_Weight <= 2)
        {
            vehicles = new Vehicle[2];
            Vehicle Volvo_FM = new Volvo("FM");
            Volvo_FM.Capacity = 0.5d;

            Volvo Volvo_FMX = new Volvo("FMX");
            Volvo_FMX.Capacity = 1.5d;

            vehicles[0] = Volvo_FM;
            vehicles[1] = Volvo_FMX;
        }
        else if (Total_Weight <= 2.7)
        {
            vehicles = new Vehicle[2];

            Vehicle Volvo_FH = new Volvo("FH");
            Volvo_FH.Capacity = 1.2d;

            Volvo Volvo_FMX = new Volvo("FMX");
            Volvo_FMX.Capacity = 1.5d;
            vehicles[0] = Volvo_FH;
            vehicles[1] = Volvo_FMX;

        }
        else
        {
            vehicles = new Vehicle[3];

            Vehicle Volvo_FH = new Volvo("FH");
            Volvo_FH.Capacity = 1.2d;

            Vehicle Volvo_FM = new Volvo("FM");
            Volvo_FM.Capacity = 0.5d;

            Volvo Volvo_FMX = new Volvo("FMX");
            Volvo_FMX.Capacity = 1.5d;
            vehicles[0] = Volvo_FH;
            vehicles[1] = Volvo_FM;
            vehicles[2] = Volvo_FMX;
        }
        }
    return vehicles;
}
