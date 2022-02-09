using System;
using HomeManager.DataAccess.DataAccess;
using HomeManager.DataAccess.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeManager.DataAccess.Test
{
    [TestClass]
    public class EntryGroupTests
    {
        [TestMethod]
        public void TestEntryGroup()
        {
            var newEntryGroup = new EntryGroupDto()
            {
                Id =0,
                Description = "Test Group"
            };
            var dataAccess = new GroupDataAccess();
            var result = dataAccess.AddEntryGroup(newEntryGroup);
            Assert.AreNotEqual(0, result.Id);

            var groupsResult = dataAccess.GetAllGroups();
            Assert.AreNotEqual(0, groupsResult.Count);

            var group = dataAccess.GetGroupById(result.Id);
            Assert.AreEqual("Test Group", result.Description);

            result.Description = "Group test modified";
            var result2 = dataAccess.UpdateEntryGroup(result);
            Assert.IsNotNull(result2);

            var result3 = dataAccess.DeleteEntryGroup(result2.Id);
            Assert.IsTrue(result3);
        }
    }
}
