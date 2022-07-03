﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UA.Models
{
    //[Table("Historial")]
    public class Historialxxxxx
    {
        public int IdAlumno { get; set; }

        [ForeignKey("IdAlumno")]
        public Alumno ID { get; set; }

        public string IDMateria { get; set; }

        //[ForeignKey("IDMateria")]
        //public MateriaC ID { get; set; }

        public string Fecha { get; set; }

        public string Nota { get; set; }

        /*[Key]
        public Guid Id { get; set; }*/

    }


}