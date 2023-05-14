using Microsoft.AspNetCore.Mvc;
using Moq;
using Rent_A_Car.Controllers;
using Rent_A_Car.Models;
using Rent_A_Car.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Rent_A_Car_Test
{
    public class ReservationControllerTest
    {
        [Fact]
        public void GetReservation_ValidId_ReturnsObject()
        {
            // Arrange
            Reservation res = new Reservation()
            {
                Id = 1,
                AppUserId = 2,
                CarId = 3,
                DateOfPickup = DateTime.Now,
                DateOfReturn = new DateTime(2023, 10, 15, 13, 30, 0)

            };


            var mockRepository = new Mock<IReservationRepository>();
            mockRepository.Setup(x => x.GetOne(1)).Returns(res);



            var controller = new ReservationsController(mockRepository.Object);

            // Act
            var actionResult = controller.GetOne(1) as OkObjectResult;

            // Assert
            Assert.NotNull(actionResult);
            Assert.NotNull(actionResult.Value);

            Assert.NotNull(actionResult);
            Assert.NotNull(actionResult.Value);
            Assert.Equal(res, actionResult.Value);
        }

        [Fact]
        public void GetReservation_InvalidId_ReturnsNotFound()
        {
            // Arrange
            var mockRepository = new Mock<IReservationRepository>();


            var controller = new ReservationsController(mockRepository.Object);

            // Act
            var actionResult = controller.GetOne(2) as NotFoundResult;

            // Assert
            Assert.NotNull(actionResult);
        }

        [Fact]
        public void PostReservation_ValidRequest_SetsLocationHeader()
        {
            // Arrange
            Reservation res = new Reservation()
            {
                Id = 1,
                AppUserId = 3,
                CarId = 4,
                DateOfPickup = DateTime.Now,
                DateOfReturn = new DateTime(2023, 10, 15, 13, 30, 0)
            };

            var mockRepository = new Mock<IReservationRepository>();
            mockRepository.Setup(x => x.GetOne(1)).Returns(res);



            var controller = new ReservationsController(mockRepository.Object);
            // Act
            var actionResult = controller.Create(res) as CreatedAtActionResult;

            // Assert
            Assert.NotNull(actionResult);

            Assert.Equal("GetOne", actionResult.ActionName);
            Assert.Equal(1, actionResult.RouteValues["id"]);

            Assert.NotNull(actionResult.Value);
            Assert.Equal(res, actionResult.Value);
        }
    }
}
