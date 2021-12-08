﻿using _01_LampshadeQuery.Contracts.Slide;

using SliderManagement.Infrastructure.EFCore;
using System.Collections.Generic;
using System.Linq;

namespace _01_LampshadeQuery.Query
{
    public class SlideQuery : ISlideQuery
    {
        private readonly SliderContext _sliderContext;

        public SlideQuery(SliderContext sliderContext)
        {
            _sliderContext = sliderContext;
        }

        public List<SlideQueryModel> GetSlides()
        {
            return _sliderContext.Slides
                .Where(x => x.IsRemoved == false)
                .Select(x => new SlideQueryModel
                {
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    BtnText = x.BtnText,
                    Heading = x.Heading,
                    Link = x.Link,
                    Text = x.Text,
                    Title = x.Title
                }).ToList();
        }
    }
}