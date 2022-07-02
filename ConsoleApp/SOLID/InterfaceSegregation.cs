using System;

interface IStuffMemberBad
{
    void DoWork();
    void PayMoney();
    void ReceiveSalary();
    (DateTime, DateTime) WorkingHours();
    IStuffMemberBad[] ManagedPersonal();
}

interface IStuff
{
    void DoWork();
    (DateTime, DateTime) WorkingHours();
}

interface IManager : IStuff
{
    IStuffMemberBad[] ManagedPersonal();
}

interface IFinanceStuff : IStuff
{
    void PayMoney();
}

interface IPaidPerson
{
    void ReceiveSalary();
}