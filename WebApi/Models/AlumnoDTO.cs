﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class AlumnoDTO
    {

    public string Id { get; set; }
        [StringLength(50, MinimumLength =3)]

        public string Nombre { get; set; }

        public bool EstaAprobado { get; set; }
    }
}