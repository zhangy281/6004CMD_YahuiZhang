using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyMauiApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string name;
        private string result;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public string Result
        {
            get => result;
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }

        public void SayHello()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Result = $"Hello, {Name}!";
            }
            else
            {
                Result = "Please enter your name";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
