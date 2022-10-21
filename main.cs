
class Jumper {
    static void Main(string[] args) {
        // instantiating classes
        var WordBank = new WordBank(); 
        var Compare = new Compare();
        var Player = new Player();


        Console.Write("Play game? [y/n]: ");
        string answer = Console.ReadLine();

        // play game while user says "y" (yes)
        while (answer == "y") {
            string word = WordBank.DrawRandomWord();
            // start out with 8 lives
            int lives = 8; 
            
            // continue game until win or run out of lives
            while (lives != 0) {
                string letter = Player.guessLetter();
                Compare.letterInWord(word, letter);



            }
        }
    }
}

