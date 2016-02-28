using challenge1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace challenge1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (TempData["errorMessage"] != null)
            {
                ViewBag.errorMessage = TempData["errorMessage"].ToString();
            }

            if (TempData["successMessage"] != null)
            {
                ViewBag.errorMessage = TempData["successMessage"].ToString();
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file == null)
            {
                TempData["errorMessage"] = "No file was chosen";
                return RedirectToAction("Index");
            }
            else
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(path);
                string text = System.IO.File.ReadAllText(path);
                ViewBag.isHidden = true;

                if (string.IsNullOrEmpty(text.Trim()))
                {
                    TempData["errorMessage"] = "Chosen file is empty";
                    System.IO.File.Delete(path);
                    return RedirectToAction("Index");
                }

                text = text.Replace(Environment.NewLine, "");
                string[] fields = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (fields.Length != 3)
                {
                    TempData["errorMessage"] = "Incorrect number of fields";
                    System.IO.File.Delete(path);
                    return RedirectToAction("Index");
                }

                string username = fields[0].Trim();
                string coins = fields[1].Trim();
                string name = fields[2].Trim();

                if (username.Length != 10 || !Regex.IsMatch(username, @"^[0-9]*$"))
                {
                    TempData["errorMessage"] = "Error on line 1: username must contain 10 digits.";
                }

                if (!Regex.IsMatch(coins, @"^[1-9]\d*$"))
                {
                    if (TempData["errorMessage"] != null)
                    {
                        TempData["errorMessage"] += " | ";
                    }
                    TempData["errorMessage"] += "Error on line 2: coins must be a natural number.";
                }

                if (TempData["errorMessage"] != null)
                {
                    System.IO.File.Delete(path);
                    return RedirectToAction("Index");
                }

                challenge1Context _db = new challenge1Context();

                try
                {
                    if (_db.Coinholders.Any(c => c.Id == username))
                    {
                        TempData["errorMessage"] = "A Coinholder with that ID already exists";
                        System.IO.File.Delete(path);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        _db.Coinholders.Add(new Coinholder
                        {
                            Id = username,
                            numberOfCoins = int.Parse(coins),
                            Name = name
                        });

                        _db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    TempData["errorMessage"] = "Sorry, there was an internal server error";
                    System.IO.File.Delete(path);
                    return RedirectToAction("Index");
                }

                TempData["successMessage"] = "File committed successfully";
                System.IO.File.Delete(path);
                return RedirectToAction("Index");
            }
        }
    }
}