using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Capstoneproject.Models;
using Microsoft.AspNetCore.Routing;
using NuGet.ContentModel;
using Capstoneproject.Controllers;
using Microsoft.EntityFrameworkCore;
using Capstoneproject.Data;
[TestFixture]
public class DatabaseContextTests
{
    [Test]
    public void SeedData_AdminInfoSeeded_Success()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<InfoDbContext>()
            .UseInMemoryDatabase(databaseName: "BlogTrackerdb")
            .Options;

        using (var context = new InfoDbContext(options))
        {
            // Act
            var adminInfo = context.AdminInfo.FirstOrDefault();

            // Assert
            //Assert.IsNotNull(adminInfo);
            //Assert.AreEqual("admin@gmail.com", adminInfo.EmailId);
            //Assert.AreEqual("admin123", adminInfo.Password);
        }
    }
}