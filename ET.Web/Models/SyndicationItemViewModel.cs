namespace ET.Web.Models
{
    public class SyndicationItemViewModel
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Link { get; set; }
        public DateTimeOffset PublishDate { get; set; }
    }
}
