namespace ConstructorInheritance
{
    public class Car : Vehicle
    {
        
        public Car(string registrationNumber)
            : base(registrationNumber) 
        {
            Console.WriteLine("Car is begin initilized. {0}" + registrationNumber);
        }
    }
}
