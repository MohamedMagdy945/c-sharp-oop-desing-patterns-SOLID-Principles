# Strategy Design Pattern

## What is the Strategy Pattern?
The **Strategy Pattern** is a **behavioral design pattern** that defines a family of algorithms, encapsulates each one, and makes them interchangeable at runtime.

It allows the behavior of a class to be selected dynamically without modifying the class itself.

> In simple terms:  
> "Choose behavior or algorithm at runtime."

---

## Purpose
- Encapsulate different algorithms or behaviors.  
- Allow switching between algorithms dynamically.  
- Separate algorithm logic from the main class.  
- Promote flexibility and reuse of code.

---

## Why the Strategy Pattern is Important
- **Eliminates Conditional Statements**: Removes multiple if/else or switch cases.  
- **Improves Flexibility**: Algorithms can be changed at runtime.  
- **Enhances Maintainability**: Each algorithm is in a separate class.  
- **Supports Open/Closed Principle**: New strategies can be added without modifying existing code.  
- **Encourages Composition Over Inheritance**: Behavior is composed rather than inherited.

---

## How the Strategy Pattern Works
The pattern usually includes:

1. **Context**
   - The main class that uses a strategy.  
   - Holds a reference to a strategy object.  
   - Delegates behavior to the strategy.

2. **Strategy Interface**
   - Defines a common interface for all supported algorithms.  

3. **Concrete Strategies**
   - Implement different versions of the algorithm.  
   - Each class represents a specific behavior or strategy.

The context can switch between strategies at runtime depending on requirements.

---

## When to Use the Strategy Pattern
- When multiple algorithms can be used for a task.  
- When you want to avoid large conditional statements.  
- When behavior needs to change at runtime.  
- When you want to isolate business logic from algorithms.

---

## Advantages
- Makes code flexible and extensible.  
- Improves separation of concerns.  
- Allows runtime switching of behavior.  
- Encourages reusable and clean design.

---

## Disadvantages
- Increases the number of classes in the system.  
- Clients must understand differences between strategies.  
- May add slight complexity for simple cases.

---

## Real-World Examples
- Payment methods (Credit Card, PayPal, Cash).  
- Sorting algorithms (Quick sort, Merge sort).  
- Compression methods (ZIP, RAR).  
- Navigation systems choosing different routes.  

---

## Key Points
- Part of **Behavioral Design Patterns**.  
- Encapsulates interchangeable behaviors or algorithms.  
- Allows behavior selection at runtime.  
- Promotes flexible and maintainable object-oriented design.  
