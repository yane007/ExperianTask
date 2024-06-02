using System.ServiceModel.Syndication;
using System.Xml;

namespace ET.Services
{
    public interface IRssFeedService
    {
        Task<List<SyndicationItem>> GetRssFeedAsync(string url);
    }

    public class RssFeedService : IRssFeedService
    {
        public async Task<List<SyndicationItem>> GetRssFeedAsync(string url)
        {
            using (var reader = XmlReader.Create(url))
            {
                var feed = SyndicationFeed.Load(reader);
                return feed.Items.ToList();
            }
        }
    }
}