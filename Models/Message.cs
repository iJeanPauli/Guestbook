using System.Data.Entity;

namespace Guestbook.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string theMessage { get; set; }

    }

    public class MessageDBContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}