using System;
using System.Collections.Generic;
using System.Text;

namespace classSevenList
{
    public class PageDataViewModel
    {
        public PageDataViewModel(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {
                new PageDataViewModel("Star Wars", "Fun Space Opera"),

                new PageDataViewModel("Space Balls", "Another Fun Space Opera"),

                new PageDataViewModel("The Revenge of Xaml", "For the Love of GOD"),

            };
        }

        public static IList<PageDataViewModel> All { private set; get; }
    }
}
