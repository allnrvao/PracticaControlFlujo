using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.clase
{
    internal class Numero
    {
        public int[] Num = new int [20];

        public void IngresarNumero(int numero, int i)
        {
            Num[i] = numero;

        }
        public int[] GetElements()
        { return Num; }
    }

}
