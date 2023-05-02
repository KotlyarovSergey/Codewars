## My Solutions ##

[001 7kyu "Did she say hallo?"](#001-did-she-say-hallo-7kyu)

[002 6kyu "Stop gninnipS My sdroW!"](#002-6kyu-stop-gninnips-my-sdrow)

[003 6kyu "Bit Counting"](#003-6kyu-bit-counting)

[004 7kyu "List Filtering"](#004-7kyu-list-filtering)

[005 6kyu "Chaser's schedule"](#005-6kyu-chasers-schedule)







------
## 001 Did she say hallo? 7kyu ##
You received a whatsup message from an unknown number. Could it be from that girl/boy with a foreign accent you met yesterday evening?
Write a simple function to check if the string contains the word hallo in different languages.
These are the languages of the possible people you met the night before:
* hello - english
* ciao - italian
* salut - french
* hallo - german
* hola - spanish
* ahoj - czech republic
* czesc - polish

Notes:
* you can assume the input is a string.
* to keep this a beginner exercise you don't need to check if the greeting is a subset of word (Hallowen can pass the test)
* function should be case insensitive to pass the tests

[home](#my-solutions)

---


## 002 6kyu "Stop gninnipS My sdroW!" ##

Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

Examples:
* spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
* spinWords( "This is a test") => returns "This is a test" 
* spinWords( "This is another test" )=> returns "This is rehtona test"

[home](#my-solutions)

---


## 003 6kyu "Bit Counting" ##

Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. You can guarantee that input is non-negative.

_Example_ : The binary representation of 1234 is 10011010010, so the function should return 5 in this case

[home](#my-solutions)

---


## 004 7kyu "List Filtering" ##

In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

Example:

ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}

ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}

ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}

[home](#my-solutions)

---
## 005 6kyu "Chaser's schedule" ##

A runner, who runs with base speed s with duration t will cover a distances d: d = s * t

However, this runner can sprint for one unit of time with double speed s * 2

After sprinting, base speed s will permanently reduced by 1, and for next one unit of time runner will enter recovery phase and can't sprint again.

Your task, given base speed s and time t, is to find the maximum possible distance d.

Input:

1 <= s < 1000

1 <= t < 1000

[home](#my-solutions)

---
