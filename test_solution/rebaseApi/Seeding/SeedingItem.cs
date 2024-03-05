using rebaseApi.Models;

namespace rebaseApi.Seeding
{
    public class SeedingItem
    {
        public IEnumerable<Item> ReturnItems()
        {
            yield return new Item { Id = 1, Name = "Name1", Email = "email1@fake.com" };
            yield return new Item { Id = 2, Name = "Name2", Email = "email2@fake.com" };
            yield return new Item { Id = 3, Name = "Name3", Email = "email3@fake.com" };
            yield return new Item { Id = 4, Name = "Name4", Email = "email4@fake.com" };
            yield return new Item { Id = 5, Name = "Name5", Email = "email5@fake.com" };
            yield return new Item { Id = 6, Name = "Name6", Email = "email6@fake.com" };
            yield return new Item { Id = 7, Name = "Name7", Email = "email7@fake.com" };
            yield return new Item { Id = 8, Name = "Name8", Email = "email8@fake.com" };
            yield return new Item { Id = 9, Name = "Name9", Email = "email9@fake.com" };
            yield return new Item { Id = 10, Name = "Name10", Email = "email10@fake.com" };
            yield return new Item { Id = 11, Name = "Name11", Email = "email11@fake.com" };
            yield return new Item { Id = 13, Name = "Name13", Email = "email13@fake.com" };
        }
    }
}
