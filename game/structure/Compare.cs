class Compare {


    Player player = new Player(); 
    WordBank wordBank = new WordBank();
    Display display = new Display();

    // check if guessed letter is in word
    // Takes 2 parameters: word & letter
    public bool letterInWord(string word, string letter) {
        return word.Contains(letter);
    }          
}