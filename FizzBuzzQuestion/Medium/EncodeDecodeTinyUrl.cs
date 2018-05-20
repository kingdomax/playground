using System;
using System.Collections.Generic;

namespace FizzBuzzQuestion.Medium
{
    /*
        TinyURL is a URL shortening service where you enter a URL such as 
        https://leetcode.com/problems/design-tinyurl and it returns a short URL such as http://tinyurl.com/4e9iAk.
     */
    public class Codec
    {
        private static string PREFIXS = "http://tinyurl.com/";
        private readonly IDictionary<string, string> _urlStorage;

        public Codec() => _urlStorage = new Dictionary<string, string>();

        public string decode(string shortUrl)
        {
            _urlStorage.TryGetValue(shortUrl, out string longUrl);
            return !String.IsNullOrEmpty(longUrl) ? longUrl : shortUrl;
        }

        public string encode(string longUrl)
        {
            // 0) handle
            if (String.IsNullOrEmpty(longUrl)) { return longUrl; }

            // 1) algorithm to encode
            var shortUrl = PossibleToHasDuplication_ButShortReturnedUrl(longUrl);
            var completeShortUrl = PREFIXS + shortUrl;

            // 2) check before insert to dictionary
            if (!_urlStorage.ContainsKey(completeShortUrl)) { _urlStorage.Add(completeShortUrl, longUrl); }

            return completeShortUrl;
        }

        // 1st Algorithm
        private string NoDuplication_ButLongReturnUrl(string longUrl)
        {
            var shortUrlByte = System.Text.Encoding.UTF8.GetBytes(longUrl);
            return System.Convert.ToBase64String(shortUrlByte);
        }

        // 2nd Algorithm
        // Very large possibility 62^6
        // (we can increase possibility by adding length of encoding)
        private string PossibleToHasDuplication_ButShortReturnedUrl(string longUrl)
        {
            var alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var encodingUrl = "";
            for (var i=0; i<6; i++)
            {
                encodingUrl += alphabet[new Random().Next(62)];
            }
            return encodingUrl;
        }
    }
}