using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dal;
using Enteties_Dto;

namespace BLL
{
    public class SmartSearch
    {
        public List<LocationDto> searchWord(string wordInTxt)
        {
            Data ourTanach = new Data();
            string txt = ourTanach.TanachTxt();
            if (string.IsNullOrEmpty(txt) || string.IsNullOrEmpty(wordInTxt))
            {
                throw new BLLException("Your input is empty, incorrect input!");
            }
            if (containsEnglishChars(wordInTxt))
            {
                throw new Exception("You can search in Hebrew only");
            }


            List<LocationDto> results = new List<LocationDto>();
            string currentBook = null;
            string currentParasha = null;
            string currentChapter = null;
            string currentVerse = null;

            string[] lines = txt.Split("\n");          

            for(int line = 0; line<lines.Length; line++)
            {
                string[] words = lines[line].Split(" ");
                for(int word = 0; word < words.Length; word++) 
                {
                    if (words[word].Contains('^'))
                    {
                        int startWordIndex = word + 1;
                        currentParasha = string.Join(" ", words.Skip(startWordIndex)).Trim();
                    }
                    else if (words[word].Contains('~'))
                    {
                        currentBook = words[word + 1].Trim();
                        currentChapter =words[word + 2].Trim();
                    }
                    else if (words[word].Contains('!'))
                    {
                        currentVerse = words[word +1].Trim();
                    }
                    else if (words[word] == wordInTxt)
                    {
                        if (!lines[line].Contains('^') && !lines[line].Contains('~'))
                        {
                            results.Add(new LocationDto()
                            {
                                Book = currentBook,
                                Parasha = currentParasha,
                                Chapter = currentChapter,
                                Verse = currentVerse

                            });
                        }
                    }
                }
            }
            return results;
        }
        public bool containsEnglishChars(string input)
        {
            foreach (var c in input)
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
