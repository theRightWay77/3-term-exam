using System;

namespace ShopStorage
{
    class Program
    {
        static string answer;
        static Device dev = new Device();
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите что хотите сделать?");
            Console.WriteLine("1-добавить новый прибор");
            Console.WriteLine("2-посмотреть весь каталог");
            Console.WriteLine("0-завершить работу и закрыть приложение");
            answer = Console.ReadLine();
            while (!answer.Equals("10"))
            {
                switch (answer)
                {
                    case "-1":
                        Console.WriteLine("Выберите что хотите сделать?");
                        Console.WriteLine("1-добавить новый прибор");
                        Console.WriteLine("2-посмотреть весь каталог");
                        Console.WriteLine("0-завершить работу и закрыть приложение");
                        answer = Console.ReadLine(); break;
                    case "1":
                        Console.WriteLine("Выберите класс прибора");
                        Console.WriteLine("1-для готовки");
                        Console.WriteLine("2-для одежды");
                        answer = Console.ReadLine();
                        if (answer == "1") { answer=AddDeviceForCooking(); }
                        break;
                    case "2":
                        {dev.ShowCatalog(); answer = "-1"; break; }
                    case "0":
                        {
                            Console.WriteLine("Досвидания!");
                            answer = "10";
                            break; }
                }

            }

        }
        static string AddDeviceForCooking()
        {
            Console.WriteLine("Введите данные о приборе на отдельных строках, если данные отсутствуют, введите 0");
            Console.Write("Тип прибора:");
            string Type = Console.ReadLine();
            Console.Write("Компания:");
            string Company = Console.ReadLine();
            Console.Write("Модель:");
            string Model = Console.ReadLine();
            Console.Write("Год выпуска:");
            string YearOfRelease = Console.ReadLine();
            ForCooking newDevice = new ForCooking(Type, Company, Model, YearOfRelease);
            Console.WriteLine("Вы успешно добавили новый прибор");
            Console.WriteLine("Выберите что хотите сделать?");
            Console.WriteLine("1-добавить новый прибор");
            Console.WriteLine("2-посмотреть весь каталог");
            Console.WriteLine("0-завершить работу и закрыть приложение");
            answer = Console.ReadLine();
            return answer;
        }
        static void AddDeviceForClothes()
        {
            Console.WriteLine("Введите данные о приборе на отдельных строках, если данные отсутствуют, введите 0");
            Console.Write("Тип прибора:");
            string Type = Console.ReadLine();
            Console.Write("Компания:");
            string Company = Console.ReadLine();
            Console.Write("Модель:");
            string Model = Console.ReadLine();
            Console.Write("Год выпуска:");
            string YearOfRelease = Console.ReadLine();
            ForClothes newDevice = new ForClothes(Type, Company, Model, YearOfRelease);
            Console.WriteLine("Вы успешно добавили новый прибор");
        }

    }
}
