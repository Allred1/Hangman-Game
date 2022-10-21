class Compare {


    Player player = new Player(); 
    WordBank wordBank = new WordBank();



    // check if guessed letter is in word
    // Takes 2 parameters: word & letter
    public string letterInWord(string word, string letter) {
        bool answer = word.Contains(letter);

        if (answer == true) {
            string message = letter;
            return message;
        } else {
            string message = "Try again!";
            return message;
        }   
    }    
}