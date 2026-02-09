# Liskov Substitution Principle (LSP)

## What is the Liskov Substitution Principle?
The **Liskov Substitution Principle (LSP)** is one of the five SOLID principles of **Object-Oriented Programming (OOP)**.

It states that:
> **Objects of a derived class should be able to replace objects of the base class without affecting the correctness of the program.**

This means a subclass must behave in a way that does not break the expectations of the base class.

---

## Why LSP is Important
- **Ensures Reliability**: Subclasses work correctly wherever the base class is used.  
- **Improves Reusability**: Base class code can be reused safely with derived classes.  
- **Supports Polymorphism**: Enables proper use of inheritance and method overriding.  
- **Reduces Bugs**: Prevents unexpected behavior when substituting objects.  
- **Enhances Design Quality**: Encourages well-structured class hierarchies.

---

## How LSP Works
- A derived class must follow the behavior and rules of the base class.  
- It should not remove or change expected functionality.  
- It can extend behavior but should not break existing logic.  
- Methods in subclasses should accept the same inputs and return expected results.

Example:
If a base class `Bird` has a method `Fly()`:

Bad design:
- Creating a subclass `Penguin` that cannot fly but inherits `Fly()`  
- This breaks expectations and violates LSP.

Good design:
- Create a base class `Bird`  
- Create a separate interface or class `FlyingBird` for birds that can fly  
- Penguin inherits only what applies to it  
- Flying birds implement flying behavior correctly  

Now any class can replace its base type without breaking the system.

---

## Key Points
- Subclasses must be fully compatible with base classes.  
- Do not override behavior in a way that breaks expected functionality.  
- Strengthens proper use of **inheritance and polymorphism**.  
- Helps maintain **consistent and predictable code behavior**.  
- Essential for building robust and scalable OOP systems.
