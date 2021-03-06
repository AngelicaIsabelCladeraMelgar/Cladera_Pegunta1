﻿using System;
using System.Web.Http;
using System.Web.Http.Results;
using Cladera_Pregunta1.Controllers;
using Cladera_Pregunta1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPegunta1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPostCladeras()
        {
            //Arrange
            Cladera expected = new Cladera()
            {
                CladeraID = 1,
                FriendofCladera = "Ana Marca",
                Email = "ana@gmail.com",
                Place = (ListaType)10,
                Birthdate = DateTime.Today,
            };
            CladerasController claderasController = new CladerasController();

            //Act
            IHttpActionResult actionResult = claderasController.PostCladera(expected);
            var result = actionResult as CreatedAtRouteNegotiatedContentResult<Cladera>;

            //Assert
            Assert.IsNotNull(result);
            // Assert.AreEqual("DefaultApi", student_actual.RouteName);
            //  Assert.AreEqual(student_expected.StudentID, student_actual.RouteValues["id"]);
            Assert.AreEqual(expected.FriendofCladera, result.Content.FriendofCladera);
            Assert.AreEqual(expected.Place, result.Content.Place);
        }
        [TestMethod]
        public void TestMethodGetCladeras()
        {
            //Arrange
            CladerasController claderasController = new CladerasController();

            //Act
            var ListaCladera = claderasController.GetCladeras();

            //Assert
            Assert.IsNotNull(ListaCladera);
        }

        [TestMethod]
        public void TestMethodPutCladeras()
        {
            //Arrange
            Cladera expected = new Cladera()
            {
                CladeraID = 1,
                FriendofCladera = "Ana Marca",
                Email = "ana@gmail.com",
                Place = (ListaType)10,
                Birthdate = DateTime.Today,
            };
            CladerasController claderasController = new CladerasController();

            //Act
            var result = claderasController.PutCladera(expected.CladeraID, expected);
            var actual = result as OkNegotiatedContentResult<Cladera>;

            //Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void TestMethodDeleteCladeras()
        {
            //Arrange
            Cladera expected = new Cladera()
            {
                CladeraID = 1,
                FriendofCladera = "Ana Marca",
                Email = "ana@gmail.com",
                Place = (ListaType)10,
                Birthdate = DateTime.Today,
            };
            CladerasController claderasController = new CladerasController();

            //Act
            IHttpActionResult actionResult = claderasController.PostCladera(expected);
            IHttpActionResult actual = claderasController.DeleteCladera(expected.CladeraID);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(OkNegotiatedContentResult<Cladera>));
        }
    }
}
