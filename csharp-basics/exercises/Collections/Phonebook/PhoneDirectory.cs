using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string,string> _dictionary;

        public PhoneDirectory()
        {
            _dictionary = new SortedDictionary<string, string>();
        }

        private bool Find(string name) 
        {
            return _dictionary.ContainsKey(name);
        }

        public string GetNumber(string name) 
        {
            return Find(name) ? _dictionary[name] : "Name not found";
        }

        public void PutNumber(string name, string number) 
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number)) 
            {
                throw new Exception("name and number cannot be null");
            }

            _dictionary.Add(name, number);
        }
    }
}