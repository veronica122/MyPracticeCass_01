using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPracticeCass.Models
{
    public class Productos
    {
        //Atributos de la clase
        [Key] //LLave primaria de la tabla
        public int IdProducto { get; set; }
        [Required(ErrorMessage ="El campo no puede ser nulo")] 
        public string CodigoProducto { get; set; }
        [Required(ErrorMessage = "El campo no puede ser nulo")]
        public string DescripcionProducto { get; set; }
        [Required(ErrorMessage = "El campo no puede ser nulo")]
        public int CantidadProducto { get; set; }
        [Required(ErrorMessage = "El campo no puede ser nulo")]
        public double PrecioProducto { get; set; }
    }
}