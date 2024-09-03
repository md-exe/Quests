using Quests.Models;
using Quests.Services;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Quests
{
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\ToDoData.json";
        private BindingList<ToDoModel> _toDoData;
        private IOService _ioService;
        public MainWindow()
        {
            InitializeComponent();
        }

        // Закрыть программу
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Возможность двигать имитацию окна
        private void ToolbarPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                base.OnMouseLeftButtonDown(e);
                DragMove();
            }
        }
        // Черная "Х" при наведении на кнопку закрытия
        private void CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            CloseLabel.Foreground = Brushes.Black;
            Cursor = Cursors.Hand;
        }
        // Белая "Х" при отведении с кнопки закрытия
        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            CloseLabel.Foreground = Brushes.White;
            Cursor = Cursors.Arrow;
        }
        // Сворачивание окна
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            Form.WindowState = WindowState.Minimized;
        }
        // Черный "-" при наведении на кнопку сворачивания
        private void MinimizeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            MinimizeLabel.Foreground = Brushes.Black;
            Cursor = Cursors.Hand;
        }
        // Белая "-" при отведении с кнопки сворачивания
        private void MinimizeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            MinimizeLabel.Foreground = Brushes.White;
            Cursor = Cursors.Arrow;
        }
        // Подгрузка данных списка
        private void Form_Loaded(object sender, RoutedEventArgs e)
        {
            // Получение данных из файла
            _ioService = new IOService(PATH);
            // Загрузка данных из файла
            // Если успешно
            try
            {
                _toDoData = _ioService.LoadData();
            }
            // Исключение
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            // Отображение списка в DataGrid
            ToDoList.ItemsSource = _toDoData;
            // Функция при изменении списка
            _toDoData.ListChanged += _toDoData_ListChanged;
        }
        // Проверка изменений списка
        private void _toDoData_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                // Если успешно
                try
                {
                    _ioService.SaveData(sender);
                }
                // Исключение
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }
    }
}
