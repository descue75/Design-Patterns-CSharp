# Design-Patterns-CSharp
---

## SOLID

### Single Responsibility Principle

* A class should only have one reason to change
* Seperation of concerns - different classes handling different, independent task/problems

The Journal class should just handle adding and removing entries but not persitance.  [Journal.cs](SOLID/SingleResponsibility/Journal.cs)

Instead you should create a seperate class to handle persistence.  [Persistence.cs](SOLID/SingleResponsibility/Persistence.cs)


### Open-Closed Principle

* Classes should be open for extension but closed for modification

### Liskov Substitution Principle

* You should be able to substitute a base type for a subtype

### Interface Segregation Principle

* Don't put too much into an interface; split into seperate interfaces
* YAGNI - You Ain't Going to Need It

### Dependency Inversion Principle

* High-level modules should not depend upon low-level ones; use abstractions

---