using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraffoSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cola cola1 = new Cola();
            //cola1.Insertar("A");
            //cola1.Insertar("B");
            //cola1.Insertar("C");
            //cola1.Imprimir();
            //Console.WriteLine("Extraemos uno de la cola:" + cola1.Extraer());
            //cola1.Imprimir();
            //Console.ReadKey();
            Cola nodito = new Cola();
            //nodito.Insertar("A", "B", "C", "D");
            //nodito.Insertar("B", "E", "F");
            //nodito.Insertar("C","G");
            //nodito.Insertar("D","H");
            //nodito.Insertar("H", "I");
            //nodito.Insertar("F", "J");
            //nodito.Imprimir();

            #region Busqueda por anchura
            Console.WriteLine(Environment.NewLine + "Ingrese nodo objetivo");
            //metodo nro 1:
            //Console.WriteLine(nodito.verificadorderutasporanchura("A", "F"));
            //nodito.mostrarelmentosdeunalista();
            //Console.ReadKey();
            //metodo nro2:
            //Console.WriteLine(nodito.BusquedaEnAncho("A", "H"));
            //Console.ReadKey();
            #endregion
            #region Busqueda por profundidad          
            ////Console.WriteLine(Environment.NewLine + "Ingrese nodo objetivo");
            ////metodo nro1:
            //Console.WriteLine(nodito.verificadorderutasporprofundidad("A", "J"));
            //nodito.mostrarelmentosdeunalista();
            //Console.ReadKey();
            ////metodo nro 2:
            ////Console.WriteLine(nodito.BusquedaEnProfundidad("A", "G"));
            ////Console.ReadKey();
            #endregion
            #region BUSQUEDA A*            
            Grafoheurustico paises = new Grafoheurustico();
            //incializacion
            paises.NuevoNodo("COLOMBIA", 120);
            paises.NuevoNodo("BOLIVIA", 90);
            paises.NuevoNodo("ECUADOR", 118);
            paises.NuevoNodo("CHILE", 145);
            paises.NuevoNodo("BRASIL", 194);
            paises.NuevoNodo("PANAMA", 48);
            paises.NuevoNodo("PERU", 93);
            paises.NuevoNodo("URUGUAY", 78);
            paises.NuevoNodo("PARAGUAY", 240);
            paises.NuevoNodo("COSTA RICA", 177);
            paises.NuevoNodo("EUU", 0);

            //enlaces
            paises.AgregarArco("COLOMBIA", "BOLIVIA", 4);
            paises.AgregarArco("COLOMBIA", "PANAMA", 11);
            paises.AgregarArco("COLOMBIA", "ECUADOR", 3);

            paises.AgregarArco("BOLIVIA", "BRASIL", 7);
            paises.AgregarArco("BOLIVIA", "COLOMBIA", 4);

            paises.AgregarArco("ECUADOR", "COLOMBIA", 3);
            paises.AgregarArco("ECUADOR", "CHILE", 8);

            paises.AgregarArco("BRASIL", "BOLIVIA", 7);
            paises.AgregarArco("BRASIL", "PANAMA", 9);

            paises.AgregarArco("PANAMA", "COLOMBIA", 11);
            paises.AgregarArco("PANAMA", "BRASIL", 9);
            paises.AgregarArco("PANAMA", "URUGUAY", 8);
            paises.AgregarArco("PANAMA", "PARAGUAY", 5);

            paises.AgregarArco("CHILE", "ECUADOR", 8);
            paises.AgregarArco("CHILE", "PERU", 2);

            paises.AgregarArco("PERU", "CHILE", 2);
            paises.AgregarArco("PERU", "PARAGUAY", 8);
            paises.AgregarArco("PERU", "COSTA RICA", 15);

            paises.AgregarArco("PARAGUAY", "PANAMA", 5);
            paises.AgregarArco("PARAGUAY", "PERU", 8);
            paises.AgregarArco("PARAGUAY", "COSTA RICA", 12);

            paises.AgregarArco("URUGUAY", "PANAMA", 6);
            paises.AgregarArco("URUGUAY", "EUU", 20);

            paises.AgregarArco("COSTA RICA", "PARAGUAY", 12);
            paises.AgregarArco("COSTA RICA", "PERU", 15);
            paises.AgregarArco("COSTA RICA", "EUU", 7);

            paises.AgregarArco("EUU", "URUGUAY", 20);
            paises.AgregarArco("EUU", "COSTA RICA", 7);

            //busqueda
            Console.WriteLine(nodito.BusquedaHeuristica("COLOMBIA", "EUU", paises));

            Console.ReadLine();
            #endregion

        }
    }
}
