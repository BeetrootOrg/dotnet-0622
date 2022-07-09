using System.Collections.Generic;
namespace ConsoleApp.Shop;

class Group
{
    private List<Group> _children { get; set; }
    private List<Goods> _goods { get; set; }
}