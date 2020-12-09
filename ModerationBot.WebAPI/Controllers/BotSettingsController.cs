using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheFirmGG.ModerationBot.Core.Models;
using TheFirmGG.ModerationBot.Core.Services;

namespace TheFirmGG.ModerationBot.WebAPI.Controllers
{
    [Route("settings")]
    public class BotSettingsController : ControllerBase
    {
        private readonly ILogger<BotSettingsController> _logger;
        private readonly IBotSettingsService _botSettingsService;

        public BotSettingsController(ILogger<BotSettingsController> logger, IBotSettingsService botSettingsService)
        {
            _logger = logger;
            _botSettingsService = botSettingsService;
        }

        [HttpGet]
        public IEnumerable<BotSetting> Get()
        {
            return _botSettingsService.GetSettings();
        }

        [HttpPost]
        public BotSetting Create(BotSetting newSetting)
        {
            var result = _botSettingsService.CreateSetting(newSetting);
            return result;
        }
    }
}