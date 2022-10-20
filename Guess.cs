// Class Guess

class Guess {
    var Player = new Player();
    var WordBank = new WordBank();
    
    
    public bool correctLetter() {
        // bool correct = false;
        string letter = Player.guessletter();
        string word = WordBank.DrawRandomWord();

        // is the letter in the word?
        bool answer = word.Contains(letter);
        Console.WriteLine(answer);

        // take Player's letter guess
        // take WordBank's random word
        // compare if the guessletter is in the randomword
            // if true: display the letter
            // if false: parachute line is cute


        // if (!correct) {
        //     Console.WriteLine(Player.guessLetter());
        // } 
        // else {
        //     Console.WriteLine(" ");
        // }
        
    }
}