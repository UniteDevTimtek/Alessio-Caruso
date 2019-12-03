using System.Collections.Generic;
using CountryDataViewer.Shared;
using CountryDataViewer.Shared.Interfaces;

namespace CountryDataReader.Service.Tests
{
    public class FakeData : ICountryData
    {

        private readonly  Countries _fakeCountryData = new Countries()
        {
            Name = "Colombia",
            TopLevelDomain = new List<string>{".co"},
            Alpha2Code = "CO",
            Alpha3Code = "COL",
            CallingCodes = new List<string>{"57"},
            Capital = "Bogotá",
            AltSpellings = new List<string>{"CO", "Republic of Colombia", "República de Colombia"},
            Region = "Americas",
            SubRegion = "South America",
            Population = "48759958",
            LatLng = new List<string>{"4.0", "-72.0"},
            Demonym = "Colombian",
            Area = "1141748.0",
            Gini = "55.9",
            TimeZones = new List<string>{"UTC-05:00"},
            Borders = new List<string>{"BRA", "ECU", "PAN", "PER", "VEN"},
            NativeName = "Colombia",
            NumericCode = "170",
            Currencies = new List<Countries.Currency>{ new Countries.Currency{Name = "COP", Code = "Colombian peso", Symbol = "$"}},
            Languages = new List<Countries.Language>{new Countries.Language{Iso639_1 = "es", Iso639_2 = "spa", Name = "spanish", NativeName = "Español"}},
            Translations = new Dictionary<string, string>{{"de", "Kolumbien"}, {"es", "Colombia"}, {"fr", "Colombie"}, {"ja", "コロンビア"}, {"it", "Colombia"}, {"br", "Colômbia"}, {"pt", "Colômbia"}},
            Flag = "https://restcountries.eu/data/col.svg",
            RegionalBlocks = new List<Countries.RegionalBlock>{new Countries.RegionalBlock{Blocks = new List<Countries.Block>{new Countries.Block{Acronym = "PA", Name = "Pacific Alliance", OtherAcronyms = new List<string>(), OtherNames = new List<string>{"Alianza del Pacífico"}},  new Countries.Block{Name = "Union of South American Nations ", Acronym = "USAN", OtherAcronyms =new List<string>{"UNASUR", "UNASUL", "UZAN"}, OtherNames = new List<string>{"Unión de Naciones Suramericanas", "União de Nações Sul-Americanas", "Unie van Zuid-Amerikaanse Naties", "South American Union"}}}, Cioc = "COL"}}
            
        };

        private readonly List<string> _countryCodes = new List<string>()
        {
            "CO",
            "USA",
            "IT"
        };

        public Countries GetCountryData(string code)
        {
            return _fakeCountryData;
        }

        public List<string> GetListOfCodes()
        {
            return _countryCodes;
        }
    }
}
