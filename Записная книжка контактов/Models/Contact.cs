using System;

namespace Записная_книжка_контактов.Models
{
    public class Contact
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Category { get; set; } // Семья, Работа, Друзья
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
