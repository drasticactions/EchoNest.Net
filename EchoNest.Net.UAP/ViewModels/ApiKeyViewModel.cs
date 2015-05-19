using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.UAP.Commands.Navigation;
using EchoNest.Net.UAP.Common;

namespace EchoNest.Net.UAP.ViewModels
{
    public class ApiKeyViewModel : NotifierBase
    {
        public ApiKeyViewModel()
        {
            ClickApiKeyButtonCommand = new AsyncDelegateCommand(async o => { await ClickApiKeyButton(); },
                o => CanClickApiKeyButton);
        }

        private string _apiKey;

        public string ApiKey
        {
            get { return _apiKey; }
            set
            {
                if (_apiKey == value) return;
                _apiKey = value;
                OnPropertyChanged();
                ClickApiKeyButtonCommand.RaiseCanExecuteChanged();
            }
        }

        public bool CanClickApiKeyButton => !string.IsNullOrWhiteSpace(ApiKey);

        public AsyncDelegateCommand ClickApiKeyButtonCommand { get; private set; }

        public event EventHandler<EventArgs> ApiKeySuccessful;

        public NavigateToMainPage NavigateToMainPage { get; set; } = new NavigateToMainPage();

        public async Task ClickApiKeyButton()
        {
            // TODO: Check if API Key is valid first before letting them continue.
            Locator.ViewModels.MainPageVm.ApiKey = ApiKey;
            NavigateToMainPage.Execute(null);
        }
    }
}
