using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Core.Models
{
    public class RetrievedDictionaryModel
    {
        // Nested classes to encapsulate the structure.  Each successful API
        // call is to return an array of Datums containing all of the useful
        // information.
        public class DictionaryEntry
        {
            public Datum[] Entries { get; set; }
        }

        public class Datum
        {
            // slug is global unique identifier.
            public string slug { get; set; }

            // is_common bool if a word is common.
            public bool is_common { get; set; }

            // array of tags like: Noun, I-Adjective, Verb, Suru-verb
            // appropriate for specific word.
            public string[] tags { get; set; }

            // associated JLPT-level of the word if there's one.
            public string[] jlpt { get; set; }

            // Array of 'Japanese' as each dictionary entry can have multiple
            // readings or alternative used words.
            public Japanese[] japanese { get; set; }

            // Array of sens that contain English definitions, tags, and various
            // meta data surrounding word.
            public Sens[] senses { get; set; }

        }

        public class Japanese
        {
            public string word { get; set; }
            public string reading { get; set; }
        }

        public class Sens
        {
            public string[] english_definitions { get; set; }
            public string[] parts_of_speech { get; set; }
            public string[] tags { get; set; }
            public string[] restrictions { get; set; }
            public string[] see_also { get; set; }
            public string[] antonyms { get; set; }
        }
    }
}
