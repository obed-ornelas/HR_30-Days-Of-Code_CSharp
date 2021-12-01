# Day 12: Inheritance

## Task

You are given two classes, Person and Student, where Person is the base class and Student is the derived class. Completed code for Person and a declaration for Student are provided for you in the editor. Observe that Student inherits all the properties of Person.

Complete the Student class by writing the following:

- A Student class constructor, which has 4 parameters:
    1. A string, *firstName*
    2. A string, *lastName*
    3. An integer, *idNumber*
    4. An integer array (or vector) of test scores, *scores*
- A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:

| Letter | Average |
|--------|---------|
| O | 90 <= a <= 100|
| E | 80 <= a < 90|
| A | 70 <= a < 80|
| P | 55 <= a < 70|
| D | 40 <= a < 55|
| T | a < 40|

## Input Format

The first line contains *firstName*, *lastName*, and *idNumber*, separated by a space. The second line contains the number of test scores. The third line of space-separated integers describes *scores.*

## Contraints

- 1 <= length of *firstName*, length of *lastName* <= 10
- length of *idNumber* = 7
- 0 <= *score* <= 100

## Sample Input

```
Heraldo Memelli 8135627
2
100 80
```

## Sample Output

```
Name: Memelli, Heraldo
ID: 8135627
Grade: O
```

# Installation

*TODO*

# Credits
[HackerRank](https://www.hackerrank.com/) 30 Days of Code - Challenge 12 