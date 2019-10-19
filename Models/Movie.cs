using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

    
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genere { get; set; }
        [Column(TypeName ="Decimal(18,2)")]
        public decimal price { get; set; }
        public int directorID { get; set; }

        public ICollection<Director> Director { get; set; }
    }
}
