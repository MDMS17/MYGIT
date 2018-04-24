using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using Microsoft.Extensions.Options;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PAHWebApp.Models;
using PAHWebApp.Data;
using PAHWebApp.Models.PAHViewModels;
using PAHWebApp.Controllers;

namespace PahTest
{
    public class PahControllerTest
    {
        [Fact]
        public async Task ReportIndex()
        {
            // Arrange
            var mockRepo = new Mock<IPah_Repository>();
            mockRepo.Setup(repo => repo.ListAsync()).Returns(Task.FromResult(GetTestData()));
            var controller = new PharmReportsController(mockRepo.Object);

            // Act
            var result = await controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<ReportViewModel>>(
                viewResult.ViewData.Model);
            Assert.Equal(5, model.Count());
        }

        private List<PharmScrubLog> GetTestData()
        {
            List<PharmScrubLog> list = new List<PharmScrubLog>();
            PharmScrubLog log = new PharmScrubLog();
            log.ScrubLogId = 1;
            log.ClaimId = "C1";
            list.Add(log);
            log = new PharmScrubLog();
            log.ScrubLogId = 2;
            log.ClaimId  = "C2";
            list.Add(log);
            log = new PharmScrubLog();
            log.ScrubLogId = 3;
            log.ClaimId = "C3";
            list.Add(log);
            log = new PharmScrubLog();
            log.ScrubLogId = 4;
            log.ClaimId = "C4";
            list.Add(log);
            log = new PharmScrubLog();
            log.ScrubLogId = 5;
            log.ClaimId  = "C5";
            list.Add(log);
            return list;
        }
    }
}
