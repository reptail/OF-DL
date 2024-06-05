namespace OF_DL.Entities.Purchased
{
    public class PaidMessageCollection
    {
        public Dictionary<long, string> PaidMessages = [];
        public List<Purchased.List> PaidMessageObjects = [];
        public List<Purchased.Medium> PaidMessageMedia = [];
    }
}
