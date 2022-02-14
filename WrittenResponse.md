# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

To provide a fun and entertaining game experience for the player. 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates that my program can take in a player guess and check it with a randomly generated word.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program receives a word from the user and then outputs a color-coded version of that word depending on the position of the characters.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<string> words = File.ReadAllLines("words.txt").ToList();
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
Random r = new Random();
int randomIndex = r.Next(0, words.Count);
string correctWord = words[randomIndex];
return correctWord;
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "words".

### 3b iv.

Describes what the data contained in the list represents in your program

The list represents all of the possible words to be guessed. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

Without a list, I would not be able to select a word to guess by generating a random index. Instead, I would need to write several if/else statements. This would be unmanageable. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static void DisplayInfo(string guess, string correctWord)
        {
            if (guess.Length != correctWord.Length)
            {
                throw new Exception ($"expected {guess} and {correctWord} to have the same length."); 
            }

            int pos = 0; 

            while (pos < correctWord.Length)
            {
                 char guessChar = guess[pos]; 
                 DisplayCharInfo(guessChar, pos, correctWord);
                 pos ++; 
            }

            return;
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
else
{
    DisplayInfo(guess, correctWord);
}
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a guess and the correct word to be guessed, displays the guess to the screen coloring each character based on its position and if it is in the correct word. This is the main function of my program. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Validate that the guess and correct word are the same length
2. If the lengths do not match, throw an exception
3. If they match, iterate through each character:
     - Use the DisplayCharInfo method to determine what color to print the character

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

DisplayInfo("writing", "angry")

Second call:

DisplayInfo("write", "angry")

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
Testing if the number of characters in player guess is not equal to 5. This will cause the body of the if statement to execute. 

Condition(s) tested by the second call:

Testing if the number of characters in player guess is equal to 5. This will skip the body of the if statement. 

### 3d iii.

Result of the first call:

The result of calling with number of characters not equal to 5 results in an exception being thrown. 

Result of the second call:

The result of calling with number of characters equal to 5 is to iterate and check character by character with the correct word. 
