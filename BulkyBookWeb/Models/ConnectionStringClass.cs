using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Models
{
    public class ConnectionStringClass:DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options): base (options)
        {

        }
    }
}
