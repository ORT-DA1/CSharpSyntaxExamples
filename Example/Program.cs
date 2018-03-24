using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chairs;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Distintas formas de instanciar un Vehiculo, la idea es utilizar la misma forma, siendo consistente 
            //a lo largo del sistema
            Vehicle ferrari = new Vehicle("Ferrari", 10);
            //Uso de var en lugar del tipo. El compilador sabe que tipo representa var, en este caso Vehiculo
            //Por prolijidad, se debe ser consistente con el uso de var y los tipos concretos.
            var audi = new Vehicle() { Name = "Audi", Miles = 1000 };
            BrokenVehicle fitito = new BrokenVehicle();
            fitito.Name = "Fitito";
            fitito.Miles = 10000000;

            var vehicles = new List<Vehicle>();
            vehicles.Add(ferrari);
            vehicles.Add(audi);
            vehicles.Add(fitito);

            //Este Vehicle se puede reemplazar tammbien por var
            foreach (Vehicle vehicleToStart in vehicles)
            {
                vehicleToStart.Start();
            }

            Console.WriteLine("\n\n");

            var brokenVehicles = new List<BrokenVehicle>();
            brokenVehicles.Add(fitito);
            for (int i = 0; i < brokenVehicles.Count; i++)
            {
                brokenVehicles[i].Start();
            }
            Console.ReadKey();


            Chair chair = new Chair();
            //Esta linea no la puedo hacer porque la clase es internal al proyecto Chairs y no puede ser accedido
            //desde el proyecto Example
            //Leg leg = new Leg(); 
        }
    }
}
