using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ACCEA_POS.ViewModels
{
    public class MainVM : INotifyPropertyChanged
    {
        private LanguageInfo _selectedLanguage;
        private string _greeting;
        private readonly ResourceManager _resourceManager;

        public MainVM()
        {
            AvailableLanguages = new List<LanguageInfo>
            {
                new LanguageInfo("en-US", "English"),
                new LanguageInfo("fr-FR", "French"),
                // Add more languages as needed
            };

            SelectedLanguage = AvailableLanguages[0]; // Set default language
            _resourceManager = new ResourceManager("LanguageSwitchingApp.Strings", typeof(MainVM).Assembly);
            UpdateLanguage();
        }

        public List<LanguageInfo> AvailableLanguages { get; }

        public LanguageInfo SelectedLanguage
        {
            get => _selectedLanguage;
            set
            {
                if (_selectedLanguage != value)
                {
                    _selectedLanguage = value;
                    UpdateLanguage();
                }
            }
        }

        public string Greeting
        {
            get => _greeting;
            set
            {
                if (_greeting != value)
                {
                    _greeting = value;
                    OnPropertyChanged();
                }
            }
        }

        private void UpdateLanguage()
        {
            var culture = CultureInfo.GetCultureInfo(SelectedLanguage.CultureCode);
            Greeting = _resourceManager.GetString("Greeting", culture);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class LanguageInfo
    {
        public LanguageInfo(string cultureCode, string displayName)
        {
            CultureCode = cultureCode;
            DisplayName = displayName;
        }

        public string CultureCode { get; }
        public string DisplayName { get; }
    }
}
