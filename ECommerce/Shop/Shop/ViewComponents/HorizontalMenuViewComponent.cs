using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewComponents
{
    public class HorizontalMenuViewComponent : ViewComponent
    {
        private readonly MyDbContext _dbContext;
        private readonly IMapper _mapper;
        public HorizontalMenuViewComponent(MyDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _dbContext.Categories.ToList();
            //var model = _mapper.Map<List<CategoryView>>(categories);
            await Task.CompletedTask;
            return View(categories);
        }
    }
}
