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
            sut = new Restaurant(42, "Restaurant name","","","","");
        }

        [Fact]
        public void RestaurantConstructor_Sets_Id_On_RestaurantModel()
        {
            int result = sut.Id;
            Assert.Equal(42, result);
        }
        [Fact]
        public void RestaurantConstructor_Sets_Name_On_RestaurantModel()
        {
            string result = sut.Name;
            Assert.Equal("Restaurant name", result);
        }
    }
}
