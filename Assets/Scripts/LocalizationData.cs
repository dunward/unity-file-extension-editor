[System.Serializable]
public class LocalizationData
{
    public string countryCode;
    public string text;

    public LocalizationData(string countryCode, string text)
    {
        this.countryCode = countryCode;
        this.text = text;
    }
}