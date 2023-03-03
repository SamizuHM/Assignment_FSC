using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class project1
    {
        static void Main(string[] args)
        {
            //读入一个数
            Console.Write("Input a number: ");
            string tmpString;
            int readIn;
            tmpString = Console.ReadLine();
            readIn = Convert.ToInt32(tmpString);

            //遍历所有因数
            for (int i = 2; i <= readIn;)
            {
                if (readIn % i == 0)
                {
                    readIn = readIn / i;
                    Console.Write($"{i} ");
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine();
        }
    }
}
