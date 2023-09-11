using Newtonsoft.Json;
using Quests.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quests.Services
{
    class IOService
    {
        // Объявление переменной пути
        private readonly string PATH;
        public IOService(string path)
        {
            PATH = path;
        }
        // Загрузка данных из файла
        public BindingList<ToDoModel> LoadData()
        {
            // Проверка наличия файла
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<ToDoModel>();
            }
            // Открытие файла
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<ToDoModel>>(fileText);
            }
        }
        // Сохранение списка
        public void SaveData(object toDoData)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(toDoData);
                writer.WriteLine(output);
                writer.Close();
            }
        }
    }
}
