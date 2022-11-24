using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public enum Gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gender Gen = Gender.女;
            Gender Gen1 = Gender.男;

            Console.WriteLine(Gen1);
        }
    }
}
