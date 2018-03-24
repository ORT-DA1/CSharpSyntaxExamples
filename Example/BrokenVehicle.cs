using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    //Clase que hereda de vehiculo
    public class BrokenVehicle : Vehicle
    {
        //Property privada con métodos get y set que se podrian usar para reutilizar código 
        private bool WillNotStart { get; set; }
        //Property pública pero solo el get es público, el set no se podrá usar fuera de la clase
        public bool WillStart { get; private set; }

        public BrokenVehicle()
        {
        }

        public BrokenVehicle(string name, int miles) : base(name, miles)
        {
            
        }

        //Método con override que sobrescribe el método virtual de la superclase
        //Si cambiamos override por new, estaríamos redefiniendo un nuevo método
        //Probar de cambiar y volver a correr el ejemplo.
        public override void Start()
        {
            Console.WriteLine("Pffffff! Todo roto!");
        }
    }
}
