using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Domain.Helpers;
using DDD.WinForm.ViewModels;
using DDD.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTests.Tests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestMethod]
        public void 直近値_シナリオ()
        {
            var measureMock = new Moq.Mock<IMeasureRepository>();
            measureMock.Setup(x => x.GetLatest()).Returns( new MeasureEntity("guidA", new MeasureDate("2017/01/01 13:00:00".ToDate()), new MeasureValue(1.23456f)));
            var viewModel = new LatestViewModel(measureMock.Object);
            Assert.AreEqual(viewModel.MeasureDate, "2017/01/01 13:00:00");
            Assert.AreEqual(viewModel.MeasureValue,"1.23m/s");
        }

        [TestMethod]
        public void イコールテスト()
        {
            var vo1 = new MeasureValue(1.23456f);
            var vo2 = new MeasureValue(1.23456f);

            Assert.AreEqual(true, vo1.Equals(vo2));

            Assert.AreEqual(true, vo1 == vo2);
        }
    }
}
