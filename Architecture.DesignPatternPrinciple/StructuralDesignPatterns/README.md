# Structural Design Patterns

## What are Structural Patterns?
**Structural Patterns** are design patterns that focus on **how classes and objects are composed to form larger structures**.  
They help ensure that the system’s structure is flexible, efficient, and easy to maintain.

> In simple terms:  
> "How objects and classes are put together."

---

## Why Structural Patterns are Important
- **Simplify Composition**: Clearly define how objects combine to form larger structures.  
- **Promote Reusability**: Components can be reused in different contexts.  
- **Encapsulate Relationships**: Hide complex relationships between objects.  
- **Enhance Flexibility**: System structure can change without affecting client code.  
- **Improve Maintainability**: Easier to extend or modify object structures.

---

## Common Structural Patterns

1. **Adapter**
   - Converts the interface of a class into another interface clients expect.  
   - Allows classes to work together that otherwise couldn’t due to incompatible interfaces.  

2. **Bridge**
   - Decouples an abstraction from its implementation so they can vary independently.  
   - Useful when both abstractions and implementations should be extensible.  

3. **Composite**
   - Composes objects into tree structures to represent part-whole hierarchies.  
   - Allows clients to treat individual objects and compositions uniformly.  

4. **Decorator**
   - Adds responsibilities to objects dynamically without altering their structure.  
   - Provides flexible alternatives to subclassing for extending functionality.  

5. **Facade**
   - Provides a simplified interface to a complex subsystem.  
   - Makes subsystems easier to use and reduces dependencies.  

6. **Flyweight**
   - Reduces memory usage by sharing as much data as possible between similar objects.  
   - Useful for large numbers of similar objects.  

7. **Proxy**
   - Provides a surrogate or placeholder for another object to control access to it.  
   - Can add functionality like lazy loading, security, or logging.

---

## Key Points
- Structural patterns focus on **object composition and relationships**.  
- They make systems **flexible, maintainable, and efficient**.  
- Often combined with creational and behavioral patterns to build robust software architecture.  
