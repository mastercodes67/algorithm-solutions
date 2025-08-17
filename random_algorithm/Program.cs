using System;

class Program
{
    static void Main(string[] args)
    {
        /*1 ile 50 arasındaki tek veya 4 e bölünebilen sayıları bul for (int i = 1; i <= 50; i++)

          {
              if (i % 2 == 1 || i % 4 == 0)
              {
                  Console.WriteLine(i);
              }
          }*/


        /*1-100 arası sayı gelene kadar döngütü devam ettir int number;


        do
        {
            Console.Write("Enter a number between 1 and 100: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Hatalı giriş, tekrar deneyin.");
            }

        }
        while (number < 1 || number > 100);

        Console.WriteLine("Başarılı Giriş Yaptınız: " + number);
 */

        /* dizi örneği
            int[] items = new int[] { 8, 15, -45, -8, 97, 13, 15, 0, 11, -15 };
        int smallestValue = items[0];
        for (int i = 0; i < 10; i++)
        {
            if (smallestValue > items[i])
            {
                smallestValue = items[i];
            }
        }
        Console.WriteLine("Dizideki en küçük eleman: " + smallestValue);        
        */

        /*10.000 TL'yi yıllık %10 oran ile 5 yıllığına faize yatırdığımıza 5 yıl boyunca her yıl sonunda elde edilecek parayı ekranda görüntüleyen uygulama yazın.
            double capital = 10000; // ana para
        double interesRate = 0.1; //yıllık faiz oranu
        int year = 5; //kaç yıl boyunca artacak

        for (int i = 0; i < year; i++)
        {
            capital = capital * (1 + interesRate);
             Console.WriteLine(i + ". Yıllık faiz gelir sıralya {0:N2}" + capital);
        }
        */

        /*1-7 arasındaki sayılardan hangisi haftanın hangi günene denk geliyor
            int dayNumber;

        do
        {
            Console.WriteLine("1-7  Please enter a number: ");
            dayNumber = Convert.ToInt32(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("uppps!fix formating");
                    break;
            }
        } while (dayNumber < 1 || dayNumber > 7);
        */
    
    }
    
}
