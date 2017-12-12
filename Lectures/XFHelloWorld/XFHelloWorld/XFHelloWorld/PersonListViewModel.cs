using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFHelloWorld.Model;

namespace XFHelloWorld
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
