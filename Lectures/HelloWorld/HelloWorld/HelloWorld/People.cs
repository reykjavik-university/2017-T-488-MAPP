using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class People
    {
        private readonly List<Person> _persons;

        public People()
        {
            this._persons = new List<Person>();
            this.LoadPersons();
        }

        public List<Person> Persons => this._persons;


        private void AddPerson(string name, int year, string imageName)
        {
            var person = new Person()
            {
                Name = name,
                BirthYear = year,
                ImageName = imageName
            };
            this._persons.Add(person);
        }

        private void LoadPersons()
        {
            this.AddPerson("Marilyn Monroe", 1926, "marilyn_monroe");
            this.AddPerson("Abraham Lincoln", 1809, "abraham_lincoln");
            this.AddPerson("John F. Kennedy", 1917, "john_kennedy");
            this.AddPerson("Martin Luther King", 1929, "martin_luther_king");
            this.AddPerson("Nelson Mandela", 1918, "nelson_mandela");
            this.AddPerson("Winston Churchill", 1874, "winston_churchill");
            this.AddPerson("Margaret Thatcher", 1925, "margaret_thatcher");
            this.AddPerson("Muhammad Ali", 1942, "muhammad_ali");
            this.AddPerson("Bill Gates", 1955, "bill_gates");
            this.AddPerson("Mother Teresa", 1910, "mother_teresa");
            this.AddPerson("Mahatma Gandhi", 1869, "mahatma_gandhi");
            this.AddPerson("Charles de Gaulle", 1890, "charles_de_gaulle");
            this.AddPerson("Christopher Columbus", 1451, "christopher_columbus");
            this.AddPerson("George Orwell", 1903, "george_orwell");
            this.AddPerson("Charles Darwin", 1809, "charles_darwin");
        }
    }
}

