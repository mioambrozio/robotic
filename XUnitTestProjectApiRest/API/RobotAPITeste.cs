using ApiRest;
using ApiRest.Interface;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Net.Http;
using ApiRest.Controllers;
using ApiRest.Models;
using ApiRest.Entities;

namespace XUnitTestProjectApiRest.API
{
    public class RobotAPITeste
    {
        [Fact]
        public void MoveMMMMMMMMMMMMMMMMMMMMMMMM()
        {
            IRobo robo = new Robo();
            var controller = new MarsController(robo);
            var result = controller.Post("MMMMMMMMMMMMMMMMMMMMMMMM");
            Assert.Equal(typeof(Microsoft.AspNetCore.Mvc.OkObjectResult), result.GetType());
        }

        [Fact]
        public void MoveAAAIsNotTypeOK()
        {
            IRobo robo = new Robo();
            var controller = new MarsController(robo);
            var result = controller.Post("AAA");
            Assert.IsNotType<Microsoft.AspNetCore.Mvc.OkObjectResult>(result.GetType());
        }

        [Fact]
        public void MoveMMRMMRMM()
        {
            try
            {
                IRobo robo = new Robo();
                var controller = new MarsController(robo);
                var result = controller.Post("MMRMMRMM");

                if (typeof(Microsoft.AspNetCore.Mvc.OkObjectResult).Equals(result.GetType()))
                    Assert.Equal("(2, 0, S)", ((Microsoft.AspNetCore.Mvc.ObjectResult)result).Value.ToString());
            }
            catch
            {
                Assert.False(null);
            } 
        }

        [Fact]
        public void MoveMML()
        {
            IRobo robo = new Robo();
            var controller = new MarsController(robo);
            var result = controller.Post("MML");
            Assert.Equal(typeof(Microsoft.AspNetCore.Mvc.OkObjectResult), result.GetType());
        }
    }
}
