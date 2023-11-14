namespace CollectionsTest
{
	class Person
	{
		public int Id { get; set; }
		public string? Name { get; set; }

		public override bool Equals(object? obj)
		{
			Person? p = obj as Person;

			if (p != null)
			{
				return Id == p.Id && Name == p.Name;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode() ^ (Name?.GetHashCode() ?? 0);  // XOR
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			// create HashSet of Persons with initial values
			var persons = new HashSet<Person>
			{
				new Person { Id = 1, Name = "Joe" },
				new Person { Id = 2, Name = "Mary" },
				new Person { Id = 3, Name = "Sue" }
			};

			Person person = new Person() { Id = 3, Name = "Sue" };

			// check if HashSet contains person
			if (persons.Contains(person))
			{
				System.Console.WriteLine("Person found");
			}
			else
			{
				System.Console.WriteLine("Person not found");
			}
		}
	}
}