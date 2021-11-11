using BuildApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BuildCreator()
        {
            HashSet<building> hashSet = new HashSet<building>();
            Create.BuildingCreator();
            Create.BuildingCreator();
            Create.BuildingCreator();
            Create.BuildingCreator();
            Create.BuildingCreator();
            hashSet = Create.Store();
            int answer = hashSet.Count;
            Assert.AreEqual(answer, 5);
        }
        [TestMethod]
        public void DeleteCreator()
        {
            HashSet<building> hashSet = new HashSet<building>();
            Create.BuildingCreator();
            Create.BuildingCreator();
            Create.BuildingCreator();
            Create.BuildingCreator();
            building buildes =Create.BuildingCreator();
            hashSet = Create.Store();

            string id = Create.ReturnId(buildes);
            Create.Delete(id);

            int answer = hashSet.Count;
            Assert.AreEqual(answer, 4);
        }


        [TestMethod]
        public void SearchQuest()
        {
            HashSet<building> hashSet = new HashSet<building>();
            Create.BuildingCreator();
            Create.BuildingCreator();
            Create.BuildingCreator();
            Create.BuildingCreator();
            building buildes = Create.BuildingCreator();
            hashSet = Create.Store();
            string id = Create.ReturnId(buildes);

            building search = Create.Search(id);
            Assert.AreEqual(buildes, search);
        }
    }
}
