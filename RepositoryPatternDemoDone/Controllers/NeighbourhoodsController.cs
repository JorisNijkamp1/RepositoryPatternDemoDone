using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemoDone.Interfaces;
using RepositoryPatternDemoDone.Models;

namespace RepositoryPatternDemoDone.Controllers
{
    public class NeighbourhoodsController : Controller
    {
        private readonly INeighbourhoodsRepository _neighbourhoods;

        public NeighbourhoodsController(INeighbourhoodsRepository neighbourhoods)
        {
            _neighbourhoods = neighbourhoods;
        }

        // GET: AllNeighbourhoods
        public async Task<IActionResult> Index()
        {
            return View(await _neighbourhoods.GetAllNeighbourhoodsAsync());
        }

        // GET: Neighbourhoods/Details/5
        public async Task<IActionResult> Details(string id)
        {
            return View(await _neighbourhoods.GetNeighbourhoodByIdAsync(id));
        }

        // GET: Neighbourhoods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Neighbourhoods/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("NeighbourhoodGroup,Neighbourhood1")] Neighbourhood neighbourhood)
        {
            return View(await _neighbourhoods.CreateNeighbourhoodAsync(neighbourhood));
        }
    }
}
