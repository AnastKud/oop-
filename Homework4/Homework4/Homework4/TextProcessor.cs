using System.Text.RegularExpressions;

namespace TextProcessingApp
{
    public class TextProcessor
    {
        /// <summary>
        /// The text to be processed.
        /// </summary>
        private string _text;
        public TextProcessor(string text)
        {
            _text = text;
        }
        /// <summary>
        /// Processes text: breaks it into sentences, sorts words in each sentence alphabetically.
        /// </summary>
        public void ProcessText()
        {
            var sentences = Regex.Split(_text, @"(?<=[.!?])\s+");
            foreach (var sentence in sentences)
            {
                if (!ContainsDate(sentence))
                {
                    var sortedWords = string.Join(" ", sentence.Split(' ').OrderBy(word => word));
                    Console.WriteLine(sortedWords);
                }
            }
        }

        /// <summary>
        /// Checks if a sentence contains a date
        /// </summary>
        private bool ContainsDate(string sentence)
        {
            return Regex.IsMatch(sentence, @"\b\d{1,2}[./]\d{1,2}[./]\d{2,4}\b");
        }
    }
}