namespace ConstructorInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

       /* public Vehicle()
        {
            Console.WriteLine("Vehicle is being Initilized");
        }*/
        public Vehicle(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initilized. {0}",registrationNumber);
        }
    }
}
