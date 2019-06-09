using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using BLL.Repositories;

namespace userServices.Services
{
    public class QuestionsService :IQuestionsService
    {
        private readonly IQuestionsRepository _questionsRepository;

        public QuestionsService(IQuestionsRepository questionsRepository)
        {
            this._questionsRepository = questionsRepository;
        }
            
        public async Task<IEnumerable<Questions>> ListAsync()
        {
            return await _questionsRepository.ListAsync();
        }

    }
}
