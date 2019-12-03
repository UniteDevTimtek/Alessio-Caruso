namespace CountryDataViewer.Shared.Interfaces
{
    public interface ICountryData
    {
        Countries GetCountryData(string code);
    }
}