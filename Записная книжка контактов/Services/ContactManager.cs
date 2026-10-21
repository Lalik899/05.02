
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; // Используем современный и стандартный сериализатор
using Записная_книжка_контактов.Models;

namespace ContactBookApp.Services
{
    public class ContactManager
    {
        private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contacts.json");

        public void SaveContacts(List<Contact> contacts)
        {
            // Сериализуем список в JSON-строку
            string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        public List<Contact> LoadContacts()
        {
            if (!File.Exists(_filePath)) return new List<Contact>();

            string json = File.ReadAllText(_filePath);
            // Десериализуем обратно в список
            return JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
        }
    }
}
