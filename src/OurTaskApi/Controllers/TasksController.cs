using System;
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
            return new List<TaskListing>{new TaskListing
            {
                Id = Guid.NewGuid(),
                Name = "Build CQRS Application",
                Instructions = "1. Attend Clear Measure CQRS workshop.\r\n2. Drink scotch.\r\n3. ???\r\n4. Profit!!!",
                DueDate = DateTime.Now.AddHours(4),
                AssignedPersonnel = new [] {
                    new PersonListing
                    {
                        Id = Guid.NewGuid(),
                        Name = "Donald Belcham"
                    },
                    new PersonListing
                    {
                        Id = Guid.NewGuid(),
                        Name = "James Kovacs"
                    }
                }
            }};
        }

        [Route("{id}")]
        [HttpGet]
        public DisplayTask GetTask(int id)
        {
            return new DisplayTask();
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