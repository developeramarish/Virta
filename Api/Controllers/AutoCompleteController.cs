﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VirtaApi.Data.Interfaces;
using VirtaApi.DTO;
using VirtaApi.Models;

namespace VirtaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutoCompleteController : ControllerBase
    {
        private readonly ILogger<MainController> _logger;
        private readonly IMapper _mapper;
        private readonly ICategoriesRepository _categoriesRepository;

        public AutoCompleteController(
            ILogger<MainController> logger,
            IMapper mapper,
            ICategoriesRepository categoriesRepository
        )
        {
            _categoriesRepository = categoriesRepository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("True");
        }

        [HttpGet("categories/{category}")]
        public async Task<IActionResult> Get(string category)
        {
            var categories = await _categoriesRepository.GetCategoriesAC(category);

            var response = _mapper.Map<List<CategoryDTO>>(categories);

            return Ok(response);
        }
    }
}