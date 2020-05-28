using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WeightliftingList.Models;

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
        public ActionResult<IEnumerable<Weight>> Get()
        {
            return _db.Weights.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Weight weight)
        {
            _db.Weights.Add(weight);
            _db.SaveChanges();
        }
    }
}