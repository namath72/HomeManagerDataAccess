using HomeManager.DataAccess.Dtos;
using HomeManager.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace HomeManager.DataAccess.DataAccess
{
    public class GroupDataAccess
    {
        #region ReadOnly Methods
        public List<EntryGroupDto> GetAllGroups()
        {
            using (var context = new HMContext())
            {
                List<EntryGroupDto> groups = new List<EntryGroupDto>();
                groups = Mapper.ToEntryGroupDtos(context.EntryGroups.ToList());
                return groups;
            }

        }

        public EntryGroupDto GetGroupById(int id)
        {
            using (var context = new HMContext())
            {
                var entryGroupDto = new EntryGroupDto();
                var entryGroup = context.EntryGroups.FirstOrDefault(g => g.Id == id);
                if (entryGroup != null)
                {
                    entryGroupDto = Mapper.ToEntryGroupDto(entryGroup);
                }
                return entryGroupDto;
            }

        }
        #endregion
        #region Read & Write Methods
        public EntryGroupDto AddEntryGroup(EntryGroupDto entryGroup)
        {
            using (var context = new HMContext())
            {
                var result = context.EntryGroups.FirstOrDefault(g => g.Description == entryGroup.Description);
                if (result == null)
                {
                    context.EntryGroups.Add(new EntryGroup
                    {
                        Description = entryGroup.Description
                    });
                    context.SaveChanges();
                    return Mapper.ToEntryGroupDto(context.EntryGroups.FirstOrDefault(g => g.Description == entryGroup.Description));
                }
                else
                {
                    return Mapper.ToEntryGroupDto(result);
                }
            }
        }

        public EntryGroupDto UpdateEntryGroup(EntryGroupDto entryGroup)
        {
            using (var context = new HMContext())
            {
                var result = context.EntryGroups.Find(entryGroup.Id);
                if (result != null)
                {
                    result.Description = entryGroup.Description;
                    context.SaveChanges();
                    return entryGroup;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool DeleteEntryGroup(int entryGroupId)
        {
            using (var context = new HMContext())
            {
                var result = context.EntryGroups.Find(entryGroupId);
                if (result != null)
                {
                    context.EntryGroups.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion
    }
}
