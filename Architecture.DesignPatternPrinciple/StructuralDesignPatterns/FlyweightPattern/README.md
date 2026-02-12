# Flyweight Design Pattern

## What is the Flyweight Pattern?
The **Flyweight Pattern** is a **structural design pattern** that reduces memory usage by sharing as much data as possible between similar objects.  
It is used when many objects of the same kind are needed, but storing all of them individually would be expensive.

> In simple terms:  
> "Share objects to save memory when many similar objects exist."

---

## Purpose
- Reduce memory consumption by sharing common parts of objects.  
- Separate intrinsic (shared) and extrinsic (unique) state.  
- Improve performance in systems with large numbers of objects.  
- Avoid creating duplicate objects unnecessarily.  
- Facilitate efficient management of fine-grained objects.  

---

## Why the Flyweight Pattern is Important
- **Memory Efficiency**: Stores shared data once instead of duplicating it.  
- **Performance**: Reduces object creation overhead.  
- **Scalability**: Supports a large number of fine-grained objects.  
- **Consistency**: Shared state ensures uniform behavior.  
- **Separation of Concerns**: Distinguishes between intrinsic and extrinsic state.  

---

## How the Flyweight Pattern Works
The pattern typically includes:

1. **Flyweight Interface**
   - Declares methods that can receive extrinsic state.  
   - Defines operations that can use shared intrinsic state.  

2. **Concrete Flyweight**
   - Implements the flyweight interface.  
   - Stores intrinsic (shared) state.  
   - Uses extrinsic (unique) state passed by the client.  

3. **Flyweight Factory**
   - Manages the pool of flyweight objects.  
   - Returns existing flyweights or creates new ones if necessary.  

4. **Client**
   - Maintains extrinsic state.  
   - Uses flyweight objects from the factory.  

The intrinsic state is shared across multiple objects, while extrinsic state is supplied by the client when needed.

---

## When to Use the Flyweight Pattern
- When a system needs a large number of similar objects.  
- When memory usage is critical.  
- When objects can be divided into intrinsic (shared) and extrinsic (unique) state.  
- When object creation overhead is expensive.  
- When building games, graphics systems, or text editors.  

---

## Advantages
- Reduces memory usage significantly.  
- Improves performance by reusing objects.  
- Promotes separation of intrinsic and extrinsic state.  
- Supports large numbers of fine-grained objects.  

---

## Disadvantages
- Adds complexity to design.  
- Requires careful separation of intrinsic and extrinsic state.  
- Can make code harder to understand.  
- Extrinsic state must be managed by client, increasing coupling.  

---

## Real-World Examples
- Text editors: sharing character objects for repeated letters.  
- Graphics systems: reusing tree, leaf, or shape objects.  
- Game development: bullets, enemies, or particles sharing data.  
- Web caching: shared resources like images or styles.  
- Document editors: formatting attributes shared among multiple elements.  

---

## Key Points
- Part of **Structural Design Patterns**.  
- Reduces memory usage by sharing objects.  
- Separates intrinsic (shared) and extrinsic (unique) state.  
- Improves performance and scalability.  
- Useful in systems with large numbers of similar objects.
