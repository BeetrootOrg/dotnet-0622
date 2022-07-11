﻿using System;
using System.Threading;

using ConsoleApp;

using static System.Console;

OnChangeHandler onChange = () => WriteLine("Property changed");
var testClass = new TestClass(onChange);

testClass.Number = 42;
testClass.Text = "text";

void OnCounterChangeHandler(Counter counter, int oldValue, int newValue)
{
    WriteLine($"Counter value changed from {oldValue} to {newValue}");
}

void AnotherOnCounterChangeHandler(Counter counter, int oldValue, int newValue)
{
    WriteLine($"Counter value raised/decreased from {oldValue} to {newValue}");
}

var counter1 = new Counter();
var counter2 = new Counter();

counter1.OnCounterChanged += OnCounterChangeHandler;
counter1.OnCounterChanged += AnotherOnCounterChangeHandler;

counter2.OnCounterChanged += OnCounterChangeHandler;

counter1.Increment();
counter2.Increment();
counter2.Decrement();

counter1.OnCounterChanged -= AnotherOnCounterChangeHandler;
counter1.Increment();

void TimerCallback(object state)
{
    var counter = (Counter)state;
    counter.Increment();
    WriteLine($"Timer tick {counter.Count}");
}

var timer = new Timer(TimerCallback, new Counter(), TimeSpan.Zero, TimeSpan.FromSeconds(1));

Thread.Sleep(10000);
