using NUnit.Framework;

namespace CountryDataReader.Service.Tests
{
    [TestFixture]
    public class ServiceTests
    {

        private ServiceReader _serviceReader;
        private FakeData _fakeData;
        
        [SetUp]
        public void Setup()
        {
            //Arrange
            _serviceReader = new ServiceReader();
            _fakeData = new FakeData();
        }

        [Test]
        public void ServiceReader_GetCountryData_IsNotNull()
        {
            //Act
            var dataRetrieved = _serviceReader.GetCountryData("CO");

            //Assert
            Assert.That(dataRetrieved != null);
        }

        [Test]
        public void ServiceReader_GetCountryCode_AllISOCodesAreValid()
        {
            //Act
            var fakeCodes = _fakeData.GetListOfCodes();
            
            //Assert
            foreach (string code in fakeCodes)
            {
                var dataRetrieved = _serviceReader.GetCountryData(code);
                Assert.That(dataRetrieved != null);
            }

        }
        
    }
}