using Microsoft.AspNetCore.Mvc;
using Moq;
using Rent_A_Car.Controllers;
using Rent_A_Car.Models;
using Rent_A_Car.Repository.Interfaces;
using System;
using Xunit;

namespace Rent_A_Car_Test
{
    public class CarControllerTest
    {
        [Fact]
        public void GetCar_ValidId_ReturnsObject()
        {
            // Arrange
            Car car = new Car()
            {
                Id = 2,
                Brand = "BMW",
                Model = "X3",
                Date = 2018,
                Price = 100,
                GearShift = "Manual",
                Country = "Serbia",
                City = "Novi Sad",
                Address = "Bulevar Oslobodjenja 15"

            };


            var mockRepository = new Mock<ICarRepository>();
            mockRepository.Setup(x => x.GetOne(1)).Returns(car);



            var controller = new CarsController(mockRepository.Object);

            // Act
            var actionResult = controller.GetOne(1) as OkObjectResult;

            // Assert
            Assert.NotNull(actionResult);
            Assert.NotNull(actionResult.Value);

            Assert.NotNull(actionResult);
            Assert.NotNull(actionResult.Value);
            Assert.Equal(car, actionResult.Value);
        }

        [Fact]
        public void GetCar_InvalidId_ReturnsNotFound()
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
        public void PostCar_ValidRequest_SetsLocationHeader()
        {
            // Arrange
            Car car = new Car()
            {
                Id = 1,
                Brand = "BMW",
                Model = "M3",
                Date = 2016,
                Price = 100,
                GearShift = "Manual",
                Country = "Serbia",
                City = "Novi Sad",
                Address = "Bulevar Oslobodjenja 15"
            };

            var mockRepository = new Mock<ICarRepository>();
            mockRepository.Setup(x => x.GetOne(1)).Returns(car);



            var controller = new CarsController(mockRepository.Object);
            // Act
            var actionResult = controller.Create(car) as CreatedAtActionResult;

            // Assert
            Assert.NotNull(actionResult);

            Assert.Equal("GetOne", actionResult.ActionName);
            Assert.Equal(1, actionResult.RouteValues["id"]);

            Assert.NotNull(actionResult.Value);
            Assert.Equal(car, actionResult.Value);
        }
    }
}
