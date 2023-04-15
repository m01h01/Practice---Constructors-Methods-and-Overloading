namespace Practice___Constructors__Methods__and_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car defaultCar= new Car();
            Car makeModelCar = new Car("Toyota", "Rav4");
            Car fullCar = new Car("Hyundai", "Sonata", 2010, 100000);

            Console.WriteLine("Car Information\n" +
                defaultCar + "\n"+
                makeModelCar + "\n"+
               fullCar + "\n\n");


            Console.WriteLine("Bank Information:");
            BankAccount account = new BankAccount("12345", "Will Cram", 20);
            Console.WriteLine(account);

            account.Deposit(500);
            Console.WriteLine(account);

            account.Deposit(-15000);
            Console.WriteLine(account);

            account.Withdraw(300);
            Console.WriteLine(account);

            account.Withdraw(500);
            Console.WriteLine(account);


        }
    }//class
}//namespace