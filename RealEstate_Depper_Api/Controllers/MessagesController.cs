﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Depper_Api.Repositories.MessageRepositories;

namespace RealEstate_Depper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;
        public MessagesController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetInBoxLast3MessageListByReceiver(int id)
        {
            var values = await _messageRepository.GetInBoxLast3MessageListByReceiver(id);
            return Ok(values);
        }

    }
}
