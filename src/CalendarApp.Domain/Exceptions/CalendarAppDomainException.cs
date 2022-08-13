using System;

namespace CalendarApp.Domain.Exceptions;

public class CalendarAppDomainException : Exception
{
	public CalendarAppDomainException() : base()
	{
	}

	public CalendarAppDomainException(string message) : base(message)
	{
	}

	public CalendarAppDomainException(string message, Exception innerException) : base(message, innerException)
	{
	}
}