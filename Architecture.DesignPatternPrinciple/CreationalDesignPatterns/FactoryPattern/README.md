# Factory Method Design Pattern

## What is the Factory Method Pattern?
The **Factory Method Pattern** is a **creational design pattern** that defines an interface for creating objects, but lets subclasses decide which class to instantiate.

> In simple terms:  
> "Delegate object creation to subclasses instead of creating objects directly."

---

## Purpose
- Encapsulate object creation logic.  
- Allow subclasses to choose the type of object to create.  
- Promote loose coupling between client and concrete classes.  
- Make the system more flexible and extensible.  
- Avoid hardcoding object types in client code.  

---

## Why the Factory Method Pattern is Important
- **Flexibility**: Clients do not depend on concrete classes.  
- **Extensibility**: New product types can be added without changing existing code.  
- **Loose Coupling**: Clients interact with interfaces, not implementations.  
- **Code Reusability**: Common creation logic can be centralized.  
- **Maintainability**: Reduces impact of changes in object creation.  

---

## How the Factory Method Pattern Works
The pattern typically includes:

1. **Product Interface**
   - Declares the interface of objects the factory creates.  

2. **Concrete Product**
   - Implements the product interface.  
   - Defines specific object behavior.  

3. **Creator (Factory)**
   - Declares the factory method for creating objects.  
   - May include default implementation or abstract method.  

4. **Concrete Creator**
   - Overrides the factory method.  
   - Returns an instance of a concrete product.  

5. **Client**
   - Calls the factory method to get products.  
   - Works with products through the product interface.  

Clients never instantiate concrete products directly; they rely on the factory method.

---

## When to Use the Factory Method Pattern
- When a class cannot anticipate the class of objects it needs to create.  
- When subclasses should specify which objects to create.  
- When you want to decouple clients from concrete classes.  
- When object creation is complex or involves configuration.  
- When extending a system with new product types frequently.  

---

## Advantages
- Promotes loose coupling between client and concrete classes.  
- Supports single responsibility principle by separating creation logic.  
- Improves maintainability and extensibility.  
- Encapsulates object creation, reducing code duplication.  
- Makes adding new product types easier.  

---

## Disadvantages
- Can increase complexity with many subclasses.  
- May require additional classes for each product type.  
- Clients may have to deal with multiple factory interfaces.  

---

## Real-World Examples
- Logger creation: FileLogger, DatabaseLogger, CloudLogger.  
- Document creation: WordDocument, PdfDocument, TextDocument.  
- UI components for different platforms (Windows, Mac, Linux).  
- Database connections for different database types.  
- Notification systems (Email, SMS, Push).  

---

## Key Points
- Part of **Creational Design Patterns**.  
- Delegates object creation to subclasses.  
- Provides flexibility and loose coupling.  
- Encapsulates object creation logic.  
- Supports system extensibility and maintainability.
