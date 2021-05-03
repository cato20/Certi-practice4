using System.Collections.Generic;
using UPB.Practice4.Data;
using UPB.Practice4.Logic.Models;

namespace UPB.Practice4.Logic.Managers
{
    public class GroupManager : IGroupManager
    {
        private int id = 0;
        private readonly IDbContext _dbContext;
        public GroupManager(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Group> GetAllGroups()
        {
            List<Data.Models.Group> groups = _dbContext.GetAll();
            return DTOMappers.MapGroups(groups);
        }
        public Group CreateGroup(Group group)
        {
            id += 1;
            string idGroup = "Group-";
            string idNum = "";
            if (id < 10)
            {
                idNum = "00";
            }
            else if (id < 100)
            {
                idNum = "0";
            }
            else
            {
                idNum = "";
            }
            group.Id = idGroup + idNum + id;
            if (group.Name.Length <= 50 && group.Name != null)
            {
                Data.Models.Group groupToAdd = DTOMappers.MapGroup(group);
                _dbContext.AddGroup(groupToAdd);
            }
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