using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chorelistt.Models;

public class Chore
{
    public Chore(string name, int amount, bool done)
    {
        Name = name; 
        Amount = amount;
        Done = false;
    }

    public string Name { get; set; }
    public int Amount { get; set; }
    public bool Done { get; set; }
}