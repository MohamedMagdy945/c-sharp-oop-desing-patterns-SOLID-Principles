# Builder Design Pattern

## Overview
The Builder Pattern is a creational design pattern used to construct complex objects step by step.  
It allows the same construction process to create different representations of an object.

Instead of creating a large constructor with many parameters, the builder pattern separates the construction logic from the final object representation.

---

## Problem
When an object has many optional fields or requires complex creation logic:
- Constructors become very long
- Hard to read and maintain
- Difficult to create different variations of the same object
- Object creation logic mixed with business logic

Example problem:
Creating a complex object like:
- User profile
- Car
- House
- Meal
With many optional properties.

---

## Solution
The Builder Pattern suggests:
- Create a separate Builder class
- Build object step by step
- Return final constructed object at the end
- Same builder can create different representations

It separates:
Construction process from final object.

---

## Structure
Main components:

### 1. Product
The complex object being created.

### 2. Builder (Interface / Abstract)
Defines steps required to build the product.

### 3. Concrete Builder
Implements builder steps and constructs final object.

### 4. Director (Optional)
Controls the order of building steps.

---

## How It Works
1. Client requests object creation
2. Client uses builder
3. Builder builds object step by step
4. Final object returned

Director (optional):
- Controls building sequence
- Can create different configurations

---

## When to Use
Use Builder pattern when:
- Object has many optional parameters
- Construction process is complex
- Need different representations of same object
- Want readable object creation
- Want immutable objects

---

## Advantages
- Clean and readable object creation
- Step-by-step construction
- Same process creates different objects
- Follows Single Responsibility Principle
- Improves maintainability
- Avoids telescoping constructors

---

## Disadvantages
- More classes required
- Increases complexity
- Not needed for simple objects

---

## Real-Life Examples
- Building a meal in restaurant
- Creating a car with options
- Building a computer (RAM, CPU, GPU)
- HTML document builder
- Query builder (SQL)

---

## Builder vs Factory
Factory Pattern:
- Creates object in one step
- Returns ready object

Builder Pattern:
- Creates object step by step
- Used for complex objects

---

## Builder vs Abstract Factory
Abstract Factory:
- Creates families of related objects

Builder:
- Builds one complex object step by step

---

## Summary
Builder Pattern is used to construct complex objects step by step.  
It separates object construction from representation and provides flexible, readable, and maintainable object creation.