// - (object) secret word (string) 
//   [the word the player is guessing]
//      - chosen from List of random words

class WordBank {

    WordBank wordBank = new WordBank();

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

    // return the length of the word (int)
    public int wordLength() {
        string word = wordBank.DrawRandomWord();
        int length = word.Length;
        return length;
    }
    
}