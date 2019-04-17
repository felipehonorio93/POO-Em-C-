using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "felipe";
            conta1.agencia = 1510;
            conta1.numero = 262019;
            conta1.saldo = 950.0;

            Console.WriteLine("Titular "+conta1.titular);
            Console.WriteLine("Agencia "+conta1.agencia);
            Console.WriteLine("Numero "+conta1.numero);
            Console.WriteLine("Saldo "+conta1.saldo);
            Console.ReadLine();
        }
    }
}
