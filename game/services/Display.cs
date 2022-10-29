class Display {
    WordBank wordBank = new WordBank();

    // display the word as underscore unless user guesses a right letter
    public int displayWord(string word, List<string> lettersGuessed, int charactersLeft) {
        charactersLeft = 0;
        foreach (var character in word) {
            var letter = character.ToString();

            if (lettersGuessed.Contains(letter)) {
                Console.Write(letter);
            }
            else {
                Console.Write("_");
                charactersLeft++;
            }
        }
        Console.WriteLine(string.Empty);
        return charactersLeft;
    }


    // build the dictionaries for parachute
    public Dictionary<string, string> buildParachute() {
        // create parachute dictionary with its elements
        Dictionary<string, string> parachute = new Dictionary<string, string>(4);

        parachute.Add("line1",  "  ___  ");
        parachute.Add("line2", @" /___\ ");
        parachute.Add("line3", @" \   / ");
        parachute.Add("line4", @"  \ /  "); 

        return parachute;
    }
    // build the dictionary for guy
    public Dictionary<string, string> buildGuy() {
        // create guy dictionary with its elements
        Dictionary<string, string> guy = new Dictionary<string, string>(4);

        guy.Add("line5",  "   o   ");
        guy.Add("line6", @"  /|\  ");
        guy.Add("line7", @"  / \  ");
        guy.Add("line8",  "^^^^^^^");

        return guy;
    }

    public void updateFigure(Dictionary<string, string> parachute, Dictionary<string, string> guy, int lives) {
        // change the parachute image according to how many lives left
        if (lives == 8) {
            // don't change the image
        } else if (lives == 7) {
            parachute.Remove("line1");
        } else if (lives == 6) {
            parachute["line2"] = @" /   \ ";
        } else if (lives == 5) {
            parachute["line2"] = @"     \ ";
        } else if (lives == 4) {
            parachute.Remove("line2");
        } else if (lives == 3) {
            parachute["line3"] = @"     / ";
        } else if (lives == 2) {
            parachute.Remove("line3");
        } else if (lives == 1) {
            parachute["line4"] = @"    /  ";
        } else {
            parachute.Remove("line4");
            guy["line5"] = "   x   ";
            // game over
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
}