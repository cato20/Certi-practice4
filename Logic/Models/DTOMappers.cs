using System.Collections.Generic;

namespace UPB.Practice4.Logic.Models
{
    public static class DTOMappers
    {
        public static List<Group> MapGroups(List<Data.Models.Group> groups)
        {
            List<Group> mappedGroups = new List<Group>();

            foreach (Data.Models.Group group in groups)
            {
                mappedGroups.Add(new Group()
                {
                    Id = group.Id,
                    Name = group.Name,
                    AvailableSlots = group.AvailableSlots
                });
            }
            return mappedGroups;
        }
    }
}