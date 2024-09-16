using GDBA2024_14_9.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GDBA2024_14_9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        // GET: api/<AlumnosController>
        static List<Alumno> alumnos = new List<Alumno>();
        
        [HttpGet]
        public IEnumerable<Alumno> Get()
        {
            return alumnos;
        }

        // GET api/<AlumnosController>/5
        [HttpGet("{id}")]
        public Alumno Get(int id)
        {
            var alumno = alumnos.FirstOrDefault(a => a.Id == id);
            return alumno;
        }

        // POST api/<AlumnosController>
        [HttpPost]
        public IActionResult Post([FromBody] Alumno alumno)
        {
            alumnos.Add(alumno);
            return Ok();
        }

        // PUT api/<AlumnosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Alumno alumno)
        {
            var existingAlumno = alumnos.FirstOrDefault(a => a.Id == id);
            if(existingAlumno != null)
            {
                existingAlumno.Name = alumno.Name;
                existingAlumno.LastName = alumno.LastName;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<AlumnosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingAlumno = alumnos.FirstOrDefault(a => a.Id == id);
            if (existingAlumno != null)
            {
                alumnos.Remove(existingAlumno);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
