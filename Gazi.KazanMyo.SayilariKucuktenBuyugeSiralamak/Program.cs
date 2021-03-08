using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.SayilariKucuktenBuyugeSiralamak
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;


            Console.Write("\n\nSayıları küçükten büyüğe sırala:\n");
            Console.Write("----------------------------------------------\n");


            Console.Write("Kaç sayı istiyorsunuz? ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Diziye element {0} girin :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nDizi ögelerini küçükten büyüğe sırala: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");
        }

    }
}

