using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using cookboard.Models;

namespace cookboard.Controllers
{
    public class AccountController : Controller
    {

        private readonly cookBoardContext co;
        public AccountController(cookBoardContext context)
        {
            //_context = context;
            co = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        public ActionResult Validate(Utilizador user)
        {
            var u = co.Utilizador.Where(s => s.Username == user.Username);
            if (u.Contains())
            {
                if (u.Where(s => s.Password == user.Password).Contains())
                {

                    return Json(new { status = true, message = "Login Successfull!" });
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }
        /*
        <script>
  function Validate()
        {
    $.ajax(
    {
                type: "POST",
      url: '@Url.Action("Validate", "Account")',
      data: {
         email: $('#Username').val(),
        password: $('#Password').val()
      },
      error: function(result) {
                    alert("There is a Problem, Try Again!");
                },
      success: function(result) {
                    console.log(result);
                    if (result.status == true)
                    {
                        window.location.href = '@Url.Action("Index", "Home")';
                    }
                    else
                    {
                        alert(result.message);
                    }
                }
            });
        }
</script>
*/
    }
}