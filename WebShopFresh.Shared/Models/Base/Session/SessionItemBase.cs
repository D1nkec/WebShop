namespace WebShopFresh.Shared.Models.Base.Session
{
    public abstract class SessionItemBase
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime Expires { get; set; }
    }
}
