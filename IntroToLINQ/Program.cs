using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ
{
    class Program
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
        //http://www.tuprogramacion.com/glosario/que-es-linq/
        static void Main(string[] args)
        {
            // The Three Parts of a LINQ Query:
            //  1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            //Operadores Lambda
            var lista_resultado = numbers.Where(num => num % 2==0).ToList();
            var ordenados = lista_resultado.OrderBy(num => num);
            var maximo = lista_resultado.Max(num => num);
            var minimo = lista_resultado.Min(num => num);
            var primero = lista_resultado.FirstOrDefault();
            numbers.ToList().ForEach(n =>
            {
                n = n * 2;
                Console.Write(n);
            }
            );
            var l = new List<int>() {1,2,3,4,5,6 };

            l.ForEach(n => n = n*2);
            //var lista_resultado2 = numbers.Where(num => num % 2 == 0);
            //lista_resultado2.ToList();

            var personas = new List<Persona> { new Persona { Id = 1, Nombre = "B", Salario=1000, Tipo=1 }, new Persona { Id = 2, Nombre = "A", Salario = 2000, Tipo = 2 } };

            var filtro = personas.Where(p => p.Nombre == "A" && p.Id == 1).ToList();

            var filtro2 = personas.OrderBy(t => t.Nombre).ThenBy(t => t.Id).ThenBy(t=>t.Nombre);

            var total = personas.Where(t => t.Tipo == 1).Sum(t=>t.Salario);

            var cantidad = personas.Where(t => t.Tipo == 2).Count();

            var cantidad2 = personas.Count(t => t.Tipo == 2);

            var cantidad3 = personas.Count(t => t.Tipo == 2)>0;

            var cantidad4 = personas.Any(t => t.Tipo == 2);
        }

        class Persona {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Tipo { get; set; }
            public double Salario { get; set; }
        }
    }
}
