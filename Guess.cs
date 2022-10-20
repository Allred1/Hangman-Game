// Class Guess

class Guess {
    Player player = new Player();
    WordBank wordBank = new WordBank();


    // see if the guessed letter was in the random word
    // if correct, print the letter
    // if incorrect, print "Try again!"
    public string correctLetter() {
        string word = wordBank.DrawRandomWord();
        int length = wordBank.wordLength(word);
        string letter = player.guessLetter();
        
        Console.WriteLine(length);

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