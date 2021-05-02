using System.Collections.Generic;
using UPB.Practice4.Data;
using UPB.Practice4.Logic.Models;

namespace UPB.Practice4.Logic.Managers
{
    public class GroupManager
    {
        private readonly DbContext _dbContext;
        public GroupManager()
        {
            _dbContext = new DbContext();
        }
        public List<Group> GetAllGroups()
        {
            List<Data.Models.Group> groups = _dbContext.GetAll();
            return DTOMappers.MapGroups(groups);
        }
        public Group CreateGroup(string name, int availableSlots)
        {
            return new Group();
        }
        public Group UpdateGroup(Group group)
        {
            return new Group();
        }
        public Group DeleteGroup()
        {
            return new Group();
        }


    }

}