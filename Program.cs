using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta2 = new ContaCorrente();

            conta2.titular = "gabriela";

            Console.WriteLine(conta2.titular);
            Console.WriteLine(conta2.saldo);
            Console.ReadLine();


        }
    }
}
