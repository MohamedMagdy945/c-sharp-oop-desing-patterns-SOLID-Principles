# Inheritance in Object-Oriented Programming (OOP)

## What is Inheritance?
Inheritance represents an **is-a relationship** where a derived class extends or specializes a base class.  
The derived class inherits behavior and structure from its parent.

> "A subclass is a type of its superclass."

---

## Key Characteristics
- Strong coupling between classes
- Shared behavior through hierarchy
- Supports polymorphism
- Compile-time structural dependency

---

## Design Intent
Inheritance is intended for modeling **true specialization** where a subclass logically fits under a base class.

---

## When to Use Inheritance
- When the relationship is clearly is-a
- When the base class is stable
- When polymorphic behavior is required
- When shared behavior is fundamental

---

## Risks and Drawbacks
- Fragile Base Class problem
- Tight coupling
- Reduced flexibility
- Difficult refactoring in large hierarchies

---

## Best Practices
- Keep base classes small and focused
- Avoid deep inheritance trees
- Prefer composition when behavior may change
- Use interfaces for contracts

---

## Summary
Inheritance is powerful but risky.  
It should be used **carefully and sparingly**, only when the is-a relationship is clear and stable.
