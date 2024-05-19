namespace prove_03;

 /*
 * CSE212
 * (c) BYU-Idaho
 * 03-Prove - Problem 1
 *
* It is a violation of BYU-Idaho Honor Code to post or share this code
* with others or to post it online. Storage into a personal and private
 * repository (e.g. private GitHub repository, unshared Google Drive
 * folder) is acceptable.
 */
 public static class MysteryStack1 {
    public static string Run(string text) {
        var stack = new Stack<char>();
        /* Make a new variable that contains the characters of the string */
        foreach (var letter in text)
        /* Iterate through each letter in the string */
            stack.Push(letter);
            /* add the newest character in the string to the list */

        var result = "";
        /* Make a new variable with blank string inside */
        while (stack.Count > 0)
        /* While the stack has something in it */
            result += stack.Pop();
            /* Remove the last letter and add it to the variable */

 return result;
 }
 }


 