using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // количество массива
            string[] nums = Console.ReadLine().Split(); // убираем пробелы
            int[] a = new int[n]; // 1-й массив
            int[] b = new int[n]; // массив с простыми числами
            int num = 0; // количество простых числов


            for (int i = 0; i < n; i++)
            {

                a[i] = int.Parse(nums[i]); // занести в массив чисел массив строк в котором введенные пользователем числа 
                bool isNotPrime = false; // bool переменная поначалу которой все простые числа
                for (int j = 2; j <= Math.Sqrt(a[i]); j++) //идем до корня так как дальше нет надобности
                {
                    if (a[i] % j == 0)
                    {
                        isNotPrime = true;   // если поделилось на какое-то число то это НЕ прайм
                        break;
                    }
                }
                if (!isNotPrime && a[i] != 1) // если это простое число и не равно 1 
                {
                    num++; // увеличивается кол-во простых чисел
                    b[i] = a[i]; // кладем в массив с простыми числами
                }

            }
            Console.WriteLine(num); // выводим кол-во простых чисел
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] != 0)
                    Console.Write(b[i] + " "); // выводим простые числа
            }
                   
        }
    }
}

