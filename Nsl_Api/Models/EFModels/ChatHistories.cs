﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Nsl_Api.Models.EFModels
{
    public partial class ChatHistories
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int TeacherId { get; set; }
        public string Message { get; set; }
        public DateTime MessageTime { get; set; }

        public virtual Members Member { get; set; }
        public virtual TeacherId Teacher { get; set; }
    }
}