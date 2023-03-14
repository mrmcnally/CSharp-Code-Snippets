//Example of a class in c# with a constructor method
public class Car{

    private string make;
    private string model;
    private string colour;
    private int engineSize;
    private int numberOfDoors;

    //constructor that take two parameters, make and model
    public Car(string make, string model){        
        this.make = make;
        this.model = model;
    }

}



 static void Main(string[] args)
    {
        //instantiating 2 car objects using the car constructor
        Car car1 = new Car("Ford", "Fiesta");
        Car car2 = new Car("Honda", "Civic");
    }

