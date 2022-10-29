class Player {

    
    // user guesses a letter, returns letter
    public string guessLetter() {
        Console.Write("Guess a letter [a-z]: ");
        string letter = Console.ReadLine();
        // char letter = char.Parse(Console.ReadLine());
        return letter;
    }


    // subtract a life when called
    public int loseLife(int lives) {
        return lives -= 1;
    }
}
