using Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zodiac.Controllers;

namespace UnitTest
{
    public class AccountControllerIntegartionTest : IDisposable
    {
        private readonly ZodiacContext _context;

        public AccountControllerIntegartionTest()
        {
            var options = new DbContextOptionsBuilder<ZodiacContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new ZodiacContext(options);
            _context.Database.EnsureCreated();
        }

        [Fact]
        public void CreateUser_Successful()
        {
            // Arrange
            var controller = new AccountController(_context);
            var user = new UserModel
            {
                Email = "dummy@email.com",
                Username = "Test",
                Password = "password",
                ConfirmPassword = "password"
            };

            // Act
            var result = controller.Register(user);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("RegistrationSuccess", redirectToActionResult.ActionName);
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}
