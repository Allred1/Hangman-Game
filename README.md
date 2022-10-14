# cse210-03
 Jumper Specification

- (object) secret word (string) 
    [the word the player is guessing]
    - chosen from List of random words

- (object) Player (string)
    [guesses a letter]

- (object) Guess (boolean) 
    [determine if correct or incorrect]
    - correct = letter is revealed
    - incorrect = a parachute line is cut

- (object) parachute
    [determines how many lives left until game is over]
    - guess true = don't cut
    - guess false = cut
    - if all cut = game over

- solved
    [keeps program playing until game over]
    - true = game over
    - false = keep playing
