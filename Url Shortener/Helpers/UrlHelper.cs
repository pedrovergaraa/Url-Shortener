using System.Text;

namespace Url_Shortener.Helpers
{
    public class UrlHelper
    {
        private const int CantCaracteresUrlCorta = 6;
        private const string abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        
        public string GetShortUrl()
        {
            Random _random = new Random();
            var codeChars = new char[CantCaracteresUrlCorta];
            for(int i = 0; i < CantCaracteresUrlCorta; i++)
            {
                var randomIndex = _random.Next(abecedario.Length - 1);
                codeChars[i] = abecedario[randomIndex];
            }

            var shortUrl = new string(codeChars);   
            return shortUrl;
        }

    }
}
