﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Nsl_Api.Models.EFModels
{
    public partial class Tags
    {
        public Tags()
        {
            TeachersTags = new HashSet<TeachersTags>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<TeachersTags> TeachersTags { get; set; }
    }
}