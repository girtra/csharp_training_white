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
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData removingGroup = oldGroups[0];
            app.Groups.Remove(0);
            
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
