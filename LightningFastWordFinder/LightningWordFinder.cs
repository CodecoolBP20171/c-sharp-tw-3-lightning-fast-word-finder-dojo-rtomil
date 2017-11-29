using System;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        private string word;
        public string GetLongestWord(string text)
        {
            var array = text.Replace('/', ';').Replace(',', ';').Replace(':', ';').Replace('[', ';').Replace(']', ';').Replace('.', ';').Replace('-', ';').Replace(' ', ';').Replace('\r', ';').Replace('\n', ';').Split(';');
            word = " ";
            foreach (var item in array)
            {
                if (item.Length > word.Length) { word = item; }
            }
            return word;
        }
    }
}
