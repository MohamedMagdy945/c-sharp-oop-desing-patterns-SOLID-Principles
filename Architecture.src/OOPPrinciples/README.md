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

---# Object-Oriented Programming (OOP) Concepts

Object-Oriented Programming (OOP) is a programming paradigm based on the concept of **objects**, which contain **data** and **methods**.  
OOP aims to improve **code organization, reusability, maintainability, and flexibility**.

---

## 1. Encapsulation

### What is Encapsulation?
Encapsulation is the principle of **hiding the internal details of an object** and exposing only what is necessary through a controlled interface.

> **"Keep the data safe, and provide controlled access to it."**

### Why Encapsulation is Important
- Protects data from unauthorized access or modification.  
- Makes code **maintainable**, as internal implementation can change without affecting other parts of the program.  
- Provides **control** to enforce rules when accessing or modifying data.  
- Allows adding validation, logging, or other logic when accessing data.

### Key Points
- Achieved using **private fields** and **public methods/properties**.  
- Promotes data integrity and modular design.

---

## 2. Inheritance

### What is Inheritance?
Inheritance allows a class (**derived/child class**) to **reuse and extend** the behavior of another class (**base/parent class**).

> **"Build on existing functionality without rewriting it."**

### Why Inheritance is Important
- Enables **code reuse**.  
- Facilitates **extensibility** by adding new functionality to existing classes.  
- Supports **polymorphism** for treating objects of different classes uniformly.  
- Improves **maintainability**, as changes in base class propagate to derived classes safely if designed correctly.

### Key Points
- Represents an **"is-a" relationship**.  
- C# supports **single inheritance**; a class can inherit from only one base class.  
- Use **protected members** carefully to allow access by derived classes without exposing them publicly.

---

## 3. Polymorphism

### What is Polymorphism?
Polymorphism is the ability of objects of different classes to be **treated as objects of a common base class**, while each object responds differently to the same method call.

> **"One interface, many forms."**

### Why Polymorphism is Important
- Increases **flexibility** by allowing general code to work with objects of different types.  
- Improves **extensibility**, enabling new classes without modifying existing code.  
- Reduces **complex conditional logic**, improving maintainability.  
- Supports **dynamic behavior**, where the same method call can produce different outcomes.

### Key Points
- Includes **compile-time polymorphism** (method overloading) and **runtime polymorphism** (method overriding).  
- Closely related to **inheritance** and **abstraction**.  
- Enhances code generalization and reusability.

---

## 4. Abstraction

### What is Abstraction?
Abstraction is the concept of **hiding complex implementation details** and exposing only the necessary functionality to the user.

> **"Focus on what an object does, not how it does it."**

### Why Abstraction is Important
- Simplifies complex systems.  
- Reduces **dependency on implementation details**.  
- Enhances **maintainability** and **readability**.  
- Allows using **interfaces or abstract classes** to define contracts.

### Key Points
- Achieved using **abstract classes** and **interfaces**.  
- Promotes loose coupling between system components.  
- Works closely with **polymorphism** to provide flexible behavior.

---

## 5. Composition

### What is Composition?
Composition is a design principle where a class is **built using references to other classes** instead of inheriting from them.

> **"A class has other classes as part of its structure."**

### Why Composition is Important
- Promotes **code reuse** without tight inheritance dependencies.  
- Supports **flexibility**, as objects can be replaced at runtime.  
- Enhances **encapsulation** by hiding internal objects.  
- Reduces **fragility** compared to inheritance-heavy designs.

### Key Points
- Represents a **"has-a" relationship**, unlike inheritance which is "is-a".  
- Preferred for **modular and maintainable design**.  
- Often used with **interfaces** to achieve polymorphic behavior.

---

## 6. Coupling

### What is Coupling?
Coupling is the **degree of dependency between modules or classes**.  
It measures **how much one module relies on another**.

> **"How tightly connected different parts of a program are."**

### Why Coupling is Important
- Low coupling improves **maintainability**.  
- Supports **reusability** of independent modules.  
- Makes **testing easier**.  
- Increases system **flexibility**.

### Key Points
- **Loose coupling** is preferred; modules are mostly independent.  
- **Tight coupling** makes changes risky and error-prone.  
- Achieved through **interfaces, abstractions, and proper design principles**.

---

## 7. Fragile Base Class

### What is a Fragile Base Class?
A Fragile Base Class is a **base class that is easy to break** when changes are made, especially if other classes inherit from it.

> **"Changing the parent can unexpectedly break the children."**

### Why It Matters
- Can cause **unexpected failures** in derived classes.  
- Indicates **tight coupling** between base and derived classes.  
- Makes the system **difficult to maintain**.  
- Limits flexibility to safely extend or modify behavior.

### How to Avoid Fragile Base Classes
- Prefer **composition over inheritance**.  
- Keep base classes **simple and focused**.  
- Minimize **protected members**; encapsulate internal details.  
- Use **interfaces or abstract classes** to define clear contracts.  

---

## Key Principles of OOP
- **Encapsulation**: Protect data and provide controlled access.  
- **Inheritance**: Reuse and extend existing behavior.  
- **Polymorphism**: One interface, many forms.  
- **Abstraction**: Hide complexity and expose only what’s necessary.  
- **Composition**: Build classes using other classes for flexibility.  
- **Low Coupling**: Keep modules independent for maintainability.  
- **Avoid Fragile Base Classes**: Design inheritance carefully.

---

## Summary
OOP principles aim to create software that is **flexible, reusable, maintainable, and scalable**.  
Combining these principles with good design practices (like **SOLID**) ensures that systems are **robust, adaptable, and easy to understand**.

---

## Inheritance vs Composition: When to Use Each One

Choosing between **Inheritance** and **Composition** is a critical design decision in Object-Oriented Programming.  
Using the wrong one can lead to rigid, fragile, and hard-to-maintain systems.

---

### Inheritance

#### What It Represents
Inheritance represents an **"is-a" relationship**, where a derived class is a specialized version of a base class.

> **"A subclass is a type of its base class."**

#### When to Use Inheritance
Use inheritance when:
- The relationship is logically and clearly **is-a**.
- The base class is **stable** and unlikely to change.
- Shared behavior is common and consistent across all derived classes.
- Polymorphism through a common base type is required.

#### Drawbacks
- Creates **tight coupling** between base and derived classes.
- Changes in the base class may break derived classes (**Fragile Base Class problem**).
- Reduces flexibility over time.

---

### Composition

#### What It Represents
Composition represents a **"has-a" relationship**, where a class contains or uses other classes to perform its behavior.

> **"A class is built using other objects."**

#### When to Use Composition
Use composition when:
- The relationship is **has-a**, not is-a.
- Behavior may change or vary at runtime.
- Flexibility and maintainability are priorities.
- You want to avoid tight coupling between classes.

#### Advantages
- Promotes **loose coupling**.
- Improves **flexibility and testability**.
- Reduces dependency on internal implementation details.
- Safer and more adaptable for large systems.

---

### Comparison Summary

| Aspect | Inheritance | Composition |
|------|------------|-------------|
| Relationship | is-a | has-a |
| Flexibility | Low | High |
| Coupling | Tight | Loose |
| Change Impact | High risk | Low risk |
| Design Safety | Risky if misused | Preferred |

---

### Design Guideline
> **Favor Composition over Inheritance**, unless inheritance clearly represents a stable and logical is-a relationship.

---


