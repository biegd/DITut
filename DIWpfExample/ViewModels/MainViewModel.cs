using System.ComponentModel;
using System.Windows.Input;

public class MainViewModel : INotifyPropertyChanged
{
    private readonly IGreetingService _greetingService;

    public MainViewModel(IGreetingService greetingService)
    {
        _greetingService = greetingService;
        GreetCommand = new RelayCommand(() => Greeting = _greetingService.GetGreeting(Name));
    }

    //public string Name { get; set; }
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }


    private string _greeting;
    public string Greeting
    {
        get => _greeting;
        set
        {
            _greeting = value;
            OnPropertyChanged(nameof(Greeting));
        }
    }

    public ICommand GreetCommand { get; }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
