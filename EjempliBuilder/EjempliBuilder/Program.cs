using EjempliBuilder.Builder;
using System;
using System.Collections.Generic;

namespace EjempliBuilder
{  
    class Program
    {
        // The Builder interface specifies methods for creating the different parts
        // of the Product objects.      
        static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();            
            var builderCarro = new CarBuilder();
            var builderManual = new CarManualBuilder();
            director.Builder = builderCarro;
            

            Console.WriteLine("Creando Producto Carro:");
            director.CarDates();
            Console.WriteLine(builderCarro.GetProduct().ListParts());

            director.Builder = builderManual;

            Console.WriteLine("Creando producto Manual Carro:");
            director.ManualDates();
            Console.WriteLine(builderManual.GetProduct().ListParts());
            
            Console.ReadLine();
        }
    }
}
