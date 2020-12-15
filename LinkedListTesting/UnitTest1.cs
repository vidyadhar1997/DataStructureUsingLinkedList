using DataStructureUsingLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTesting
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the method for given value on 30 then should search and find node.
        /// </summary>
        [TestMethod]
        public void GivenValue_When30_ThenShouldSearchAndFindNode()
        {
            LinkedList linkedListTesting = new LinkedList();
            linkedListTesting.Add(56);
            linkedListTesting.Add(30);
            linkedListTesting.Add(70);
            Node node=linkedListTesting.Search(30);
            Assert.AreEqual(30, node.data);
        }
    }
}