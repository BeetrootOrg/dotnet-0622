using System;

namespace LinqLesson
{
	public enum Gender
	{
		Male,
		Female
	}

	public record Friend
	{
		public int Id { get; init; }
		public string Name { get; init; }
	}

	public record Person
	{
		public string Id { get; init; }
		public int Index { get; init; }
		public Guid Guid { get; init; }
		public bool IsActive { get; init; }
		public string Balance { get; init; }
		public int Age { get; init; }
		public string EyeColor { get; init; }
		public string Name { get; init; }
		public Gender Gender { get; init; }
		public string Company { get; init; }
		public string Email { get; init; }
		public string Phone { get; init; }
		public string Address { get; init; }
		public string About { get; init; }
		public DateTime Registered { get; init; }
		public double Latitude { get; init; }
		public double Longitude { get; init; }
		public string[] Tags { get; init; }
		public Friend[] Friends { get; init; }
	}
}
