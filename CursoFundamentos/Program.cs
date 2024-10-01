using CursoFundamentos.Models;
using System;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CursoFundamentos
{ 

    class Program
    {

        static void Main(string[] args)
        {
            /* desde acá es de los 1ros 4 videos 
            Bebida bebida = new Bebida("Coca Cola", 500);
            //Cerveza cerveza = new Cerveza();
            Cerveza cerveza = new Cerveza(2500, "Quilmes");

            bebida.Beberse(100);
            //Console.WriteLine(cerveza2.Nombre);

            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("iteración: " + i + " - " + numeros[i]);
            }

            foreach(var numero in numeros)
            {
                Console.WriteLine("iteración: " + numero);
            }

            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; ;

            //lista.Add(1);
            //lista.Add(2); 
            //lista.Remove(2);
            foreach (var numero in lista)
            {
                Console.WriteLine(numero);
            }

            List<Cerveza> cervezas = new List<Cerveza> { new Cerveza(1000,"Heineken") };
            cervezas.Add(new Cerveza(200, "Kibor"));
            Cerveza salta = new Cerveza( 400);
            cervezas.Add(salta);
           

            foreach (var cerveza2 in cervezas)
            {
                Console.WriteLine("Cerveza " + cerveza2.Nombre);
            }

            var bebidaAlcoholica = new Vino(255);
            MostrarRecomendacion(bebidaAlcoholica);

            hasta acá es de los 1ros 3 videos */
           
            CervezaBD cervezaBD = new CervezaBD();

            // insertamos nueva cerveza.
            // Al ponerle {} creamos un contexto nuevo solo para lo que está entre {} y no se duplica 
            //el nombre de la variable cerveza

            { 
                Cerveza cerveza = new Cerveza(15, "Pale Ale");
                cerveza.Marca = "Minerva";
                cerveza.Alcohol = 6;
                cervezaBD.Add(cerveza);
            }

            //obtener todas las cervezas
            var cervezas = cervezaBD.Get();

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);
            }
        }

        static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();
            }
    }
}
