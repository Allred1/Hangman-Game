// - (object) secret word (string) 
//   [the word the player is guessing]
//      - chosen from List of random words

class WordBank {
    // create a list of words
    List<string> words = new List<string> {"Mordor", "Rohan", "Gondor", "Gandalf", "Frodo", "Aragorn", "Legolas", "Gimli", "Castle", "Ringwraith", "Theoden", "Eomer"};

    Random generator = new Random();
    

    public string DrawRandomWord() {
        int randomIndex = generator.Next(words.Count);
        string randomWord = words[randomIndex];
        words.RemoveAt(randomIndex);
        return randomWord;
    }    
}