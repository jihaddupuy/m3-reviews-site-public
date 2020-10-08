using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Controllers;
using System;
using Xunit;

namespace ReviewsSite.Tests
{
    public class RestaurantControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            //Arrange
            RestaurantController sut = new RestaurantController();
            //Act
            var result = sut.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
