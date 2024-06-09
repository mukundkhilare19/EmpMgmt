using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmpMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>();
        // GET: api/<EmpController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET api/<EmpController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        // POST api/<EmpController>
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            employees.Add(value);
          //  Console.WriteLine("Employee is added");
        }

        // PUT api/<EmpController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee value)
        {
           int i= employees.FindIndex(e => e.Id == id);
            if(i>=0)
            {
                employees[i] = value;
            }
        }

        // DELETE api/<EmpController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            employees.RemoveAll(e => e.Id == id);   
        }
    }
}
