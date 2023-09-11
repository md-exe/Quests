using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quests.Models
{
    class ToDoModel: INotifyPropertyChanged
    {
        // Объявление переменных
        private bool _isDone;
        private string _tasktext;
        // Время СЕЙЧАС
        public DateTime CreationDate { get; set; } = DateTime.Now;
        // Сделано
        public bool IsDone
        {
            get { return _isDone; }
            set
            {
                if (_isDone == value)
                {
                    return;
                }
                else
                {
                    _isDone = value;
                    OnPropertyChange("IsDone");
                }
                ;
            }
        }
        // Текст задачи
        public string TaskText
        {
            get { return _tasktext; }
            set
            {
                if (_tasktext == value)
                {
                    return;
                }
                else
                {
                    _tasktext = value;
                    OnPropertyChange("Task");
                }
                ;
            }
        }
        // События изменения списка
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChange(string propertyName="")
        {
            // Проверка НЕ пустоты события
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
