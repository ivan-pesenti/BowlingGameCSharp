# repro steps
1. add test case to check bonus
1. create a Bonus class
1. renamed HasElements() to HasRolls()
1. changed Bonus() to return the newly created class. now the Bonus() will take the number of rolls take in as param and return their sum
1. changed Add() methods of Score class to be more consistent. Now score is incremented by: otherScore, a second roll or a bonus.
1. changed ComputeScore() by switch the implementation of Bonus method on Score class