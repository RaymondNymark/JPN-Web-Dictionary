using Dictionary.Core.Enums;

namespace Dictionary.Core.Models
{
    public class Entry
    {
        // Model for a single dictionary entry.  A dictionary entry can hold
        // multiple English definitions, but only one Japanese reading. Parts of
        // speech is basic categorization of the word, whether it's a noun, verb,
        // or an expression. 
        public Entry(string slug, bool isCommon, JLPTenum jLPTLevel, string japaneseWord, string japaneseReading, string[] englishDefinitions, string[] partsOfSpeech)
        {
            Slug = slug;
            IsCommon = isCommon;
            JLPTLevel = jLPTLevel;
            JapaneseWord = japaneseWord;
            JapaneseReading = japaneseReading;
            EnglishDefinitions = englishDefinitions;
            PartsOfSpeech = partsOfSpeech;
        }

        public string Slug { get; set; }
        public bool IsCommon { get; set; }
        public JLPTenum JLPTLevel { get; set; }
        public string JapaneseWord { get; set; }
        public string JapaneseReading { get; set; }
        public string[] EnglishDefinitions { get; set; }
        public string[] PartsOfSpeech { get; set; }
    }
}
