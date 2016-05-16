using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static string nombrecliente = "";
        static string telefono = "";
        static string libro1 = "El Señor de los anillos, Las dos torres.";
        static string libro2 = "Alicia en el país de la Maravillas.";
        static string libro3 = "Cementerio de Mascotas";
        static string libro4 = "Quiero aprender";
        static string libro5 = "El poder del pensamiento Positivo";
        static string libro6 = "Mi primer libro de matemáticas.";
        static string libro7 = "Las aventuras de Tom Sawyer.";
        static string libro8 = "El mago de Oz.";
        static string libro9 = "La zona muerta.";
        static string libro10 = "Viaje al centro de la tierra";
        static int pre1 = 1000;
        static int can1 = 0;
        static int pre2 = 2000;
        static int can2 = 0;
        static int pre3 = 3000;
        static int can3 = 0;
        static int pre4 = 4000;
        static int can4 = 0;
        static int pre5 = 5000;
        static int can5 = 0;
        static int pre6 = 6000;
        static int can6 = 0;
        static int pre7 = 7000;
        static int can7 = 0;
        static int pre8 = 8000;
        static int can8 = 0;
        static int pre9 = 9000;
        static int can9 = 0;
        static int pre10 = 10000;
        static int can10 = 0;
        static int libro = 0;
        static int cantidad = 0;
        static int salir = 0;
        static int monto = 0;
        static int descuento = 0;
        static int montodescuento = 0;
        static int montoimpuesto = 0;
        static int Main(){
            Console.WriteLine("Libreria El Buen Lector");
            Console.Write("Digite el nombre del cliente:");
            nombrecliente = Console.ReadLine();
            Console.Write("Digite el telefono del cliente:");
            telefono = Console.ReadLine();
            
            while (salir == 0)
            
            {
                Console.WriteLine("1 = " + libro1);
                Console.WriteLine("2 = " + libro2);
                Console.WriteLine("3 = " + libro3);
                Console.WriteLine("4 = " + libro4);
                Console.WriteLine("5 = " + libro5);
                Console.WriteLine("6 = " + libro6);
                Console.WriteLine("7 = " + libro7);
                Console.WriteLine("8 = " + libro8);
                Console.WriteLine("9 = " + libro9);
                Console.WriteLine("10 = " + libro10);
                Console.Write("Seleccione el libro a comprar:");
                libro = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad a comprar del libro");
                cantidad = int.Parse(Console.ReadLine());
                if (libro == 1)
                {
                    monto = monto + pre1 * cantidad;
                    descuento = descuento + pre1 * 15/100 * cantidad;
                    can1 = cantidad;
                    int total1 = monto;

                }
                if (libro == 2 )
                {
                    monto = monto + pre2 * cantidad;
                    descuento = descuento + pre2 * 5 / 100 * cantidad;
                    can2 = cantidad;
                    int total2 = monto;
                }
                if (libro == 3)
                {
                    monto = monto + pre3 * cantidad;
                    descuento = descuento + pre3 * 10 / 100 * cantidad;
                    can3 = cantidad;
                    int total3 = monto;
                }
                if (libro == 4)
                {
                    monto = monto + pre4 * cantidad;
                    descuento = descuento + pre4 * 20 / 100 * cantidad;
                    can4 = cantidad;
                    int total4 = monto;
                }
                if (libro == 5)
                {
                    monto = monto + pre5 * cantidad;
                    descuento = descuento + pre5 * 25 / 100 * cantidad;
                    can5 = cantidad;
                    int total5 = monto;
                }
                if (libro == 6)
                {
                    monto = monto + pre6 * cantidad;
                    descuento = descuento + pre6 * 20 / 100 * cantidad;
                    can6 = cantidad;
                    int total6 = monto;
                }
                if (libro == 7)
                {
                    monto = monto + pre7 * cantidad;
                    descuento = descuento + pre7 * 5 / 100 * cantidad;
                    can7 = cantidad;
                    int total7 = monto;
                }
                if (libro == 8)
                {
                    monto = monto + pre8 * cantidad;
                    descuento = descuento + pre8 * 15 / 100 * cantidad;
                    can8 = cantidad;
                    int total8 = monto;
                }
                if (libro == 9)
                {
                    monto = monto + pre9 * cantidad;
                    descuento = descuento + pre9 * 10 / 100 * cantidad;
                    can9 = cantidad;
                    int total9 = monto;
                }
                if (libro == 10)
                {
                    monto = monto + pre10 * cantidad;
                    descuento = descuento + pre10 * 25 / 100 * cantidad;
                    can10 = cantidad;
                    int total10 = monto;
                }

                Console.WriteLine("desea comprar mas libros digite 0 de lo contrario digite 1");
                salir = int.Parse(Console.ReadLine());
                

            }
            montodescuento = monto - descuento;
            int impuesto = montodescuento * 13 / 100;
            montoimpuesto = montodescuento + impuesto;
            Console.WriteLine("El monto a pagar es=" + montoimpuesto);
            Console.WriteLine("Ingrese el monto con el que cansela:");
            int dinero = int.Parse(Console.ReadLine());
            while (dinero < montoimpuesto)
            {            
                Console.WriteLine("El monto no alcanza");
                    Console.WriteLine("Ingrese el monto con el que cansela:");
                    dinero = int.Parse(Console.ReadLine());

                } 
        
            Console.WriteLine("============================================");
            Console.WriteLine("     *­* Libreria El Buen Lector *­*");
            Console.WriteLine("============================================");
            Console.WriteLine("Factura Proforma                     N° 0001");
            Console.WriteLine("Cliente: " + nombrecliente);
            Console.WriteLine("Teléfono: " + telefono);
            Console.WriteLine("============================================");
            Console.WriteLine("Item        "
                +"Ctd     "
                +"Precio       "
                +"SubTotal        ");

            if (can1 != 0){
                Console.WriteLine(libro1+"  " 
                    + can1 +"   "
                    + pre1 +"   "
                    + (can1 * pre1) + "  ");
            }

            if (can2 != 0)
            {
                Console.WriteLine(libro2 + "  "
                    + can2 + "   "
                    + pre2 + "   "
                    + (can2*pre2) + "  ");
            }

            if (can3 != 0)
            {
                Console.WriteLine(libro3 + "  "
                    + can3 + "   "
                    + pre3 + "   "
                    + (can3 * pre3) + "  ");
            }
            if (can4 != 0)
            {
                Console.WriteLine(libro4 + "  "
                    + can4 + "   "
                    + pre4 + "   "
                    + (can4 * pre4) + "  ");
            }
            if (can5 != 0)
            {
                Console.WriteLine(libro5 + "  "
                    + can5 + "   "
                    + pre5 + "   "
                    + (can5 * pre5) + "  ");
            }
            if (can6 != 0)
            {
                Console.WriteLine(libro6 + "  "
                    + can6 + "   "
                    + pre6 + "   "
                    + (can6 * pre6) + "  ");
            }
            if (can7 != 0)
            {
                Console.WriteLine(libro7 + "  "
                    + can7 + "   "
                    + pre7 + "   "
                    + (can7 * pre7) + "  ");
            }
            if (can8 != 0)
            {
                Console.WriteLine(libro8 + "  "
                    + can8 + "   "
                    + pre8 + "   "
                    + (can8 * pre8) + "  ");
            }
            if (can9 != 0)
            {
                Console.WriteLine(libro9 + "  "
                    + can9 + "   "
                    + pre9 + "   "
                    + (can9 * pre9) + "  ");
            }
            if (can10 != 0)
            {
                Console.WriteLine(libro10 + "  "
                    + can10 + "   "
                    + pre10 + "   "
                    + (can10 * pre10) + "  ");
            }

            Console.WriteLine("Total Orden:                     " + monto);
            Console.WriteLine("Descuento:                       " + descuento);
            Console.WriteLine("Impuesto Venta:                      13%");

            Console.WriteLine("Impuesto total:                  " + impuesto);
            Console.WriteLine("Precio Neto:                     " + montoimpuesto);
            Console.WriteLine("============================================");
            Console.WriteLine("Monto Recibido:      " + dinero);
            int cambio = dinero - montoimpuesto;
            Console.WriteLine("Monto Cambio:        " + cambio);
            Console.WriteLine("============================================");
            Console.WriteLine("Gracias por su compra...");

            Console.ReadKey();
            return 0;
        }
    }
}
