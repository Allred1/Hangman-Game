// directs the program


class Director {

    // instantiating classes
    WordBank wordBank = new WordBank(); 
    Compare compare = new Compare();
    Player player = new Player();
    Display display = new Display();

     
    public void beginGame() {
        int lives = 8;
        bool gameOver = false;
        string letter = "";     
        int charactersLeft = 0;
        var lettersGuessed = new List<string>();

        // draw up a secret word  
        string word = wordBank.DrawRandomWord();
        // build the two images as dictionaries
        Dictionary<string, string> parachute = display.buildParachute();
        Dictionary<string, string> guy = display.buildGuy();
        

        while(gameOver == false) {
            // display word (and keep track of how many characters are left unguessed)
            charactersLeft = display.displayWord(word, lettersGuessed, charactersLeft);
            // display image 
            display.updateFigure(parachute, guy, lives);
            // if solved, player wins game, game ends
            if (charactersLeft ==  0) {
                Console.WriteLine($"Congratulations, you solved the puzzle! The word was {word}. ");
                gameOver = true;
                break;
            }
            // player guesses a letter
            letter = player.guessLetter();
            lettersGuessed.Add(letter);
            // see if letter is in word. Return true or false. 
            bool letterInWord = compare.letterInWord(word, letter);
            // if letter is not in word, deal with it
            if (letterInWord == false) {
                // cut a line in the parachute 
                lives = player.loseLife(lives);
            }
            // if no more lives, game is over
            if (lives == 0) {
                display.updateFigure(parachute, guy, lives);
                Console.WriteLine($"You died! The secret word was {word}. ");
                gameOver = true;
            }            
        }
    }
}
