﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Nsl_Api.Models.EFModels
{
    public partial class PaymentMethods
    {
        public PaymentMethods()
        {
            MembersConsumptionRecords = new HashSet<MembersConsumptionRecords>();
        }

        public int Id { get; set; }
        public string PaymentMethod { get; set; }

        public virtual ICollection<MembersConsumptionRecords> MembersConsumptionRecords { get; set; }
    }
}