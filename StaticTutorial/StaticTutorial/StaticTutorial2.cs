public class Person
{
	public Person()
	{
		addPerson();
	}

	public static int numberOfPeople { get; set; } = 0;
	public void addPerson()
	{
		numberOfPeople += 1;
	}
}

public static class StaticExample2{
	public static void Main()
    {
		Console.WriteLine(Person.numberOfPeople);

		var harry = new Person();

		Console.WriteLine(Person.numberOfPeople);

		var tom = new Person();
		Console.WriteLine(Person.numberOfPeople);

	}
}

