﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
