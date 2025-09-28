using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Task_4_1
{
    internal class ToggleButton : Button
    {
        // Регистрируем DependencyProperty
        public static readonly DependencyProperty IsToggledProperty =
            DependencyProperty.Register(
                "IsToggled",
                typeof(bool),
                typeof(ToggleButton),
                new PropertyMetadata(false, OnIsToggledChanged));

        // Обычное свойство для доступа к DP
        public bool IsToggled
        {
            get { return (bool)GetValue(IsToggledProperty); }
            set { SetValue(IsToggledProperty, value); }
        }
        public event EventHandler<bool> IsToggledChanged;
        // Конструктор
        public ToggleButton()
        {
            // Инициализируем состояние
            UpdateVisualState();

            // Обработчик клика
            Click += (sender, e) => IsToggled = !IsToggled;
        }

        // Обработчик изменения состояния
        private static void OnIsToggledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ToggleButton button)
            {
                button.UpdateVisualState();
                button.IsToggledChanged?.Invoke(button, (bool)e.NewValue);
            }
        }

        // Обновляем визуальное состояние
        private void UpdateVisualState()
        {
            if (IsToggled)
            {
                Background = Brushes.Green;
                Content = "ON";
            }
            else
            {
                Background = Brushes.Red;
                Content = "OFF";
            }
        }
    }
}



