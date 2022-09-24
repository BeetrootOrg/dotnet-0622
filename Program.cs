using PatternsTest.Composite;

CompositeValidator validator = new(
	new IValidator[]
	{
		new NotNullValidator(),
		new NotEmptyValidator(),
		new HasSymbolValidator('a')
	}
);

string str = "abcd";
if (validator.IsValid(str))
{
	System.Console.WriteLine("Valid");
}
