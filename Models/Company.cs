using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Company
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }

}