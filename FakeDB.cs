using System.Collections.Generic;
using artist.Models;

namespace artist
{
  static  public class FakeDB
  {
    static public List<Artist> Artists { get; set; } = new List<Artist>() { new Artist("Picaso", 1678, true) };
  }
}