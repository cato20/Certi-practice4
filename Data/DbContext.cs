using System;
using System.Collections.Generic;

using UPB.Practice4.Data.Models;

namespace UPB.Practice4.Data
{
    public class DbContext : IDbContext
    {
        public List<Group> GroupTable { get; set; }
        public DbContext()
        {
            GroupTable = new List<Group>();
        }
        public Group AddGroup(Group group)
        {
            GroupTable.Add(group);
            return group;
        }
        public Group UpdateGroup(Group groupUpdate)
        {
            Group foundGroup = GroupTable.Find(group => group.Id == groupUpdate.Id);

            foundGroup.Name = groupUpdate.Name;
            foundGroup.AvailableSlots = groupUpdate.AvailableSlots;

            return foundGroup;
        }
        public Group DeleteGroup(Group groupToDelete)
        {
            GroupTable.Remove(groupToDelete);
            return groupToDelete;
        }
        public List<Group> GetAll()
        {
            return GroupTable;
        }
    }
}