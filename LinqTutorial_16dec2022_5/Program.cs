namespace LinqTutorial_16dec2022_5;
//Any()

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] { 5, 9, 2, 12, 6 };
        bool isAnyLargerThan10 = numbers.Any(number => number > 10);
        if (isAnyLargerThan10 == true)
        {
            Console.WriteLine("There's a number larger than 10!");
        }
        else Console.WriteLine("No numbers larger than 10.");


        var pets = new[]
        {
            new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            new Pet(2, "Anthony", PetType.Cat, 1.1f),
            new Pet(3, "Ed", PetType.Cat, 1.1f),
            new Pet(4, "Taiga", PetType.Dog, 1.1f),
            new Pet(5, "Rex", PetType.Dog, 1.1f),
            new Pet(6, "Lucky", PetType.Dog, 1.1f),
            new Pet(7, "Storm", PetType.Cat, 1.1f),
            new Pet(8, "Nyan", PetType.Cat, 1.1f)
        };

        var isAnyPetNamedBruce = pets.Any(pet => pet.Name == "Bruce");
        Console.WriteLine(isAnyPetNamedBruce);

        var isAnyPetAfish = pets.Any(pet => pet.Type == PetType.Fish);
        Console.WriteLine(isAnyPetAfish);

        var isThereAVerySpecificPet = pets.Any(pet => pet.Type == PetType.Dog && pet.Name == "Lucky" && pet.Id % 2 == 0 && pet.Name.Length < 6);
        Console.WriteLine(isThereAVerySpecificPet);

        var isNotEmpty = pets.Any(); /*This returns true if a collection has elements and returns false if the collection is empty.*/

    }
}