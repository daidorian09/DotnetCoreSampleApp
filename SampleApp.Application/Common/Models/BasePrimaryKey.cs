using System;

namespace SampleApp.Application.Common.Models
{
    public class BasePrimaryKey
    {
        public string Id => Guid.NewGuid().ToString("D");
    }
}