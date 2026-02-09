# Composition in Object-Oriented Programming (OOP)

## What is Composition?
Composition is a principle in **Object-Oriented Programming (OOP)** where a class is **built using references to other classes** instead of inheriting from them.  
It is often described as a **"has-a" relationship** between objects.  

In simple terms:  
> **"A class contains other classes as part of its structure."**

---

## Why Composition is Important
- **Code Reusability**: Classes can use functionality of other classes without inheriting from them.  
- **Flexibility**: Objects can be combined or replaced at runtime.  
- **Maintainability**: Reduces tight coupling between classes.  
- **Encapsulation**: Internal objects can remain hidden while providing controlled access.

---

## How Composition Works
- A class **contains instances of other classes** as its members.  
- Instead of extending a class, you **delegate responsibilities** to the contained objects.  
- Changes in one class do not affect the composed class as long as the interface stays the same.  
- Promotes **loose coupling** and **high cohesion** in design.