﻿using Microsoft.AspNetCore.Mvc;

namespace MVCDay2.Controllers
{
    public class TestController : Controller
    {
       //action
        public string welcome()
        {
            return "welcome to test Controller";
        }
        public string welcome2(int id)
        {
            return $"welcome , your id is {id}";
        }
        public string About(string message)
        {
            return $"welcome , your Name is {message}";
        }
        public string Contact(int id,string mymessage)
        {
            return $"id={id} and Name is {mymessage}";
        }
    }
}