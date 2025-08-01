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
    public class ToggleColorButton : Button
    {
        //1. регистрируем DependencyProperty
        public static readonly DependencyProperty IsToggledProperty =
            DependencyProperty.Register(
                nameof(IsToggled),
                typeof(bool),
                typeof(ToggleColorButton),
                new FrameworkPropertyMetadata(false, OnIsToggledChanged));

        public bool IsToggled
        {
            get => (bool)GetValue(IsToggledProperty);
            set => SetValue(IsToggledProperty, value);
        }

        // Статический конструктор для установки стиля по умолчанию
        static ToggleColorButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(ToggleColorButton),
                new FrameworkPropertyMetadata(typeof(ToggleColorButton)));
        }
        // Вызывается при изменении IsToggled
        private static void OnIsToggledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = (ToggleColorButton)d;
            button.UpdateAppearance();
        }

        // Обновляет цвет и текст
        private void UpdateAppearance()
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
    


