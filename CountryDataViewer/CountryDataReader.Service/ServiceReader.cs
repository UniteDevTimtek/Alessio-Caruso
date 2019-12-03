using System;
using System.Net;
using CountryDataViewer.Shared;
using CountryDataViewer.Shared.Interfaces;
using Newtonsoft.Json;
using RestSharp;

namespace CountryDataReader.Service
{
    public class ServiceReader : ICountryData
    {
        private readonly string _uri = "https://restcountries.eu/rest/v2/alpha/";
        
        public Countries GetCountryData(string code)
        {
            var client = new RestClient($"{_uri}{code}");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<Countries>(response.Content);

                return content;
            }

            return null;
        }
    }
}