using System;
using StrategyTest.Helper;
using StrategyTest.Operation;

Console.WriteLine("Please write your meth operation:");
string input = Console.ReadLine();
Arguments arguments = ArgumentsParser.ToArguments(input);
IOperation operation = OperationsFactory.CreateOperation(arguments.Operator);
int result = operation.Execute(arguments.Number1, arguments.Number2);
Console.WriteLine($"Result is {result}");
