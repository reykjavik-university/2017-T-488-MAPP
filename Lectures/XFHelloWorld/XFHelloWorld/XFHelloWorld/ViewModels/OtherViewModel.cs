using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFHelloWorld.ViewModels 
{
    public class OtherViewModel : INotifyPropertyChanged
    {
        private string _taskText;

        public OtherViewModel()
        {
            this.TaskText = "Before running tasks";
            this.TaskCommand = new Command(StartTasks);
        }

        public ICommand TaskCommand { get; set; }

        public string TaskText
        {
            get => this._taskText;
            set
            {
                this._taskText = value;
                OnPropertyChanged();
            }
        }

        private void StartTasks()
        {
            this.FirstTask();
            this.SecondTask();
            this.TaskText = "After starting tasks";
        }

        private async Task FirstTask()
        {
            await Task.Run(async () =>
            {
                await Task.Delay(3000);
            });

            this.TaskText = "First task finished";
        }

        private async Task SecondTask()
        {
            await Task.Run(async () =>
            {
                await Task.Delay(6000);
            });

            this.TaskText = "Second task finished";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
