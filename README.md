# CapMon Assignment

## Background

During my job interview with [CapMon](https://capmon.dk/) as software developer, I was tasked with solving a small programming assignment. I was provided with a whiteboard to write down my solution. I was able to write some sudo-code on the board and communicate my thought process to the interviewers about my general ideas and approach on how I would solve the problem, but I didn't take a picture of my solution to show (sorry!). 

After the interview, I didn't feel like I did well during the test (this was my first time doing a live "Alright, look through this paper and show us how you would solve it"), so I asked if I could keep the assignment paper, with the objective of trying to give it another go at home, and with more precise and actual code.

I would note though, that though I didn't feel like I performed during the test, the feedback I got was that while I did not solve (all) the problems, they where very satisfied with my communication and on-the-spot-problem-solving skills, so I was invited back for the second round of interviews (to be held in late august 2020).

Because of the few notes I managed to scribble on the papar, I've writen the assignment details in the next section.

## The Assignment
- 1

Input: A string is given with some special fields, that must be expanded. E.g

```javascript
"http://www.someserver.com/doc=[1..200]/text.html"
```

This must be translated into an array of strings:

```javascript
[
  "http://www.someserver.com/doc=1/text.html",
  "http://www.someserver.com/doc=2/text.html",
  ...
  "http://www.someserver.com/doc=[200]/text.html"
]
```

In the format, '[' and ']' are characters reserved for field separators. Write in your language of choice a program that takes a single string as input and returns an array. 
E.g. if it was in JavaScript, fill in the ellipsis ("...") in this function:

```javascript
function expandedSequences(uri){
let list = [];
...
return list;
}
```

- 2 

If not implemented already, expand it so there can be several of such fields for expansion. Also, if the first field has prefixed zeros, then the resulting field must also have prefixed zeros, if needed to keep a constant field widt. There may be prefixed zeros on the last field (after the '..'), but they are ignored. So this input:

```javascript
"http://www.someserver.com/doc=[1...200]/text[022..023].html"
```

Has this array as output

```javascript
[
"http://www.someserver.com/doc=09/text022.html",
"http://www.someserver.com/doc=09/text023.html",
"http://www.someserver.com/doc=10/text022.html",
"http://www.someserver.com/doc=10/text023.html"
]
```

- 3

Describe in words (no working example necessary) how one would expand this to cover {a..f} to iterate through *a,b,c,d,e,f* and (0;50;2) to go from 0 to 50 in increments of 2

## My Solution

I decided (both for the interview and this repo) to try and tackle the problem using C# and .NET, using the Visual Studio IDE. The project currently has a solution for the first part of the assignment.

When running the project, I've used the CTRL + F5 command to run the program without the debugger and preventing the console from closing, as soon as the project is done.
