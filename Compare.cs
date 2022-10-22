class Compare {


    Player player = new Player(); 
    WordBank wordBank = new WordBank();
    Display display = new Display();



    // check if guessed letter is in word
    // Takes 2 parameters: word & letter
    public bool letterInWord(string word, string letter) {
        return word.Contains(letter);          
    }

    // take action depeding on whether there was a letter in the word or not
    // Has 4 parameters: bool answer (after determining "letterInWord"), the letter, the actual random word, and the number of lives. 
    public string correctOrIncorrect(bool letterInWord, string letter, string word, int updateLives) {
        // call the display word method here
        display.displayWord(word, letter);
                
        if (letterInWord == true) {
            display.createParachuteGuy(updateLives);
            // make the letter appear over its underscore
            return letter;
        } 
        else {
            updateLives = player.loseLife(updateLives);
            display.createParachuteGuy(updateLives);
            // call the update the parachute visual
            return updateLives + "Try again!";
        } 
        
    }    
}