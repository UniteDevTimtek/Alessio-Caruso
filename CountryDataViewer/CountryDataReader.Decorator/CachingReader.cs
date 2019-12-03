using System;
using CountryDataViewer.Shared;
using CountryDataViewer.Shared.Interfaces;

namespace CountryDataReader.Decorator
{
    public class CachingReader : ICountryData
    {
        private readonly ICountryData _wrapperReader;
        private readonly  TimeSpan _cacheDuration = new TimeSpan(0, 5, 0);

        private Countries _cachedItems;
        private DateTime _dateTime;

        private bool IsCacheValid
        {
            get
            {
                if (_cachedItems == null)
                    return false;

                var cacheAge = DateTime.Now - _dateTime;
                return cacheAge < _cacheDuration;
            }
        }


        public CachingReader(ICountryData wrapperReader)
        {
            _wrapperReader = wrapperReader;
        }

        public Countries GetCountryData(string code)
        {
            ValidateCache(code);
            return _cachedItems;
        }

        private void ValidateCache(string code)
        {
            if (IsCacheValid)
                return;

            try
            {
                _cachedItems = _wrapperReader.GetCountryData(code);
                _dateTime = DateTime.Now;
            }
            catch
            {
                InvalidateCache(); 
            }

        }

        private void InvalidateCache()
        {
            _cachedItems = new Countries();
            _dateTime = DateTime.MinValue;
        }
    }
}
