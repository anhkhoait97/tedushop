﻿using TeduShop.Data.Infrastucture;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISlideRepository
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}