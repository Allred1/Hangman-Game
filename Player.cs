class Player {

    int lives = 8;

    // user guesses a letter, returns letter
    public string guessLetter() {
        Console.Write("Guess a letter: ");
        string letter = Console.ReadLine() ?? "";
        return letter;
    }


    // subtract a life when called
    public int loseLife(int lives) {
        return lives -= 1;
    }
}
//testing