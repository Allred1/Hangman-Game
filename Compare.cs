class Compare {


    Player player = new Player(); 
    WordBank wordBank = new WordBank();



    // check if guessed letter is in word
    // Takes 2 parameters: word & letter
    public bool letterInWord(string word, string letter) {
        return word.Contains(letter);          
    }

    // take action depeding on whether there was a letter in the word or not
    // Has 2 parameters: bool answer (after determining "letterInWord") and the letter. 
    public string correctOrIncorrect(bool letterInWord, string letter) {
        if (letterInWord == true) {
            return letter;
        } 
        else {
            string message = "Try again!";
            return message;
        } 
    }    
}