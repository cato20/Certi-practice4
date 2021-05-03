using System.Collections.Generic;
using UPB.Practice4.Data;
using UPB.Practice4.Logic.Models;

namespace UPB.Practice4.Logic.Managers
{
    public class GroupManager : IGroupManager
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
        public Group CreateGroup(Group group)
        {
            Data.Models.Group groupToAdd = DTOMappers.MapGroup(group);
            _dbContext.AddGroup(groupToAdd);
            return group;
        }
        public Group UpdateGroup(Group group)
        {
            Data.Models.Group groupToUpdate = DTOMappers.MapGroup(group);
            _dbContext.UpdateGroup(groupToUpdate);
            return group;
        }
        public Group DeleteGroup(Group group)
        {
            Data.Models.Group groupToDelete = DTOMappers.MapGroup(group);
            _dbContext.DeleteGroup(groupToDelete);
            return group;
        }


    }

}