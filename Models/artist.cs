using System;
using System.ComponentModel.DataAnnotations;

namespace artist.Models
{
    public class Artist
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int paintings { get; set; }
        [Required]
        public bool deceased { get; set; }

        public Artist(string n, int p, bool d)
        {
            name = n;
            paintings = p;
            deceased = d;
        }
  }
}