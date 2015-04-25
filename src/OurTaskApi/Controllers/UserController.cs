using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Http;
using OurTaskApi.Dto;

namespace OurTaskApi.Controllers
{
    [RoutePrefix("api/Users")]
    public class UserController:ApiController
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<PersonListing> Get()
        {
            //list of all users
            return new List<PersonListing> {new PersonListing() {Name = "James", Id = Guid.NewGuid()}, new PersonListing(){Name = "Donald", Id = Guid.NewGuid()}};
        }

        [Route("{username}")]
        [HttpGet]
        public IEnumerable<TaskListing> GetUserTasks(string username)
        {
            //get all tasks for a user
            return null;
        }

        [Route("{username}/Subordinates")]
        [HttpGet]
        public IEnumerable<PersonListing> GetSubordinateUsers(string username)
        {
            //list of all subordinate users
            return null;
        }
    }
}