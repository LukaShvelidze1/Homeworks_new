using Homework12.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;

namespace Homework12.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Personcontroller : Controller
    {

        //POST
        [HttpPost("person")]
        public IActionResult AddUser(Person person)
        {

            var validator = new PersonValidator();
            var result = validator.Validate(person);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors[0].ErrorMessage);
            }

            var newPerson = new Person
            {
                CreateDate = DateTime.Now,
                Firstname = person.Firstname,
                Lastname = person.Lastname,
                JobPosition = person.JobPosition,
                Salary = person.Salary,
                Workexperience = person.Workexperience,
                PersonAdress = person.PersonAdress,

            };

            string path = @"C:\Users\Geekster PC\Desktop\Homeworks_new\Homework12\Homework12\PersonList.json";
            string JSONresult = JsonConvert.SerializeObject(newPerson);


            using (var tw = new StreamWriter(path))
            {
                tw.WriteLine(JSONresult);

            }

            return Ok(JSONresult);








        }


        [HttpGet("person")]
        public IActionResult GetUser()
        {

        }

        [HttpGet("person/{id}")]
        public IActionResult GetUserById(int id)
        {

        }

    }

}

