using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options) : IdentityDbContext<Monolith.Schedule.Data.MyUser>(options)
{
}
