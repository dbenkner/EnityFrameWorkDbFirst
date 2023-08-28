using EnityFrameWorkDbFirst.Models;


var _context = new PrsDbContext();

var users = _context.Users.ToList();

foreach(var user in users)
{
    Console.WriteLine($"{user.Firstname} {user.LastName}");
}

