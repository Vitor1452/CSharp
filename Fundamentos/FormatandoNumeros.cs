using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {
            //ARREDONDAR NUMERO 
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1"));

            //TRANSFORMAR UM VALOR MONÉTARIO (MOEDA DE ACORDO COM A MÁQUINA)
            Console.WriteLine(valor.ToString("C"));

            // MUTIPLICA UM VALOR POR 100 E ADICIONA PERCENTUAL 
            Console.WriteLine(valor.ToString("P"));

            //FORMATANDO O NÚMERO DO JEITO QUE VOCê QUISER
            Console.WriteLine(valor.ToString("#.##"));
        }
            
    }
}
