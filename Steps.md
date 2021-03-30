# repro steps
1. add refs to "real" in "test" project
1. add method params in test class. the first one is the input and the second one is the output to check with
1. write the body of the function to check the logic we'd like to cover. the test now fails as it won't compile (missing MyProgram)
1. make the program compiles but still failing
1. create the business logic covered by the test case (adds methods, classes and so on)
1. run the tests to check if now are successfull

# notes
- now the ComputeScore will sum up all of the values by not take care of spare/strike that double the value to sum of next rolls.
