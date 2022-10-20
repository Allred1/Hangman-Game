// Class Guess

class Guess {
    Player player = new Player();
    WordBank wordBank = new WordBank();


    public string correctLetter() {
        // take Player's letter guess
        // take WordBank's random word
        string letter = player.guessLetter();
        string word = wordBank.DrawRandomWord();

        // compare if the guessletter is in the randomword
        bool answer = word.Contains(letter);
    
        // if true: display the letter
        // if false: parachute line is cut
        string message;
        if (answer == true) {
            message = letter;
            return message;
        } else {
            message = "Try again!";
            return message;
        }        
    }
}