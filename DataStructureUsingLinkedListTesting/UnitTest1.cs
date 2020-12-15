using DataStructureUsingLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureUsingLinkedListTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenValue_When30_ThenSearchAndFindTheNode()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            Node node = linkedList.Search(30);
            Assert.AreEqual(30, node.data);
        }
    }
}
