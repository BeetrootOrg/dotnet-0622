using System.Collections.Generic;
using System.Linq;

namespace PatternsTest.Composite
{
	public interface IValidator
	{
		bool IsValid(string str);
	}

	public class NotNullValidator : IValidator
	{
		public bool IsValid(string str)
		{
			return str != null;
		}
	}

	public class NotEmptyValidator : IValidator
	{
		public bool IsValid(string str)
		{
			return str.Length > 0;
		}
	}

	public class HasSymbolValidator : IValidator
	{
		private readonly char _symbol;

		public HasSymbolValidator(char symbol)
		{
			_symbol = symbol;
		}

		public bool IsValid(string str)
		{
			return str.Contains(_symbol);
		}
	}

	public class CompositeValidator : IValidator
	{
		private readonly IEnumerable<IValidator> _validators;

		public CompositeValidator(IEnumerable<IValidator> validators)
		{
			_validators = validators;
		}

		public bool IsValid(string str)
		{
			return _validators.All(v => v.IsValid(str));
		}
	}
}