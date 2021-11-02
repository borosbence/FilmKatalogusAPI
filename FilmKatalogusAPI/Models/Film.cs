﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmKatalogusAPI.Models
{
    public class Film : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Cim { get; set; }

        [Required]
        [StringLength(30)]
        public string Mufaj { get; set; }

        [DataType(DataType.Date)]
        public DateTime BemutatoDatum { get; set; }
    }
}
