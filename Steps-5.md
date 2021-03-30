# repro steps
1. add test cases for strike frames
1. change Bonus(). The strike doubles the next two rolls so we've to track the position to double the correct roll
1. change ComputeScore() to manage strike frame logic

# notes
- now we're checking if the FirstRoll value == 10 and if so, it will double the next two rolls