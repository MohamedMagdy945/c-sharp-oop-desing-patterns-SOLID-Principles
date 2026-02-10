# Design Patterns in Object-Oriented Programming (OOP)

## What are Design Patterns?
**Design Patterns** are proven, reusable solutions to common problems in software design.  
They provide a **blueprint or template** for solving recurring design issues in a standardized way.

> "A repeatable solution to a common software problem."

---

## Why Design Patterns are Important
- **Reusability**: Avoid reinventing solutions for common problems.  
- **Maintainability**: Clear structure improves understanding and reduces bugs.  
- **Scalability**: Easier to extend or modify systems.  
- **Communication**: Standard pattern names convey design ideas quickly.  
- **Best Practices**: Incorporates expert knowledge and proven solutions.

---

## Categories of Design Patterns
Design patterns are generally divided into **three main categories**:

### 1. Creational Patterns
Focus on **object creation** and abstracting the instantiation process.  
They help make a system independent of how its objects are created, composed, and represented.

Common Creational Patterns:
- **Singleton**: Ensures a class has only one instance and provides a global access point.  
- **Factory Method**: Defines an interface for creating objects but allows subclasses to decide which class to instantiate.  
- **Abstract Factory**: Provides an interface for creating families of related objects without specifying their concrete classes.  
- **Builder**: Separates the construction of a complex object from its representation.  
- **Prototype**: Creates new objects by cloning existing ones.

---

### 2. Structural Patterns
Focus on **how classes and objects are composed** to form larger structures.  
They simplify the design by identifying relationships between entities.

Common Structural Patterns:
- **Adapter**: Allows incompatible interfaces to work together.  
- **Decorator**: Dynamically adds responsibilities to objects without altering their structure.  
- **Facade**: Provides a simplified interface to a complex subsystem.  
- **Composite**: Composes objects into tree structures to represent part-whole hierarchies.  
- **Proxy**: Provides a placeholder or surrogate to control access to another object.

---

### 3. Behavioral Patterns
Focus on **communication between objects** and **how responsibilities are distributed**.  
They manage algorithms, relationships, and responsibilities between objects.

Common Behavioral Patterns:
- **Observer**: Defines a one-to-many dependency so that when one object changes, all dependents are notified.  
- **Strategy**: Encapsulates interchangeable algorithms and makes them interchangeable at runtime.  
- **Command**: Encapsulates requests as objects, allowing parameterization and queuing of actions.  
- **Iterator**: Provides a way to access elements of a collection sequentially without exposing the underlying representation.  
- **State**: Allows an object to change its behavior when its internal state changes.  
- **Mediator**: Defines an object that encapsulates how a set of objects interact.  
- **Chain of Responsibility**: Passes requests along a chain of handlers, giving multiple objects a chance to handle it.

---

## Key Points
- Design patterns **solve recurring design problems** in a standard, reusable way.  
- They improve **code clarity, maintainability, and scalability**.  
- Knowledge of patterns helps **communicate designs effectively** among developers.  
- Not every problem requires a pattern; use them **judiciously**.  
- Often combined with **SOLID principles** for robust object-oriented design.

---

## References
- “Design Patterns: Elements of Reusable Object-Oriented Software” by Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides (Gang of Four).  
- SOLID Principles and their relation to design patterns.  
