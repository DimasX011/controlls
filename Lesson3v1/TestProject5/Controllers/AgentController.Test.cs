using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using consoleApiApp.AgentReposity;
using consoleApiApp.Controllers;

namespace TestProject5.Controllers
{
    public class AgentControllertest
    {

        private AgentController controller;
        private Mock<IAgentMetricsRepository> mock;

        public AgentControllertest()
        {
            mock = new Mock<IAgentMetricsRepository>();
            controller = new AgentController(mock.Object);
        }

        [Fact]
        public void GetByTimePeriod()
        {
            mock.Setup(repository => repository.GetByTimePeriod());
            var result = controller.GetAll();
            mock.Verify();
        }

    }
}
