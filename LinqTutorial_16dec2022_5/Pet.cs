using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial_16dec2022_5;

public enum PetType
{
    Dog,
    Cat,
    Fish
}
internal class Pet
{
    public Pet(int id, string name, PetType type, float number)
    {
        Id = id;
        Name = name;
        Type = type;
        Number = number;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public PetType Type { get; set; }
    public float Number { get; set; }
}
