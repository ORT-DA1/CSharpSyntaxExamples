using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Para poder usar las clases que componen a la silla, necesito incluir el namespace del paquete
using Chairs.Components;

//Nuevo namespace (paquete) para la clase silla
namespace Chairs
{
    public class Chair
    {
        //Properties internals (no pueden ser publicas porque las clases no lo son)
        //Encapsulan como esta implementada la silla
        internal Base Base { get; set; }
        internal Back Back { get; set; }
        internal List<Leg> Legs { get; set; }

        public Chair()
        {
            //Toda silla tiene una base donde sentarse y una pata por lo menos
            Base = new Base();
            Legs = new List<Leg>() { new Leg() };
        }

        //Opcionalmente se le puede agregar un respaldo
        public void AddBack()
        {
            //Como esta encapsulada podría cambiar la implementación de respaldo por ej: new BrokenBack()
            //Y las clases clientes (que usan a la clase silla) 'no notarían' el cambio
            Back = new Back(); 
        }
        public void Sentar()
        {

        }

        public void Arreglar()
        {

        }
    }
}
