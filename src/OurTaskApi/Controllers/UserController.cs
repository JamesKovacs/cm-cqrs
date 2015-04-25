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
        public IEnumerable<UserListing> Get()
        {
            //list of all users
            return new List<UserListing> {new UserListing {Name = "James"}, new UserListing {Name = "Donald"}};
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
        public IEnumerable<UserListing> GetSubordinateUsers(string username)
        {
            //list of all subordinate users
            return null;
        }
    }
}