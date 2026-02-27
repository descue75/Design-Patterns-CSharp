# Design-Patterns-CSharp

## <u>SOLID </u>

### Single Responsibility Principle

* A class should only have one reason to change
* Seperation of concerns - different classes handling different, independent task/problems

#### Example:
The Journal class should just handle adding and removing entries but not persistence.
[Journal.cs](SOLID/SingleResponsibility/Journal.cs)

Instead you should create a seperate class to handle persistence.
[Persistence.cs](SOLID/SingleResponsibility/Persistence.cs)


---
### Open-Closed Principle

* Classes should be open for extension but closed for modification

#### Example:
The ProductFilter class has to be opened every time a new filter is added.
[ProductFilter.cs](SOLID/OpenClosed/Bad/ProductFilter.cs)

Instead use inheritance like in the specification pattern which will be covered in more detail later.

Create two generic interfaces, one for filters ([IFilter.cs](SOLID/OpenClosed/IFilter.cs)) and one for
specifications ([ISpecification.cs](SOLID/OpenClosed/ISpecification.cs)).  The filter interface has one
function called Filter that takes an IEnumerable of the generic type and ISpecification which has
one function called IsSatisfied which takes an instance of the generic type to be compared and returns
whether or not the specification is satisfied on that instance (in other words a predicate).

To use, make a concreate specification, in this case with the Product class
(example: [ColorSpecification.cs](SOLID/OpenClosed/ColorSpecification.cs)).  The concrete class should
take in all the properties to be filtered on (in this case Color).  In the implementation of IsSatisfied
just compare the passed in Product with the Color passed into ColorSpecification and return whether or
not the color matches.

Now create a concrete filter for the type being filtered, Product in this case
([BetterProductFilter.cs](SOLID/OpenClosed/BetterProductFilter.cs)).  The Filter function implementation
takes the IEnumerable of Products and an instance of a Product Specification (passing in the filter
criteria of the specification).  It returns a filtered IEnumerable that only contains items that satisfy
the satisfies the Specification (by calling IsSatisfied).

When creating an instance of BetterProductFilter pass in the IEnumerable of Products and the Specification
that you want to be satisfied.  Now you can add additional specifications without opening an existing class.

> [!NOTE] You can combine specifications by creating an and specification
([AndSpecification.cs](SOLID/OpenClosed/AndSpecification.cs)) and an or specification
([OrSpecification.cs](SOLID/OpenClosed/OrSpecification.cs)).



### Liskov Substitution Principle

* You should be able to substitute a base type for a subtype

### Interface Segregation Principle

* Don't put too much into an interface; split into seperate interfaces
* YAGNI - You Ain't Going to Need It

### Dependency Inversion Principle

* High-level modules should not depend upon low-level ones; use abstractions

---