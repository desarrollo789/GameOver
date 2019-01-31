using System;
using System.Collections.Generic;
using Comun;
using ClienteBrl;


namespace ConsoleApplicationGameOver
{
    public class Program
    {

        static void Main(string[] args)
        {
            ////Crear videojuego
            //VideoJuego videojuego = new VideoJuego()
            //{
            //    VideoJuegoId = 1,
            //    Nombre = "Call of Duty",
            //    Precio = 2.2F,
            //    CategoriaId = new Categoria()
            //    {
            //        CategoriaId = 3,
            //        Nombre = "Shooter",
            //    },
            //    ComentarioId = new Comentario
            //    {
            //        ComentarioId = 1,
            //        Comentariotext = "Esta muy bueno",
            //        UsuarioId = new Usuario
            //        {
            //            UsuarioId = 1,
            //            Username = "Rodrigo",
            //            Apellido = "Fuentes Paredes",
            //            SexoId = new Sexo
            //            {
            //                Nombre = "MASCULINO",
            //                SexoId = 1,
            //            },
            //            Administrador = true,
            //            FechaNacimiento = DateTime.Now,
            //            Fechaderegistro = DateTime.Now,                        
            //        },
            //    },
            //    Eliminado = false,
            //    Fecha = DateTime.Now,
            //    Portada = "D:/local_programs/xampp/htdocs/proyectos Webs/GAMEOVER/images/images-1.jpg",
            //    Trailer = "https://www.youtube.com/watch?v=BjiaMBk6rHk",
            //    RankingId = new Ranking
            //    {
            //        RankingId = 1,
            //        Puntuacion = 5,
            //    },
            //    ProveedorId = new Proveedor
            //    {
            //        ProveedorId = 1,
            //        NombreProveedor = "Felipe",
            //        ApellidoProveedor = "Vargas Medina",
            //        CorreoElectronico = "proveedorfelipe@gmail.com ",
            //        Eliminado = false,
            //    },                                                         
            //};
            // Lista videojuegos
            Console.WriteLine("Lista de VideoJuegos");
            var listaVideoJuego = VideoJuegoListBrl.Get();
            foreach (VideoJuego videojM in listaVideoJuego)
            {
                Console.WriteLine(videojM.VideoJuegoId);
                Console.WriteLine(videojM.Nombre);
                Console.WriteLine(videojM.Fecha);
                Console.WriteLine(videojM.CategoriaId);

                Console.WriteLine(videojM.Precio);
                Console.WriteLine((videojM.ProveedorId) + " " + (videojM.ProveedorId));
                Console.WriteLine(videojM.ComentarioId);
                Console.WriteLine(videojM.Eliminado);
                Console.WriteLine(videojM.RankingId);
                Console.WriteLine(videojM.Portada);
                Console.WriteLine(videojM.Trailer);
            }
            //VideoJuego videojE = VideoJuegoBrl.Get(2);
            //videojE.Eliminado = true;
            //VideoJuego videoU = VideoJuegoBrl.Get(2);
            //VideoJuegoBrl juego = new VideoJuegoBrl();
            //VideoJuegoBrl.Eliminar(2);
            //VideoJuegoBrl.Insertar(videojuego);
            //VideoJuegoBrl.Actualizar(videojuego);


            Console.ReadKey();
        }
    }
}
