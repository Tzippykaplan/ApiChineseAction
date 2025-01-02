

using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Gift
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
        public string Description { get; set; }
        public string imgUrl { get; set; }
        [Required]
        public int donorId { get; set; }
       
        public int Price { get; set; } = 10;
    

    }
}
