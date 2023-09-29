using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ESistema
    {
        Decimal,
        Binario
    }
    public class Numeracion
    {
        private ESistema sistema;
        private double valor;
        public Numeracion(double valor, ESistema sistema)
        {
            this.valor = valor;
            this.sistema = sistema;
        }

        public Numeracion(string valor, ESistema sistema)
        {
            //this.valor = valor;
            this.sistema = sistema;
        }

        public ESistema Sistema 
        { 
            get { return sistema; } 
        }

        //public string Valor
        //{
           // get { return valor; }
       // }

        private double BinarioADecimal(string valor)
        {
            return 1;
        }

        public string ConvertirA(ESistema sistema)
        {
            return " ";
        }

        private string DecimalABinario(int valor)
        {
            return "";
        }

        private bool EsBinario (string valor)
        {
            return true;
        }

        private void InicializarValores(string valor, ESistema sistema)
        {

        }

    }
}
