﻿using Azure.AI.OpenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YodaApp.Services.Interface
{
    public interface IAiAssistant
    {
        //Task<ChatMessage> GetCompletion();
        Task<ChatMessage> GetFunFact();
    }
}

