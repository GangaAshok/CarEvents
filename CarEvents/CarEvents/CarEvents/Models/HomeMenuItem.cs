using System;
using System.Collections.Generic;
using System.Text;

namespace CarEvents.Models
{
    public enum MenuItemType
    {
        Browse,
        Login,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
