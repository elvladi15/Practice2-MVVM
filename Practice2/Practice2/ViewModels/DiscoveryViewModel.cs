using Practice2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2.ViewModels
{
    public class DiscoveryViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineDiningMenuOption { get; set; } = new MenuOption();
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();
        public DiscoveryViewModel()
        {
            BarAndHotelsMenuOption.Image = "beer";
            BarAndHotelsMenuOption.Title = "Title & Hotels";

            FineDiningMenuOption.Image = "dinner";
            FineDiningMenuOption.Title = "Fine Dinner";

            CafesMenuOption.Image = "coffee";
            CafesMenuOption.Title = "Cafes";

            NearbyMenuOption.Image = "nearby";
            NearbyMenuOption.Title = "Nearby";

            FastFoodsMenuOption.Image = "fastFood";
            FastFoodsMenuOption.Title = "Fast Foods";

            FeaturedFoodsMenuOption.Image = "pizza";
            FeaturedFoodsMenuOption.Title = "Featured Foods";
        }
    }
}
