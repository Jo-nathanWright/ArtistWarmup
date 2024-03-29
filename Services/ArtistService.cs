using System;
using System.Collections.Generic;
using artist.Models;

namespace artist.Services
{
    public class ArtistService
    {
        internal IEnumerable<Artist> Get()
        {
            return FakeDB.Artists;
        }
        internal Artist Get(int id)
        {
            Artist found = FakeDB.Artists.Find(a => a.id == id);
            if(found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }

        internal Artist Create(Artist newArtist)
        {
            FakeDB.Artists.Add(newArtist);
            return newArtist;
        }

        internal void Delete(int id)
        {
            int deleted = FakeDB.Artists.RemoveAll(a => a.id == id);
            if(deleted == 0){
                throw new Exception("Invalid Id");
            }
        }
    }
}