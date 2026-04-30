using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;
using Util.Model;

namespace TeacherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherAPIController : ControllerBase
    {

        private readonly ILogger<TeacherAPIController> _logger;
        private static List<TeacherModel>_teachers = new List<TeacherModel>();

        public TeacherAPIController(ILogger<TeacherAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Get/{ID}")]
        public TeacherModel GetById(string ID)
        {
            return _teachers.Where(t => t.ID.Equals(ID, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        [HttpGet("All")]
        public IEnumerable<TeacherModel> GetAll()
        {
            return _teachers.ToArray();
        }

        [HttpPost("Add")]
        public bool AddTeacher(TeacherModel model)
        {
            _teachers.Add(model);
            return true;
        }
        [HttpDelete("Remove/{ID}")]
        public bool Remove(string ID)
        {
            var model = _teachers.Where(t => t.ID.Equals(ID, StringComparison.OrdinalIgnoreCase)).FirstOrDefault(); 
            _teachers.Remove(model);
            return true;
        }
    }
}
