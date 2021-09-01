using artist.Services;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using artist.Models;

namespace artist.Controllers
{
    [ApiController]

    [Route("/api/[controller]")]
    public class ArtistController : ControllerBase
    {
    private readonly ArtistService _artistService;

    public ArtistController(ArtistService artistService)
    {
      _artistService = artistService;
    }

    [HttpGet]

    public ActionResult<IEnumerable<Artist>> Get()
    {
        try
        {
            IEnumerable<Artist> artists = _artistService.Get();
            return Ok(artists);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpGet("{id}")]

    public ActionResult<Artist> Get(string id)
    {
        try
        {
            Artist found = _artistService.Get(id);
            return Ok(found);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpPost]

    public ActionResult<Artist> Create([FromBody]Artist rawArtist)
    {
        try
        {
            Artist artist = _artistService.Create(rawArtist);
            return Ok(artist);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpDelete("{id}")]

    public ActionResult<Artist> Delete(string id)
    {
        try
        {
            _artistService.Delete(id);
            return Ok("Successfully Cancled Artist");
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }
  }
}