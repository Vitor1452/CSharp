﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeriticos {
        public static void Executar() {
            /* Console.WriteLine("Digite um numero");

              int n1 = int.Parse(Console.ReadLine());


              Console.WriteLine("Digite outro numero");

              int n2 = int.Parse(Console.ReadLine());


              Console.WriteLine($"A soma deles é {n1 + n2}");
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */

            Console.WriteLine("Digite a base do triangulo:");

            int base1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do triangulo:");

            int altura = int.Parse(Console.ReadLine());

            Console.WriteLine($"O cálculo é : {base1 * altura /2}");



        }
    }
}
