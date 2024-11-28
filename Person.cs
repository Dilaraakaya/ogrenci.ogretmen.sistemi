using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Person : IPerson
{
    public string Name { get; set; }
    public int ID { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public abstract void DisplayInfo();
}
