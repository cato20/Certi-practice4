using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using UPB.Practice4.Logic.Managers;
using UPB.Practice4.Logic.Models;

namespace Practice4.Controllers
{
    [ApiController]
    [Route("/api/groups")]

    public class GroupController : ControllerBase
    {
        private readonly IGroupManager _groupManager;

        public GroupController(IGroupManager groupManager)
        {
            _groupManager = groupManager;
        }

        [HttpGet]
        public List<Group> GetGroups()
        {
            return _groupManager.GetAllGroups();
        }
        [HttpPost]
        public Group CreateGroup([FromBody] Group group)
        {
            return _groupManager.CreateGroup(group);
        }

        [HttpPut]

        public Group UpdateGroup([FromBody] Group group)
        {
            return _groupManager.UpdateGroup(group);
        }

        [HttpDelete]
        public Group DeleteGroup([FromBody] Group group)
        {
            return _groupManager.DeleteGroup(group);
        }
    }
}
