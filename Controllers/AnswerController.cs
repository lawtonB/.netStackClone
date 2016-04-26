//using System.Threading.Tasks;
//using System.Security.Claims;
//using System.Linq;
//using Microsoft.AspNet.Mvc;
//using Microsoft.AspNet.Authorization;
//using Microsoft.AspNet.Identity;
//using StackClone.Models;


//namespace StackClone.Controllers
//{
//    [Authorize]
//    public class AnswerController : Controller
//    {
//        private readonly ApplicationDbContext _db;
//        private readonly UserManager<ApplicationUser> _userManager;

//        public AnswerController(
//            UserManager<ApplicationUser> userManager,
//            ApplicationDbContext db
//        )
//        {
//            _userManager = userManager;
//            _db = db;
//        }

//        public async Task<IActionResult> Index()
//        {
//            var currentUser = await _userManager.FindByIdAsync(User.GetUserId());
//            return View(_db.Answers.Where(x => x.User.Id == currentUser.Id));
//        }

//        public IActionResult Create()
//        {
//            return View();

//        }
//        [HttpPost]
//        public async Task<IActionResult> Create(Answer answer)
//        {
//            var currentUser = await _userManager.FindByIdAsync(User.GetUserId());
//            answer.User = currentUser;
//            _db.Answers.Add(answer);
//            _db.SaveChanges();
//            return RedirectToAction("Index");
//        }
//    }


//}