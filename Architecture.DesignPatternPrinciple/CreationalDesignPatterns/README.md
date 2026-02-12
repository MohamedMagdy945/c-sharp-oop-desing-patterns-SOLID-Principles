# Creational Design Patterns

## What are Creational Patterns?
**Creational Patterns** are design patterns that focus on **how objects are created**.  
They provide mechanisms to create objects in a way that **enhances flexibility, reuse, and control over object creation**.

> In simple terms:  
> "How objects are created efficiently and flexibly."

---

## Why Creational Patterns are Important
- **Encapsulate Object Creation**: Separates object construction from its use.  
- **Promote Flexibility**: Allows changing the way objects are created without affecting client code.  
- **Improve Maintainability**: Object creation logic is centralized and easier to manage.  
- **Enhance Reusability**: Standardizes creation methods across the system.  
- **Support Different Creation Scenarios**: Can handle simple, complex, or conditional object creation.  

---

## Common Creational Patterns

1. **Singleton**
   - Ensures a class has only **one instance** and provides a global access point.  

2. **Factory Method**
   - Defines an **interface for creating objects**, but lets subclasses decide which class to instantiate.  

3. **Abstract Factory**
   - Provides an **interface for creating families of related or dependent objects** without specifying their concrete classes.  

4. **Builder**
   - Separates the construction of a **complex object** from its representation.  
   - Allows building different representations of the same object step by step.  

5. **Prototype**
   - Creates new objects by **copying an existing object (cloning)**.  
   - Useful when object creation is expensive or complex.  

---

## Key Points
- Creational patterns focus on **object creation mechanisms**.  
- They **decouple clients from the actual object classes**.  
- Enhance flexibility, scalability, and maintainability.  
- Often combined with structural and behavioral patterns to build robust systems.  
