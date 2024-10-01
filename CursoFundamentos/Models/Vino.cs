using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFundamentos.Models
{
    class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public Vino(int Cantidad = 347, string Nombre = "Rutini") : base(Nombre, Cantidad)
        {

        }
        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo recomendado es 3 copas");
        }

        //public Cerveza() :  base(Nombre, Cantidad)
        //{

        //}




    }
}
