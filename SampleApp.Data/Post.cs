using System;
using SampleApp.Data.Enums;

namespace SampleApp.Data
{
    public class Post : IBaseEntity
    {
        public string Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public PostStatus PostStatus { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}