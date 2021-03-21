using System;

namespace LMS.Domain
{
    public class Content
    {
        public Guid Id { get; set; }
        public ContentType ContentType { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
    }
}
