using InterfaceSegregation.Bases;

namespace InterfaceSegregation
{
    internal class Program
    {
        // OOP Principles
        // SOLID Principles

        static void Main(string[] args)
        {
            ICalis robot = new Robot();
            robot.Calis();
            robot = new Calisan();
            robot.Calis();
            (robot as Calisan).MaasAl();  // cast işlemi yapıldı ICalis tipine Calisan tipine atadık
            ((Calisan)robot).YemekYe();

            Yonetici yonetici = new Yonetici();
            yonetici.Calis();
            yonetici.YemekYe();
            yonetici.MaasAl();
        }
    }
}