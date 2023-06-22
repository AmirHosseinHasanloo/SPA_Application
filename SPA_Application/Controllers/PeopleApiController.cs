using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SPA_Application.Data;
namespace SPA_Application.Controllers
{
    public class PeopleApiController : ApiController
    {
        SPA_ApplicationContext db = new SPA_ApplicationContext();
        public IEnumerable<People> GetPeople()
        {
            return db.People.ToList();
        }

        public People GetById(int id)
        {
            return db.People.Find(id);
        }

        public bool PostPeople(People people)
        {
            if (people != null)
            {
                db.People.Add(people);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PutPeople(int id,People people) 
        {
            if (id == people.ID)
            {
                db.Entry(people).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeletePeople(int id)
        {
            if(db.People.Any(P=>P.ID==id)) 
            {
                var Delete = GetById(id);
                db.People.Remove(Delete);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
