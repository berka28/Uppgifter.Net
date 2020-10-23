using Newtonsoft.Json;
using SharedClassLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClassLibrary.Models
{
    public class Person
    {
        public Person()
        {

        }

        public Person(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }
        [JsonProperty(propertyName:"firstName")]
        public string FirstName { get; set; }
        [JsonProperty(propertyName: "lastName")]
        public string LastName { get; set; }
        [JsonProperty(propertyName: "age")]
        public int Age { get; set; }
        [JsonProperty(propertyName: "city")]
        public string City { get; set; }
    }

    public class PersonViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public PersonViewModel()
        {
            Persons = new ObservableCollection<Person>();
        }
    }
}
