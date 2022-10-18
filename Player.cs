// Class Player

class Player {

    public string guessWord() {
        Console.Write("Guess a letter: ");
        string letter = Console.ReadLine() ?? "";
        return letter;
    }
}