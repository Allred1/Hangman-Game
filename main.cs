
class Jumper {
    static void Main(string[] args) {
        // instantiating classes
        var WordBank = new WordBank(); 
        var Compare = new Compare();
        var Player = new Player();
        var Display = new Display();


        Console.Write("Play game? [y/n]: ");
        string answer = Console.ReadLine() ?? "";

        // play game while user says "y" (yes)
        while (answer == "y") {
            string word = WordBank.DrawRandomWord();
            // start out with 8 lives
            int lives = 8; 
            
            // continue game until win or run out of lives
            while (lives != 0) {
                Console.WriteLine(word); // temporarily see the word (for testing purposes)
                // get the player's letter guess
                string letter = Player.guessLetter();
                // check if it's in the random word
                bool letterInWord = Compare.letterInWord(word, letter);
                // deal with the following conditions 
                Console.WriteLine(Compare.correctOrIncorrect(letterInWord, letter));



            }
        }
    }
}

