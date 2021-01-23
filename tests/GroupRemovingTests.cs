using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_tests_white
{
    public class GroupRemovingTests : TestBase
    {
        [Test]
        public void GroupRemovingTest()
        {

            GroupData defaultGroup = new GroupData()
            {
                Name = "testGroupNameWhiteIfEmpty"
            };

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            if (oldGroups.Count <= 1)
            {
                app.Groups.Add(defaultGroup);
                oldGroups.Add(defaultGroup);
            }

            GroupData removingGroup = oldGroups[0];
            app.Groups.Remove(0);
            
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }

        [Test]
        public void RemovingLastGroupTest()
        {

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.ChangeGroupsListToOneGroup(oldGroups);
            app.Groups.RemoveLastOne();
            List<GroupData> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups, newGroups);
        }
        
    }
}
