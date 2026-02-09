# Single Responsibility Principle (SRP)

## What is the Single Responsibility Principle?
The **Single Responsibility Principle (SRP)** is one of the five SOLID principles of **Object-Oriented Programming (OOP)**.

It states that:
> **A class should have only one reason to change.**

This means every class should have a single, well-defined responsibility or purpose within the system.

---

## Why SRP is Important
- **Improves Maintainability**: Smaller, focused classes are easier to update and maintain.  
- **Enhances Readability**: Code becomes clearer because each class has a specific role.  
- **Reduces Complexity**: Breaking large classes into smaller ones simplifies development.  
- **Easier Testing**: Classes with a single responsibility are easier to test.  
- **Better Scalability**: Changes in one functionality do not affect unrelated parts of the system.

---

## How SRP Works
- Identify different responsibilities within a class.  
- Separate each responsibility into its own class.  
- Ensure each class handles only one specific functionality.  
- If a class has more than one reason to change, split it into multiple classes.

Example:
Instead of one class handling:
- Database operations  
- Business logic  
- Logging  

Create separate classes:
- Data access class  
- Business logic class  
- Logging service  

Each class now has a single responsibility.

---

## Key Points
- A class should do **one thing only** and do it well.  
- Helps create **clean and modular code**.  
- Makes systems easier to maintain and extend.  
- Closely related to other SOLID principles like **Open/Closed Principle** and **Dependency Inversion**.  
- Applying SRP leads to better **software design** and fewer bugs.
