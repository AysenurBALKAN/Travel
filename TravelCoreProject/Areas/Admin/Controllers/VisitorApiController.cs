﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Area("Admin")]
    public class VisitorApiController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public VisitorApiController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:28790/api/Visitor");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<VisitorViewModel>>(JsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddVisitor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddVisitor(VisitorViewModel p)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:28790/api/Visitor", content);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");
            }
            return View();
        }

      
        public async Task<IActionResult> DeleteVisitor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:28790/api/Visitor/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateVisitor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:28790/api/Visitor/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<VisitorViewModel>(JsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateVisitor(VisitorViewModel p)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:28790/api/Visitor", content);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
