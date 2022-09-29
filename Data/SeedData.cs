namespace ShopOnline.Data;

public static class SeedData
{
    public static void Initialize(CakeFactoryContext db)
    {
        var caketypes = new CakeTypes[]
        {
            new CakeTypes()
            {
                CakeName = "Chocolate Cake",
                Price = 49.99m,
                Description = "Why wouldn't you want one? It's chocolate cake!",
                Image = "img/cakes/chocolateCake.jpg",
            },
            new CakeTypes()
            {
                CakeName = "Cheesecake",
                Price = 49.99m,
                Description = "Deliciously rich and creamy.",
                Image = "img/cakes/cheesecake.jpg",
            },
            new CakeTypes()
            {
                CakeName = "Apple Pie",
                Price = 39.99m,
                Description = "Mmmmm... Tarty :P",
                Image = "img/cakes/applePie.jpg",
            },
            new CakeTypes()
            {
                CakeName = "Donuts(x6)",
                Price = 19.99m,
                Description = "I'm mean... who doesn't love donuts?",
                Image = "img/cakes/donuts.jpg",
            },
            new CakeTypes()
            {
                CakeName = "Strawberry Cake",
                Price = 49.99m,
                Description = "Just the right ratio between strawberry and cream.",
                Image = "img/cakes/strawberryCake.jpg",
            },
            new CakeTypes()
            {
                CakeName = "Black Forest Cake",
                Price = 59.99m,
                Description = "The October Fest Tradition.",
                Image = "img/cakes/blackForestCake.jpg",
            },
        };
        db.CakeTypeses.AddRange(caketypes);
        db.SaveChanges();
    }
}