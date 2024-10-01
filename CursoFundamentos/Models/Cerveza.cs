using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoFundamentos.Models;


namespace CursoFundamentos.Models
{
    class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public Cerveza( int Cantidad = 347, string Nombre = "Quilmes") : base(Nombre, Cantidad)
        {

        }
        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo recomendado es 5 latas");
        }

        //public Cerveza() :  base(Nombre, Cantidad)
        //{

        //}




    }
}
