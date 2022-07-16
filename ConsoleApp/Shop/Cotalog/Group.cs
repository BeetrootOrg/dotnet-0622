namespace ConsoleApp.Shop;
using System.Collections.Generic;

class Group
{
    private List<Group> _children { get; set; }
    private List<Goods> _goods { get; set; }
}