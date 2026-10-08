# Pure Danish Greeter, writing the tests

Another developer has written the production code for the specification at https://gist.github.com/joserbala/99149710c109d12efb018013b5b1e0fa, and it's now your job to implement the tests of this system based on the requirement analysis that we have done (see below). Please, solve any errors you find during testing.

## Equivalence classes

EC1: time ∈ [6, 9) => greeting = "Godmorgen, `name`!"

EC2: time ∈ [9, 12) => greeting = "God formiddag, `name`!"

EC3: time ∈ [12, 18) => greeting = "God eftermiddag, `name`!"

EC4: time ∈ [18, 24) => greeting = "God aften, `name`!"

EC5: time ∈ [0, 6) => greeting = "Godnat, `name`!"

EC6: time ∈ (-inf, 0) => Error

EC7: time ∈ [24, inf) => Error

## Boundary-value analysis

- Between EC1 and EC2:

    ```
    ----- 8 | 9 -----
    ```

    From EC1 on-point = 8, off-point = 9

    From EC2 on-point = 9, off-point = 8


- Between EC2 and EC3:

    ```
    ----- 11 | 12 -----
    ```

    From EC2 on-point = 11, off-point = 12

    From EC3 on-point = 12, off-point = 11


- Between EC3 and EC4:

    ```
    ----- 17 | 18 -----
    ```

    From EC3 on-point = 17, off-point = 18

    From EC4 on-point = 18, off-point = 17


- Between EC4 and EC7:

    ```
    ----- 23 | 24 -----
    ```

    From EC4 on-point = 23, off-point = 24

    From EC6 on-point = 24, off-point = 23


- Between EC5 and EC1:

    ```
    ----- 5 | 6 -----
    ```

    From EC5 on-point = 5, off-point = 6
    
    From EC1 on-point = 6, off-point = 5


- Between EC6 and EC5:
    ```
    ----- -1 | 0 -----
    ```

    From EC6 on-point = -1, off-point = 0

    From EC5 on-point = 0, off-point = -1