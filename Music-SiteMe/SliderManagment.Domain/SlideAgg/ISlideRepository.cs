

using _0_Framework.Domain;
using SliderManagement.Application.Contracts.Slide;
using System.Collections.Generic;

namespace SliderManagement.Domain.SlideAgg
{
    public interface ISlideRepository : IRepository<long, Slide>
    {
        EditSlide GetDetails(long id);
        List<SlideViewModel> GetList();
    }
}
