using System;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Console
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}