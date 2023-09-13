using Constructors_Demo_3.Classes;

namespace Constructors_Demo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zaman işlemleri(TimeOperations)
            //duration(süre, saniye cinsinden)
            //time(zaman)
            //duration = 90 -> time = 00:1:30  dk saat:dakika:saniye
            //time = 00:02:00 -> duration= 120 sn       
            
            TimeOperations timeOperations = new TimeOperations(3800);
            Console.WriteLine(timeOperations.CalcutureTime());

            timeOperations = new TimeOperations("23:59:59");
            Console.WriteLine(timeOperations.CalculateDuration() + " seconds.");

        }
    }
}