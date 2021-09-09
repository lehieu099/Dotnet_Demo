using System;
using System.ComponentModel.DataAnnotations;

namespace Dotnet_Demo.Models{
    public class Movie{
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string DemoName { get; set; }
    }
}

