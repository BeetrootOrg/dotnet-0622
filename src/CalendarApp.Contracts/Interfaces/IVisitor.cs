namespace CalendarApp.Contracts.Interfaces;

public interface IVisitor<in T>
{
	void Visit(T model);
}