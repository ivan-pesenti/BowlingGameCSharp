# repro steps
1. add test case for spare
1. add class BowlingRolls with its constructor
1. add HasElements() & CanRoll()
1. add RollOne() and Bonus() which both return a Roll (thr former with Dequeue() and the latter with Peek())
1. change the ParseInput to return the newly created class
1. change the ComputeScore() to expect the new class as param

# notes
- now we set the max num of frames to be 10