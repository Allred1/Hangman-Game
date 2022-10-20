// - (object) secret word (string) 
//   [the word the player is guessing]
//      - chosen from List of random words

class WordBank {

    // WordBank wordBank = new WordBank();

    // create a list of words
    List<string> words = new List<string> {"Mordor", "Rohan", "Gondor", "Gandalf", "Frodo", "Aragorn", "Legolas", "Gimli", "Castle", "Ringwraith", "Theoden", "Eomer"};

    Random generator = new Random();
    

    // draw a random word from the word bank
    public string DrawRandomWord() {
        int randomIndex = generator.Next(words.Count);
        string randomWord = words[randomIndex];
        words.RemoveAt(randomIndex);
        return randomWord;
    }    


    // returns the length of the random word (when passed through the parameter)
    public int wordLength(string randomWord) {
        Console.WriteLine(randomWord);
        int length = randomWord.Length;
        return length;
    }
    
}