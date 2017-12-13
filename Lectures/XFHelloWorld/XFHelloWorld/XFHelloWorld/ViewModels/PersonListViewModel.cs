using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using XFHelloWorld.Model;
using XFHelloWorld.Pages;

namespace XFHelloWorld.ViewModels
{
    public class PersonListViewModel : INotifyPropertyChanged
    {
        private INavigation _navigation;
        private Person _selectedPerson;
        private List<Person> _personList;

        public PersonListViewModel(INavigation navigation, List<Person> personList)
        {
            this._navigation = navigation;
            this._personList = personList;
        }

        public List<Person> Persons
        {
            get => this._personList;

            set
            {
                this._personList = value; 
                OnPropertyChanged();
            }
        }

        public Person SelectedPerson
        {
            get => this._selectedPerson;

            set {
                if (value != null)
                {
                    this._selectedPerson = value;
                    this._navigation.PushAsync(new PersonPage(this._selectedPerson), true);
                } 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
