using System.Collections.Generic;

using UPB.Practice4.Data.Models;
namespace UPB.Practice4.Data
{
    public interface IDbContext
    {
        Group AddGroup(Group group);
        Group UpdateGroup(Group groupUpdate);
        Group DeleteGroup(Group groupToDelete);
        List<Group> GetAll();
    }
}