using Azure;
using Azure.AI.OpenAI;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YodaApp.Services.Interface;

namespace YodaApp.ViewModels
{
    //[QueryProperty(nameof(Response), "Response")]
    public partial class YodaAnswerViewModel : BaseViewModel
    {
        private ChatMessage _answerResponseModel;

        public ChatMessage Response
        {
            get { return _answerResponseModel; }
            set
            {
                _answerResponseModel = value;
                OnPropertyChanged();
            }
        }

        private IAiAssistant _helper;

        public YodaAnswerViewModel(IAiAssistant helper)
        {
            _helper = helper;
        }

        [RelayCommand]
        public async void GetResponses()
        {
            Response = await _helper.GetFunFact();
        }
    }
}
