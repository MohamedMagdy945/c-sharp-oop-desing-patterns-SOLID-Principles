# Interface Segregation Principle (ISP)

## What is the Interface Segregation Principle?
The **Interface Segregation Principle (ISP)** is one of the five SOLID principles of **Object-Oriented Programming (OOP)**.

It states that:
> **Clients should not be forced to depend on interfaces they do not use.**

This means large, general-purpose interfaces should be split into smaller, more specific ones so that classes only implement what they actually need.

---

## Why ISP is Important
- **Reduces Unnecessary Dependencies**: Classes only depend on methods they use.  
- **Improves Flexibility**: Easier to modify or extend specific behaviors.  
- **Enhances Maintainability**: Smaller interfaces are easier to manage.  
- **Prevents Empty or Unused Methods**: Classes won't implement irrelevant functionality.  
- **Promotes Clean Design**: Encourages modular and focused interfaces.

---

## How ISP Works
- Avoid creating large interfaces with many unrelated methods.  
- Split large interfaces into smaller, specific ones.  
- Let classes implement only the interfaces they need.  
- Design interfaces based on client requirements.

Example:

Bad design:
A single interface:
- Print()
- Scan()
- Fax()

A simple printer class must implement all methods even if it only prints.

Good design:
Split into multiple interfaces:
- Printable → Print()  
- Scannable → Scan()  
- Faxable → Fax()  

Now:
- BasicPrinter implements Printable only  
- AdvancedPrinter implements Printable, Scannable, Faxable  

Each class uses only what it needs.

---

## Key Points
- Create **small and specific interfaces** instead of large ones.  
- Classes should not be forced to implement unused methods.  
- Improves modularity and flexibility in design.  
- Works closely with **Single Responsibility Principle**.  
- Leads to cleaner and more maintainable OOP systems.
