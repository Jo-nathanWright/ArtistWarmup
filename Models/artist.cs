using System;
using System.ComponentModel.DataAnnotations;

namespace artist.Models
{
    public class Artist
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Paintings { get; set; }
        [Required]
        public bool Famous { get; set; }

        public Artist(string name, int paintings, bool famous)
        {
            Name = name;
            Paintings = paintings;
            Famous = famous;
            Id = Guid.NewGuid().ToString();
        }
  }
}