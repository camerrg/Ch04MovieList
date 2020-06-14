using Microsoft.AspNetCore.Mvc;
using WebApplication1Cameron.Controllers;
using WebApplication1Cameron.Models;
using Xunit;

namespace WebApplication1CameronTest
{
    public class HomeControllerTests
    {
        T GetViewModel<T>(IActionResult result) where T : class
        {
            return (result as ViewResult)?.ViewData.Model as T;
        }

        [Fact]
        public void Test_Index()
        {
            //Arrange
            HomeController homeController = new HomeController();

            //Act
            var result = GetViewModel<PersonModel>(homeController.Index());


            //Assert
            Assert.IsType<PersonModel>(result);
            Assert.Equal(0, result.BirthYear);

        }

        [Fact]
   
        public void Test_CalculateByDate()
        {
            //Arrange
            HomeController homeController = new HomeController();

            //Act
            var result = GetViewModel<PersonExactDateModel>(homeController.CalculateByDate());

            //Assert
            Assert.IsType<PersonExactDateModel>(result);
            Assert.Null(result.BirthDate);
        }

    }
}
