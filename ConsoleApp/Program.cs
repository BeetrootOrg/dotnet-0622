
using System.Collections.Generic;

static List<int> FindMultiples(int integer, int limit)
  { 
    var list = new List<int>();
    var i = integer;
    do {
        list.Add(i);
        i += integer;
    } while (integer <= limit);

    return list;
  }

 FindMultiples(5, 15);