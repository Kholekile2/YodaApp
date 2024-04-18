using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YodaApp.Configuration
{
    public class ConstantSetting : ISetting
    {
        public string AzureOpenAiEndPoint { get => "https://loadsheddingkmpopenai.openai.azure.com/"; }
        public string AzureOpenAiKey { get => "a1a1d0ab107d440d8179a54da45160e6"; }
    }
}
