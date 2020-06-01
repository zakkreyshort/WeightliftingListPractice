using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WeightliftingList.Models;
using Microsoft.EntityFrameworkCore;

namespace WeightliftingList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeightsController : ControllerBase
    {
        private WeightliftingListContext _db;

        public WeightsController(WeightliftingListContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Weight>> Get(string weightType, string material, string brand)
        {
            var query = _db.Weights.AsQueryable();

            if (weightType != null)
            {
                query = query.Where(entry => entry.WeightType == weightType);
            }

            if(material != null)
            {
                query = query.Where(entry => entry.Material == material);
            }

            if(brand != null)
            {
                query = query.Where(entry => entry.Brand == brand);
            }
            return query.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Weight weight)
        {
            _db.Weights.Add(weight);
            _db.SaveChanges();
        }

        [HttpGet("{id}")]
        public ActionResult<Weight> GetAction(int id)
        {
            return _db.Weights.FirstOrDefault(entry => entry.WeightId == id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Weight weight)
        {
            weight.WeightId = id;
            _db.Entry(weight).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var weightToDelete = _db.Weights.FirstOrDefault(entry => entry.WeightId == id);
            _db.Weights.Remove(weightToDelete);
            _db.SaveChanges();
        }
    }
}