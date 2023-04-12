using _2_generics;

Pessoa pessoa = new Pessoa
{
    Id = 1,
    Nome = "fulano"
};
Animal animal = new Animal
{
    Id = 1,
    Especie = "cachorro"
};

RepositorioGenerico<Pessoa> repositorioPessoa = new RepositorioGenerico<Pessoa>();
RepositorioGenerico<Animal> repositorioAnimal = new RepositorioGenerico<Animal>();

repositorioPessoa.Insert(pessoa);
repositorioAnimal.Insert(animal);

foreach (Pessoa p in repositorioPessoa.Get())
{
    Console.WriteLine($"nome da pessoa: {p.Nome}");
}
foreach (Animal a in repositorioAnimal.Get())
{
    Console.WriteLine($"especie do animal: {a.Especie}");
}