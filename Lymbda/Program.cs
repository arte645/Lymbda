using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lymbda
{
    internal class Program
    {
        delegate int calculator(int x, int y, int z);

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            calculator sum = (int x,int y, int z) => { return x + y + z;  }; 

            calculator multy = (int x, int y, int z) => { return x * y * z; };

            calculator min = (int x, int y, int z) => {
                int[] math = new int[3] { x, y, z };
                Array.Sort(math);
                return math[2]; 
            };

            calculator max = (int x, int y, int z) => {
                int[] math = new int[3] { x, y, z };
                Array.Sort(math);
                return math[0]; };

            calculator mid = (int x, int y, int z) => {return (x+y+z)/3;};

            Console.WriteLine($"Сумма этих штучек равна:{sum(a,b,c) }") ;
            Console.WriteLine($"Произведение этих штучек равно:{multy(a, b, c)}");
            Console.WriteLine($"Максимальный элеменет среди этих штучек равен:{min(a, b, c)}");
            Console.WriteLine($"Минимальный элеменет среди этих штучек равен:{max(a, b, c)}");
            Console.WriteLine($"Среднее ариф. этих штучек равно:{mid(a, b, c)}");
        }
    }
}
