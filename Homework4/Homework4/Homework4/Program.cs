using TextProcessingApp;

class Program
{
    /// <summary>
    /// Main method to run the text processing application.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Please enter your text. Type exit to finish: ");
        string inputText = "";
        string userInput;
        while ((userInput = Console.ReadLine()) != "exit")
        {
            inputText += userInput + " ";
        }
        TextProcessor processor = new TextProcessor(inputText.Trim());
        Console.WriteLine("\nProcessed Sentences:");
        processor.ProcessText();
    }
}
