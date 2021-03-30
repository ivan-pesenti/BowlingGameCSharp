# repro steps
1. change return type of ParseInput method from List to Queue
1. change input type param of ComputeScore method from List to Queue
1. add default value on constructor of Score
1. add another constructor for Score Class which take in a Roll object
1. add "Add" method to Score class to sum the score with a roll passed in as param
1. add IsSpare method to Score class to check if it's spare or not
1. add "Add" method to Score class to sum up a score with another score take in as param

# notes
- now the ComputeScore() uses Queue instead of List.