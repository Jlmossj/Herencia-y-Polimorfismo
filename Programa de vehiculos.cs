
using System;
using ORIENTACION_A_OBJETOS.MisClases;

namespace ORIENTACION_A_OBJETOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo micarro = new Vehiculo(2090, "Amarillo", "Mitsubishi");
            Electrico miBYD = new Electrico(2021, "Blanco", "Changan");
            AutoCombustion miAuto = new AutoCombustion(2015, "Rojo", "Toyota");
            Motocicleta miMoto = new Motocicleta(2025, "Amarillo", "Suzuki Vstrom", "Crucero", true);
            Camion miCamion = new Camion(2018, "Blanco", "Voltswagen", 15.5, 3);

            
            while (true)
            {
                Console.WriteLine("\n--- Menu de Vehículos ---");
                Console.WriteLine("1. ver auto normal");
                Console.WriteLine("2. ver auto eléctrico");
                Console.WriteLine("3. ver auto de combustión");
                Console.WriteLine("4. ver motocicleta");
                Console.WriteLine("5. ver camion");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion no válida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        InteractuarConAuto(micarro);
                        break;
                    case 2:
                        InteractuarConElectrico(miBYD);
                        break;
                    case 3:
                        InteractuarConAutoCombustion(miAuto);
                        break;
                    case 4:
                        InteractuarConMotocicleta(miMoto);
                        break;
                    case 5:
                        InteractuarConCamion(miCamion);
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void InteractuarConAuto(Vehiculo auto)
        {
            Console.WriteLine("\n--- Interactuando con el Auto Normal ---");
            auto.InformacionVehiculo();
            auto.Color = "Rojo";
            Console.WriteLine("Nuevo color:");
            auto.InformacionVehiculo();
            auto.acelerar(50);
        }

        static void InteractuarConElectrico(Electrico electrico)
        {
            Console.WriteLine("\n--- Interactuando con el Auto Eléctrico ---");
            electrico.InformacionVehiculo();
            electrico.cargarBateria(20);
            Console.WriteLine("Batería cargada al " + electrico.cargarBateria() + "%");
        }

        static void InteractuarConAutoCombustion(AutoCombustion autoCombustion)
        {
            Console.WriteLine("\n--- Interactuando con el Auto de Combustión ---");
            autoCombustion.InformacionVehiculo();
            autoCombustion.acelerar(30);
            Console.WriteLine("Nivel de combustible: " + autoCombustion.ObtenerCombustible() + "%");
        }

        static void InteractuarConMotocicleta(Motocicleta motocicleta)
        {
            Console.WriteLine("\n--- Interactuando con la Motocicleta ---");
            motocicleta.InformacionVehiculo();
            motocicleta.acelerar(80);
            motocicleta.HacerCaballito();
            if (motocicleta.TieneMaletas())
            {
                Console.WriteLine("La motocicleta tiene maletas laterales.");
            }
            else
            {
                Console.WriteLine("La motocicleta no tiene maletas laterales.");
            }
        }

        static void InteractuarConCamion(Camion camion)
        {
            Console.WriteLine("\n--- Interactuando con el Camión ---");
            camion.InformacionVehiculo();
            camion.acelerar(60);
            camion.CargarMercancia(10.0); 
          
        }
    }
}