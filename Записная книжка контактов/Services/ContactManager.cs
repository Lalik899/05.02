using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; // Обязательно для работы методов LINQ (.Where, .ToList)
using System.Text.Json;
using Записная_книжка_контактов.Models;

namespace Записная_книжка_контактов.Services
{
    public class ContactManager
    {
        private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contacts.json");

        // 1. Метод сохранения списка контактов в JSON
        public void SaveContacts(List<Contact> contacts)
        {
            string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        // 2. Метод загрузки списка контактов из JSON
        public List<Contact> LoadContacts()
        {
            if (!File.Exists(_filePath)) return new List<Contact>();

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
        }

        // 3. Метод поиска контактов по имени или телефону с помощью LINQ
        public List<Contact> SearchContacts(string query)
        {
            // Загружаем актуальный список из файла
            List<Contact> allContacts = LoadContacts();

            if (string.IsNullOrWhiteSpace(query))
            {
                return allContacts; // Если строка поиска пустая, возвращаем всех
            }

            // Приводим запрос к нижнему регистру, чтобы поиск не зависел от больших/маленьких букв
            string lowerQuery = query.ToLower();

            // Фильтрация LINQ: ищем совпадения по Имени ИЛИ Телефону
            var filteredContacts = allContacts
                .Where(c => (!string.IsNullOrEmpty(c.Name) && c.Name.ToLower().Contains(lowerQuery)) ||
                            (!string.IsNullOrEmpty(c.Phone) && c.Phone.Contains(lowerQuery)))
                .ToList();

            return filteredContacts;
        }
    }
}
