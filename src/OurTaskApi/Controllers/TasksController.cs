using System.Collections;
using System.Collections.Generic;
using System.Web.Http;
using OurTaskApi.Dto;

namespace OurTaskApi.Controllers
{
    [RoutePrefix("api/tasks")]
    public class TasksController:ApiController
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<TaskListing> Get()
        {
            return new List<TaskListing>{new TaskListing()};
        }

        [Route("")]
        [HttpPost]
        public void Create(CreateTask task)
        {
            
        }

        [Route("{id}")]
        [HttpPut]
        public void Update(int id, UpdateTask task)
        {
            
        }

        [Route("{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            
        }
    }
}