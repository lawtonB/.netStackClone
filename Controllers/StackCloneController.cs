using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using StackClone.Models;


namespace StackClone.Controllers
{
    [Authorize]
    public class StackCloneController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public StackCloneController(
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext db
        )
        {
            _userManager = userManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.FindByIdAsync(User.GetUserId());
            return View(_db.Posts.Where(x => x.User.Id == currentUser.Id));
        }

        public IActionResult Create()
        {
            return View();
           
        }
        [HttpPost]
        public async Task<IActionResult> Create(Post post)
        {
            var currentUser = await _userManager.FindByIdAsync(User.GetUserId());
            post.User = currentUser;
            _db.Posts.Add(post);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Details
        public IActionResult Details(int id)
        {
            var thisPost = _db.Posts.FirstOrDefault(posts => posts.id == id);
            return View(thisPost);
        }
    }

    
}