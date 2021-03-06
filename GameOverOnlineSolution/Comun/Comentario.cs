﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    /// <summary>
    /// Define los comentarios para un juego
    /// </summary>
    public class Comentario
    {
        /// <summary>
        /// Identificador de comentario
        /// </summary>
        public int ComentarioId { get; set; }
        /// <summary>
        /// Identificador de usuario para un comentario
        /// </summary>
        public Usuario UsuarioId { get; set; }
        /// <summary>
        /// Texto del comentario
        /// </summary>
        public string Comentariotext { get; set; }
        /// <sumary>
        /// /// define estado de eliminado del juego
        /// </sumary>
        public byte Eliminado { get; set; }
    }
}
