﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoreSoft.Shared.Tests.Entities
{
    public partial class Priority
    {
        public Priority()
        {
            Tasks = new List<Task>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Byte[] RowVersion { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}