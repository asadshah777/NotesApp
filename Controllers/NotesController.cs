using Microsoft.AspNetCore.Mvc;

public class NotesController : Controller
{
    private readonly ILogger<NotesController> _logger;
    private readonly ApplicationDbContext _db;
    public NotesController(ILogger<NotesController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        List<Note> getNotes = _db.notes.OrderBy(note => note.CreatedAt).ToList();
        return View(getNotes);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
        [HttpGet]
    public IActionResult Edit(int? Id)
    {
        var findNote = _db.notes.Find(Id);
        if(findNote == null)
        {
            return View("CustomNotFound");
        }
        return View(findNote);
    }
    [HttpPost]
    public IActionResult Create(Note note)
    {
        
        if(note == null)
        {
            return RedirectToAction("Create", "Notes");
        }
        note.CreatedAt = DateTime.SpecifyKind(note.CreatedAt, DateTimeKind.Utc);
        var addData = _db.notes.Add(note);

        _db.SaveChanges();

        return RedirectToAction("Index", "Notes");
    }
    [HttpPost]
    public IActionResult Edit(Note note)
    {
        
        if(note == null)
        {
            return RedirectToAction("Edit", "Notes");
        }
        var addData = _db.notes.Update(note);
        _db.SaveChanges();

        return RedirectToAction("Index", "Notes");
    }
    [HttpGet]
    public IActionResult Delete(int? Id)
    {
      var findNote = _db.notes.Find(Id);
      if(findNote == null)
      {
            return View("CustomNotFound");
      }
      _db.notes.Remove(findNote);
      _db.SaveChanges();

      return RedirectToAction("Index", "Notes");   
    }
}