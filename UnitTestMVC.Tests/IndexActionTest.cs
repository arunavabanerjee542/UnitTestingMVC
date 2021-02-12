using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingMVC.Controllers;
using UnitTestingMVC.Models;
using Xunit;

namespace UnitTestMVC.Tests
{
    public class IndexActionTest
    {
        class FakeSource : IDataSource
        {
            public IEnumerable<Product> GetProducts()
            {
                return new List<Product>()
                {
                new Product(){Name="Bat",Price=4500},
                new Product(){Name="Bal",Price=500}
                };

            }
        }

        [Fact]
        public void Index_IsProductSourceValid_ReturnsTrue()
        {
            // Arrange
            var fake = new FakeSource();
            var items = fake.GetProducts();
            var controller = new HomeController();

            // Act

            var model = (controller.Index() as
            ViewResult)?.ViewData.Model
           as IEnumerable<Product>;

            // Assert

            Assert.Equal(items, model, GiveComparer.GetComparerObj<Product>(
                (a, b) => a.Name == b.Name && a.Price == b.Price
                )) ;


        }


    }
}
