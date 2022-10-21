class Display {
    WordBank wordBank = new WordBank();

    // method to display the word as underscores and each letter as it's guessed
    // takes length (of the word) as a parameter
    public void displayWord(string word, string letter) {
        int wordLength = wordBank.getLength(word);
        int dash = wordLength;
        string space = " ";
        char[] guess = new char[word.Length];
        
        // Console.WriteLine(word);


        // for (int p = 0; p < word.Length; p++) {
        //     guess[p] = '*';

        // }



        // foreach (char c in word) {
            // if (letter in word) {
            //     Console.WriteLine($"{c}", c.ToString());
            // } else if ((c in word) == " ") {
            //     Console.WriteLine($"{space}", space.ToString());
            // } else {
            //     Console.WriteLine("_".ToString());
            //     dash -= 1;
            // }
        }
    
        // return null;


    // method to display the parachuting man
    public string displayParachuteGuy() {
        return null;
    }
}