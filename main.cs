


class Jumper {
    static void Main(string[] args) {
        // instantiating classes
        var WordBank = new WordBank(); 
        // var Player = new Player();
        var Guess = new Guess();
        var Parachute = new Parachute();
        
        // Console.WriteLine(WordBank.DrawRandomWord());
        // Console.WriteLine(Player.guessLetter());


        // Console.WriteLine(Parachute.displayWord());
        
        // Console.WriteLine(Guess.correctLetter());

        Console.WriteLine(WordBank.DrawRandomWord());
        Console.WriteLine(WordBank.wordLength());

        


    }
}
