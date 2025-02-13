# Mutable Reference Behavior in F#

This example demonstrates unexpected behavior that can arise when using mutable references in F#.  If you're unfamiliar with how mutable references work in F#, the behavior of the provided code might seem counterintuitive.

## Bug Report
The code snippet uses a mutable variable `x` and then assigns its reference to `y`. Modifying the value referenced by `y` directly affects the original variable `x`. This behavior is inherent to how mutable references are handled in F#. 

## How to Reproduce
1. Compile and run the code in `bug.fs`
2. Observe that the output is 20, despite the initial value of `x` being 10.