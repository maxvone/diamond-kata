## Diamond Kata: Approach and Design

This solution implements the Diamond Kata problem using a test-driven development (TDD) approach in C#.

## 1. Development Process (TDD)

The process started with the tests in ```DiamondBuilderTests.cs```.

1. **Simplest Case First**: I created a test for the simplest input, A. This forced the creation of the Diamond.Buildmethod and the logic to handle the base case.
2. **Incrementing Complexity**: The next test for C drove the core logic. It required calculating the diamond's total width, generating rows with correct internal spacing, and centering each row.
3. **Refactoring**: As the logic for C was built, the code was refactored into smaller, private helper methods (GenerateRow, CenterText) to improve clarity and adhere to the Single Responsibility Principle.
4. **Symmetry**: The logic was designed to build the top half of the diamond (including the middle row) and then mirror it to create the bottom half. This avoids code duplication and simplifies the main loop.
5. **Edge Cases and Boundaries**: Finally, tests for invalid inputs (lowercase, numbers, symbols) were added to ensure the program behaves predictably and robustly by throwing an ArgumentException. Tests for E and the maximum-boundary case, Z, were also included to verify the logic scales correctly.

## 2. Code Design and Trade-offs

- **Static Class**: The Diamond class is static because it represents a pure function. It takes an input, produces an output, and holds no internal state. This is the simplest design that fits the requirements.
- **Readability vs. Performance (Memory Allocation)**: The current solution intentionally prioritizes clarity over raw performance. It uses multiple List<string> objects and creates many intermediate strings, which are then combined with string.Join. This makes the logic very easy to follow.
	- *The Alternative (StringBuilder)*: A more memory-efficient approach would use a single StringBuilder instance. One could loop from 'A' to the target letter and back down to 'A', appending each row and newline character directly to the builder. This would significantly reduce memory allocations by avoiding the creation of intermediate string objects and lists.
	- *The Trade-off*: For a small-scale problem like this kata, the performance gain from StringBuilder is negligible, and the clarity of the list-based manipulation is preferable. However, in a performance-critical system or if generating extremely large patterns, the StringBuilder approach would be the superior choice.

- **Error Handling**: Throwing an ArgumentException is standard practice for invalid method parameters, providing clear feedback to the caller about misuse.
