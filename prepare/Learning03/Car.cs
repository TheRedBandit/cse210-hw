public class Car
{
    private string _color;
    private float _engineSize;
    // Constructor. Every class has a constructor, and it is the function which
    // is called upon object creation.
    // Stuff that goes in here:
    // * global memmber variables
    // * stuff you want to happen upon object creation
    // Other important notes
    // * Constructors don't need a specified return type or scope
    // * Name of constructor MUST match the name of the class to be recognized

    public Car(string color, float engineSize) {
        _color = color;
        _engineSize = engineSize;
    }

    // Function declarations have certain necessary parts:
    // 1. Scope (who can access this?). Default is private
    // 2. Return type (what is the output of this function? does it have a return or no?)
    // 3. Arbitrary name
    // 4. Parenthases to define paramaters (arguments, or input)

    public string getColor() {
        return _color;
    }
    

}