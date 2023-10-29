using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DatTiec.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        DatDonTiecEntities3 db = new DatDonTiecEntities3();
        
        public ActionResult showMenu()
        {
            return View(db.MENUs.ToList());
        }

        public ActionResult taoMenu()
        {
            ViewBag.MA_KV = new SelectList(db.MONKHAIVIs, "MA_KV", "TENMON");
            ViewBag.MA_MC = new SelectList(db.MONCHINHs, "MA_MC", "TENMON");
            ViewBag.MA_MN = new SelectList(db.MONNUOCs, "MA_MN", "TENNUOC");
            ViewBag.MA_MP = new SelectList(db.MONPHUs, "MA_MP", "TENMON");
            ViewBag.MA_MS = new SelectList(db.MONSUPs, "MA_MS", "TENSUP");
            ViewBag.MA_TM = new SelectList(db.TRANGMIENGs, "MA_TM", "TENTM");
           
            return View();
        }

        [HttpPost, ActionName("taoMenu")]
        [ValidateInput(false)]
        public ActionResult themMenu([Bind(Include = "MA_MENU,TENMENU,GIATONG,MA_KV,MA_MP,MA_MC,MA_MS,MA_MN,MA_TM")] MENU menu)
        {
            if (ModelState.IsValid)
            {
                db.MENUs.Add(new MENU
                {
                    MA_MENU = menu.MA_MENU,
                    TENMENU = menu.TENMENU,  
                    MA_KV = menu.MA_KV,
                    MA_MP = menu.MA_MP,
                    MA_MC = menu.MA_MC,
                    MA_MS = menu.MA_MS,
                    MA_MN = menu.MA_MN,
                    MA_TM = menu.MA_TM
                });

                db.SaveChanges();

                return RedirectToAction("showMenu");
            }

            ViewBag.MA_KV = new SelectList(db.MONKHAIVIs, "MA_KV", "TENMON", menu.MA_KV);
            ViewBag.MA_MC = new SelectList(db.MONCHINHs, "MA_MC", "TENMON", menu.MA_MC);
            ViewBag.MA_MN = new SelectList(db.MONNUOCs, "MA_MN", "TENNUOC",menu.MA_MN);
            ViewBag.MA_MP = new SelectList(db.MONPHUs, "MA_MP", "TENMON",menu.MA_MP);
            ViewBag.MA_MS = new SelectList(db.MONSUPs, "MA_MS", "TENSUP",menu.MA_MS);
            ViewBag.MA_TM = new SelectList(db.TRANGMIENGs, "MA_TM", "TENTM",menu.MA_TM);

            return View(menu);
        }

      
        public ActionResult showKH()
        {
            return View(db.KHACHHANGs.ToList());
        }
        public ActionResult themKH()
        {
            return View();
        }
        [HttpPost, ActionName("themKH")]
        [ValidateInput(false)]
        public ActionResult themKhach([Bind(Include = "MA_KH,TENHO,CMND,SDT,NAMSINH,DIACHI")] KHACHHANG kh)
        {
            if (ModelState.IsValid)
            {
                db.KHACHHANGs.Add(new KHACHHANG
                {
                   MA_KH = kh.MA_KH,
                   TENHO =kh.TENHO,
                   CMND = kh.CMND,
                   SDT = kh.SDT,
                   NAMSINH = kh.NAMSINH,
                   DIACHI = kh.DIACHI
                });

                db.SaveChanges();
                return RedirectToAction("showKH");
            }

            return View(kh);
        }

        [HttpGet]
        public ActionResult XoaKH(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHACHHANG kh = db.KHACHHANGs.Find(id);
            if (kh == null)
            {
                return HttpNotFound();
            }
            return View(kh);
        }

        //Xác nhận xoá
        [HttpPost, ActionName("XoaKH")]
        [ValidateInput(false)]
        public ActionResult XoaKHs(int id)
        {

            KHACHHANG khs = db.KHACHHANGs.Find(id);
            db.KHACHHANGs.Remove(khs);
            db.SaveChanges();
            return RedirectToAction("showKH");
        }

    }
}