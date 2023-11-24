﻿using System.ComponentModel.DataAnnotations;

namespace Url_Shortener.Models
{
    public class UrlForCreationDto
    {
        public int Id { get; set; }

        [Required]
        public string? Url { get; set; }
        [Required]
        public string? ShortUrl { get; set; }
        [Required]
        public int ContVisitas { get; set; }

        public CategoriaEnum Categoria { get; set; }


    }
}
