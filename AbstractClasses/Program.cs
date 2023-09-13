using AbstractClasses.Bases;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecordBase record = new Product()
            {
                Id = 1,
                Name = "Computer",
                StockAmount = 10,
                UnitPrice = 75000,
            };
            Console.WriteLine(record);

            record = new Store()
            {
                City = "Antalya",
                Country = "Türkiye",
                Id = 1,
                Name = "Vatan"
            };
            Store store = record as Store;
            Console.WriteLine($"ID: {store.Id}\nGuid: {store.Guid}\nAdı: {store.Name}\nÜlkesi: {store.Country}\nŞehir: {store.City}");
        }
    }
}