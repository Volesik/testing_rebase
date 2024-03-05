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
        }
    }
}
