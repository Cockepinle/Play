using FakeItEasy;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s;
            do { 
            Console.WriteLine("Введите число, соотвествующее номеру игры:");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("Если устали играть, то введите - 4 ");
            s = Convert.ToInt32(Console.ReadLine());

                if (s == 1)
                {


                    Ugadaichislo(1);
                }
                if (s == 2)
                {

                    Tablizaumhogania(2);
                }
                if (s == 3)
                {

                    Vovoddeliteleihisla(3);
                }
                if (s == 4)
                {
                    break;
                }
            }
            while (s != 5);            
        }
       
            static void Ugadaichislo(int NomberToSchow)
            {
            int otvet;
            Random b = new Random();
         
                Console.WriteLine("Угадай число от 0 до 100");
                Console.WriteLine("Введите число:");
                int hislo = Convert.ToInt32(b.Next(100));
                otvet = Convert.ToInt32(Console.ReadLine());
                while (hislo != otvet)
                {

                    if (otvet > hislo)
                    {
                        Console.WriteLine("Введите число меньше:");
                        Console.WriteLine("Если хочешь выйти из программы и начать новую игру введите число 101");
                        otvet = Convert.ToInt32(Console.ReadLine());
                    }
                    
                    if (otvet < hislo)
                    {
                        Console.WriteLine("Введите число больше:");
                        Console.WriteLine("Если хочешь выйти из программы и начать новую игру введите число 101");
                        otvet = Convert.ToInt32(Console.ReadLine());
                    }

                    if (otvet == hislo)
                    {
                        Console.WriteLine("Вы угадали!");
                       
                    }

                    if (otvet == 101)
                    {
                        Console.WriteLine("Введите число, соотвествующее номеру игры:");
                        break;
                        
                    }

                } 
              }

        
        static void Tablizaumhogania(int Gagag)
        {

           

            
                int[,] Tablizaumhogania = new int[10, 10];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Tablizaumhogania[i, j] = i * j;
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                    Console.Write ($"{Tablizaumhogania[i,j]}\t");
                    }
                    Console.WriteLine();
                }
            }
        
        static void Vovoddeliteleihisla(int Masama)
        {
           
            
                Console.WriteLine("Введите число:");
                int chislo1;
                chislo1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= chislo1/i; i++)
                {
                    if (chislo1%i == 0)
                    Console.WriteLine(i);
                }
            
        }
      

    }
}
                 
 

           