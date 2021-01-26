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
    public class WINNController : Controller
    {
        private Varlık_Envanter_TakippEntities db = new Varlık_Envanter_TakippEntities();

        // GET: WINN
        public ActionResult Index()
        {
            return View(db.ENVATER_TAKIP_DB.ToList());
        }

        // GET: WINN/Details/5
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

        // GET: WINN/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WINN/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,PERSONEL_SICIL_NO,PERSONEL_AD_SOYAD,PERSONEL_BOLUMU,PERSONEL_ALT_BOLUM,PERSONEL_POZISYON,PERSONEL_KULLANICI_ADI,ISYERI_LOKASYON,BILGISAYAR_DOMAIN_GRUBU,BILGISAYAR_MARKA,BILGISAYAR_MODEL,BILGISAYAR_ADI,BILGISAYAR_IP_ADRESI,BILGISAYAR_MAC_ADRESI,BILGISAYAR_ISLETIM_SISTEMI,BILGISAYAR_TUTANAK_DURUMU,BILGISAYAR_TESLIM_DURUMU,BILGISAYAR_ACIKLAMA,MONITOR_MARKA,MONITOR_MODEL,MONITOR_SERI_NO,MONITOR_INCH,MONITOR_TESLIM_DURUMU,MONITOR_TUTANAK_DURUMU,MONITOR_ACIKLAMA,YAZICI_MARKA,YAZICI_MODEL,YAZICI_SERI_NO,YAZICI_USB,YAZICI_IP_ADRESI,YAZICI_MUREKKEP_TURU,YAZICI_TESLIM_DURUMU,YAZICI_TUTANAK_DURUMU,YAZICI_ACIKLAMA,YAZILIM_OFFICE_TEAMS_KULLANICI_ADI,YAZILIM_OFFICE_TEAMS_MS_365_STATU,YAZILIM_OFFICE_TEAMS_TEAMS_STATU,YAZILIM_OFFICE_TEAMS_SIFRE,YAZILIM_OFFICE_TEAMS_ALTERNATIF_SIFRE,YAZILIM_OFFICE_TEAMS_TESLIM_DURUMU,YAZILIM_OFFICE_TEAMS_TUTANAK_DURUMU,SAP_MODUL,SAP_EMAIL_ADRES,SAP_YETKILENDIRME,SAP_KULLANICI_KODU,SAP_PAROLA,SAP_LOGONA_NAME,SAP_SCN_NAME,SAP_TESLIM_DURUMU,SAP_TUTANAK_DURUMU,SAP_ACIKLAMA,VINN_MARKA,VINN_MODEL,VINN_HAT_NUMARASI,VINN_PIN_NO,VINN_TESLIM_DURUMU,VINN_TUTANAK_DURUMU,VINN_ACIKLAMA")] ENVATER_TAKIP_DB eNVATER_TAKIP_DB)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.ENVATER_TAKIP_DB.Add(eNVATER_TAKIP_DB);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(eNVATER_TAKIP_DB);
        //}

        // GET: WINN/Edit/5
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

        // POST: WINN/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PERSONEL_SICIL_NO,PERSONEL_AD_SOYAD,PERSONEL_BOLUMU,PERSONEL_ALT_BOLUM,PERSONEL_POZISYON,PERSONEL_KULLANICI_ADI,ISYERI_LOKASYON,BILGISAYAR_DOMAIN_GRUBU,BILGISAYAR_MARKA,BILGISAYAR_MODEL,BILGISAYAR_ADI,BILGISAYAR_IP_ADRESI,BILGISAYAR_MAC_ADRESI,BILGISAYAR_ISLETIM_SISTEMI,BILGISAYAR_TUTANAK_DURUMU,BILGISAYAR_TESLIM_DURUMU,BILGISAYAR_ACIKLAMA,BILGISAYAR_RAM,BILGISAYAR_ISLEMCI,BILGISAYAR_SERI_NO,MONITOR_MARKA,MONITOR_MODEL,MONITOR_SERI_NO,MONITOR_INCH,MONITOR_TESLIM_DURUMU,MONITOR_TUTANAK_DURUMU,MONITOR_ACIKLAMA,YAZICI_MARKA,YAZICI_MODEL,YAZICI_SERI_NO,YAZICI_TONER_KARTUS_KODU,YAZICI_BAGLI_KULLANICI,YAZICI_USB,YAZICI_IP_ADRESI,YAZICI_MUREKKEP_TURU,YAZICI_TESLIM_DURUMU,YAZICI_TUTANAK_DURUMU,YAZICI_ACIKLAMA,YAZILIM_OFFICE_TEAMS_KULLANICI_ADI,YAZILIM_OFFICE_TEAMS_MS_365_STATU,YAZILIM_OFFICE_TEAMS_TEAMS_STATU,YAZILIM_OFFICE_TEAMS_SIFRE,YAZILIM_OFFICE_TEAMS_ALTERNATIF_SIFRE,YAZILIM_OFFICE_TEAMS_TESLIM_DURUMU,YAZILIM_OFFICE_TEAMS_TUTANAK_DURUMU,SAP_MODUL,SAP_EMAIL_ADRES,SAP_YETKILENDIRME,SAP_KULLANICI_KODU,SAP_PAROLA,SAP_LOGONA_NAME,SAP_SCN_NAME,SAP_TESLIM_DURUMU,SAP_TUTANAK_DURUMU,SAP_ACIKLAMA,VINN_MARKA,VINN_MODEL,VINN_HAT_NUMARASI,VINN_SERI_NO,VINN_PIN_NO,VINN_TESLIM_DURUMU,VINN_TUTANAK_DURUMU,VINN_ACIKLAMA")] ENVATER_TAKIP_DB eNVATER_TAKIP_DB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eNVATER_TAKIP_DB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eNVATER_TAKIP_DB);
        }

        // GET: WINN/Delete/5
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

        // POST: WINN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ENVATER_TAKIP_DB eNVATER_TAKIP_DB = db.ENVATER_TAKIP_DB.Find(id);
            db.ENVATER_TAKIP_DB.Remove(eNVATER_TAKIP_DB);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
