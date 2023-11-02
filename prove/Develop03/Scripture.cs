using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        public class Scripture
        {
            private string _book;
            private int _chapter;
            private int _startVerse;
            private int _endVerse;
            private string _body;

            private Scripture(string book, int chapter, int startVerse, int endVerse, string body)
            {
                _book = book;
                _chapter = chapter;
                _startVerse = startVerse;
                _endVerse = endVerse;
                _body = body;
            }

            public string GetScripture()
            {
                string fullScripture = $"{_book} chapter{_chapter}:{_startVerse}-{endVerse}}"
                return fullScripture
            }
        } 
    }
}