namespace ApiAnimais.Models;

public class Animal
{
    public Animal()
    {
        this.Id = Guid.NewGuid();
    }
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
}