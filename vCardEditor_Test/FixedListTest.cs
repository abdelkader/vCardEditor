using vCardEditor.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace vCardEditor_Test
{
    
    
    /// <summary>
    ///Classe de test pour FixedListTest, destinée à contenir tous
    ///les tests unitaires FixedListTest
    ///</summary>
    [TestClass()]
    public class FixedListTest
    {
        /// <summary>
        ///Test pour enqueue
        ///</summary>
        [TestMethod()]
        public void enqueue_one_element_test()
        {
            int size = 1; 
            FixedList target = new FixedList(size);
            string elem = "test";
            target.Enqueue(elem);
            
            Assert.IsTrue( target.Size == 1);
            Assert.IsTrue(target[0] == "test");
        }

        /// <summary>
        ///Test pour enqueue
        ///</summary>
        [TestMethod()]
        public void enqueue_two_elements_test()
        {
            int size = 1;
            FixedList target = new FixedList(size);
            
            target.Enqueue("elem1");
            target.Enqueue("elem2");

            Assert.IsTrue(target.Size == 1);
            Assert.IsTrue(target[0] == "elem2");

            Assert.IsTrue(target.Size == 1);
        }

        [TestMethod()]
        public void enqueue_three_elements_test()
        {
            int size = 3;
            FixedList target = new FixedList(size);

            target.Enqueue("elem1"); // this one should be remove !
            target.Enqueue("elem2");
            target.Enqueue("elem3");
            target.Enqueue("elem4");

            Assert.IsTrue(target.Size == 3);
            Assert.IsTrue(target[0] == "elem2");
            Assert.IsTrue(target[1] == "elem3");

            Assert.IsTrue(target.Size == 3);
        }
    }
}
