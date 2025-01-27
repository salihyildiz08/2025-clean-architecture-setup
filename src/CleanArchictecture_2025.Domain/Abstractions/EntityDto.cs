﻿namespace CleanArchictecture_2025.Domain.Abstractions
{
    public abstract class EntityDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreateAt { get; set; }
        public DateTimeOffset? UpdateAt { get; set; }
        public DateTimeOffset? DeleteAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
