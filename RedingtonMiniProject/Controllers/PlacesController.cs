namespace RedingtonMiniProject.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    public class PlacesController : ApiController
    {
        public static int NextValue = 1;

        public static Dictionary<int, Place> Places = new Dictionary<int, Place>();

        // DELETE: api/Places/5
        public void Delete(int id)
        {
            Places.Remove(id);
        }

        // GET: api/Places
        public IEnumerable<Place> Get()
        {
            return Places.Values;
        }

        // POST: api/Places
        public void Post([FromBody] Place value)
        {
            value.Id = ++NextValue;
            Places.Add(NextValue, value);
        }

        // PUT: api/Places/5
        public void Put(int id, [FromBody] Place value)
        {
            Places[id] = value;
        }
    }

    public class Place
    {
        public double AverageRating { get; set; }

        public string Description { get; set; }

        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Name { get; set; }
    }
}