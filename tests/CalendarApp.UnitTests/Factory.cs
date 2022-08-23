using System;
using Bogus;
using CalendarApp.Contracts;

namespace CalendarApp.UnitTests;

internal static class Factory
{
	public static readonly Faker<Meeting> MeetingFaker = new Faker<Meeting>()
			.RuleFor(x => x.Name, f => f.Random.Word())
			.RuleFor(x => x.Timeframe, f =>
			{
				var start = f.Date.Past();

				return new Timeframe
				{
					Start = start,
					End = start.Add(f.Date.Timespan(TimeSpan.FromHours(2)))
				};
			})
			.RuleFor(x => x.Room, f => new Room
			{
				Name = f.Random.Word()
			});

	public static readonly Faker CommonFaker = new Faker();
} 