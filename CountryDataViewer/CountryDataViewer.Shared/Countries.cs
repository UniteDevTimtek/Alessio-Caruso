using System;
using System.Collections.Generic;

namespace CountryDataViewer.Shared
{
    public class Countries
    {
        public string Name { get; set; }
        public List<string> TopLevelDomain { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public List<string> CallingCodes { get; set; }
        public string Capital { get; set; }
        public List<string> AltSpellings { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public string Population { get; set; }
        public List<string> LatLng { get; set; }
        public string Demonym { get; set; }
        public string Area { get; set; }
        public string Gini { get; set; }
        public List<string> TimeZones { get; set; }
        public List<string> Borders { get; set; }
        public string NativeName { get; set; }
        public string NumericCode { get; set; }
        public List<Currency> Currencies { get; set; }
        public List<Language> Languages { get; set; }
        public Dictionary<string, string> Translations { get; set; }
        public string Flag { get; set; }
        public List<RegionalBlock> RegionalBlocks { get; set; }


        public class Currency
        {
            public string Code { get; set; }
            public string  Name { get; set; }
            public string Symbol { get; set; }
        }

        public class Language
        {
            public string Iso639_1 { get; set; }
            public string Iso639_2 { get; set; }
            public string Name { get; set; }
            public string NativeName { get; set; }
        }

        public class RegionalBlock
        {
            public List<Block> Blocks { get; set; }
            public string Cioc { get; set; }
        }


        public class Block
        {
            public string Acronym { get; set; }
            public string Name { get; set; }
            public List<string> OtherAcronyms { get; set; }
            public List<string> OtherNames { get; set; }
        }
        
    }
    
}