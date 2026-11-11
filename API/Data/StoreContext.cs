using Microsoft.EntityFrameworkCore;

namespace API;

public class StoreContext(DbContextOptions<StoreContext> options) : DbContext(options)
{
    public required DbSet<Product> Products { get; set; }
    
    

}
