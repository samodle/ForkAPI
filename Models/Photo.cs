﻿using Microsoft.AspNetCore.SignalR;
using System;

namespace ForkApp.API.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
    }
}