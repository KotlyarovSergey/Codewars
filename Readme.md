## My Solutions ##

[001 7kyu "Did she say hallo?"](#001-did-she-say-hallo-7kyu)

[002 6kyu "Stop gninnipS My sdroW!"](#002-6kyu-stop-gninnips-my-sdrow)

[003 6kyu "Bit Counting"](#003-6kyu-bit-counting)

[004 7kyu "List Filtering"](#004-7kyu-list-filtering)

[005 6kyu "Chaser's schedule"](#005-6kyu-chasers-schedule)

[006 7kyu "Alphabet war"](#006-7kyu-alphabet-war)

[007 7kyu "Another card game"](#007-7kyu-another-card-game)

[008 5kyu "Don't Drink the Water"](#008-5kyu-dont-drink-the-water)

[009 5kyu "Land perimeter"](#009-5kyu-land-perimeter)

[010 5kyu "Digits"](#010-5kyu-digits)

[011 4kyu "The observed PIN"](#011-4kyu-the-observed-pin)

[012 4kyu "Strings Mix"](#012-4kyu-strings-mix)

[013 4kyu "So Many Permutations!"](#013-4kyu-so-many-permutations)



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
[ _link on codewars_ ](https://www.codewars.com/kata/628df6b29070907ecb3c2d83)

A runner, who runs with base speed s with duration t will cover a distances d: d = s * t

However, this runner can sprint for one unit of time with double speed s * 2

After sprinting, base speed s will permanently reduced by 1, and for next one unit of time runner will enter recovery phase and can't sprint again.

Your task, given base speed s and time t, is to find the maximum possible distance d.

Input:

1 <= s < 1000

1 <= t < 1000

[home](#my-solutions)

---

## 006 7kyu "Alphabet war" ##

*Introduction:* 
There is a war and nobody knows - the alphabet war!
There are two groups of hostile letters. The tension between left side letters and right side letters was too high and the war began.

**Task:**
Write a function that accepts fight string consists of only small letters and return who wins the fight. When the left side wins return Left side wins!, when the right side wins return Right side wins!, in other case return Let's fight again!.

The left side letters and their power:
 * w - 4
 * p - 3
 * b - 2
 * s - 1

The right side letters and their power:
* m - 4
* q - 3
* d - 2
* z - 1



[home](#my-solutions)

---

## 007 7kyu "Another card game" ##
[ _link on codewars_ ](https://www.codewars.com/kata/633874ed198a4c00286aa39d)

Twelve cards with grades from 0 to 11 randomly divided among 3 players: Frank, Sam, and Tom, 4 cards each. The game consists of 4 rounds. The goal of the round is to move by the card with the most points.
In round 1, the first player who has a card with 0 points, takes the first turn, and he starts with that card. Then the second player (queue - Frank -> Sam -> Tom -> Frank, etc.) can move with any of his cards (each card is used only once per game, and there are no rules that require players to make only the best moves). The third player makes his move after the second player, and he sees the previous moves.
The winner of the previous round then makes the first move in the next round with any remaining card.
The player who wins 2 rounds first, wins the game.

**Task:** 
Return true if Frank has a chance of winning the game.
Return false if Frank has no chance.

*Input:*
3 arrays of 4 unique numbers in each (numbers in array are sorted in ascending order). Input is always valid, no need to check.

[home](#my-solutions)

---

## 008 5kyu "Don't Drink the Water" ##

[( _link on codewars_ )](https://www.codewars.com/kata/562e6df5cf2d3908ad00019e)


Given a two-dimensional array representation of a glass of mixed liquids, sort the array such that the liquids appear in the glass based on their density. (Lower density floats to the top) The width of the glass will not change from top to bottom.

Density Chart
- Honey    'H'  1.36 
- Water    'W'  1.00 
- Alcohol  'A'  0.87 
- Oil      'O'  0.80  


{                             {
  { 'H', 'H', 'W', 'O' },        { 'O','O','O','O' },  
  { 'W', 'W', 'O', 'W' },  =>    { 'W','W','W','W' },  
  { 'H', 'H', 'O', 'O' }         { 'H','H','H','H' }  
}                             }

The glass representation may be larger or smaller. If a liquid doesn't fill a row, it floats to the top and to the left.

[home](#my-solutions)

---

## 009 5kyu "Land perimeter" ##  
[( _link on codewars_ )](https://www.codewars.com/kata/5839c48f0cf94640a20001d3)

Given an array arr of strings, complete the function by calculating the total perimeter of all the islands. Each piece of land will be marked with 'X' while the water fields are represented as 'O'. Consider each tile being a perfect 1 x 1 piece of land. Some examples for better visualization:
['XOOXO',  
 'XOOXO',  
 'OOOXO',  
 'XXOXO',  
 'OXOOO']   
 should return: "Total land perimeter: 24".

[home](#my-solutions)

---


## 010 5kyu "Digits" ##  
[( _link on codewars_ )](https://www.codewars.com/kata/638b042bf418c453377f28ad)

The code consists of four unique digits (from 0 to 9).
Tests will call your solution; you should answer with an array of four digits.
Your input is number of matches (the same digit in the same place) with your previous answer. For the first call input value is -1 (i.e. each new test starts with input -1)
You have to find the code in 16 calls or less. You are the best. Do it.
For example

The code is {1, 2, 3, 4}
1st call return new [] {1, 3, 4, 5} will give 1 match in next input
2nd call return new [] {1, 2, 3, 0} will give 3 matches in next input
3rd call return new [] {1, 2, 3, 4} will not give 4 matches in next input, because you're the champion!


[home](#my-solutions)

---

## 011 4kyu "The observed PIN" ##  
[( _link on codewars_ )](https://www.codewars.com/kata/5263c6999e0f40dee200059d/csharp)

Alright, detective, one of our colleagues successfully observed our target person, Robby the robber. We followed him to a secret warehouse, where we assume to find all the stolen stuff. The door to this warehouse is secured by an electronic combination lock. Unfortunately our spy isn't sure about the PIN he saw, when Robby entered it.

The keypad has the following layout:

1 2 3  
4 5 6  
7 8 9   
&ensp; 0  

He noted the PIN 1357, but he also said, it is possible that each of the digits he saw could actually be another adjacent digit (horizontally or vertically, but not diagonally). E.g. instead of the 1 it could also be the 2 or 4. And instead of the 5 it could also be the 2, 4, 6 or 8.

He also mentioned, he knows this kind of locks. You can enter an unlimited amount of wrong PINs, they never finally lock the system or sound the alarm. That's why we can try out all possible (*) variations.

* possible in sense of: the observed PIN itself and all variations considering the adjacent digits

Can you help us to find all those variations? It would be nice to have a function, that returns an array (or a list in Java/Kotlin and C#) of all variations for an observed PIN with a length of 1 to 8 digits. We could name the function getPINs (get_pins in python, GetPINs in C#). But please note that all PINs, the observed one and also the results, must be strings, because of potentially leading '0's. We already prepared some test cases for you.


[home](#my-solutions)

---



## 012 4kyu "Strings Mix" ##  
[( _link on codewars_ )](https://www.codewars.com/kata/5629db57620258aa9d000014)

Given two strings s1 and s2, we want to visualize how different the two strings are. We will only take into account the *lowercase* letters (a to z). First let us count the frequency of each *lowercase* letters in s1 and s2.

> s1 = "A aaaa bb c"

> s2 = "& aaa bbb c d"

> s1 has 4 'a', 2 'b', 1 'c'

> s2 has 3 'a', 3 'b', 1 'c', 1 'd'

So the maximum for 'a' in s1 and s2 is 4 from s1; the maximum for 'b' is 3 from s2. In the following we will not consider letters when the maximum of their occurrences is less than or equal to 1.

We can resume the differences between s1 and s2 in the following string: __"1:aaaa/2:bbb"__ where __1__ in __1:aaaa__ stands for string s1 and __aaaa__ because the maximum for __a__ is 4. In the same manner __2:bbb__ stands for string s2 and ___bbb___ because the maximum for __b__ is 3.

The task is to produce a string in which each *lowercase* letters of s1 or s2 appears as many times as its maximum if this maximum is *strictly greater than 1*; these letters will be prefixed by the number of the string where they appear with their maximum value and __:__. If the maximum is in s1 as well as in s2 the prefix is __=:__.

In the result, substrings (a substring is for example 2:nnnnn or 1:hhh; it contains the prefix) will be in decreasing order of their length and when they have the same length sorted in ascending lexicographic order (letters and digits - more precisely sorted by codepoint); the different groups will be separated by '/'. See examples and "Example Tests".

Hopefully other examples can make this clearer.

  > s1 = "my&friend&Paul has heavy hats! &"  
  s2 = "my friend John has many many friends &"   
  mix(s1, s2) --> "2:nnnnn/1:aaaa/1:hhh/2:mmm/2:yyy/2:dd/2:ff/2:ii/2:rr/=:ee/=:ss"

  > s1 = "mmmmm m nnnnn y&friend&Paul has heavy hats! &"   
  s2 = "my frie n d Joh n has ma n y ma n y frie n ds n&"   
  mix(s1, s2) --> "1:mmmmmm/=:nnnnnn/1:aaaa/1:hhh/2:yyy/2:dd/2:ff/2:ii/2:rr/=:ee/=:ss"   

  > s1="Are the kids at home? aaaaa fffff"   
  s2="Yes they are here! aaaaa fffff"   
  mix(s1, s2) --> "=:aaaaaa/2:eeeee/=:fffff/1:tt/2:rr/=:hh"   

[home](#my-solutions)

---



## 013 4kyu "So Many Permutations!" ##  
[( _link on codewars_ )](https://www.codewars.com/kata/5254ca2719453dcc0b00027d/csharp)

In this kata, your task is to create all permutations of a non-empty input string and remove duplicates, if present.

Create as many "shufflings" as you can!

Examples:

  With input 'a':
  Your function should return: ['a']

  With input 'ab':
  Your function should return ['ab', 'ba']

  With input 'abc':
  Your function should return ['abc','acb','bac','bca','cab','cba']

  With input 'aabb':
  Your function should return ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']

Note: The order of the permutations doesn't matter.

Good luck!


[home](#my-solutions)

---