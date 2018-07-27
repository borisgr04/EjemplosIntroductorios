using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManejoHilos
{
    class Suma
    {
        Int32 num1, num2, resultado;
        public Suma(Int32 num1, Int32 num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void sumar()
        {
            resultado = num1 + num2;
        }
        public Int32 getResultado()
        {
            return resultado;
        }
    }

    public class EjemploHilo
    {
        public void Ejecutar()
        {
            Suma objeto_hilo = new Suma(1, 2);
            Thread hilo = new Thread(new ThreadStart(objeto_hilo.sumar));
            hilo.Start();
            hilo.Join();
            var resultado = objeto_hilo.getResultado().ToString();
        }
    }
}
