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
IRepositoryGeneric<NyFrugt> repositoryGenericInterface = new FrugtRepositoryUsingGenericInterface();
NyFrugt nybanan = new NyFrugt(4, "Banan", 5.50);
NyFrugt nyæble = new NyFrugt(6, "Æble", 3.50);
repositoryGenericInterface.Create(nybanan);
repositoryGenericInterface.Create(nyæble);


Console.WriteLine("===== Udskriv Alle =====");
foreach (NyFrugt frugt in repositoryGenericInterface.GetAll())
{
    Console.WriteLine(frugt);
}

Console.WriteLine("===== Update Æble =====");
NyFrugt nyæble22 = new NyFrugt(6, "Æble", 1.50);
repositoryGenericInterface.Update(6, nyæble22);
Console.WriteLine(repositoryGenericInterface.GetById(6));

Console.WriteLine("===== Sletter Æble =====");
NyFrugt nyf2 = repositoryGenericInterface.Delete(6);
Console.WriteLine(nyf2);

try
{
    NyFrugt frugt = repositoryGenericInterface.Delete(6);
}
catch (KeyNotFoundException knfe)
{
    Console.WriteLine(knfe.Message);
}


/*
 * Prøver Generic Repository med NyFrugt
 */
IRepositoryGeneric<NyFrugt> genericRepo = new RepositoryGeneric<NyFrugt>();
genericRepo.Create(nybanan);
genericRepo.Create(nyæble);


Console.WriteLine("===== Udskriv Alle =====");
foreach (NyFrugt frugt in genericRepo.GetAll())
{
    Console.WriteLine(frugt);
}

Console.WriteLine("===== Update Æble =====");
nyæble22 = new NyFrugt(6, "Æble", 1.50);
genericRepo.Update(6, nyæble22);
Console.WriteLine(genericRepo.GetById(6));

Console.WriteLine("===== Sletter Æble =====");
nyf2 = genericRepo.Delete(6);
Console.WriteLine(nyf2);

try
{
    NyFrugt frugt = genericRepo.Delete(6);
}
catch (KeyNotFoundException knfe)
{
    Console.WriteLine(knfe.Message);
}