using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_TEST_9
{
    public class CustomCommands
    {
        public static RoutedUICommand ChangeColor { get; private set; }

        static CustomCommands()
        {
            ChangeColor = new RoutedUICommand(
                text: "Изменить цвет",
                name: "ChangeColor",
                ownerType: typeof(CustomCommands),
                inputGestures: new InputGestureCollection { new KeyGesture(Key.C, ModifierKeys.Control) }
            );
        }
    }
}
