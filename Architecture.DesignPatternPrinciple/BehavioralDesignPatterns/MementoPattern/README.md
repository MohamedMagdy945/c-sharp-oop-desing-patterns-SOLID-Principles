# Memento Design Pattern

## What is the Memento Pattern?
The **Memento Pattern** is a **behavioral design pattern** that allows an object to capture and externalize its internal state **without violating encapsulation**, so it can be restored later.

> In simple terms:  
> "Save and restore an object's state."

---

## Purpose
- Preserve the state of an object at a specific point in time.  
- Allow undo or rollback operations without exposing the internal details of the object.  
- Keep the internal structure **hidden from external classes**.

---

## Participants
1. **Originator**
   - The object whose state needs to be saved and restored.  
   - Creates a memento containing a snapshot of its current state.  

2. **Memento**
   - Stores the internal state of the Originator.  
   - Provides read-only access to the state to protect encapsulation.  

3. **Caretaker**
   - Responsible for keeping the memento.  
   - Does not modify or access the internal state of the memento.  
   - Requests the Originator to restore its state when needed.

---

## Key Points
- Enables **undo/redo functionality** in applications.  
- Preserves encapsulation by not exposing the internal details of the Originator.  
- Often used in **text editors, game state saving, or transactional systems**.  
- Part of **Behavioral Design Patterns** because it deals with **object state and behavior over time**.

---

## Example Use Cases
- Undo/redo operations in **text editors**.  
- Saving and restoring **game states**.  
- Storing snapshots in **transactional applications**.  
