using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using userServices.Services;
using userServices.Resources;
using AutoMapper;

namespace userServices.Controllers
{
    [Route("/api/[controller]")]
    public class QuestionsController : Controller
    {
        private readonly IQuestionsService _questionsService;
        private readonly IMapper _mapper;

        public QuestionsController(IQuestionsService questionsService, IMapper mapper)
        {
            _questionsService = questionsService;
            _mapper = mapper;
        }

        /*
        [HttpGet]
        public async Task<IEnumerable<QuestionsResource>> GetAllAsync()
        {
            var questions = await _questionsService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Questions>, IEnumerable<QuestionsResource>>(questions);

            return resources;
        }
        */

    }
}