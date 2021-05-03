using System.Collections.Generic;

using UPB.Practice4.Logic.Models;
namespace UPB.Practice4.Logic.Managers
{
    public interface IGroupManager
    {
        List<Group> GetAllGroups();

        Group CreateGroup(Group group);

        Group UpdateGroup(Group group);

        Group DeleteGroup(Group group);

    }
}