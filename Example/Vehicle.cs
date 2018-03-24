using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Vehicle
    {
        //Property que maneja el get y set 'automaticamente'
        public string Name { get; set; }

        //Atributo privado de la clase 
        private int miles;
        //Property que encapsula y controla el acceso al atributo privado 'miles' por medio de get y set
        public int Miles {
            get
            {
                return miles;
            }
            set {
                if(value > 0)
                {
                    miles = value;
                }
            }
        }

        //Property protegida, que solo podrán acceder y heredar las clases hijas a Vehiculo
        protected float FuelTankMaxLevel { get; set; }
        //Property protegida, que solo podrán acceder y heredar las clases hijas a Vehiculo
        protected float FuelTankLevel { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string name, int miles)
        {
            Name = name;
            Miles = miles;
        }

        //Método vitual, quiere decir que las clases hijas de Vehiculo lo podrán sobreescribir 
        public virtual void Start()
        {
            Console.WriteLine(Name + ": Bruum Bruum Bruum");
        }

        //Método que no es virutal, por lo que las clases hijas no podrán sobreescribirlo
        //Este método utiliza propiedades protegidas, por lo que la implementación de si el taque está lleno o no
        //queda en capsulada en el método. 
        //Las clases que usen a Vehiculo no podrán ver las protegidas, una subclase de vehiculo
        //eventualmente sí podría utilizar las propiedades protegidas para otra cosa.
        public bool IsTankFull()
        {
            return FuelTankLevel == FuelTankMaxLevel;
        }
    }
}
