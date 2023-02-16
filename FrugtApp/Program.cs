// See https://aka.ms/new-console-template for more information
using FrugtLib.generic;
using FrugtLib.model;

Console.WriteLine("Hello, World!");

Frugt banan = new Frugt(4, "Banan", 5.50);
Frugt æble = new Frugt(6, "Æble", 3.50);

Console.WriteLine(banan);
Console.WriteLine(æble);

/*
 * Prøver Frugt Repository
 */
IFrugtRepository repository = new FrugtRepository();
repository.Create(banan);
repository.Create(æble);


Console.WriteLine("===== Udskriv Alle =====");
foreach (Frugt frugt in repository.GetAll())
{
    Console.WriteLine(frugt);
}

Console.WriteLine("===== Update Æble =====");
Frugt æble2 = new Frugt(6, "Æble", 1.50);
repository.Update(6, æble2);
Console.WriteLine(repository.GetById(6));

Console.WriteLine("===== Sletter Æble =====");
Frugt f = repository.Delete(6);
Console.WriteLine(f);

try
{
    Frugt frugt = repository.Delete(6);
}
catch(KeyNotFoundException knfe)
{
    Console.WriteLine(knfe.Message);
}


/*
 * Prøver Frugt Repository med Generic interface
 */
IRepositoryGeneric<Frugt> repositoryGenericInterface = new FrugtRepositoryUsingGenericInterface();
repositoryGenericInterface.Create(banan);
repositoryGenericInterface.Create(æble);


Console.WriteLine("===== Udskriv Alle =====");
foreach (Frugt frugt in repositoryGenericInterface.GetAll())
{
    Console.WriteLine(frugt);
}

Console.WriteLine("===== Update Æble =====");
Frugt æble22 = new Frugt(6, "Æble", 1.50);
repositoryGenericInterface.Update(6, æble2);
Console.WriteLine(repositoryGenericInterface.GetById(6));

Console.WriteLine("===== Sletter Æble =====");
Frugt f2 = repositoryGenericInterface.Delete(6);
Console.WriteLine(f2);

try
{
    Frugt frugt = repositoryGenericInterface.Delete(6);
}
catch (KeyNotFoundException knfe)
{
    Console.WriteLine(knfe.Message);
}