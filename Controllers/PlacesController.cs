using Microsoft.AspNetCore.Mvc;
using ExplorationApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ExplorationApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PlacesController : ControllerBase
  {
    private ExplorationApiContext _db;
    public PlacesController(ExplorationApiContext db)
    {
      _db = db;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<Place>> GetAction(string username, int rating)
    {
      var query = _db.Places.AsQueryable();

      if (username != null)
      {
        query = query.Where(entry => entry.UserName == username);
      }

      if (rating != 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Place place)
    {
      _db.Places.Add(place);
      _db.SaveChanges();
    }
    [HttpGet("{id}")]
    public ActionResult<Place> Get(int id)
    {
      return _db.Places.FirstOrDefault(entry => entry.PlaceId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Place place)
    {
      place.PlaceId = id;
      _db.Entry(place).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var placeToDelete = _db.Places.FirstOrDefault(entry => entry.PlaceId == id);
      _db.Places.Remove(placeToDelete);
      _db.SaveChanges();
    }
  }
}