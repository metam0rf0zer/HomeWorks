using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF_Task_9_1
{
    internal class CustomCommands
    {
        public static RoutedUICommand ChangeColor {  get; set; }

        static CustomCommands()
        {
            InputGestureCollection inputGestureCollection = new InputGestureCollection();
            inputGestureCollection.Add(new KeyGesture(Key.C, ModifierKeys.Control));
            ChangeColor = new RoutedUICommand("ChangeColor","Изменить цвет",typeof(CustomCommands),inputGestureCollection);
            
        }
    }
}
