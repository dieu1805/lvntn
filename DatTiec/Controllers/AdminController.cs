using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DatTiec.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DatDonTiecEntities3 db = new DatDonTiecEntities3();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult updateMon()
        {
            return View();
        }
       //thêm món chính
        public ActionResult showMC()
        {
            return View(db.MONCHINHs.ToList());
        }
        public ActionResult themMC()
        {
            return View();
        }
        [HttpPost, ActionName("themMC")]
        [ValidateInput(false)]
        public ActionResult themThucAn([Bind(Include = "MA_MC,TENMON,GIA")] MONCHINH monchinh)
        {
            if (ModelState.IsValid)
            {       
                db.MONCHINHs.Add(new MONCHINH
                {
                    MA_MC = monchinh.MA_MC,
                    TENMON = monchinh.TENMON,
                    GIA = monchinh.GIA
                });
               
                db.SaveChanges();
                return RedirectToAction("showMC");
            }

            return View(monchinh);
        }

        [HttpGet]
        public ActionResult XoaMC(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONCHINH monchinh = db.MONCHINHs.Find(id);
            if (monchinh == null)
            {
                return HttpNotFound();
            }
            return View(monchinh);
        }

        //Xác nhận xoá
        [HttpPost, ActionName("XoaMC")]
        [ValidateInput(false)]
        public ActionResult XoaMCs(int id)
        {

            MONCHINH monchinhs = db.MONCHINHs.Find(id);
            db.MONCHINHs.Remove(monchinhs);
            db.SaveChanges();
            return RedirectToAction("showMC");
        }

        //thêm khai vị
        public ActionResult showKV()
        {
            return View(db.MONKHAIVIs.ToList());
        }
        public ActionResult themKV()
        {
            return View();
        }
        [HttpPost, ActionName("themKV")]
        [ValidateInput(false)]
        public ActionResult themKhaiVi([Bind(Include = "MA_KV,TENMON,GIACA")]MONKHAIVI monkv)
        {
            if (ModelState.IsValid)
            {
                db.MONKHAIVIs.Add(new MONKHAIVI
                {
                    MA_KV = monkv.MA_KV,
                    TENMON = monkv.TENMON,
                    GIACA = monkv.GIACA
                });

                db.SaveChanges();
                return RedirectToAction("showKV");
            }

            return View(monkv);
        }

        [HttpGet]
        public ActionResult XoaKV(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONKHAIVI monkv= db.MONKHAIVIs.Find(id);
            if (monkv == null)
            {
                return HttpNotFound();
            }
            return View(monkv);
        }

        //Xác nhận xoá
        [HttpPost, ActionName("XoaKV")]
        [ValidateInput(false)]
        public ActionResult XoaKVs(int id)
        {

            MONKHAIVI monkvs = db.MONKHAIVIs.Find(id);
            db.MONKHAIVIs.Remove(monkvs);
            db.SaveChanges();
            return RedirectToAction("showKV");
        }

        //thêm món phụ
        public ActionResult showMP()
        {
            return View(db.MONPHUs.ToList());
        }
        public ActionResult themMP()
        {
            return View();
        }
        [HttpPost, ActionName("themMP")]
        [ValidateInput(false)]
        public ActionResult themMonPhu([Bind(Include = "MA_MP,TENMON,GIACA")] MONPHU monphu)
        {
            if (ModelState.IsValid)
            {
                db.MONPHUs.Add(new MONPHU
                {
                    MA_MP = monphu.MA_MP,
                    TENMON = monphu.TENMON,
                    GIACA = monphu.GIACA
                });

                db.SaveChanges();
                return RedirectToAction("showMP");
            }

            return View(monphu);
        }

        [HttpGet]
        public ActionResult XoaMP(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONPHU monphu = db.MONPHUs.Find(id);
            if (monphu == null)
            {
                return HttpNotFound();
            }
            return View(monphu);
        }

        //Xác nhận xoá
        [HttpPost, ActionName("XoaMP")]
        [ValidateInput(false)]
        public ActionResult XoaMPs(int id)
        {

            MONPHU monphus = db.MONPHUs.Find(id);
            db.MONPHUs.Remove(monphus);
            db.SaveChanges();
            return RedirectToAction("showMP");
        }

        //thêm món súp
        public ActionResult showMS()
        {
            return View(db.MONSUPs.ToList());
        }
        public ActionResult themMS()
        {
            return View();
        }
        [HttpPost, ActionName("themMS")]
        [ValidateInput(false)]
        public ActionResult themMonSup([Bind(Include = "MA_MS,TENSUP,GIA")] MONSUP monsup)
        {
            if (ModelState.IsValid)
            {
                db.MONSUPs.Add(new MONSUP
                {
                    MA_MS = monsup.MA_MS,
                    TENSUP = monsup.TENSUP,
                    GIA = monsup.GIA
                });

                db.SaveChanges();
                return RedirectToAction("showMS");
            }

            return View(monsup);
        }

        [HttpGet]
        public ActionResult XoaMS(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONSUP monsup = db.MONSUPs.Find(id);
            if (monsup == null)
            {
                return HttpNotFound();
            }
            return View(monsup);
        }

        //Xác nhận xoá
        [HttpPost, ActionName("XoaMS")]
        [ValidateInput(false)]
        public ActionResult XoaMSs(int id)
        {

            MONSUP monsups = db.MONSUPs.Find(id);
            db.MONSUPs.Remove(monsups);
            db.SaveChanges();
            return RedirectToAction("showMS");
        }

        //thêm món nước

        public ActionResult showMN()
        {
            return View(db.MONNUOCs.ToList());
        }
        public ActionResult themMN()
        {
            return View();
        }
        [HttpPost, ActionName("themMN")]
        [ValidateInput(false)]
        public ActionResult themMonNc([Bind(Include = "MA_MN,TENNUOC,GIA")] MONNUOC monnc)
        {
            if (ModelState.IsValid)
            {
                db.MONNUOCs.Add(new MONNUOC
                {
                    MA_MN = monnc.MA_MN,
                    TENNUOC = monnc.TENNUOC,
                    GIA = monnc.GIA
                });

                db.SaveChanges();
                return RedirectToAction("showMN");
            }

            return View(monnc);
        }

        [HttpGet]
        public ActionResult XoaMN(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MONNUOC monnc = db.MONNUOCs.Find(id);
            if (monnc == null)
            {
                return HttpNotFound();
            }
            return View(monnc);
        }

        //Xác nhận xoá
        [HttpPost, ActionName("XoaMN")]
        [ValidateInput(false)]
        public ActionResult XoaMNs(int id)
        {

            MONNUOC monncs = db.MONNUOCs.Find(id);
            db.MONNUOCs.Remove(monncs);
            db.SaveChanges();
            return RedirectToAction("showMN");
        }
        //them tráng miệng
        public ActionResult showTM()
        {
            return View(db.TRANGMIENGs.ToList());
        }
        public ActionResult themTM()
        {
            return View();
        }
        [HttpPost, ActionName("themTM")]
        [ValidateInput(false)]
        public ActionResult themTrangMieng([Bind(Include = "MA_TM,TENTM,GIA")] TRANGMIENG tm)
        {
            if (ModelState.IsValid)
            {
                db.TRANGMIENGs.Add(new TRANGMIENG
                {
                    MA_TM = tm.MA_TM,
                    TENTM = tm.TENTM,
                    GIA = tm.GIA
                });

                db.SaveChanges();
                return RedirectToAction("showTM");
            }

            return View(tm);
        }

        [HttpGet]
        public ActionResult XoaTM(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRANGMIENG tm = db.TRANGMIENGs.Find(id);
            if (tm == null)
            {
                return HttpNotFound();
            }
            return View(tm);
        }

        //Xác nhận xoá
        [HttpPost, ActionName("XoaTM")]
        [ValidateInput(false)]
        public ActionResult XoaTMs(int id)
        {

            TRANGMIENG tm = db.TRANGMIENGs.Find(id);
            db.TRANGMIENGs.Remove(tm);
            db.SaveChanges();
            return RedirectToAction("showTM");
        }

        //them dich vu cuoi
        public ActionResult showDV()
        {
            return View(db.DICHVUs.ToList());
        }
        public ActionResult themDV()
        {
            return View();
        }
        [HttpPost, ActionName("themDV")]
        [ValidateInput(false)]
        public ActionResult themDichvu([Bind(Include = "MA_DV,TENDICHVU,GIADV")] DICHVU dv)
        {
            if (ModelState.IsValid)
            {
                db.DICHVUs.Add(new DICHVU
                {
                    MA_DV = dv.MA_DV,
                    TENDICHVU = dv.TENDICHVU,
                    GIADV = dv.GIADV
                });

                db.SaveChanges();
                return RedirectToAction("showDV");
            }

            return View(dv);
        }

        [HttpGet]
        public ActionResult XoaDV(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DICHVU dv = db.DICHVUs.Find(id);
            if (dv == null)
            {
                return HttpNotFound();
            }
            return View(dv);
        }

        //Xác nhận xoá
        [HttpPost, ActionName("XoaDV")]
        [ValidateInput(false)]
        public ActionResult XoaDVs(int id)
        {

            DICHVU dv = db.DICHVUs.Find(id);
            db.DICHVUs.Remove(dv);
            db.SaveChanges();
            return RedirectToAction("showDV");
        }

        //them sanh cuoi

        public ActionResult showSC()
        {
            return View(db.SANHCUOIs.ToList());
        }
        public ActionResult themSC()
        {
            return View();
        }
        [HttpPost, ActionName("themSC")]
        [ValidateInput(false)]
        public ActionResult themSanhcuoi([Bind(Include = "MA_SC,TENSANH,VITRI,SUCCHUA,SOBAN,GIADAT")] SANHCUOI sc)
        {
            if (ModelState.IsValid)
            {
                db.SANHCUOIs.Add(new SANHCUOI
                {
                   MA_SC = sc.MA_SC,
                   TENSANH = sc.TENSANH,
                   VITRI = sc.VITRI,
                   SUCCHUA = sc.SUCCHUA,
                   SOBAN = sc.SOBAN,
                   GIADAT = sc.GIADAT
                });

                db.SaveChanges();
                return RedirectToAction("showSC");
            }

            return View(sc);
        }

        [HttpGet]
        public ActionResult XoaSC(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANHCUOI sc = db.SANHCUOIs.Find(id);
            if (sc == null)
            {
                return HttpNotFound();
            }
            return View(sc);
        }

        //Xác nhận xoá
        [HttpPost, ActionName("XoaSC")]
        [ValidateInput(false)]
        public ActionResult XoaSCs(int id)
        {

            SANHCUOI sc = db.SANHCUOIs.Find(id);
            db.SANHCUOIs.Remove(sc);
            db.SaveChanges();
            return RedirectToAction("showSC");
        }

        //dang nhap
        public ActionResult Dangnhap()
        {

            if (Session["QUYEN"] == null)
            {
                Session["QUYEN"] = "User";
            }
            return View();
        }
        [HttpPost, ActionName("Dangnhap")]
        [ValidateInput(false)]
        public ActionResult Dangnhap(ACCOUNT account)
        {
            
                var user = db.ACCOUNTs.Where(x => x.USERNAME == account.USERNAME && x.PASSWORD == account.PASSWORD).Count();
                if (user > 0)
                {
                    return RedirectToAction("Index");
                }
              
                else
                {
                     return View(account);
                }
                    
            
        }
        public ActionResult Logout()
        {
            Session.Remove("USERNAME");
            Session["QUYEN"] = "User";
            return RedirectToAction("Dangnhap");
        }
        public ActionResult Dangky()
        {
            return View();
        }
        [HttpPost, ActionName("Dangky")]
        [ValidateInput(false)]
        public ActionResult Dangky(ACCOUNT account)
        {

            if (ModelState.IsValid)
            {

                try
                {

                    account.QUYEN = "User";
                    db.ACCOUNTs.Add(account);
                    db.SaveChanges();
                    return RedirectToAction("Dangnhap");
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "UserName đã tồn tại");
                    return View();
                }

            }
            return View();
        }

    }
}