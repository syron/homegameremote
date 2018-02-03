using Microsoft.VisualStudio.TestTools.UnitTesting;
using homegameauto.repositories;
using homegameauto.models;
using System;
using System.Collections.Generic;
using homegameauto.api.Controllers;

namespace homegameauto.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IGameConsoleRepository console = new MockImplementation();

            GameConsolesController controller = new GameConsolesController(console);

            var result = controller.Get();

            Assert.IsNotNull(result);
        }
    }


    public class MockImplementation : IGameConsoleRepository
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<GameConsole> GetAll()
        {
            return new List<GameConsole>();
        }

        public GameConsole GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(GameConsole console)
        {
            throw new NotImplementedException();
        }

        public void Update(GameConsole console)
        {
            throw new NotImplementedException();
        }
    }
}
