using RealEstateUploader.Core.Entities;
using System;
using System.Text.RegularExpressions;

namespace RealEstateUploader.Core.Services
{
    public static class QueryExtensions
    {
        private const int _vectorValue = 111000;

        public static string CleanSpecialCharaters(this string value)
        {
            return Regex.Replace(Regex.Replace(value, @"\s+", ""), "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        public static string CleanWhiteSpace(this string value)
        {
            return Regex.Replace(value, @"\s+", "");
        }
        public static string StringReverse(this string value)
        {
            string[] arySource = value.Split(new char[] { ' ' });
            string strReverse = string.Empty;
            for (int i = arySource.Length - 1; i >= 0; i--)
            {
                strReverse = strReverse + " " + arySource[i];
            }
            return strReverse.TrimStart();
        }
        public static bool LatitudeLongitudeCompare(this Property p, decimal latitude, decimal longitude)
        {
            var latDiff = (latitude - p.Latitude) * _vectorValue;
            var lonDiff = (longitude - p.Longitude) * _vectorValue;
            return ((Math.Abs(latDiff) < 200 || Math.Abs(lonDiff) < 200));
        }
    }
}
