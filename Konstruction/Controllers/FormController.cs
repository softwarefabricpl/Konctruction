using DevExpress.Web.Internal;
using DevExpress.Web.Mvc;
using Konstruction.Helpers;
using Konstruction.Model;
using Konstruction.Model.Helpers;
using Konstruction.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Konstruction.Controllers
{

    [Authorize]
    public class FormController : Controller
    {
        [AllowAnonymous]
        public ActionResult PassTeileNrRebuild(int no)
        {
            FormHelper.PassTeileNrRebuild(no);

            return Content("ok");
        }

        [AllowAnonymous]
        public ActionResult KundenTeileNrRebuild(int no)
        {
            FormHelper.KundenTeileNrRebuild(no);

            return Content("ok");
        }

        private static bool CheckRights()
        {
            var ui = CommonHelper.GetUserInfo();
            return ui != null;
        }
        public ActionResult PassKundezuweisungZSBNrComboboxPartial(int? ID)
        {
            SessionDataHelper.PassKundezuweisungZSBNrValueData = ID;
            return PartialView("Controls/PassKundezuweisungZSBNrComboboxPartial");
        }
        public ActionResult KundezuweisungZSBNrComboboxPartial(int? ID)
        {
            SessionDataHelper.KundezuweisungZSBNrValueData = ID;
            return PartialView("Controls/KundezuweisungZSBNrComboboxPartial");
        }
        public ActionResult PasszuweisungZSBNrComboboxPartial(int? ID)
        {
            SessionDataHelper.PasszuweisungZSBNrValueData = ID;
            return PartialView("Controls/PasszuweisungZSBNrComboboxPartial");
        }
        public ActionResult PassTeileNrComboboxPartial()
        {
            return PartialView("Controls/PassTeileNrComboboxPartial");
        }
        public ActionResult KundenTeileNrComboboxPartial()
        {
            return PartialView("Controls/KundenTeileNrComboboxPartial");
        }
        
        public ActionResult Form1Index()
        {
            return View(GetDataHelper.GetKundenTeileNrItems());
        }

        public ActionResult Form1IndexPartialView()
        {
            return PartialView(GetDataHelper.GetKundenTeileNrItems());
        }
        public ActionResult Form2Index()
        {
            return View(GetDataHelper.GetPassTeileNrItems());
        }

        public ActionResult Form2IndexPartialView()
        {
            return PartialView(GetDataHelper.GetPassTeileNrItems());
        }

        #region New Form
        public ActionResult NewForm1Session()
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            return RedirectToAction("NewForm1", new { SessionKey = Guid.NewGuid() });
        }
        public ActionResult NewForm1(Guid SessionKey)
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            KundenTeileNrFormViewModel model = new KundenTeileNrFormViewModel();
            model.SessionKey = SessionKey.ToString();
            model.UserInfo = CommonHelper.GetUserInfo();

            return View(model);
        }

        public ActionResult NewForm2Session()
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            return RedirectToAction("NewForm2", new { SessionKey = Guid.NewGuid() });
        }

        public ActionResult NewForm2(Guid SessionKey)
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            PassTeileNrFormViewModel model = new PassTeileNrFormViewModel();
            model.SessionKey = SessionKey.ToString();
            model.UserInfo = CommonHelper.GetUserInfo();

            return View(model);
        }

        public ActionResult Form2PassZuweisungZSBNrPartial(string SessionKey, int? oid)
        {
            #region delete from session

            if (oid.HasValue)
                FormHelper.RemovePassZuweisungZsbNr(SessionKey, oid);
            #endregion

            return PartialView("Controls/Form2PassZuweisungZSBNrPartial", FormHelper.GetSessionForm1PassZuweisungZSBNrData(SessionKey));
        }
        public ActionResult Form1KundeZuweisungZSBNrPartial(string SessionKey, int? oid)
        {
            #region delete from session

            if (oid.HasValue)
                FormHelper.RemoveKundeZuweisungZsbNr(SessionKey, oid);
            #endregion

            return PartialView("Controls/Form1KundeZuweisungZSBNrPartial", FormHelper.GetSessionForm2KundeZuweisungZSBNrData(SessionKey));
        }

        public ActionResult Form1PassKundeZuweisungZSBNrPartial(string SessionKey, int? oid)
        {
            #region delete from session

            if (oid.HasValue)
                FormHelper.RemovePassKundeZuweisungZsbNr(SessionKey, oid);
            #endregion

            return PartialView("Controls/Form1PassKundeZuweisungZSBNrPartial", FormHelper.GetSessionForm2PassKundeZuweisungZSBNrData(SessionKey));
        }
        
        public ActionResult Form2PassZgRevisionPartial(string SessionKey, int? oid)
        {
            #region delete from session

            if (oid.HasValue)
                FormHelper.RemovePassZgRevision(SessionKey, oid);
            #endregion

            return PartialView("Controls/Form2PassZgRevisionPartial", FormHelper.GetSessionForm1PassZgRevisionData(SessionKey));
        }
        public ActionResult Form1KundeZgRevisionPartial(string SessionKey, int? oid)
        {
            #region delete from session

            if (oid.HasValue)
                FormHelper.RemoveKundeZgRevision(SessionKey, oid);
            #endregion

            return PartialView("Controls/Form1KundeZgRevisionPartial", FormHelper.GetSessionForm2KundeZgRevisionData(SessionKey));
        }

        [ValidateInput(false)]
        public ActionResult Form1KundeZuweisungZSBNrSessionEdit(MVCxGridViewBatchUpdateValues<KundeZuweisungZsbNrViewModel, int> updateValues, string SessionKey)
        {
            if (updateValues != null)
            {
                if (updateValues.Insert.Any())
                {
                    int id = FormHelper.GetLastKundeZuweisungZsbNrID(SessionKey);
                    foreach (var item in updateValues.Insert)
                    {
                        if (updateValues.IsValid(item))
                        {
                            item.ID = id;
                            FormHelper.AddKundeZuweisungZsbNr(SessionKey, item);
                            id++;
                        }
                    }
                }

                if (updateValues.Update.Any())
                {
                    int lp = 0;
                    foreach (var item in updateValues.Update)
                    {

                        if (updateValues.IsValid(item))
                        {
                            FormHelper.UpdateKundeZuweisungZsbNr(SessionKey, item);
                        }

                        lp++;
                    }
                }
            }


            return PartialView("Controls/Form1KundeZuweisungZSBNrPartial", FormHelper.GetSessionForm2KundeZuweisungZSBNrData(SessionKey));
        }

        [ValidateInput(false)]
        public ActionResult Form1PassKundeZuweisungZSBNrSessionEdit(MVCxGridViewBatchUpdateValues<PassKundeZuweisungZsbNrViewModel, int> updateValues, string SessionKey)
        {
            if (updateValues != null)
            {
                if (updateValues.Insert.Any())
                {
                    int id = FormHelper.GetLastPassKundeZuweisungZsbNrID(SessionKey);
                    foreach (var item in updateValues.Insert)
                    {
                        if (updateValues.IsValid(item))
                        {
                            item.ID = id;
                            FormHelper.AddPassKundeZuweisungZsbNr(SessionKey, item);
                            id++;
                        }
                    }
                }

                if (updateValues.Update.Any())
                {
                    int lp = 0;
                    foreach (var item in updateValues.Update)
                    {

                        if (updateValues.IsValid(item))
                        {
                            FormHelper.UpdatePassKundeZuweisungZsbNr(SessionKey, item);
                        }

                        lp++;
                    }
                }
            }


            return PartialView("Controls/Form1PassKundeZuweisungZSBNrPartial", FormHelper.GetSessionForm2PassKundeZuweisungZSBNrData(SessionKey));
        }


        
        [ValidateInput(false)]
        public ActionResult Form2PassZuweisungZSBNrSessionEdit(MVCxGridViewBatchUpdateValues<PassZuweisungZsbNrViewModel, int> updateValues, string SessionKey)
        {
            if (updateValues != null)
            {
                if (updateValues.Insert.Any())
                {
                    int id = FormHelper.GetLastPassZuweisungZsbNrID(SessionKey);
                    foreach (var item in updateValues.Insert)
                    {
                        if (updateValues.IsValid(item))
                        {
                            item.ID = id;
                            FormHelper.AddtPassZuweisungZsbNr(SessionKey, item);
                            id++;
                        }
                    }
                }

                if (updateValues.Update.Any())
                {
                    int lp = 0;
                    foreach (var item in updateValues.Update)
                    {

                        if (updateValues.IsValid(item))
                        {
                            FormHelper.UpdatePassZuweisungZsbNr(SessionKey, item);
                        }

                        lp++;
                    }
                }
            }


            return PartialView("Controls/Form2PassZuweisungZSBNrPartial", FormHelper.GetSessionForm1PassZuweisungZSBNrData(SessionKey));
        }

        [ValidateInput(false)]
        public ActionResult Form2PassZgRevisionSessionEdit(MVCxGridViewBatchUpdateValues<PassZgRevisionViewModel, int> updateValues, string SessionKey)
        {
            if (updateValues != null)
            {
                if (updateValues.Insert.Any())
                {
                    int id = FormHelper.GetLastPassZgRevisionID(SessionKey);
                    foreach (var item in updateValues.Insert)
                    {
                        if (updateValues.IsValid(item))
                        {
                            item.ID = id;
                            FormHelper.AddPassZgRevision(SessionKey, item);
                            id++;
                        }
                    }
                }

                if (updateValues.Update.Any())
                {
                    int lp = 0;
                    foreach (var item in updateValues.Update)
                    {

                        if (updateValues.IsValid(item))
                        {
                            FormHelper.UpdatePassZgRevision(SessionKey, item);
                        }

                        lp++;
                    }
                }
            }


            return PartialView("Controls/Form2PassZgRevisionPartial", FormHelper.GetSessionForm1PassZgRevisionData(SessionKey));
        }
        [ValidateInput(false)]
        public ActionResult Form1KundeZgRevisionSessionEdit(MVCxGridViewBatchUpdateValues<KundeZgRevisionViewModel, int> updateValues, string SessionKey)
        {
            if (updateValues != null)
            {
                if (updateValues.Insert.Any())
                {
                    int id = FormHelper.GetLastKundeZgRevisionID(SessionKey);
                    foreach (var item in updateValues.Insert)
                    {
                        if (updateValues.IsValid(item))
                        {
                            item.ID = id;
                            FormHelper.AddKundeZgRevision(SessionKey, item);
                            id++;
                        }
                    }
                }

                if (updateValues.Update.Any())
                {
                    int lp = 0;
                    foreach (var item in updateValues.Update)
                    {

                        if (updateValues.IsValid(item))
                        {
                            FormHelper.UpdateKundeZgRevision(SessionKey, item);
                        }

                        lp++;
                    }
                }
            }


            return PartialView("Controls/Form1KundeZgRevisionPartial", FormHelper.GetSessionForm2KundeZgRevisionData(SessionKey));
        }



        [HttpPost]

        [ValidateInput(false)]
        public ActionResult NewForm2(PassTeileNrFormViewModel model)
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            if (!string.IsNullOrEmpty(model.PassPdbNr) && (model.PassPdbNr.Length != 12 && model.PassPdbNr.Replace(".","").Replace(" ", "").Length != 0))
                ModelState.AddModelError("PassPdbNr", "Ungültiges Format!");

            RemoveErrorFromModalState("ZgNr");

            if (ModelState.IsValid)
            {
                int id = FormHelper.SaveForm2(model);

                return RedirectToAction("BrowseForm2", "Form", new { ID = id });
            }

            model.UserInfo = CommonHelper.GetUserInfo();

            return View(model);
        }

        [HttpPost]

        [ValidateInput(false)]
        public ActionResult NewForm1(KundenTeileNrFormViewModel model)
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            if (!string.IsNullOrEmpty(model.PassPdbNr) && (model.PassPdbNr.Length != 12 && model.PassPdbNr.Replace(".", "").Replace(" ", "").Length != 0))
                ModelState.AddModelError("PassPdbNr", "Ungültiges Format!");

            if (ModelState.IsValid)
            {
                int id = FormHelper.SaveForm1(model);

                return RedirectToAction("BrowseForm1", "Form", new { ID = id });
            }

            model.UserInfo = CommonHelper.GetUserInfo();

            return View(model);
        }

        #endregion
        public ActionResult TakeoverForm2(int ID)
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            PassTeileNrFormViewModel model = FormHelper.GetForm2(ID);
            if (model == null) return RedirectToAction("InvalidOperation", "Security");

            var ui = CommonHelper.GetUserInfo();
            model.UserInfo = ui;
            FormHelper.AssignToForm2(model.UserInfo.UserName, ID, true);

            return RedirectToAction("BrowseForm2", "Form", new { ID = ID });
        }

        public ActionResult BrowseSearchForm1(int ID)
        {
            return RedirectToAction("BrowseForm1", "Form", new { ID = ID });
        }


        public ActionResult BrowseSearchForm2(int ID)
        {
            return RedirectToAction("BrowseForm2", "Form", new { ID = ID });
        }

        public ActionResult BrowseForm2(int ID)
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            PassTeileNrFormViewModel model = FormHelper.GetForm2(ID);
            if (model == null) return RedirectToAction("InvalidOperation", "Security");

            var ui = CommonHelper.GetUserInfo();
            model.UserInfo = ui;
            if (ui.UserRole == Model.Class.UserRole.Full)
                FormHelper.AssignToForm2(model.UserInfo.UserName, ID, false);
            model = FormHelper.GetForm2(ID);
            model.UserInfo = ui;

            return View(model);
        }

        [HttpPost]

        [ValidateInput(false)]
        public ActionResult BrowseForm2(PassTeileNrFormViewModel model)
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            PassTeileNrFormViewModel check = FormHelper.GetForm2(model.ID);
            if (check == null) return RedirectToAction("InvalidOperation", "Security");

            if (!string.IsNullOrEmpty(model.PassPdbNr) && (model.PassPdbNr.Length != 12 && model.PassPdbNr.Replace(".", "").Replace(" ", "").Length != 0))
                ModelState.AddModelError("PassPdbNr", "Ungültiges Format!");

            if (ModelState.IsValid)
            {
                var ui = CommonHelper.GetUserInfo();
                if (ui != null && ui.UserName.ToLower() != check.AssignedTo.ToLower())
                    return RedirectToAction("BrowseForm2", "Form", new { ID = model.ID });

                FormHelper.UpdateForm2(model);

                return RedirectToAction("BrowseForm2", "Form", new { ID = model.ID });
            }

            model.UserInfo = CommonHelper.GetUserInfo();

            return View(model);
        }

        public ActionResult BrowseForm2PassZgRevisionPartial(int Parent)
        {
            return PartialView("Controls/BrowseForm2PassZgRevisionPartial", FormHelper.GetPassZgRevisionItems(Parent));
        }

        public ActionResult BrowseForm2PassZuweisungZSBNrPartial(int Parent)
        {
            return PartialView("Controls/BrowseForm2PassZuweisungZSBNrPartial", FormHelper.GetPassZuweisungZsbNrItems(Parent));
        }

        [ValidateInput(false)]
        public ActionResult BrowseForm2PassZgRevisionSessionEdit(MVCxGridViewBatchUpdateValues<PassZgRevisionViewModel, int> updateValues, int Parent)
        {
            if (updateValues != null)
            {
                using (var db = new KonstructionEntities())
                {
                    if (updateValues.Update.Any())
                    {
                        foreach (var item in updateValues.Update)
                        {
                            var itemToUpdate = db.Pass_zg_revision.FirstOrDefault(x => x.ID == item.ID);
                            if (itemToUpdate != null)
                            {
                                itemToUpdate.p_rev_date = item.RevDate;
                                itemToUpdate.p_rev_record = item.RevRecord;
                                db.SaveChanges();
                            }
                        }
                    }

                    if (updateValues.Insert.Any())
                    {
                        var mainItem = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == Parent);
                        if (mainItem != null)
                        {
                            foreach (var item in updateValues.Insert)
                            {
                                if (updateValues.IsValid(item))
                                {
                                    var revNewItem = new Pass_zg_revision();
                                    revNewItem.p_rev_date = item.RevDate;
                                    revNewItem.p_rev_record = item.RevRecord;
                                    revNewItem.p_zg_nr = mainItem.p_zg_nr;
                                    revNewItem.p_zg_id = mainItem.ID;

                                    db.Pass_zg_revision.Add(revNewItem);
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }
        

            return PartialView("Controls/BrowseForm2PassZgRevisionPartial", FormHelper.GetPassZgRevisionItems(Parent));
        }

        [ValidateInput(false)]
        public ActionResult BrowseForm2PassZuweisungZSBNrSessionEdit(MVCxGridViewBatchUpdateValues<PassZuweisungZsbNrViewModel, int> updateValues, int Parent)
        {
            if (updateValues != null)
            {
                using (var db = new KonstructionEntities())
                {
                    if (updateValues.Update.Any())
                    {
                        foreach (var item in updateValues.Update)
                        {
                            var pzznr = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == item.PasszuweisungZSBNr);
                            if (pzznr != null)
                            {
                                var itemToUpdate = db.Pass_zuweisung_ZSB_Nr.FirstOrDefault(x => x.ID == item.ID);
                                if (itemToUpdate != null)
                                {
                                    itemToUpdate.p_unter_zsb_zg_nr = pzznr.p_zg_nr;
                                    itemToUpdate.p_unter_zsb_zg_id = pzznr.ID;
                                    db.SaveChanges();
                                }
                            }
                        }
                    }

                    if (updateValues.Insert.Any())
                    {
                        var mainItem = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == Parent);
                        if (mainItem != null)
                        {
                            foreach (var item in updateValues.Insert)
                            {
                                var pzznr = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == item.PasszuweisungZSBNr);
                                if (pzznr != null)
                                {
                                    if (updateValues.IsValid(item))
                                    {
                                        var revNewItem = new Pass_zuweisung_ZSB_Nr();
                                        revNewItem.p_unter_zsb_zg_nr = pzznr.p_zg_nr;
                                        revNewItem.p_unter_zsb_zg_id = pzznr.ID;

                                        revNewItem.p_zg_nr = mainItem.p_zg_nr;
                                        revNewItem.p_zg_id = mainItem.ID;

                                        db.Pass_zuweisung_ZSB_Nr.Add(revNewItem);
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                }
            }


            return PartialView("Controls/BrowseForm2PassZuweisungZSBNrPartial", FormHelper.GetPassZuweisungZsbNrItems(Parent));
        }

        public ActionResult DeletePassZgRevision(int id)
        {
            FormHelper.DeletePassZgRevision(id);

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeletePassZuweisungZSBNr(int id)
        {
            FormHelper.DeletePassZuweisungZSBNr(id);

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TakeoverForm1(int ID)
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            KundenTeileNrFormViewModel model = FormHelper.GetForm1(ID);
            if (model == null) return RedirectToAction("InvalidOperation", "Security");

            var ui = CommonHelper.GetUserInfo();
            model.UserInfo = ui;
            FormHelper.AssignToForm1(model.UserInfo.UserName, ID, true);

            return RedirectToAction("BrowseForm1", "Form", new { ID = ID });
        }

        public ActionResult BrowseForm1(int ID)
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            KundenTeileNrFormViewModel model = FormHelper.GetForm1(ID);
            if (model == null) return RedirectToAction("InvalidOperation", "Security");

            var ui = CommonHelper.GetUserInfo();
            model.UserInfo = ui;
            if (ui.UserRole == Model.Class.UserRole.Full)
                FormHelper.AssignToForm1(model.UserInfo.UserName, ID, false);
            model = FormHelper.GetForm1(ID);
            model.UserInfo = ui;

            return View(model);
        }

        [HttpPost]

        [ValidateInput(false)]
        public ActionResult BrowseForm1(KundenTeileNrFormViewModel model)
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            KundenTeileNrFormViewModel check = FormHelper.GetForm1(model.ID);
            if (check == null) return RedirectToAction("InvalidOperation", "Security");

            if (!string.IsNullOrEmpty(model.PassPdbNr) && (model.PassPdbNr.Length != 12 && model.PassPdbNr.Replace(".", "").Replace(" ", "").Length != 0))
                ModelState.AddModelError("PassPdbNr", "Ungültiges Format!");

            if (ModelState.IsValid)
            {
                var ui = CommonHelper.GetUserInfo();
                if (ui != null && ui.UserName.ToLower() != check.AssignedTo.ToLower())
                    return RedirectToAction("BrowseForm1", "Form", new { ID = model.ID });

                FormHelper.UpdateForm1(model);

                return RedirectToAction("BrowseForm1", "Form", new { ID = model.ID });
            }

            model.UserInfo = CommonHelper.GetUserInfo();

            return View(model);
        }
        public ActionResult BrowseForm1KundeZgRevisionPartial(int Parent)
        {
            return PartialView("Controls/BrowseForm1KundeZgRevisionPartial", FormHelper.GetKundeZgRevisionItems(Parent));
        }

        [ValidateInput(false)]
        public ActionResult BrowseForm1KundeZgRevisionEdit(MVCxGridViewBatchUpdateValues<KundeZgRevisionViewModel, int> updateValues, int Parent)
        {
            if (updateValues != null)
            {
                using (var db = new KonstructionEntities())
                {
                    if (updateValues.Update.Any())
                    {
                        foreach (var item in updateValues.Update)
                        {
                            var itemToUpdate = db.Kunde_zg_revision.FirstOrDefault(x => x.ID == item.ID);
                            if (itemToUpdate != null)
                            {
                                itemToUpdate.k_rev_date = item.RevDate;
                                itemToUpdate.k_rev_record = item.RevRecord;
                                db.SaveChanges();
                            }
                        }
                    }

                    if (updateValues.Insert.Any())
                    {
                        var mainItem = db.Kunden_Teile_nr.FirstOrDefault(x => x.ID == Parent);
                        if (mainItem != null)
                        {
                            foreach (var item in updateValues.Insert)
                            {
                                if (updateValues.IsValid(item))
                                {
                                    var revNewItem = new Kunde_zg_revision();
                                    revNewItem.k_rev_date = item.RevDate;
                                    revNewItem.k_rev_record = item.RevRecord;
                                    revNewItem.k_zg_nr = mainItem.k_zg_nr;
                                    revNewItem.k_zg_id = mainItem.ID;

                                    db.Kunde_zg_revision.Add(revNewItem);
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }


            return PartialView("Controls/BrowseForm1KundeZgRevisionPartial", FormHelper.GetKundeZgRevisionItems(Parent));
        }

        public ActionResult DeleteKundeZgRevision(int id)
        {
            FormHelper.DeleteKundeZgRevision(id);

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult BrowseForm1KundeZuweisungZSBNrPartial(int Parent)
        {
            return PartialView("Controls/BrowseForm1KundeZuweisungZSBNrPartial", FormHelper.GetKundeZuweisungZsbsNrItems(Parent));
        }

        [ValidateInput(false)]
        public ActionResult BrowseForm1KundeZuweisungZSBNrEdit(MVCxGridViewBatchUpdateValues<KundeZuweisungZsbNrViewModel, int> updateValues, int Parent)
        {
            if (updateValues != null)
            {
                using (var db = new KonstructionEntities())
                {
                    if (updateValues.Update.Any())
                    {
                        foreach (var item in updateValues.Update)
                        {
                            var itemToUpdate = db.Kunde_zuweisung_ZSB_Nr.FirstOrDefault(x => x.ID == item.ID);
                            if (itemToUpdate != null)
                            {
                                var pzznr = db.Kunden_Teile_nr.FirstOrDefault(x => x.ID == item.KundezuweisungZSBNr);
                                if (pzznr != null)
                                {
                                    itemToUpdate.k_unter_zsb_zg_nr = pzznr.k_zg_nr;
                                    itemToUpdate.k_unter_zsb_zg_id = pzznr.ID;
                                    db.SaveChanges();
                                }
                            }
                        }
                    }

                    if (updateValues.Insert.Any())
                    {
                        var mainItem = db.Kunden_Teile_nr.FirstOrDefault(x => x.ID == Parent);
                        if (mainItem != null)
                        {
                            foreach (var item in updateValues.Insert)
                            {
                                if (updateValues.IsValid(item))
                                {
                                    var pzznr = db.Kunden_Teile_nr.FirstOrDefault(x => x.ID == item.KundezuweisungZSBNr);
                                    if (pzznr != null)
                                    {
                                        var revNewItem = new Kunde_zuweisung_ZSB_Nr();
                                        revNewItem.k_unter_zsb_zg_nr = pzznr.k_zg_nr;
                                        revNewItem.k_unter_zsb_zg_id = pzznr.ID;

                                        revNewItem.k_zg_nr = mainItem.k_zg_nr;
                                        revNewItem.k_zg_id = mainItem.ID;

                                        db.Kunde_zuweisung_ZSB_Nr.Add(revNewItem);
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                }
            }


            return PartialView("Controls/BrowseForm1KundeZuweisungZSBNrPartial", FormHelper.GetKundeZuweisungZsbsNrItems(Parent));
        }

        public ActionResult DeleteKundeZuweisungZSBNr(int id)
        {
            FormHelper.DeleteKundeZuweisungZSBNr(id);

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);

        }

        public ActionResult BrowseForm1PassKundeZuweisungZSBNrPartial(int Parent)
        {
            return PartialView("Controls/BrowseForm1PassKundeZuweisungZSBNrPartial", FormHelper.GetPassKundeZuweisungZsbsNrItems(Parent));
        }

        [ValidateInput(false)]
        public ActionResult BrowseForm1PassKundeZuweisungZSBNrEdit(MVCxGridViewBatchUpdateValues<PassKundeZuweisungZsbNrViewModel, int> updateValues, int Parent)
        {
            if (updateValues != null)
            {
                using (var db = new KonstructionEntities())
                {
                    if (updateValues.Update.Any())
                    {
                        foreach (var item in updateValues.Update)
                        {
                            var itemToUpdate = db.Pass_Kunde_zuweisung_ZSB_Nr.FirstOrDefault(x => x.ID == item.ID);
                            if (itemToUpdate != null)
                            {
                                var pzznr = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == item.PassKundezuweisungZSBNr);
                                if (pzznr != null)
                                {
                                    itemToUpdate.p_zg_nr = pzznr.p_zg_nr;
                                    itemToUpdate.p_zg_id = pzznr.ID;
                                    db.SaveChanges();
                                }
                            }
                        }
                    }

                    if (updateValues.Insert.Any())
                    {
                        var mainItem = db.Kunden_Teile_nr.FirstOrDefault(x => x.ID == Parent);
                        if (mainItem != null)
                        {
                            foreach (var item in updateValues.Insert)
                            {
                                if (updateValues.IsValid(item))
                                {
                                    var pzznr = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == item.PassKundezuweisungZSBNr);
                                    if (pzznr != null)
                                    {
                                        var revNewItem = new Pass_Kunde_zuweisung_ZSB_Nr();
                                        revNewItem.p_zg_nr = pzznr.p_zg_nr;
                                        revNewItem.p_zg_id = pzznr.ID;

                                        revNewItem.k_zg_nr = mainItem.k_zg_nr;
                                        revNewItem.k_zg_id = mainItem.ID;

                                        db.Pass_Kunde_zuweisung_ZSB_Nr.Add(revNewItem);
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                }
            }


            return PartialView("Controls/BrowseForm1PassKundeZuweisungZSBNrPartial", FormHelper.GetPassKundeZuweisungZsbsNrItems(Parent));
        }

        public ActionResult DeletePassKundeZuweisungZSBNr(int id)
        {
            FormHelper.DeletePassKundeZuweisungZSBNr(id);

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);

        }

        private void RemoveErrorFromModalState(string key)
        {
            if ((ModelState.Keys.Count > 0) && (ModelState.Keys.Any(x => x == key)))
            {
                ModelState[key].Errors.Clear();
            }
        }

    }
}
