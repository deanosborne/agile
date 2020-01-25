using System;
using System.Collections.Generic;
using System.Text;

namespace Agile6.Models
{
    public enum MenuItemType
    {
        About,
        Browse,
        R1,
        R2,
        R3,
        R4
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
