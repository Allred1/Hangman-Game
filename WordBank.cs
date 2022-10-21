class WordBank {

    // word bank
    List<string> words = new List<string> {"Mordor", "Rohan", "Gondor", "Gandalf", "Frodo", "Aragorn", "Legolas", "Gimli", "Castle", "Ringwraith", "Theoden", "Eomer"};
    
    // random generator
    Random generator = new Random();


    // draw a random word from the word bank
    public string DrawRandomWord() {
        int randomIndex = generator.Next(words.Count);
        string randomWord = words[randomIndex];
        words.RemoveAt(randomIndex);
        return randomWord;
    }    

    // returns the length of the random word (when passed through the parameter)
    public int getLength(string randomWord) {
        int length = randomWord.Length;
        return length;
    }
}