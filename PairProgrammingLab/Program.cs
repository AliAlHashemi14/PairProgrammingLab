using PairProgrammingLab;

Employee a = new Employee("Dan", 15, "Starving Artist");
Employee b = new Employee("Asia", 150000, "Master Chef");
Employee c = new Employee("Ali", 420, "Jazz Cabbage Farmer");

List<Employee> list = new List<Employee>();
list.Add(a);
list.Add(b);
list.Add(c);
list.Add(new Employee("Justin",30000,"Instructor"));
list.Add(new Employee("Josh", 30000, "Instructor assistant"));
foreach(Employee e in list)
{
    Console.WriteLine($"{e.Name} is a {e.Position} and makes ${e.Salary}");

}