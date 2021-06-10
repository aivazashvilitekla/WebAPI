using Classwork.EF;
using Classwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Classwork.Controllers
{
    //[RoutePrefix("api/Locations")]
    public class ValuesController : ApiController

    {
        [Route("api/GetLocations")]
        [HttpGet]
        public IEnumerable<LocationViewModel> Get()
        {
            using (LearningCenterDB db = new LearningCenterDB())
            {
                return db.Locations.Select(i => new LocationViewModel
                {
                    Name = i.Name,
                    Latitude = i.Latitude,
                    Longtitude = i.Longtitude
                }).ToList();
            }
        }

        [Route("api/GetLocations/{nm}")]
        [HttpGet]
        public LocationViewModel Get(string nm)
        {
            using (LearningCenterDB db = new LearningCenterDB())
            {
                return db.Locations.Where(i => i.Name.Equals(nm)).Select(i => new LocationViewModel
                {
                    Name = i.Name,
                    Longtitude = i.Longtitude,
                    Latitude = i.Latitude
                }).FirstOrDefault();
            }
        }


        [Route("api/GetLocations")]
        [HttpPost]
        public void Post([FromBody] LocationViewModel l)
        {
            using (LearningCenterDB db = new LearningCenterDB())
            {
                //if (!db.Locations.Any(i => i.Name.Equals(l.Name)))
                //    throw new Exception($"ადგილმდებარეობა სახელით {l.Name} უკვე არსებობს!");
                Locations location = new Locations
                {
                    Name = l.Name,
                    Longtitude = l.Longtitude,
                    Latitude = l.Latitude
                };
                db.Locations.Add(location);
                db.SaveChanges();
            }
        }

        
        //[Route("api/Locations/{nm}")]
        [Route("api/GetLocations/{nm}")]
        [HttpPut]
        public void Put(string nm, [FromBody] LocationViewModel l)
        {
            using (LearningCenterDB db = new LearningCenterDB())
            {
                if (!db.Locations.Any(i => i.Name.Equals(nm)))
                    throw new Exception($"ადგილმდებარეობა სახელით {nm} ვერ მოიძებნა!");
                var r = db.Locations.Where(i => i.Name.Equals(nm)).First();

                r.Name = l.Name;
                r.Longtitude = l.Longtitude;
                r.Latitude = l.Latitude;
                r.ParentID = l.ParentID;

                db.SaveChanges();
            }
        }

        
        //[Route("api/Locations/{nm}")]
        [Route("api/GetLocations/{nm}")]
        [HttpDelete]
        public void Delete(string nm)
        {
            using (LearningCenterDB db = new LearningCenterDB())
            {
                if (!db.Locations.Any(i => i.Name.Equals(nm)))
                    throw new Exception($"ადგილმდებარეობა სახელით {nm} ვერ მოიძებნა!");


                var r = db.Locations.Where(i => i.Name.Equals(nm)).First();

                db.Locations.Remove(r);
                db.SaveChanges();
            }
        }
    }
}
