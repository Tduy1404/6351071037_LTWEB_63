using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thWeb.Models;

namespace thWeb.Controllers
{

    public class HomeController : Controller
    {
        BanHangEntities db = new BanHangEntities();
        public ActionResult Index()
        {

            List<MoTa> sachs = db.MoTas.ToList();

            return View(sachs);
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
        public ActionResult CHitiet(int? id)
        {
            var chuDeList = db.CHUDEs.Distinct().ToList(); // Lấy danh sách chủ đề không trùng lặp
            var NXBList = db.NHAXUATBANs.ToList();
            ViewBag.ChuDeList = chuDeList;

            ViewBag.NXBList = NXBList;
            List<MoTa> dsSach = db.MoTas
                                  .Where(s => s.SACH.CHUDE.MaCD == id)
                                  .ToList();

            return View(dsSach);
        }

        public ActionResult Detail(int id)
        {
            var chuDeList = db.CHUDEs.Distinct().ToList(); // Lấy danh sách chủ đề không trùng lặp
            var NXBList = db.NHAXUATBANs.ToList();
            ViewBag.ChuDeList = chuDeList;

            ViewBag.NXBList = NXBList;
            List<MoTa> dsSach = db.MoTas
                                  .Where(s => s.SACH.MaSach == id)
                                  .ToList();

            return View(dsSach);
        }
        public ActionResult ChuDe()
        {
            var chude = from cd in db.CHUDEs select cd;
            return PartialView(chude);
        }
        public ActionResult NXB()
        {
            var xuatban = from cd in db.NHAXUATBANs select cd;
            return PartialView(xuatban);
        }
        public ActionResult CHitietXb(int? id)
        {
            var chuDeList = db.CHUDEs.Distinct().ToList(); // Lấy danh sách chủ đề không trùng lặp
            var NXBList = db.NHAXUATBANs.ToList();
            ViewBag.ChuDeList = chuDeList;

            ViewBag.NXBList = NXBList;
            List<MoTa> dsSach = db.MoTas
                                  .Where(s => s.SACH.NHAXUATBAN.MaNXB == id)
                                  .ToList();

            return View(dsSach);
        }

    }





}


