﻿using System.ComponentModel.DataAnnotations;

namespace E_tickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Movie> Movies { get; set; }

    }
}
