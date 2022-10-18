// Class Player

class Player {

    public string guessLetter() {
        Console.Write("Guess a letter: ");
        string letter = Console.ReadLine() ?? "";
        return letter;
    }
}