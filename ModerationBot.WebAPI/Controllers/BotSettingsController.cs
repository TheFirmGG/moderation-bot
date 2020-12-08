using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheFirmGG.EntityFramework;
using TheFirmGG.EntityFramework.Models;

namespace ModerationBot.WebAPI.Controllers
{
    [Route("settings")]
    public class BotSettingsController : ControllerBase
    {
        private readonly ILogger<BotSettingsController> _logger;

        private readonly ModerationBotContext _dbContext;
        
        public BotSettingsController(ILogger<BotSettingsController> logger, ModerationBotContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<BotSetting> Get()
        {
            return _dbContext.Settings;
        }
    }
}