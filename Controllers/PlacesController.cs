using Microsoft.AspNetCore.Mvc;
using ExplorationApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.WebSockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ExplorationApi.Wrappers;
// using Pagination.WebApi.Contexts;
// using Pagination.WebApi.Filter;
// using Pagination.WebApi.Helpers;
// using Pagination.WebApi.Models;
// using Pagination.WebApi.Services;
// using Pagination.WebApi.Wrappers;

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
    
    // [HttpGet]
    // public ActionResult<IEnumerable<Place>> GetAction(string username, int rating)
    // {
    //   var query = _db.Places.AsQueryable();

    //   if (username != null)
    //   {
    //     query = query.Where(entry => entry.UserName == username);
    //   }

    //   if (rating != 0)
    //   {
    //     query = query.Where(entry => entry.Rating == rating);
    //   }
    //   return query.ToList();
    // }

    [HttpPost]
    public void Post([FromBody] Place place)
    {
      _db.Places.Add(place);
      _db.SaveChanges();
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
    {
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = await _db.Places
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToListAsync();
      var totalRecords = await _db.Places.CountAsync();
      return Ok(new PagedResponse<List<Place>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var place = await _db.Places.Where(a => a.PlaceId == id).FirstOrDefaultAsync();
      return Ok(new Response<Place>(place));
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