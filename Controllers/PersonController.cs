using CurrencyRate.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyRate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private static List<Person> PersonList = new List<Person>
        {
            new Person{Id = 1, FullName =  "Person1"},
            new Person{Id = 2, FullName =  "Person2"},
            new Person{Id = 3, FullName =  "Person3"},
            new Person{Id = 4, FullName =  "Person4"},
            new Person{Id = 5, FullName =  "Person5"},
        };

        [HttpGet]
        public ActionResult<List<Person>> GetPersons()
        {
            return PersonList;
        }
        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonsById(int id)
        {
            return PersonList.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}