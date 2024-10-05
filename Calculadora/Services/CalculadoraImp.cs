using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {

        private List<string> listaHistorico;

        public CalculadoraImp()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            listaHistorico.Insert(0, "res: " + res);
            return res;
        }

        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            listaHistorico.Insert(0, "res: " + res);
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            listaHistorico.Insert(0, "res: " + res);
            return res;
        }


        public int Dividir(int num1, int num2)
        {
            int res = num1/num2;
            listaHistorico.Insert(0, "res: " + res);
            return res;
        }

        public List<string> Historico()
        {
            List<string> historico;
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}