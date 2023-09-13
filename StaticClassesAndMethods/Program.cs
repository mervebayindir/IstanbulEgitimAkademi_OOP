namespace StaticClassesAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Config.Title);
            Config.ExecutedBy = "Merve Bayındır.";
            Console.WriteLine(Config.ExecutedBy + " (" + Config.ExecutionDate + ")");

            Console.WriteLine(Database.Name + " - " + Database.Language); // Oracle - PL/SQL 
            //Database.Name = "Microsoft SQL Server";
            //Database.Language = "T-SQL";
            Database.SetNameAndLanguage("Microsoft SQL Serve", "T-SQL");
            Console.WriteLine(Database.Name + " - " + Database.Language); // Oracle - PL/SQL 
            Database db = new Database();
            db.Log("select * from Urunler");

            string ad = "Merve";
            ad= ad.Trim();
            if (string.IsNullOrWhiteSpace(ad))  //IsNullOrWhiteSpace  "", "    ", null değerlerini kontrol ediyor  Bu daha çok kullanışlı
                Console.WriteLine("ad boş");
            else
                Console.WriteLine("ad boş değil");
                                               //IsNullOrEmpty  null, "" değerlerini kontrol eder


            if(StringUtil.IsEmpty(null))
                Console.WriteLine("empty");
            else
                Console.WriteLine("not empty");

            Console.Write("Sayı: ");
            string giris = Console.ReadLine();
            double sayi;
            if(StringUtil.IsNumeric(giris, out sayi,"en-US"))  //sayiyı double olarak oluşturuyoruz daha sonra out olarak atayabılıyoruz
                Console.WriteLine(giris + " sayısaldır sayı: " + sayi);
            else
                Console.WriteLine(giris + "sayısal değildir.");


        }
        static class Config
        {
            //public static string Title = "Static Classes Demo";  // Asla public kullanılmaz
            public static string Title => "Static Classes Demo";
            public static string ExecutedBy { get; set; }
            public static DateTime ExecutionDate => DateTime.Now;
        }
        class Database
        {
            public static string Name { get; set; }
            public static string Language { get; set; }

            static Database()
            {
                Name = "Oracle";
                Language = "PL/SQL";
            }
            public static void SetNameAndLanguage(string name, string language)
            {
                Name = name;
                Language = language;
            }
            public void Log(string sql) //log sorgu
            {
                Console.WriteLine($"\"{sql}\" logged.");
            }
        }
    }
}