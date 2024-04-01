using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Enteties_Dto;
using Newtonsoft.Json;

namespace BLL
{
    public class SearchInJsonFile
    {
        List<TanachByJsonFile>? objectsList = new();
        public SearchInJsonFile()
        {
            Data searchFile = new Data();
            string jsonTxt = searchFile.JsonFile();

            objectsList = new List<TanachByJsonFile>();
            if (jsonTxt != null)
                objectsList.Add(JsonConvert.DeserializeObject<TanachByJsonFile>(jsonTxt));
        }
        public List<LocationDto2> searchPasukToName(string name)
        {
            char firstN = name[0];
            char lastN = name[name.Length - 1];
            List<LocationDto2> results = new List<LocationDto2>();

            if (containsEnglishChars(name))
            {
                throw new Exception("You can search in Hebrew only");
            }

            if (objectsList != null)
            {
                foreach (var tanachByJsonFile in objectsList)
                {
                    if (tanachByJsonFile.Book != null)
                    {
                        for (int chapterIndex = 0; chapterIndex < tanachByJsonFile.Book.Count; chapterIndex++)
                        {
                            var perek = tanachByJsonFile.Book[chapterIndex];

                            foreach (var pasuk in perek)
                            {
                                var words = pasuk.Split(' ');

                                if (words.Length > 0)
                                {
                                    if (words[0][0] == firstN && words[words.Length - 1][words[words.Length - 1].Length - 1] == lastN)
                                        results.Add(new LocationDto2 { Book = "תהילים", Chapter = (chapterIndex + 1).ToString(), Verse = pasuk });
                                }
                            }
                        }
                    }
                }
            }
            if (results.Count > 0)
                return results;
            else
            {
                return new List<LocationDto2> { new LocationDto2 { Book = "Custom Message", Chapter = "", Verse = "Sorry, we didn't find any pasuk for you." } };
            }
        }
        public bool containsEnglishChars(string input)
        {
            foreach(var c in input)
            {
                if (char.IsLetter(c) && char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.OtherLetter)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
