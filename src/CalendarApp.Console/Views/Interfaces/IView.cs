using System;

namespace CalendarApp.Console.Views.Interfaces;

public interface IView
{
	void Clear();
	void Print(string input);
	ConsoleKey ReadKey();
	string ReadRow();
}