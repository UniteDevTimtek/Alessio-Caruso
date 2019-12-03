using System.Collections.Generic;
using CountryDataReader.Decorator;
using CountryDataReader.Service;
using CountryDataViewer.Shared;
using CountryDataViewer.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CountryDataViewer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryDataController : ControllerBase
    {
        private readonly ICountryData _countryRepository;

        public CountryDataController()
        {
            var serviceReader = new ServiceReader();
            _countryRepository = new CachingReader(serviceReader);
        }

        [HttpGet/*("{code}", Name = "GetCountry")*/]
        public Countries GetCountry(string code)
        {
            code = "CO"; //Temporary for testing - Once the parameter will be passed correctly from React, this line will be deleted
            var country = _countryRepository.GetCountryData(code);

            return country;

        }
        
    }
}