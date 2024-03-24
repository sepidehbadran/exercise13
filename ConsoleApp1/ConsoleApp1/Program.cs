// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
class program
{
    static void Main(string[] args)
    {
        double tota1tax = 0;
        double tota1NetCost = 0;
        while (true)
        {
            Console.WriteLine(" please the start time of the conversation (from 23 to 0):");
            int startHour = Convert.ToInt32(Console.ReadLine());
            if (startHour == -99) { 
            break;
                Console.WriteLine("please enter the number of conversation pulses:");
                int pulses = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter date of the conversation( from 1 to 7):");
                int day = Convert.ToInt32(Console.ReadLine());
                double rate = 0;
                if (startHour >= 23 || startHour < 8)
                {
                    rate = 50.0 / 100;
                }
                else if (day == 7)
                {
                    rate =76.0 / 100;
                }
                else
                {
                    rate = 1.0;
                }
                double pu1seRate = 46;
                double grossCost = pulses * pu1seRate * rate;
                double tax = grossCost * 4 / 100;
                double netCost = grossCost + tax;
                tota1tax += tax;
                tota1NetCost += netCost;   
                Console.WriteLine($"gross call amount : {grossCost} rial");
                Console.WriteLine($"tax : {tax} rial");
                Console.WriteLine($"pure amount  : {netCost} rial ");
                Console.WriteLine($" total tax :{ tax} rial");
                Console.WriteLine($"total pure amount : {tota1NetCost} rial ");
                {

                }
                    {

                    }
                
            }
        }
    }
}