using BlazorFluentUI;

namespace MauiBlazorApp.Models
{
    public class OverflowItem : IOverflowSetItem
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public OverflowItem(int id)
        {
            Key = id.ToString();
            Name = id.ToString();
        }
    }
}
