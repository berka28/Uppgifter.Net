﻿using Newtonsoft.Json;
using SharedClassLibrary.Helpers;
using SharedClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Uppgift_1.Net
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private PersonViewModel personViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            personViewModel = new PersonViewModel();
            PopulatePersonViewModel("file.json").GetAwaiter();
        }

        public async Task PopulatePersonViewModel(string fileName)
        {
            var persons = JsonConvert.DeserializeObject<ObservableCollection<Person>>(await FileHelper.GetFileContentAsync(fileName));
        
            foreach (var person in persons)
            {
                personViewModel.Persons.Add(person);
            }
        }


    }
}