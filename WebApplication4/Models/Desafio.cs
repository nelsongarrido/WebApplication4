//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Desafio
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Accion { get; set; }
        public string Controladora { get; set; }
        public Nullable<int> UsuarioID { get; set; }
        public Nullable<int> TipoDesafioID { get; set; }
        public string Letras { get; set; }
        public string Palabra { get; set; }
        public string Imagen { get; set; }
    
        public virtual TipoDesafio TipoDesafio { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
