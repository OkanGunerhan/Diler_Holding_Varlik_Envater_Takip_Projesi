using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Diler_Holding_Varlik_Envater.Models;


namespace Diler_Holding_Varlik_Envater.Controllers
{
    public class HomeController : Controller
    {
        private Varlık_Envanter_TakippEntities db = new Varlık_Envanter_TakippEntities();


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENVATER_TAKIP_DB eNVATER_TAKIP_DB = db.ENVATER_TAKIP_DB.Find(id);
            if (eNVATER_TAKIP_DB == null)
            {
                return HttpNotFound();
            }
            return View(eNVATER_TAKIP_DB);
        }

        // POST: Monitor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ENVATER_TAKIP_DB eNVATER_TAKIP_DB = db.ENVATER_TAKIP_DB.Find(id);
            db.ENVATER_TAKIP_DB.Remove(eNVATER_TAKIP_DB);
            db.SaveChanges();
            return RedirectToAction("MainList");
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MainList()
        {
            return View(db.ENVATER_TAKIP_DB.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include =
            "ID," +
            "PERSONEL_SICIL_NO," +
            "PERSONEL_AD_SOYAD," +
            "PERSONEL_BOLUMU," +
            "PERSONEL_ALT_BOLUM," +
            "PERSONEL_POZISYON," +
            "ISYERI_LOKASYON," +
            "BILGISAYAR_DOMAIN_GRUBU," +
            "BILGISAYAR_MARKA," +
            "BILGISAYAR_MODEL," +
            "BILGISAYAR_ADI," +
            "BILGISAYAR_IP_ADRESI," +
            "BILGISAYAR_MAC_ADRESI," +
            "BILGISAYAR_ISLETIM_SISTEMI," +
            "BILGISAYAR_TUTANAK_DURUMU," +
            "BILGISAYAR_TESLIM_DURUMU," +
            "BILGISAYAR_ACIKLAMA," +
            "BILGISAYAR_RAM,"+
            "BILGISAYAR_ISLEMCI,"+
            "BILGISAYAR_SERI_NO,"+
            "MONITOR_MARKA," +
            "MONITOR_MODEL," +
            "MONITOR_SERI_NO," +
            "MONITOR_INCH," +
            "MONITOR_TESLIM_DURUMU," +
            "MONITOR_TUTANAK_DURUMU," +
            "MONITOR_ACIKLAMA," +
            "YAZICI_MARKA," +
            "YAZICI_MODEL," +
            "YAZICI_SERI_NO," +
            "YAZICI_TONER_KARTUS_KODU,"+
            "YAZICI_BAGLI_KULLANICI,"+
            "YAZICI_USB," +
            "YAZICI_IP_ADRESI," +
            "YAZICI_MUREKKEP_TURU," +
            "YAZICI_TESLIM_DURUMU," +
            "YAZICI_TUTANAK_DURUMU," +
            "YAZICI_ACIKLAMA," +
            "YAZILIM_OFFICE_TEAMS_KULLANICI_ADI," +
            "YAZILIM_OFFICE_TEAMS_MS_365_STATU," +
            "YAZILIM_OFFICE_TEAMS_TEAMS_STATU," +
            "YAZILIM_OFFICE_TEAMS_SIFRE," +
            "YAZILIM_OFFICE_TEAMS_ALTERNATIF_SIFRE," +
            "SAP_MODUL," +
            "SAP_EMAIL_ADRES," +
            "SAP_YETKILENDIRME," +
            "SAP_KULLANICI_KODU," +
            "SAP_PAROLA," +
            "SAP_LOGONA_NAME," +
            "SAP_SCN_NAME," +
            "SAP_ACIKLAMA," +
            "VINN_MARKA," +
            "VINN_MODEL," +
            "VINN_HAT_NUMARASI," +
            "VINN_PIN_NO," +
            "VINN_TESLIM_DURUMU," +
            "VINN_TUTANAK_DURUMU," +
            "VINN_ACIKLAMA")] ENVATER_TAKIP_DB eNVATER_TAKIP_DB)
        {
            if (ModelState.IsValid)
            {
                db.ENVATER_TAKIP_DB.Add(eNVATER_TAKIP_DB);
                db.SaveChanges();
                return RedirectToAction("MainList");
            }

            return View(eNVATER_TAKIP_DB);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENVATER_TAKIP_DB eNVATER_TAKIP_DB = db.ENVATER_TAKIP_DB.Find(id);
            if (eNVATER_TAKIP_DB == null)
            {
                return HttpNotFound();
            }
            return View(eNVATER_TAKIP_DB);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENVATER_TAKIP_DB eNVATER_TAKIP_DB = db.ENVATER_TAKIP_DB.Find(id);
            if (eNVATER_TAKIP_DB == null)
            {
                return HttpNotFound();
            }
            return View(eNVATER_TAKIP_DB);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = 
            "ID," +
            "PERSONEL_SICIL_NO," +
            "PERSONEL_AD_SOYAD," +
            "PERSONEL_BOLUMU," +
            "PERSONEL_ALT_BOLUM," +
            "PERSONEL_POZISYON," +            
            "ISYERI_LOKASYON," +
            "BILGISAYAR_DOMAIN_GRUBU," +
            "BILGISAYAR_MARKA," +
            "BILGISAYAR_MODEL," +
            "BILGISAYAR_ADI," +
            "BILGISAYAR_IP_ADRESI," +
            "BILGISAYAR_MAC_ADRESI," +
            "BILGISAYAR_ISLETIM_SISTEMI," +
            "BILGISAYAR_TUTANAK_DURUMU," +
            "BILGISAYAR_TESLIM_DURUMU," +
            "BILGISAYAR_ACIKLAMA," +
            "BILGISAYAR_RAM,"+
            "BILGISAYAR_ISLEMCI,"+
            "BILGISAYAR_SERI_NO,"+
            "MONITOR_MARKA," +
            "MONITOR_MODEL," +
            "MONITOR_SERI_NO," +
            "MONITOR_INCH," +
            "MONITOR_TESLIM_DURUMU," +
            "MONITOR_TUTANAK_DURUMU," +
            "MONITOR_ACIKLAMA," +
            "YAZICI_MARKA," +
            "YAZICI_MODEL," +
            "YAZICI_SERI_NO," +
            "YAZICI_TONER_KARTUS_KODU,"+
            "YAZICI_BAGLI_KULLANICI,"+
            "YAZICI_USB," +
            "YAZICI_IP_ADRESI," +
            "YAZICI_MUREKKEP_TURU," +
            "YAZICI_TESLIM_DURUMU," +
            "YAZICI_TUTANAK_DURUMU," +
            "YAZICI_ACIKLAMA," +
            "YAZILIM_OFFICE_TEAMS_KULLANICI_ADI," +
            "YAZILIM_OFFICE_TEAMS_MS_365_STATU," +
            "YAZILIM_OFFICE_TEAMS_TEAMS_STATU," +
            "YAZILIM_OFFICE_TEAMS_SIFRE," +
            "YAZILIM_OFFICE_TEAMS_ALTERNATIF_SIFRE," +
            "SAP_MODUL," +
            "SAP_EMAIL_ADRES," +
            "SAP_YETKILENDIRME," +
            "SAP_KULLANICI_KODU," +
            "SAP_PAROLA," +
            "SAP_LOGONA_NAME," +
            "SAP_SCN_NAME," +            
            "SAP_ACIKLAMA," +
            "VINN_MARKA," +
            "VINN_MODEL," +
            "VINN_HAT_NUMARASI," +
            "VINN_PIN_NO," +
            "VINN_TESLIM_DURUMU," +
            "VINN_TUTANAK_DURUMU," +
            "VINN_ACIKLAMA")] ENVATER_TAKIP_DB eNVATER_TAKIP_DB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eNVATER_TAKIP_DB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("MainList");
            }
            return View(eNVATER_TAKIP_DB);
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LOGIN login)
        {
            if (ModelState.IsValid)
            {
                Varlık_Envanter_TakippEntities db = new Varlık_Envanter_TakippEntities();
                var user = (from userlist in db.LOGINs
                            where userlist.KULLANICI_ADI == login.KULLANICI_ADI && userlist.PAROLA == login.PAROLA
                            select new
                            {
                                userlist.ID,
                                userlist.KULLANICI_ADI
                            }).ToList();
                if (user.FirstOrDefault() != null)
                {
                    Session["KULLANICI_ADI"] = user.FirstOrDefault().KULLANICI_ADI;
                    Session["ID"] = user.FirstOrDefault().ID;
                    return Redirect("/home/Create");
                }
                else
                {
                    ModelState.AddModelError("", "Yetkisiz kullanıcı erişimi");
                }
            }
            return View(login);
        }


    }
}






    //public class HomeController : Controller
    //{
    //    private Varlık_Envanter_TakippEntities db = new Varlık_Envanter_TakippEntities();

    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

    //    public ActionResult MainList()
    //    {
    //        return View(db.ENVATER_TAKIP_DB.ToList());
    //    }

    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    //[HttpPost]
    //    //[ValidateAntiForgeryToken]
    //    //public ActionResult Create([Bind(Include ="ID,PERSONEL_SICIL_NO,PERSONEL_AD_SOYAD,PERSONEL_BOLUMU,PERSONEL_ALT_BOLUM,PERSONEL_POZISYON,ISYERI_LOKASYON,BILGISAYAR_DOMAIN_GRUBU,BILGISAYAR_MARKA,BILGISAYAR_MODEL,BILGISAYAR_ADI,BILGISAYAR_IP_ADRESI,BILGISAYAR_MAC_ADRESI,BILGISAYAR_ISLETIM_SISTEMI,BILGISAYAR_TUTANAK_DURUMU,BILGISAYAR_TESLIM_DURUMU,BILGISAYAR_ACIKLAMA,BILGISAYAR_RAM,BILGISAYAR_ISLEMCI,BILGISAYAR_SERI_NO,MONITOR_MARKA,MONITOR_MODEL,MONITOR_SERI_NO,MONITOR_INCH,MONITOR_TESLIM_DURUMU,MONITOR_TUTANAK_DURUMU,MONITOR_ACIKLAMA,YAZICI_MARKA,YAZICI_MODEL,YAZICI_SERI_NO,YAZICI_TONER_KARTUS_KODU,YAZICI_BAGLI_KULLANICI,YAZICI_USB,YAZICI_IP_ADRESI,YAZICI_MUREKKEP_TURU,YAZICI_TESLIM_DURUMU,YAZICI_TUTANAK_DURUMU,YAZICI_ACIKLAMA,YAZILIM_OFFICE_TEAMS_KULLANICI_ADI,YAZILIM_OFFICE_TEAMS_MS_365_STATU,YAZILIM_OFFICE_TEAMS_TEAMS_STATU,YAZILIM_OFFICE_TEAMS_SIFRE,YAZILIM_OFFICE_TEAMS_ALTERNATIF_SIFRE,SAP_MODUL,SAP_EMAIL_ADRES,SAP_YETKILENDIRME,SAP_KULLANICI_KODU,SAP_PAROLA,SAP_LOGONA_NAME,SAP_SCN_NAME,SAP_ACIKLAMA,VINN_MARKA,VINN_MODEL,VINN_HAT_NUMARASI,VINN_SERI_NO,VINN_PIN_NO,VINN_TESLIM_DURUMU,VINN_TUTANAK_DURUMU,VINN_ACIKLAMA")] ENVATER_TAKIP_DB eNVATER_TAKIP_DB)
    //    //{
    //    //    if (ModelState.IsValid)
    //    //    {
    //    //        db.ENVATER_TAKIP_DB.Add(eNVATER_TAKIP_DB);
    //    //        db.SaveChanges();
    //    //        return RedirectToAction("MainList");
    //    //    }

    //    //    return View(eNVATER_TAKIP_DB);
    //    //}

    //    //[HttpPost]
    //    //[ValidateAntiForgeryToken]
    //    //public ActionResult Create([Bind(Include = "ID,PERSONEL_SICIL_NO,PERSONEL_AD_SOYAD,PERSONEL_BOLUMU,PERSONEL_ALT_BOLUM,PERSONEL_POZISYON,ISYERI_LOKASYON,BILGISAYAR_DOMAIN_GRUBU,BILGISAYAR_MARKA,BILGISAYAR_MODEL,BILGISAYAR_ADI,BILGISAYAR_IP_ADRESI,BILGISAYAR_MAC_ADRESI,BILGISAYAR_ISLETIM_SISTEMI,BILGISAYAR_TUTANAK_DURUMU,BILGISAYAR_TESLIM_DURUMU,BILGISAYAR_ACIKLAMA,MONITOR_MARKA,MONITOR_MODEL,MONITOR_SERI_NO,MONITOR_INCH,MONITOR_TESLIM_DURUMU,MONITOR_TUTANAK_DURUMU,MONITOR_ACIKLAMA,YAZICI_MARKA,YAZICI_MODEL,YAZICI_SERI_NO,YAZICI_USB,YAZICI_IP_ADRESI,YAZICI_MUREKKEP_TURU,YAZICI_TESLIM_DURUMU,YAZICI_TUTANAK_DURUMU,YAZICI_ACIKLAMA,YAZILIM_OFFICE_TEAMS_KULLANICI_ADI,YAZILIM_OFFICE_TEAMS_MS_365_STATU,YAZILIM_OFFICE_TEAMS_TEAMS_STATU,YAZILIM_OFFICE_TEAMS_SIFRE,YAZILIM_OFFICE_TEAMS_ALTERNATIF_SIFRE,SAP_MODUL,SAP_EMAIL_ADRES,SAP_YETKILENDIRME,SAP_KULLANICI_KODU,SAP_PAROLA,SAP_LOGONA_NAME,SAP_SCN_NAME,SAP_TESLIM_DURUMU,SAP_ACIKLAMA,VINN_MARKA,VINN_MODEL,VINN_HAT_NUMARASI,VINN_PIN_NO,VINN_TESLIM_DURUMU,VINN_TUTANAK_DURUMU,VINN_ACIKLAMA")] ENVATER_TAKIP_DB eNVATER_TAKIP_DB)
    //    //{
    //    //    if (ModelState.IsValid)
    //    //    {
    //    //        try
    //    //        {
    //    //            db.ENVATER_TAKIP_DB.Add(eNVATER_TAKIP_DB);
    //    //            db.SaveChanges();
    //    //            return RedirectToAction("Index");
    //    //        }
    //    //        catch (Exception)
    //    //        {
    //    //            throw;
    //    //        }

    //    //    }

    //    //    return View(eNVATER_TAKIP_DB);
    //    //}

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Create([Bind(Include = "ID,PERSONEL_SICIL_NO,PERSONEL_AD_SOYAD,PERSONEL_BOLUMU,PERSONEL_ALT_BOLUM,PERSONEL_POZISYON,PERSONEL_KULLANICI_ADI,ISYERI_LOKASYON,BILGISAYAR_DOMAIN_GRUBU,BILGISAYAR_MARKA,BILGISAYAR_MODEL,BILGISAYAR_ADI,BILGISAYAR_IP_ADRESI,BILGISAYAR_MAC_ADRESI,BILGISAYAR_ISLETIM_SISTEMI,BILGISAYAR_TUTANAK_DURUMU,BILGISAYAR_TESLIM_DURUMU,BILGISAYAR_ACIKLAMA,MONITOR_MARKA,MONITOR_MODEL,MONITOR_SERI_NO,MONITOR_INCH,MONITOR_TESLIM_DURUMU,MONITOR_TUTANAK_DURUMU,MONITOR_ACIKLAMA,YAZICI_MARKA,YAZICI_MODEL,YAZICI_SERI_NO,YAZICI_USB,YAZICI_IP_ADRESI,YAZICI_MUREKKEP_TURU,YAZICI_TESLIM_DURUMU,YAZICI_TUTANAK_DURUMU,YAZICI_ACIKLAMA,YAZILIM_OFFICE_TEAMS_KULLANICI_ADI,YAZILIM_OFFICE_TEAMS_MS_365_STATU,YAZILIM_OFFICE_TEAMS_TEAMS_STATU,YAZILIM_OFFICE_TEAMS_SIFRE,YAZILIM_OFFICE_TEAMS_ALTERNATIF_SIFRE,YAZILIM_OFFICE_TEAMS_TESLIM_DURUMU,YAZILIM_OFFICE_TEAMS_TUTANAK_DURUMU,SAP_MODUL,SAP_EMAIL_ADRES,SAP_YETKILENDIRME,SAP_KULLANICI_KODU,SAP_PAROLA,SAP_LOGONA_NAME,SAP_SCN_NAME,SAP_TESLIM_DURUMU,SAP_TUTANAK_DURUMU,SAP_ACIKLAMA,VINN_MARKA,VINN_MODEL,VINN_HAT_NUMARASI,VINN_PIN_NO,VINN_TESLIM_DURUMU,VINN_TUTANAK_DURUMU,VINN_ACIKLAMA")] ENVATER_TAKIP_DB eNVATER_TAKIP_DB)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.ENVATER_TAKIP_DB.Add(eNVATER_TAKIP_DB);
    //            db.SaveChanges();
    //            return RedirectToAction("M");
    //        }

    //        return View(eNVATER_TAKIP_DB);
    //    }


    //    public ActionResult Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        ENVATER_TAKIP_DB eNVATER_TAKIP_DB = db.ENVATER_TAKIP_DB.Find(id);
    //        if (eNVATER_TAKIP_DB == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(eNVATER_TAKIP_DB);
    //    }

    //    public ActionResult Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        ENVATER_TAKIP_DB eNVATER_TAKIP_DB = db.ENVATER_TAKIP_DB.Find(id);
    //        if (eNVATER_TAKIP_DB == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(eNVATER_TAKIP_DB);
    //    }

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit([Bind(Include = "ID,PERSONEL_SICIL_NO,PERSONEL_AD_SOYAD,PERSONEL_BOLUMU,PERSONEL_ALT_BOLUM,PERSONEL_POZISYON,ISYERI_LOKASYON,BILGISAYAR_DOMAIN_GRUBU,BILGISAYAR_MARKA,BILGISAYAR_MODEL,BILGISAYAR_ADI,BILGISAYAR_IP_ADRESI,BILGISAYAR_MAC_ADRESI,BILGISAYAR_ISLETIM_SISTEMI,BILGISAYAR_TUTANAK_DURUMU,BILGISAYAR_TESLIM_DURUMU,BILGISAYAR_ACIKLAMA,BILGISAYAR_RAM,BILGISAYAR_ISLEMCI,BILGISAYAR_SERI_NO,MONITOR_MARKA,MONITOR_MODEL,MONITOR_SERI_NO,MONITOR_INCH,MONITOR_TESLIM_DURUMU,MONITOR_TUTANAK_DURUMU,MONITOR_ACIKLAMA,YAZICI_MARKA,YAZICI_MODEL,YAZICI_SERI_NO,YAZICI_TONER_KARTUS_KODU,YAZICI_BAGLI_KULLANICI,YAZICI_USB,YAZICI_IP_ADRESI,YAZICI_MUREKKEP_TURU,YAZICI_TESLIM_DURUMU,YAZICI_TUTANAK_DURUMU,YAZICI_ACIKLAMA,YAZILIM_OFFICE_TEAMS_KULLANICI_ADI,YAZILIM_OFFICE_TEAMS_MS_365_STATU,YAZILIM_OFFICE_TEAMS_TEAMS_STATU,YAZILIM_OFFICE_TEAMS_SIFRE,YAZILIM_OFFICE_TEAMS_ALTERNATIF_SIFRE,YAZILIM_OFFICE_TEAMS_TESLIM_DURUMU,YAZILIM_OFFICE_TEAMS_TUTANAK_DURUMU,SAP_MODUL,SAP_EMAIL_ADRES,SAP_YETKILENDIRME,SAP_KULLANICI_KODU,SAP_PAROLA,SAP_LOGONA_NAME,SAP_SCN_NAME,SAP_TESLIM_DURUMU,SAP_TUTANAK_DURUMU,SAP_ACIKLAMA,VINN_MARKA,VINN_MODEL,VINN_HAT_NUMARASI,VINN_SERI_NO,VINN_PIN_NO,VINN_TESLIM_DURUMU,VINN_TUTANAK_DURUMU,VINN_ACIKLAMA")] ENVATER_TAKIP_DB eNVATER_TAKIP_DB)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Entry(eNVATER_TAKIP_DB).State = EntityState.Modified;
    //            db.SaveChanges();
    //            return RedirectToAction("MainList");
    //        }
    //        return View(eNVATER_TAKIP_DB);
    //    }

    //    public ActionResult Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        ENVATER_TAKIP_DB eNVATER_TAKIP_DB = db.ENVATER_TAKIP_DB.Find(id);
    //        if (eNVATER_TAKIP_DB == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(eNVATER_TAKIP_DB);
    //    }


    //    // POST: Monitor/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteConfirmed(int id)
    //    {
    //        ENVATER_TAKIP_DB eNVATER_TAKIP_DB = db.ENVATER_TAKIP_DB.Find(id);
    //        db.ENVATER_TAKIP_DB.Remove(eNVATER_TAKIP_DB);
    //        db.SaveChanges();
    //        return RedirectToAction("MainList");
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    public ActionResult Login()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    public ActionResult Login(LOGIN login)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            Varlık_Envanter_TakippEntities db = new Varlık_Envanter_TakippEntities();
    //            var user = (from userlist in db.LOGINs
    //                        where userlist.KULLANICI_ADI == login.KULLANICI_ADI && userlist.PAROLA == login.PAROLA
    //                        select new
    //                        {
    //                            userlist.ID,
    //                            userlist.KULLANICI_ADI
    //                        }).ToList();
    //            if (user.FirstOrDefault() != null)
    //            {
    //                Session["KULLANICI_ADI"] = user.FirstOrDefault().KULLANICI_ADI;
    //                Session["ID"] = user.FirstOrDefault().ID;
    //                return Redirect("/home/Create");
    //            }
    //            else
    //            {
    //                ModelState.AddModelError("", "Yetkisiz kullanıcı erişimi");
    //            }
    //        }
    //        return View(login);
    //    }

    //}
    //}
