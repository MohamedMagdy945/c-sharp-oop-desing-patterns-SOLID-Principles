# Dependency Inversion Principle (DIP)

## What is the Dependency Inversion Principle?
The **Dependency Inversion Principle (DIP)** is one of the five SOLID principles of **Object-Oriented Programming (OOP)**.

It states that:
> **High-level modules should not depend on low-level modules. Both should depend on abstractions.**  
> **Abstractions should not depend on details. Details should depend on abstractions.**

In simple terms:
- Code should depend on **interfaces or abstract classes**, not on concrete implementations.

---

## Why DIP is Important
- **Reduces Coupling**: High-level code does not directly depend on low-level implementation.  
- **Enhances Flexibility**: Implementations can change without affecting high-level logic.  
- **Improves Testability**: Interfaces make it easier to use mocks or stubs in testing.  
- **Supports Maintainability**: Changing one module has minimal impact on others.  
- **Encourages Clean Architecture**: Promotes use of abstractions and proper dependency management.

---

## How DIP Works
- Identify high-level modules (business logic) and low-level modules (details, e.g., database, file system).  
- Define **interfaces or abstract classes** representing the expected behavior.  
- Make both high-level and low-level modules depend on these abstractions.  
- Inject dependencies (via constructor, setter, or interface) instead of creating objects directly.

Example:

Bad design:
```csharp
class FileLogger {
    public void Log(string message) { /* write to file */ }
}

class UserService {
    private FileLogger logger = new FileLogger(); // direct dependency
    public void CreateUser() { logger.Log("User created"); }
}
