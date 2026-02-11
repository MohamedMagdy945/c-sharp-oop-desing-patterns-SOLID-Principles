# Mediator Design Pattern

## What is the Mediator Pattern?
The **Mediator Pattern** is a **behavioral design pattern** that defines a central object (mediator) that manages communication between multiple objects, so they do not communicate directly with each other.

> In simple terms:  
> "Objects communicate through a mediator instead of directly with each other."

---

## Purpose
- Reduce direct communication between objects.  
- Centralize control of interactions.  
- Simplify complex object relationships.  
- Promote loose coupling between components.  
- Organize communication logic in one place.  

---

## Why the Mediator Pattern is Important
- **Loose Coupling**: Objects don’t depend directly on each other.  
- **Centralized Communication**: All interaction handled by mediator.  
- **Scalability**: Easy to add new components without modifying others.  
- **Maintainability**: Interaction logic managed in one place.  
- **Cleaner Code**: Reduces complex object-to-object references.  

---

## How the Mediator Pattern Works
The pattern typically includes:

1. **Mediator Interface**
   - Defines communication methods between objects.  
   - Declares methods used by colleague objects.  

2. **Concrete Mediator**
   - Implements mediator interface.  
   - Coordinates communication between objects.  
   - Contains interaction logic and rules.  

3. **Colleague Components (Objects)**
   - Communicate only through mediator.  
   - Do not communicate directly with each other.  
   - Notify mediator when events occur.  

When an object needs to communicate, it sends a request to the mediator, which then decides how other objects should respond.

---

## When to Use the Mediator Pattern
- When many objects communicate in complex ways.  
- When object relationships become tightly coupled.  
- When you want centralized communication control.  
- When building UI systems with many components.  
- When implementing chat systems or control centers.  

---

## Advantages
- Reduces tight coupling between objects.  
- Centralizes communication logic.  
- Makes code easier to maintain.  
- Improves flexibility and scalability.  
- Simplifies object interaction.  

---

## Disadvantages
- Mediator can become very complex.  
- May turn into a large "God Object".  
- Adds extra layer of abstraction.  
- Harder to reuse mediator if tightly coupled.  

---

## Real-World Examples
- Chat room applications.  
- Air traffic control systems.  
- GUI components communication.  
- Smart home central controller.  
- Customer service request routing.  

---

## Key Points
- Part of **Behavioral Design Patterns**.  
- Central mediator handles communication.  
- Promotes loose coupling.  
- Simplifies complex relationships.  
- Objects communicate through mediator only.
