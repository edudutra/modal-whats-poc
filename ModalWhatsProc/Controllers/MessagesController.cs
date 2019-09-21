using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModalWhatsProc.Models;
using ModalWhatsProc.Wavy.Model;
using Newtonsoft.Json;

namespace ModalWhatsProc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly ILogger<MessagesController> _logger;
        private readonly Message[] _messages;

        public MessagesController(ILogger<MessagesController> logger)
        {
            _logger = logger;

            _messages = new Message[] {
                new Message() {
                    PhoneNumber = "5511947811895",
                    Name = "Eduardo Dutra",
                    When = DateTime.Now,
                    MessageText = "Olá",
                    Direction = Direction.In
                },
                new Message() {
                    PhoneNumber = "5511947811895",
                    Name = "Eduardo Dutra",
                    When = DateTime.Now,
                    MessageText = "Hello You",
                    Direction = Direction.Out
                }
            };
        }
        // GET: api/Messages
        [HttpGet]
        public IEnumerable<Message> Get()
        {
            return _messages;
        }

        // GET: api/Messages/out
        [HttpGet("{direction}", Name = "Get")]
        public IEnumerable<Message> Get(Direction direction)
        {
            return _messages.Where(m => m.Direction == direction);
        }

        // POST: api/Messages/in/whatsapp
        [HttpPost("in/whatsapp")]
        public void Post([FromBody] WhatsAppMessages messages)
        {
            _logger.LogDebug(JsonConvert.SerializeObject(messages));
        }

        // POST: api/Messages/out
        [HttpPost("out")]
        public void Post(Channel channel, [FromBody] Message message)
        {
            _logger.LogTrace(JsonConvert.SerializeObject(message));
        }
    }
}
