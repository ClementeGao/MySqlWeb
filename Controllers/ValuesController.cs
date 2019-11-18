using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MySql.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IStudentManger _studentManger;

        public ValuesController(IStudentManger studentManger)
        {
            _studentManger = studentManger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            //var student = _studentManger.GetStudentById(1);


            return "test";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromHeader]string value)
        {
            var name = _studentManger.CreateStudent();

            return name;

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromHeader] string value)
        {
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
