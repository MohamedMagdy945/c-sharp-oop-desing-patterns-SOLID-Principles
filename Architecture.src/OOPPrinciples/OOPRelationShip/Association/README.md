# Association in Object-Oriented Programming (OOP)

## What is Association?
Association is the most general type of relationship in Object-Oriented Programming.  
It represents a connection between two or more classes where objects **know about each other**, but **none owns the other**.

> "Objects are related, but independent."

---

## Key Characteristics
- No ownership between objects
- Independent lifecycles
- Very loose coupling
- Can exist in different cardinalities:
  - One-to-One
  - One-to-Many
  - Many-to-Many

---

## Design Intent
Association is used to model **communication or collaboration** between objects without implying responsibility or ownership.

---

## When to Use Association
- When objects need to interact or exchange information
- When there is no lifecycle dependency
- When you want to minimize coupling
- When modeling temporary or logical connections

---

## Advantages
- High flexibility
- Easy to change or remove relationships
- Encourages modular design
- Safe for evolving systems

---

## Limitations
- Does not express ownership
- Not suitable for modeling part-whole relationships
- Can become unclear if overused without documentation

---

## Summary
Association is the foundation of object relationships in OOP.  
It should be used whenever objects collaborate while remaining **fully independent**.
