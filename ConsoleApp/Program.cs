using ConsoleApp;

using static System.Console;

OnChangeHandler onChange = () => WriteLine("Property changed");
var testClass = new TestClass(onChange);

testClass.Number = 42;
testClass.Text = "text";