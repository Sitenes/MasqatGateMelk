using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Data;
using WebSite.ViewModels;

namespace WebSite.Controllers;

public class HomeController : Controller
{
    private readonly RealEstateDbContext _context;

    public HomeController(RealEstateDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new HomeViewModel();
        var totalAdvertisements = await _context.Advertisements.CountAsync();

        if (totalAdvertisements < 5)
        {
            var advertisements = await _context.Advertisements
                .Include(x => x.Keywords)
                .Include(x => x.Deal!)
                .Include(x => x.House!)
                .ThenInclude(x => x.Images)
                .ToListAsync();

            viewModel.advertisements = advertisements
                .Where(x => x.Deal is { HaveOffer: true, DealTypeId: 1 })
                .ToList();

            viewModel.advertisementsCount = totalAdvertisements;
        }
        else
        {
            var advertisements = await _context.Advertisements
                .Include(x => x.Keywords)
                .Include(x => x.Deal!)
                .Include(x => x.House!)
                .ThenInclude(x => x.Images)
                .ToListAsync();

            viewModel.advertisements = advertisements
                .Where(x => x.Deal is { HaveOffer: true, DealTypeId: 1 })
                .OrderBy(x => Guid.NewGuid())
                .Take(10)
                .ToList();

            viewModel.advertisementsCount = viewModel.advertisements.Count;
        }

        viewModel.staticDatas = await _context.staticDatas.Include(x => x.Group).ToListAsync();
        viewModel.agents = await _context.Agents.OrderBy(x => Guid.NewGuid()).Take(4).ToListAsync();
        viewModel.articles = await _context.Articles.Where(x => x.IsPublished).OrderByDescending(x => x.PublishedAt).Take(4).ToListAsync();

        return View(viewModel);
    }

    public IActionResult Error()
    {
        return View();
    }
}
