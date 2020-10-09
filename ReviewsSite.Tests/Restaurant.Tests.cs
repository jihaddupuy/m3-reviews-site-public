using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewsSite.Tests
{
    

    public class RestaurantTests
    {
        Restaurant sut;
        public RestaurantTests()
        {
            sut = new Restaurant();
        }

        [Fact]
        public void RestaurantConstructor_Sets_Id_On_CourseModel()
        {
            int result = sut.Id;
            Assert.Equal(42, result);
        }
    }
}
