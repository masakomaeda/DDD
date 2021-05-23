using DDD.Domain.Entities;
using DDD.Domain.Helpers;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObject;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DDDTests.Tests
{
    [TestClass]
    public class MeasureViesModelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var viewModel = new MeasureViesModel(new SensorMock());
            //viewModel.MeasureValue.Equals("--");

            //viewModel.Measure();
            //viewModel.MeasureValue.Equals("1.23 m/s");

            var sensorMock = new Moq.Mock<ISensorRepository>();
            var viewModel = new MeasureViewModel(sensorMock.Object);
            sensorMock.Setup(x => x.GetData()).Returns(new MeasureValue(1.23456f));
            viewModel.Measure();
            Assert.AreEqual(viewModel.MeasureValue,"1.23m/s");


            sensorMock.Setup(x => x.GetData()).Returns(new MeasureValue(2.2f));
            viewModel.Measure();
            Assert.AreEqual(viewModel.MeasureValue,"2.2m/s");
        }
    }
    [TestClass]
    public class MeasureListViesModelTest
    {
        [TestMethod]
        public void 計測リスト_シナリオ()
        {
            var measureMock = new Moq.Mock<IMeasureRepository>();
            var measures = new List<MeasureEntity>
            {
                new MeasureEntity("guidA",new MeasureDate( "2017/01/01 13:00:00".ToDate()),new MeasureValue(1.23456f)),
                new MeasureEntity("guidB",new MeasureDate( "2017/01/01 14:00:00".ToDate()),new MeasureValue(2.23456f)),
            };

            measureMock.Setup(x => x.GetData()).Returns(measures);
            var viewModel = new MeasureListViewModel(measureMock.Object);

            Assert.AreEqual(viewModel.Measures.Count, 2);
            Assert.AreEqual(viewModel.Measures[0].MeasureDate, "2017/01/01 13:00:00");
            Assert.AreEqual(viewModel.Measures[0].MeasureValue, "1.23m/s");
        }
    }
}
