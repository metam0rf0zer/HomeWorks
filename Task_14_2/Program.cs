namespace Task_14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var homeSystem = new SmartHomeSystem();

            // Подписываемся на событие
            homeSystem.DeviceStateChanged += LogDeviceStateChange;

            // Вызываем действия
            homeSystem.TurnOnLight();
            homeSystem.SetTemperature(23);
            homeSystem.LockDoor();
            homeSystem.TurnOffLight();
            homeSystem.UnlockDoor();
            homeSystem.SetTemperature(19);
        }

        // Обработчик события — выводит информацию в формате лога
        private static void LogDeviceStateChange(object sender, DeviceStateChangedEventArgs e)
        {
            string time = e.Timestamp.ToString("HH:mm:ss");
            Console.WriteLine($"[{time}] {e.DeviceType}: {e.NewState}");
        }

    }

}
public class DeviceStateChangedEventArgs : EventArgs
{
    public string DeviceType { get; }
    public string NewState { get; }
    public DateTime Timestamp { get; }

    public DeviceStateChangedEventArgs(string deviceType, string newState)
    {
        DeviceType = deviceType;
        NewState = newState;
        Timestamp = DateTime.Now;
    }
}


public class SmartHomeSystem
{
    
    public event EventHandler<DeviceStateChangedEventArgs> DeviceStateChanged;

    
    protected virtual void OnDeviceStateChanged(string deviceType, string newState)
    {
        DeviceStateChanged?.Invoke(this, new DeviceStateChangedEventArgs(deviceType, newState));
    }

    
    public void TurnOnLight()
    {
        OnDeviceStateChanged("Light", "Включен");
    }

    public void TurnOffLight()
    {
        OnDeviceStateChanged("Light", "Выключен");
    }

    
    public void SetTemperature(int newTemp)
    {
        OnDeviceStateChanged("Thermostat", $"Температура изменена на {newTemp}°C");
    }

    
    public void LockDoor()
    {
        OnDeviceStateChanged("Door", "Заблокирована");
    }

    public void UnlockDoor()
    {
        OnDeviceStateChanged("Door", "Разблокирована");
    }


}


