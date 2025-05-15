using CC_Lab_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CC_Lab_12.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		[HttpPost]
		public ActionResult UserResponseSubmition(UserResponse response) {
			if (response.userSelectedImage == null) {
				TempData["message"] = "Please select an image to proceed!";
			}
			else if (response.userSelectedImage == "image1") {
				TempData["message"] = "A photo with a pet could lead to a playful narrative about being an animal whisperer or preferring furry companionship over humans.";
			}
			else if (response.userSelectedImage == "image2") {
				TempData["message"] = "If a user selects a photo from a costume party, Photo Persona might humorously suggest a love for creativity and a secret desire to be a superhero.\r\n\r\n";
			}
			else if (response.userSelectedImage == "image3")
			{
				TempData["message"] = "A photo with a office environment suggests that the person has a calm and resilient personality!";
			}
			else if (response.userSelectedImage == "image4")
			{
				TempData["message"] = "A photo with a bombing scene suggests that the person has a brutal and violent nature!";
			}
			return RedirectToAction("Index");
			

			
		}
	}
}