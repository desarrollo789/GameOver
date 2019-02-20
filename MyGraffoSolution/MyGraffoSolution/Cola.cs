using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraffoSolution
{
    public class Cola
    {       
        public class Nodo
        {
            public string info { get; set; }
            public Nodo sig1;
            public Nodo sig2;
            public Nodo sig3;
            public List<string> Arcodelnodo { get; set; }
            public Nodo()
            {
                Arcodelnodo = new List<string>();
            }

        }
        //ultimo
        public List<string> Obtenervecinos(string estado)
        {
            List<string> resp = new List<string>();
            foreach (Nodo nodo in this.ListadeNodos)
            {
                if (nodo.info == estado)
                {
                    resp = nodo.Arcodelnodo;
                }
            }
            return resp;
        }

        public string BusquedaArcoNodo(string nodo)
        {
            Nodo actual = BusquedadeCoincidencia(nodo);
            foreach (string elemento in actual.Arcodelnodo)
            {
                if (elemento == nodo)
                {
                    return nodo;
                }                
            }
            return null;
        }
        //fin ultimo


        private Nodo raiz, fondo;
        private List<Nodo> ListadeNodos;

        public Cola()
        {
            raiz = null;       
            fondo = null;
            ListadeNodos = new List<Nodo>();          

        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }
        public bool VacioReferancias(Nodo nodo)
        {
            if (nodo.sig1 == null && nodo.sig2 == null && nodo.sig3 == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Nodo crearnodo(string info)
        {
            Nodo nodo;
            nodo = new Nodo();
            nodo.info = info;
            nodo.sig1 = null;
            nodo.sig2 = null;
            nodo.sig3 = null;
            return nodo;
        }

        public Nodo BusquedadeCoincidencia(string parametro)
        {
            //Nodo reco1 = raiz;
            //Nodo reco2 = raiz;
            //Nodo reco3 = raiz;
            if (ListadeNodos != null)
            {
                foreach (Nodo elemento in ListadeNodos)
                {
                    if (elemento.info == parametro)
                    {
                        return elemento;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }           
            #region busqueda
            //    while (reco1 == null || reco2 == null || reco3 == null)
            //    {                                       
            //            try
            //            {
            //                if (orientacion == "izquierda" && reco1.info == parametro)
            //                {
            //                    fondo.sig1 = reco1;
            //                    fondo = reco1;
            //                    return true;
            //                }
            //            }
            //            catch
            //            {
            //                Console.WriteLine("orientacion no valida enviado");
            //            }

            //            try
            //            {
            //                if (orientacion == "medio" && reco1.info == parametro)
            //                {
            //                    fondo.sig2 = reco1;
            //                    fondo = reco1;
            //                    return true;
            //                }
            //            }
            //            catch
            //            {
            //                Console.WriteLine("orientacion no valida enviado");
            //            }

            //            try
            //            {
            //                if (orientacion == "derecha" && reco1.info == parametro)
            //                {
            //                    fondo.sig3 = reco1;
            //                    fondo = reco1;
            //                    return true;
            //                }
            //            }
            //            catch
            //            {
            //                Console.WriteLine("orientacion no valida enviado");
            //            }                    
            //        if (reco2 != reco1)
            //        {                        
            //                try
            //                {
            //                    if (orientacion == "izquierda" && reco2.info == parametro)
            //                    {
            //                        fondo.sig1 = reco2;
            //                        fondo = reco2;
            //                        return true;
            //                    }
            //                }
            //                catch
            //                {
            //                    Console.WriteLine("orientacion no valida enviado");
            //                }

            //                try
            //                {
            //                    if (orientacion == "medio" && reco2.info == parametro)
            //                    {
            //                        fondo.sig2 = reco2;
            //                        fondo = reco2;
            //                        return true;
            //                    }
            //                }
            //                catch
            //                {
            //                    Console.WriteLine("orientacion no valida enviado");
            //                }
            //                try
            //                {
            //                    if (orientacion == "derecha" && reco2.info == parametro)
            //                    {
            //                        fondo.sig3 = reco2;
            //                        fondo = reco2;
            //                        return true;
            //                    }
            //                }
            //                catch
            //                {
            //                    Console.WriteLine("orientacion no valida enviado");
            //                }                        
            //        }
            //        if (reco3 != reco1)
            //        {                        
            //                try
            //                {
            //                    if (orientacion == "izquierda" && reco3. info == parametro)
            //                    {
            //                        fondo.sig1 = reco3;
            //                        fondo = reco3;
            //                        return true;
            //                    }
            //                }
            //                catch
            //                {
            //                    Console.WriteLine("orientacion no valida enviado");
            //                }

            //                try
            //                {
            //                    if (orientacion == "medio" && reco3.info == parametro)
            //                    {
            //                        fondo.sig2 = reco3;
            //                        fondo = reco3;
            //                        return true;
            //                    }
            //                }
            //                catch
            //                {
            //                    Console.WriteLine("orientacion no valida enviado");
            //                }

            //                try
            //                {
            //                    if (orientacion == "derecha" && reco3.info == parametro)
            //                    {
            //                        fondo.sig3 = reco3;
            //                        fondo = reco3;
            //                        return true;
            //                    }
            //                }
            //                catch
            //                {
            //                    Console.WriteLine("orientacion no valida enviado");
            //                }                                            

            //        //linea de separacion

            //        if (reco1.sig1 == null) { break; }
            //        else { reco1 = reco1.sig1; }
            //        if (reco1.sig2 == null) { break; }
            //        else { reco2 = reco1.sig2; }
            //        if (reco1.sig3 == null) { break; }
            //        else { reco3 = reco1.sig3; }
            //    }
            //}
            #endregion
            
        }
        public Nodo BusquedadeCoincidencia(Nodo nuevo)
        {
            if (ListadeNodos != null)
            {
                foreach (Nodo elemento in ListadeNodos)
                {
                    if (elemento.info == nuevo.info)
                    {
                        return elemento;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }        
        }

        public Nodo BusquedadeCoincidenciaRelaciones(Nodo nuevo)
        {
            if (ListadeNodos != null)
            {
                foreach (Nodo elemento in ListadeNodos)
                {
                    #region busqueda siguiente
                    if (elemento.sig1 == null)
                    {
                        return null;
                    }
                    if (elemento.sig1.info == nuevo.info)
                    {
                        elemento.sig1 = nuevo;
                        return elemento.sig1;
                    }
                    if (elemento.sig2 == null)
                    {
                        return null;
                    }
                    if (elemento.sig2.info == nuevo.info)
                    {
                        elemento.sig2 = nuevo;
                        return elemento.sig2;
                    }
                    if (elemento.sig3 == null)
                    {
                        return null;
                    }
                    if (elemento.sig3.info == nuevo.info)
                    {
                        elemento.sig3 = nuevo;
                        return elemento.sig3;
                    }
                    #endregion                    
                                 
                }
                return null;
            }
            else
            {
                return null;
            }            
        }


        public void Asignarsiguentealanterior(Nodo siguiente)
        {
            if (raiz.sig1 == null && raiz.sig1.info == siguiente.info)
            {
                raiz.sig1 = siguiente;
            }
            if (raiz.sig2 == null && raiz.sig2.info == siguiente.info)
            {
                raiz.sig2 = siguiente;
            }
            if (raiz.sig3 == null && raiz.sig3.info == siguiente.info)
            {
                raiz.sig3 = siguiente;
            }
        }

        public void Asignarsiguentealanterior(Nodo anterior, Nodo siguiente)
        {
            if (anterior.sig1 == null && anterior.sig1.info == siguiente.info)
            {
                anterior.sig1 = siguiente;
            }
            if (anterior.sig2 == null && anterior.sig2.info == siguiente.info)
            {
                anterior.sig2 = siguiente;
            }
            if (anterior.sig3 == null && anterior.sig3.info == siguiente.info)
            {
                anterior.sig3 = siguiente;
            }
        }
    
        public void asignacionfondoElementos(Nodo nuevo)
        {
            fondo = nuevo;
        }
        public void asignacionfondoElementos(Nodo nuevo, string izquierda)
        {            
            if (BusquedadeCoincidencia(nuevo) != null)
            {
                Console.WriteLine("El nodo insertado ya existe");
                nuevo = BusquedadeCoincidencia(nuevo);
            }
            else
            {
                ListadeNodos.Add(nuevo);
            }

            BusquedadeCoincidenciaRelaciones(nuevo);
            //asignacion de izquierda                        
            if (BusquedadeCoincidencia(izquierda) != null)
            {
                nuevo.sig1 = BusquedadeCoincidencia(izquierda); ;                
                ListadeNodos.Add(nuevo.sig1);
                nuevo.Arcodelnodo.Add(nuevo.sig1.info);
            }
            else
            {
                fondo = nuevo;
                nuevo.sig1 = crearnodo(izquierda);                
                ListadeNodos.Add(nuevo.sig1);
                nuevo.Arcodelnodo.Add(nuevo.sig1.info);
            }
            //fin asignacion de izquierda  
            
        }

        public void asignacionfondoElementos(Nodo nuevo, string izquierda, string medio)
        {
            if (BusquedadeCoincidencia(nuevo) != null)
            {
                Console.WriteLine("El nodo insertado ya existe");
                nuevo = BusquedadeCoincidencia(nuevo);
            }
            else
            {
                ListadeNodos.Add(nuevo);
            }
            //if (BusquedadeCoincidenciaRelaciones(nuevo) != null)
            //{
            //    (BusquedadeCoincidenciaRelaciones(nuevo).sig1 = nuevo;
            //}
            //asignacion de izquierda                        
            if (BusquedadeCoincidencia(izquierda) != null)
            {
                nuevo.sig1 = BusquedadeCoincidencia(izquierda); ;                
                ListadeNodos.Add(nuevo.sig1);
                nuevo.Arcodelnodo.Add(nuevo.sig1.info);
            }
            else
            {
                fondo = nuevo;
                nuevo.sig1 = crearnodo(izquierda);                
                ListadeNodos.Add(nuevo.sig1);
                nuevo.Arcodelnodo.Add(nuevo.sig1.info);
            }
            //fin asignacion de izquierda
            //asignacion de medio
            if (BusquedadeCoincidencia(medio) != null)
            {
                nuevo.sig2 = BusquedadeCoincidencia(medio);                
                ListadeNodos.Add(nuevo.sig2);
                nuevo.Arcodelnodo.Add(nuevo.sig2.info);
            }
            else
            {
                fondo = nuevo;
                nuevo.sig2 = crearnodo(medio);                
                ListadeNodos.Add(nuevo.sig2);
                nuevo.Arcodelnodo.Add(nuevo.sig2.info);
            }
            //fin asignacion de medio   
        }
        public void asignacionfondoElementos(Nodo nuevo, string izquierda, string medio, string derecha)
        {
            if (BusquedadeCoincidencia(nuevo) != null)
            {
                Console.WriteLine("El nodo insertado ya existe");
                nuevo = BusquedadeCoincidencia(nuevo);
            }
            else
            {
                ListadeNodos.Add(nuevo);
            }
            BusquedadeCoincidenciaRelaciones(nuevo);
            //asignacion de izquierda                        
            if (BusquedadeCoincidencia(izquierda) != null)
            {
                nuevo.sig1 = BusquedadeCoincidencia(izquierda); ;
                ListadeNodos.Add(nuevo.sig1);
                nuevo.Arcodelnodo.Add(nuevo.sig1.info);
            }
            else
            {
                fondo = nuevo;
                nuevo.sig1 = crearnodo(izquierda);
                ListadeNodos.Add(nuevo.sig1);
                nuevo.Arcodelnodo.Add(nuevo.sig1.info);
            }
            //fin asignacion de izquierda
            //asignacion de medio
            if (BusquedadeCoincidencia(medio) != null)
            {
                nuevo.sig2 = BusquedadeCoincidencia(medio);
                ListadeNodos.Add(nuevo.sig2);
                nuevo.Arcodelnodo.Add(nuevo.sig2.info);
            }
            else
            {
                fondo = nuevo;
                nuevo.sig2 = crearnodo(medio);
                ListadeNodos.Add(nuevo.sig2);
                nuevo.Arcodelnodo.Add(nuevo.sig2.info);
            }
            //fin asignacion de medio   
            //asignacion de derecha
            if (BusquedadeCoincidencia(derecha) != null)
            {
                nuevo.sig3 = BusquedadeCoincidencia(derecha);
                ListadeNodos.Add(nuevo.sig3);
                nuevo.Arcodelnodo.Add(nuevo.sig3.info);
            }
            else
            {
                fondo = nuevo;
                nuevo.sig3 = crearnodo(derecha);
                ListadeNodos.Add(nuevo.sig3);
                nuevo.Arcodelnodo.Add(nuevo.sig3.info);
            }
            //fin asignacion de derecha              
        }

        public void Insertar(string info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig1 = null;
            nuevo.sig2 = null;
            nuevo.sig3 = null;              
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
                asignacionfondoElementos(nuevo);
            }
            else
            {
                asignacionfondoElementos(nuevo);
            }
        }

        public void Insertar(string info, string izquierda)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig1 = null;
            nuevo.sig2 = null;
            nuevo.sig3 = null;           
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
                asignacionfondoElementos(nuevo, izquierda);
            }
            else
            {
                asignacionfondoElementos(nuevo, izquierda);
            }
        }
        public void Insertar(string info, string izquierda, string medio)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig1 = null;
            nuevo.sig2 = null;
            nuevo.sig3 = null;
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
                asignacionfondoElementos(nuevo, izquierda, medio);
            }
            else
            {
                asignacionfondoElementos(nuevo, izquierda, medio);
            }
        }

        public void Insertar(string info, string izquierda, string medio, string derecha)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig1 = null;
            nuevo.sig2 = null;
            nuevo.sig3 = null;
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
                asignacionfondoElementos(nuevo, izquierda, medio, derecha);
            }
            else
            {
                asignacionfondoElementos(nuevo, izquierda, medio, derecha);
            }
        }
        public string Extraer()
        {
            if (Vacia())
            {
                string informacion = raiz.info;
                if (raiz == fondo)
                {
                    raiz = null;
                    fondo = null;
                }
                else
                {
                    raiz = raiz.sig1;
                }
                return informacion;
            }
            else
            {
                return "la lista no contiene elementos";

            }
        }
        public void Imprimir()           
        {
            Console.WriteLine("Elementos del grafo");
            foreach (Nodo elemento in ListadeNodos)
            {                
                Console.Write(elemento.info);
            }
            Console.WriteLine("");
            #region inprimir antiguo
            //Nodo reco1 = raiz;
            //Nodo reco2 = raiz;
            //Nodo reco3 = raiz;
            ////Nodo reco4 = raiz;
            ////Nodo reco5 = raiz;
            ////Nodo reco6 = raiz;
            //if (Vacia())
            //{
            //    Console.WriteLine("No existe grafo");
            //}
            //else
            //{
            //    //while (reco1 != null || reco2 != null || reco3 != null)
            //    //{
            //        Console.WriteLine("Listado de todos los elementos de la cola.");
            //        Console.WriteLine("Primera ruta");
            //        while (reco1 != null)
            //        {
            //            Console.Write(reco1.info + "-");
            //            reco1 = reco1.sig1;

            //        }                    
            //        Console.WriteLine(Environment.NewLine + "Segunda ruta");
            //        while (reco2 != null)
            //        {                        
            //            Console.Write(reco2.info + "-");
            //            reco2 = reco2.sig2;
            //        }
            //        Console.WriteLine(Environment.NewLine + "Tercera ruta");
            //        while (reco3 != null)
            //        {                        
            //            Console.Write(reco3.info + "-");
            //            reco3 = reco3.sig3;
            //        }
            //        Console.WriteLine();
            //        //if (reco1 == null)
            //        //{
            //        //    reco1 = raiz;
            //        //}


            //        ////linea de separacion
            //        //if (reco1.sig2 == null) { break; }
            //        //else { reco2 = reco1.sig2; }
            //        //if (reco1.sig3 == null) { break; }
            //        //else { reco3 = reco1.sig3; }
            //        //if (reco1.sig1 == null) { break; }
            //        //else { reco1 = reco1.sig1; }
                    
            //        //string lolo = "lolo";
            //    //}                                                
            //}

            #endregion
        }
               
        List<string> listarutas = new List<string>();

        List<string> listaconocidos = new List<string>();
        public void mostrarelmentosdeunalista()
        {
            foreach(string elemento in listarutas)
            {
                Console.Write("Elemeto:");
                Console.WriteLine(elemento);
            }

        }

        public void AgragarLista(string ruta)
        {
            listarutas.Add(ruta);
        }
        public void EliminarLista(string ruta)
        {
            listarutas.Remove(ruta);
        }
        public void AgragarListaconocidos(string ruta)
        {
            listaconocidos.Add(ruta);
        }

        public Nodo siguiente(int siguiente)
        {
            if (siguiente == 1)
            {
                return raiz.sig1;
            }
            if (siguiente == 2)
            {
                return raiz.sig2;
            }
            if (siguiente == 3)
            {
                return raiz.sig3;
            }
            return null;
        }
        public Nodo siguiente(Nodo nodo ,int siguiente)
        {
            if (siguiente == 1)
            {
                return nodo.sig1;
            }
            if (siguiente == 2)
            {
                return nodo.sig2;
            }
            if (siguiente == 3)
            {
                return nodo.sig3;
            }
            return null;
        }



        public string verificadorderutasporanchura(string nodo, string obj)
        {
            #region verficador de rutas
            //if (Vacia())
            //{
            //    return "No existe la lista";
            //}
            //else
            //{                
            //    Nodo reco1 = raiz;
            //    Nodo reco2 = raiz;
            //    Nodo reco3 = raiz;
            //    while (reco1.info != obj || reco2.info != obj || reco3.info != obj)
            //    {
            //        if (reco1.sig1 == null) { }
            //        else
            //        {
            //            AgragarLista(reco1.info + reco1.sig1.info);
            //        }
            //        if (reco1.sig2 == null) { }
            //        else
            //        {
            //            AgragarLista(reco1.info + reco1.sig2.info);
            //        }
            //        if (reco1.sig3 == null) { }
            //        else
            //        {
            //            AgragarLista(reco1.info + reco1.sig3.info);
            //        }
            //        if (reco1 == null) { }
            //        else { AgragarListaconocidos(reco1.info); }
            //        if (reco2 != reco1 || reco2 != reco3)
            //        {
            //            if (reco2.sig1 == null) { }
            //            else
            //            {
            //                AgragarLista(reco2.info + reco2.sig1.info);
            //            }
            //            if (reco2.sig2 == null) { }
            //            else
            //            {
            //                AgragarLista(reco2.info + reco2.sig2.info);
            //            }
            //            if (reco2.sig3 == null) { }
            //            else
            //            {
            //                AgragarLista(reco2.info + reco2.sig3.info);
            //            }
            //            if (reco2 == null) { }
            //            else { AgragarListaconocidos(reco2.info); }
            //        }
            //        if (reco3 != reco1 || reco3 != reco2 )
            //        {
            //            if (reco3.sig1 == null) { }
            //            else
            //            {
            //                AgragarLista(reco3.info + reco3.sig1.info);
            //            }
            //            if (reco3.sig2 == null) { }
            //            else
            //            {
            //                AgragarLista(reco3.info + reco3.sig2.info);
            //            }
            //            if (reco3.sig3 == null) { }
            //            else
            //            {
            //                AgragarLista(reco3.info + reco3.sig3.info);
            //            }
            //            if (reco3 == null) { }
            //            else { AgragarListaconocidos(reco3.info); }
            //        }              

            //        //linea de separacion

            //        if (reco1.sig1 == null) { }
            //        else { reco1 = reco1.sig1; }
            //        if (reco1.sig2 == null) { }
            //        else { reco2 = reco1.sig2; }
            //        if (reco1.sig3 == null) { }
            //        else { reco3 = reco1.sig3; }
            //        if (reco1.sig1 == null && reco1.sig2 == null && reco1.sig3 == null)
            //        {
            //            break;
            //        }
            //    }

            //    return "Objetivo alcazado";
            //}
            #endregion
            foreach (Nodo elemento in ListadeNodos)
            {
                listarutas.Add(elemento.info);
                if (elemento.info == obj)
                {
                    listaconocidos.Add(elemento.info);
                    return "Objetivo alcazado";
                }
            }
            return "objetivo no existente";
        }


        public string BusquedaEnAncho(string nOrigen, string nDestino)
        {
            string nodo = "";
            string solucion = "";
            List<string> visitados = new List<string>();
            List<string> vecinos = new List<string>();
            List<string> direcciones = new List<string>();
            string path = nOrigen;
            nodo = nOrigen;

            if (nodo == nDestino)
            {
                solucion = nodo;
            }
            else
            {
                vecinos = Obtenervecinos(nodo);
                //Agrega nuevas direcciones
                foreach (string estadoVec in vecinos)
                {
                    if (!visitados.Contains(estadoVec))
                    {
                        string dir = path + "," + estadoVec;
                        direcciones.Add(dir);
                        if (estadoVec == nDestino)
                        {
                            solucion = dir;
                        }
                    }
                }
                visitados.Add(nodo);

                while (solucion == "" && direcciones.Count > 0)
                {
                    //pop
                    string visitDir = direcciones[0];
                    path = visitDir;
                    direcciones.RemoveAt(0);

                    //cambio de nodo
                    string[] newNodos = visitDir.Split(',');
                    string nNodo = newNodos[newNodos.Length - 1];
                    nodo = nNodo;

                    vecinos = Obtenervecinos(nodo);
                    foreach (string estadoVec in vecinos)
                    {
                        if (!visitados.Contains(estadoVec))
                        {
                            string dir = path + "," + estadoVec;
                            direcciones.Add(dir);
                            if (estadoVec == nDestino)
                            {
                                solucion = dir;
                            }
                        }
                    }
                    visitados.Add(nodo);
                }
                if (solucion == "")
                {
                    solucion = "no existe camino";
                }
            }



            return solucion;
        }

        public int numero = 1;
        public Nodo nodoiniobtener(string nodo)
        {
            Nodo buscado = new Nodo();
            buscado.info = nodo;
            Nodo reco2 = new Nodo();
            if (BusquedadeCoincidencia(buscado) != null)
            {
                reco2 = BusquedadeCoincidencia(buscado);
            }
            return reco2;
        }
        public string verificadorderutasporprofundidad(string nodo, string obj)
        {            
            if (ListadeNodos == null)
            {
                return "No existe la lista";
            }
            else
            {
                Nodo reco2 = nodoiniobtener(nodo);
                Nodo buscado = new Nodo();
                buscado.info = nodo;                
                Nodo reco1 = new Nodo();                
                if (BusquedadeCoincidencia(buscado) != null)
                {
                    reco1 = BusquedadeCoincidencia(buscado);                    
                }
                else
                {
                    return "Elemento nodo inicial invalido";
                }
                Nodo reco3 = ListadeNodos.First();
                while (reco1 != null)
                {
                    if (reco1.info == obj)
                    {
                        listarutas.Add(reco1.info);
                        return "Objetivo alcanzado";
                    }
                    else
                    {
                        listarutas.Add(reco1.info);
                    }                                         
                        reco1 = reco1.sig1;
                }
                if (reco2.sig1 != null)
                {
                    if (reco2.sig1.sig2 != null)
                    {
                        return verificadorderutasporprofundidad(reco2.sig1.sig2.info, obj);
                    }
                    if (reco2.sig1.sig3 != null)
                    {
                        return verificadorderutasporprofundidad(reco2.sig1.sig3.info, obj);
                    }
                }
                if ( numero == 1)
                {
                    buscado.info = "A";
                    reco2 = BusquedadeCoincidencia(buscado);
                    if (reco2.sig2 != null)
                    {
                        numero++;
                        return verificadorderutasporprofundidad(reco2.sig2.info, obj);
                    }
                }

                buscado.info = "A";
                reco2 = BusquedadeCoincidencia(buscado);
                if (reco2.sig3 != null)
                {
                    numero++;
                    return verificadorderutasporprofundidad(reco2.sig3.info, obj);
                }


                return "No se alcazo el Objetivo";
            }
        }

        public string BusquedaEnProfundidad(string ninicial, string nDestino)
        {            
            string solucion = "";
            List<string> visitados = new List<string>();
            List<string> listavecinos = new List<string>();
            List<string> direcciones = new List<string>();
            string temp = ninicial;            

            if (ninicial == nDestino)
            {
                solucion = ninicial;
            }
            else
            {
                listavecinos = Obtenervecinos(ninicial);
                //Agrega nuevas direcciones
                foreach (string vecino in listavecinos)
                {
                    if (!visitados.Contains(vecino))
                    {
                        string dir = temp + "," + vecino;
                        direcciones.Add(dir);
                        if (vecino == nDestino)
                        {
                            solucion = dir;
                        }
                    }
                }
                visitados.Add(ninicial);

                while (solucion == "" && direcciones.Count > 0)
                {
                    //pop
                    string visitDir = direcciones[direcciones.Count - 1];
                    temp = visitDir;
                    direcciones.RemoveAt(direcciones.Count - 1);

                    //cambio de nodo
                    string[] newNodos = visitDir.Split(',');
                    string nNodo = newNodos[newNodos.Length - 1];
                    ninicial = nNodo;

                    listavecinos = Obtenervecinos(ninicial);
                    foreach (string vecinos in listavecinos)
                    {
                        if (!visitados.Contains(vecinos))
                        {
                            string dir = temp + "," + vecinos;
                            direcciones.Add(dir);
                            if (vecinos == nDestino)
                            {
                                solucion = dir;
                            }
                        }
                    }
                    visitados.Add(ninicial);
                }
                if (solucion == "")
                {
                    solucion = "no existe camino";
                }
            }
            return solucion;
        }
        public string BusquedaHeuristica(string eOrigen, string eDestino, Grafoheurustico grafo)
        {
            List<string> conocidos = new List<string>();
            List<Nodoh> vecinos = new List<Nodoh>();
            string direccion = "";  // Direcciones
            int costoAcum = 0; // Acumula el costo de camino
            string solucion = "";
            int costoCamino = 0;

            string nodo = eOrigen;// Origen
            direccion = nodo;
            if (nodo == eDestino)
            {
                solucion = direccion + nodo;
            }
            else
            {
                do
                {
                    vecinos = grafo.ObtenerVecinos(nodo, conocidos);//sin explorar
                    foreach (var vecino in vecinos)
                    {
                        if (vecino.Estado == eDestino)
                        {
                            solucion += direccion + "," + vecino.Estado + "\nCosto: " + costoCamino.ToString();
                            break;
                        }
                    }
                    if (solucion == "")
                    {
                        NodoCosto menor = grafo.ObtenerVecinoMenorCosto(nodo, costoAcum, conocidos);
                        costoAcum += menor.ArcCosto;
                        direccion += "," + menor.Nodo;
                        conocidos.Add(nodo);
                        costoCamino = menor.Costo;
                        nodo = menor.Nodo;
                        vecinos = grafo.ObtenerVecinos(nodo, conocidos);
                    }
                }
                while ( solucion == "");
            }
            return solucion;

        }
        public void nodoobj(string objetivo)
        {
            if (Vacia())
            {
                Nodo reco = raiz;
                while (reco != null)
                {
                    if (reco.info == objetivo)
                    {
                        Console.WriteLine("llegaste al nodo objetivo");
                    }
                    reco = reco.sig1;                   
                }

            }
        }     
    }
    public struct NodoCosto
    {
        public string Nodo { get; set; }
        public int Costo { get; set; }
        public int ArcCosto { get; set; }
    }
}
