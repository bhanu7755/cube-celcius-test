using NUnit.Framework;
using TemperatureConversion.API.Model;
using TemperatureConversion.API.Services;

namespace TemperatureConversion.Test
{
    public class TemperatureConvertorTest
    {
        private ITemperatureConvertor _temperatureConvetor;

        [SetUp]
        public void Setup()
        {
            _temperatureConvetor = new TemperatureConvertor();
        }

        [Test]
        public void Celcius_To_Fahrenheit_Except_Success()
        {
            var result = _temperatureConvetor.GetTemperature(Constants.CELCIUS, Constants.FAHRENHEIT, -2);
            Assert.AreEqual(28.4f, result.Result);
        }

        [Test]
        public void Celcius_To_Kelvin_Except_Success()
        {
            var result = _temperatureConvetor.GetTemperature(Constants.CELCIUS, Constants.KELVIN, 10);
            Assert.AreEqual(283f, result.Result);
        }

        [Test]
        public void Fahrenheit_To_Celcius_Except_Success()
        {
            var result = _temperatureConvetor.GetTemperature(Constants.FAHRENHEIT, Constants.CELCIUS, 100);
            Assert.AreEqual(37.7777786f, result.Result);
        }

        [Test]
        public void Fahrenheit_To_Kelvin_Except_Success()
        {
            var result = _temperatureConvetor.GetTemperature(Constants.FAHRENHEIT, Constants.KELVIN, 100);
            Assert.AreEqual(311.277771f, result.Result);
        }

        [Test]
        public void Kelvin_To_Celcius_Except_Success()
        {
            var result = _temperatureConvetor.GetTemperature(Constants.KELVIN, Constants.CELCIUS, 10);
            Assert.AreEqual(-263.0f, result.Result);
        }

        [Test]
        public void Kelvin_To_Fahrenheit_Except_Success()
        {
            var result = _temperatureConvetor.GetTemperature(Constants.KELVIN, Constants.FAHRENHEIT, 15);
            Assert.AreEqual(-432.399994f, result.Result);
        }
    }
}