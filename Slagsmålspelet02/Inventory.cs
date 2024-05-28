public class Inventory<T>
{
    // Lista för att hålla alla objekt av typ T
    private List<T> items;

    // Konstruktor som initierar listan
    public Inventory()
    {
        items = new List<T>();
    }

    // Metod för att lägga till ett objekt i listan
    public void AddItem(T item)
    {
        items.Add(item);
    }

    // Metod för att ta bort ett objekt från listan
    public bool RemoveItem(T item)
    {
        return items.Remove(item);
    }

    // Metod för att skriva ut alla objekt i listan
    public void ListItems()
    {
        Console.WriteLine("Inventarielista:");
        foreach (var item in items)
        {
            // Anropa ToString() på varje objekt för att få dess textrepresentation
            Console.WriteLine(item.ToString());
        }
    }
}
