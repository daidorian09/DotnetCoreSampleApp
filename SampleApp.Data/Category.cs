using System;
using System.Collections.Generic;

namespace SampleApp.Data
{
    public class Category : IBaseEntity
    {
        #region Ctor

        public Category()
        {
            Posts = new HashSet<Post>();
        }

        #endregion

        public string Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }

        public string ParentId { get; set; }
        public Category Parent { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Post> Posts { get; }
    }
}