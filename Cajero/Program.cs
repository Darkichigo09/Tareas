using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Program
    {
        static int opcion = 0;
        static double dinerocuenta = 0;
        static int seleccion = 0;
        static double dinero = 0;
        static int retiro = 0;
        static int moneda = 0;
        static double tipocamb = 0;

        static void depositar_dinero()
        {
            if (opcion == 1){
            Console.Clear();
            Console.WriteLine("Ha escogido Deposito de dinero");
            Console.Write("Digite el monto a depositar:");
            dinero = int.Parse(Console.ReadLine());
            Console.WriteLine("Monto depositado correctamente.");
            Console.WriteLine("El saldo actual de la cuenta es:"+(dinerocuenta+=dinero));
            }
        }
        static void retirar_dinero()
        {

            if (opcion == 2) {
            if (dinerocuenta > retiro){   
                    Console.Clear();
                    Console.WriteLine("Ha escogido Retirar dinero");
                    Console.Write("Digite el monto a retirar:");
                    retiro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Monto retirado correctamente.");
                    Console.WriteLine("El monto retirado es de: "+retiro);
                    Console.WriteLine("El saldo actual de la cuenta es:"+ (dinerocuenta-=retiro));
                }
                else if (retiro>dinerocuenta ) {
                    Console.WriteLine("Los fondos de la cuenta son insuficientes por favor intente de nuevo.");
                }

            } else if (dinerocuenta<=0) {
                Console.WriteLine("No hay dinero en la cuenta por lo tanto esta opcion no es valida.\nPor favor intente de nuevo");

            }
        }
        static void recibir_monedas()
        {
            int moneda5 = 0;
            int moneda10 = 0;
            int moneda25 = 0;
            int moneda50 = 0;
            int moneda100 = 0;
            int moneda500 = 0;
            if (opcion == 3)
            {
                Console.Clear();
                Console.WriteLine("Ha escogido la recepcion de monedas.");
                do
                {
                    Console.WriteLine("Digite el monto de la moneda o presione 0 para salir:");
                    moneda = int.Parse(Console.ReadLine());
                    dinerocuenta += moneda;
                    if (moneda == 5)
                    {
                        moneda5++;
                    }
                    else if (moneda == 10)
                    {
                        moneda10++;
                    }
                    else if (moneda == 25)
                    {
                        moneda25++;
                    }
                    else if (moneda == 50)
                    {
                        moneda50++;
                    }
                    else if (moneda == 100)
                    {
                        moneda100++;
                    }
                    else if (moneda == 500)
                    {
                        moneda500++;
                    }
                    else {
                        Console.WriteLine("El monto no es equivalente a ninguna moneda intente de nuevo.");
                    }

                } while (moneda != 0);
                Console.WriteLine("Montos depositado correctamente.");
                Console.WriteLine("La cantidad de Monedas de las denominaciones ingresadas son:\nCantidad de monedas de 5: " + moneda5 + "\nCantidad de monedas de 10: " + moneda10 + "\nCantidad de monedas de 25: " + moneda25 + "\nCantidad de monedas de 50: " + moneda50 + "\nCantidad de monedas de 100: " + moneda100 + "\nCantidad de monedas de 500: " + moneda500);
                Console.WriteLine("El saldo actual de la cuenta es: "+ dinerocuenta);
            }
        }
        static void indicar_tipodecambio() {
            if (opcion==4) {
                Console.Clear();
                Console.WriteLine("Ha escogido ver el tipo de cambio actual.");
                Console.WriteLine("El tipo de cambio para el dia del 23/Mayo/2016 es 543.65");
                Console.WriteLine("Digite la conversion que desee:\n 1-De Colones a Dolares\n 2-De Dolares a Colones");
                seleccion = int.Parse(Console.ReadLine());
                if (seleccion== 1) {
                    Console.Clear();
                    Console.WriteLine("Ha escogido  de Colones a Dolares");
                    Console.WriteLine("Digite el monto que desea conocer: ");
                    dinero = float.Parse(Console.ReadLine());
                    tipocamb = dinero * 543.65;
                    Console.WriteLine("El monto ingresado en Dolares es: " + tipocamb);
                    
                }
                if (seleccion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ha escogido  de Dolares a Colones");
                    Console.WriteLine("Digite el monto que desea conocer: ");
                    dinero = float.Parse(Console.ReadLine());
                    tipocamb = 543.65*dinero;
                    Console.WriteLine("El monto ingresado en Colones es:" + tipocamb);

                }


            }

        }

    static int Main()
        {


            Console.WriteLine("Digite el monto de fondos con que se va a empezar a trabajar:");
            dinerocuenta = int.Parse(Console.ReadLine());
            Console.Clear();
            do
            {
                Console.Clear();
                Console.WriteLine("Cajero Banco Estado");
                Console.WriteLine("1. Deposito de Dinero.");
                Console.WriteLine("2. Retiro de Dinero.");
                Console.WriteLine("3. Recibo de Monedas.");
                Console.WriteLine("4. Consulta Tipo de Cambio.");
                Console.WriteLine("5. Salir.");
                Console.WriteLine("Seleccione una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {

                    case 1:
                        { 
                            depositar_dinero();
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {

                            retirar_dinero();
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            recibir_monedas();
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                           indicar_tipodecambio();
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una opción válida");
                            Console.ReadKey();
                            break;
                        }
                }
            } while (opcion != 5);
            return 0;
        }
    }
}
