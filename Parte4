using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "bruno";
            contaDoBruno.saldo= 150.0;
            contaDoBruno.Sacar ( 100.0);
            contaDoBruno.Depositar(100);
            Console.WriteLine(contaDoBruno.saldo);


            ContaCorrente contaGabi = new ContaCorrente();
            contaGabi.titular = "gabi";

            contaDoBruno.Tranferir(100.0, contaGabi);

            Console.WriteLine("saldo gabi: "+contaGabi.saldo);
            Console.WriteLine("saldo Bruno: " + contaDoBruno.saldo);
            Console.ReadLine();
        }
    }
}
