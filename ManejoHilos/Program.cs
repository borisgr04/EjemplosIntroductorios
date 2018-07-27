using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManejoHilos
{
    class Program
    {
        //http://eledwin.com/blog/tutorial-de-hilos-en-c-con-ejemplos-parte-1-31
        //http://eledwin.com/blog/tutorial-de-sockets-en-c-con-ejemplos-parte-1-54
        //http://www.albahari.com/threading/
        static void Main(string[] args)
        {
            //Creamos el delegado 
            ThreadStart delegado = new ThreadStart(WriteY);
            //Creamos la instancia del hilo 
            Thread hilo = new Thread(delegado);
            //Iniciamos el hilo 
            hilo.Start();
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}
