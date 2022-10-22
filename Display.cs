class Display {
    WordBank wordBank = new WordBank();

    // method to display the word as underscores and each letter as it's guessed
    // takes length (of the word) as a parameter
    public void displayWord(string word, string letter) {
        int wordLength = wordBank.getLength(word);
        int dash = wordLength;
        // string space = " ";
        char[] guess = new char[word.Length];
        
        Console.WriteLine(word); // for seeing the word for testing purposes


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
    public void createParachuteGuy(int updateLives) {
        // create parachute dictionary with its elements
        Dictionary<string, string> parachute = new Dictionary<string, string>(4);

        parachute.Add("line1",  "  ___  ");
        parachute.Add("line2", @" /___\ ");
        parachute.Add("line3", @" \   / ");
        parachute.Add("line4", @"  \ /  ");    

        // create guy dictionary with its elements
        Dictionary<string, string> guy = new Dictionary<string, string>(4);

        guy.Add("line5",  "   o   ");
        guy.Add("line6", @"  /|\  ");
        guy.Add("line7", @"  / \  ");
        guy.Add("line8",  "^^^^^^^");


        // change the parachute image according to how many lives left
        if (updateLives == 8) {
            // don't change the image
        } else if (updateLives == 7) {
            parachute.Remove("line1");
        } else if (updateLives == 6) {
            parachute.Remove("line2");
            parachute.Add("line2", @" /   \ " );
            // parachute["line2"] = @" /   \ ";
        } else if (updateLives == 5) {
            parachute["line2"] = @"     \ ";
        } else if (updateLives == 4) {
            parachute.Remove("line2");
        } else if (updateLives == 3) {
            parachute["line3"] = @"     / ";
        } else if (updateLives == 2) {
            parachute.Remove("line3");
        } else if (updateLives == 1) {
            parachute["line4"] = @"    /  ";
        } else {
            parachute.Remove("line4");
            gameOver();
        } 


        // display the parachute
        foreach (KeyValuePair<string, string> line in parachute) {
            Console.WriteLine(line.Value);
        }

        // display the guy
        foreach (KeyValuePair<string, string> line in guy) {
            Console.WriteLine(line.Value);
        }
    }


    // game over message if no lives left
    public void gameOver() {
        Console.WriteLine("You died! Game over.");
    }

    // // update the visual (for when a parachute line has been cut)
    // public void updateImage() {
    //     Compare compare = new Compare();



    //     // display the parachute
    //     foreach (KeyValuePair<string, string> line in parachute) {
    //         Console.WriteLine(line.Value);
    //     }

    //     // display the guy
    //     foreach (KeyValuePair<string, string> line in guy) {
    //         Console.WriteLine(line.Value);
    //     }
    // }


    // note to self: 
    // all that's left to do is display the word/letters the right way
    // and update the parachute according to incorrect guesses
}