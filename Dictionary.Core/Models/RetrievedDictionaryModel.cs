using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dictionary.Core.Models
{
    public class RetrievedDictionaryModel
    {
        // Nested classes to encapsulate the structure.  Each successful API
        // call is to return an array of Datums containing all of the useful
        // information.
        public class DictionaryEntry
        {
            [JsonProperty("data")]
            public List<Datum> Entries { get; set; }
        }

        public class Datum
        {
            // slug is global unique identifier.
            [JsonProperty("slug")]
            public string UniqueIdentifier { get; set; }

            // is_common bool if a word is common.
            [JsonProperty("is_common")]
            public bool IsCommon { get; set; }

            // array of tags like: Noun, I-Adjective, Verb, Suru-verb
            // appropriate for specific word.
            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            // associated JLPT-level of the word if there's one.
            [JsonProperty("jlpt")]
            public List<string> JLPTLevel { get; set; }

            // Array of 'Japanese' as each dictionary entry can have multiple
            // readings or alternative used words.
            [JsonProperty("japanese")]
            public List<Japanese> JapaneseData { get; set; }

            // Array of sens that contain English definitions, tags, and various
            // meta data surrounding word.
            [JsonProperty("senses")]
            public List<Sens> EnglishData { get; set; }

        }

        public class Japanese
        {
            [JsonProperty("word")]
            public string Word { get; set; }
            [JsonProperty("reading")]
            public string Reading { get; set; }
        }

        public class Sens
        {
            [JsonProperty("english_definitions")]
            public List<string> EnglishDefinitions { get; set; }
            [JsonProperty("parts_of_speech")]
            public List<string> PartsOfSpeech { get; set; }
            [JsonProperty("tags")]
            public List<string> Tags { get; set; }
            [JsonProperty("restrictions")]
            public List<string> Restrictions { get; set; }
            [JsonProperty("see_also")]
            public List<string> ExtraData { get; set; }
            [JsonProperty("antonyms")]
            public List<string> Antonyms { get; set; }
        }
    }
}
