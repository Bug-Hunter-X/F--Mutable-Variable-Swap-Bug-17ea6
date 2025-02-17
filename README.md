# F# Mutable Variable Swap Bug

This repository demonstrates a common error when working with mutable variables and references in F#.  The core issue involves misunderstanding how F# handles variables passed to functions.  The `bug.fs` file showcases incorrect and correct ways to swap the values of two mutable variables.

## How to Reproduce

1. Clone the repository.
2. Open `bug.fs` in a F# environment.
3. Run the code. Observe the unexpected output in the first `swap` function, versus the correct output in `swap2` which uses references.  The `swap3` function demonstrates passing by value, which again fails to swap the variables.

## Solution

The `bugSolution.fs` file provides the corrected implementation using references (`byref`) to achieve the desired variable swapping behavior. This ensures that the function modifies the original variables, not just copies.