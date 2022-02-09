using HomeManager.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManager.DataAccess.Dtos
{
    public class Mapper
    {
        internal static List<EntryGroupDto> ToEntryGroupDtos(List<EntryGroup> entryGroups)
        {
            List<EntryGroupDto> result = new List<EntryGroupDto>();
            foreach(var entryGroup in entryGroups)
            {
                result.Add(new EntryGroupDto
                {
                    Id = entryGroup.Id,
                    Description = entryGroup.Description
                });
            }
            return result;
        }

        internal static EntryGroupDto ToEntryGroupDto(EntryGroup entryGroup)
        {
            return new EntryGroupDto
            {
                Id = entryGroup.Id,
                Description = entryGroup.Description
            };
        }
    }
}
