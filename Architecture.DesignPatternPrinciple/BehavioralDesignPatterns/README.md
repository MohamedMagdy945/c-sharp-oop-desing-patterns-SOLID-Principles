# Behavioral Design Patterns

## What are Behavioral Patterns?
**Behavioral Patterns** are design patterns that focus on **how objects interact and communicate** with each other.  
They define **responsibilities, algorithms, and communication** between objects, making the system flexible and easier to maintain.

> In simple terms:  
> "How objects talk and work together."

---

## Why Behavioral Patterns are Important
- **Improve Communication**: Clearly define how objects interact.  
- **Encapsulate Algorithms**: Allows algorithms to vary independently from clients that use them.  
- **Promote Flexibility**: Behavior can change at runtime without modifying classes.  
- **Simplify Responsibilities**: Distribute tasks among objects more effectively.  
- **Enhance Maintainability**: Easier to extend or modify interactions between objects.

---

## Common Behavioral Patterns

1. **Observer**
   - Defines a one-to-many dependency between objects.  
   - When one object changes state, all dependents are notified automatically.  

2. **Strategy**
   - Encapsulates interchangeable algorithms or behaviors.  
   - Clients can choose the algorithm at runtime.  

3. **Command**
   - Encapsulates a request as an object.  
   - Allows parameterization of clients with different requests, and supports queuing or undoable operations.  

4. **Iterator**
   - Provides a way to access elements of a collection sequentially without exposing its underlying representation.  

5. **State**
   - Allows an object to alter its behavior when its internal state changes.  
   - The object appears to change its class.  

6. **Mediator**
   - Encapsulates how a set of objects interact.  
   - Promotes loose coupling by keeping objects from referring to each other directly.  

7. **Chain of Responsibility**
   - Passes requests along a chain of handlers.  
   - Each handler decides whether to process the request or pass it along.  

8. **Template Method**
   - Defines the skeleton of an algorithm in a method.  
   - Subclasses can override specific steps without changing the algorithm's structure.  

9. **Visitor**
   - Lets you define a new operation without changing the classes of the elements on which it operates.  

10. **Interpreter**
    - Defines a grammar for interpreting a language and provides an interpreter to deal with sentences in that language.  

---

## Key Points
- Behavioral patterns focus on **object communication and responsibility distribution**.  
- They make systems **more flexible, reusable, and maintainable**.  
- Often combined with structural and creational patterns to build robust object-oriented systems.  
