using System.Linq;
using System.Web.Mvc;
using User.Models;

namespace User.Controllers
{
    public class CandidatesController : Controller
    {
        // GET: Candidates/Random
        private ApplicationDbContext _context;
        public CandidatesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var candidates = _context.Candidates.ToList();
            return View(candidates);
        }
        public ActionResult Details(int id)
        {
            var candidate = _context.Candidates.SingleOrDefault(c => c.Id == id);
            if (candidate == null)
                return HttpNotFound();
            return View(candidate);
        }


        public ActionResult Create()
        {


            return View();

        }


        [HttpPost]
        public ActionResult Create(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            _context.SaveChanges();
            return RedirectToAction("Details", "Candidates", new { id = candidate.Id });

        }



        // POST: PersonalDetails/Delete/5

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(FormCollection fcNotUsed, int id = 0)
        {
            Candidate candidate = _context.Candidates.Find(id);
            if (candidate == null)
            {
                return HttpNotFound();
            }
            _context.Candidates.Remove(candidate);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}