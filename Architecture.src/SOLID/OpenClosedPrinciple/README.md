# Open/Closed Principle (OCP)

## What is the Open/Closed Principle?
The **Open/Closed Principle (OCP)** is one of the five SOLID principles of **Object-Oriented Programming (OOP)**.

It states that:
> **Software entities (classes, modules, functions) should be open for extension but closed for modification.**

This means you should be able to add new functionality without changing existing code.

---

## Why OCP is Important
- **Prevents Breaking Existing Code**: New features can be added without modifying tested code.  
- **Improves Stability**: Reduces risk of introducing bugs in existing functionality.  
- **Enhances Scalability**: Makes systems easier to expand and extend.  
- **Encourages Clean Architecture**: Promotes abstraction and proper design patterns.  
- **Supports Maintainability**: Code becomes easier to manage and update.

---

## How OCP Works
- Use **abstraction** (interfaces or abstract classes).  
- Define a base behavior that can be extended.  
- Create new classes that extend the behavior instead of modifying existing ones.  
- Avoid adding conditions (if/else or switch) for every new feature.

Example:
Instead of modifying a class every time a new payment method is added:

Bad approach:
- Add `if` statements for Credit Card, PayPal, etc. inside one class.

Good approach:
- Create a base `Payment` interface.  
- Create separate classes:
  - CreditCardPayment  
  - PayPalPayment  
  - CryptoPayment  
- Each class implements the same interface.  
- New payment methods can be added without modifying existing code.

---

## Key Points
- Open for extension → You can add new features.  
- Closed for modification → Avoid changing existing code.  
- Achieved using **inheritance, interfaces, and polymorphism**.  
- Reduces risk and improves code stability.  
- Essential for building **scalable and maintainable systems**.
