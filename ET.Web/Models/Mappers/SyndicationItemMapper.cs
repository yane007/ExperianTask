using System.ServiceModel.Syndication;

namespace ET.Web.Models.Mappers
{
    public static class SyndicationItemMapper
    {
        public static SyndicationItemViewModel ToViewModel(this SyndicationItem item)
        {
            return new SyndicationItemViewModel
            {
                Title = item.Title.Text,
                Summary = item.Summary?.Text,
                Link = item.Links.FirstOrDefault()?.Uri.ToString(),
                PublishDate = item.PublishDate
            };
        }
    }
}
