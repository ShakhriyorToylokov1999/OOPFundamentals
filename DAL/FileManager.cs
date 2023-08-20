using OOPFundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OOPFundamentals.DAL
{
    internal class FileManager
    {
        private readonly string _basePath;

        public FileManager(string basePath)
        {
            _basePath = basePath;
        }

        public void WriteCard<T>(string number, T document) where T : IDocument
        {
            var filePath = Path.Combine(_basePath, $"{typeof(T).Name}_{number}.json");
            var json = JsonSerializer.Serialize(document);
            File.WriteAllText(filePath, json);
        }

        public T ReadCard<T>(string number) where T : IDocument
        {
            var filePath = Path.Combine(_basePath, $"{typeof(T).Name}_{number}.json");
            if (!File.Exists(filePath))
            {
                return default;
            }

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
