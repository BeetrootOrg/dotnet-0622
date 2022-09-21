using System;
using System.Collections.Generic;

namespace StrategyTest.Operation
{
	public class OperationsFactory
	{
		private static readonly IDictionary<char, IOperation> _operations = new Dictionary<char, IOperation>
		{
			['+'] = new Add(),
			['-'] = new Subtract(),
			['*'] = new Mul(),
			['/'] = new Divide()
		};

		public static IOperation CreateOperation(char operation)
		{
			return _operations.TryGetValue(operation, out IOperation strategy)
				? strategy
				: throw new ArgumentOutOfRangeException(nameof(operation));
		}
	}
}