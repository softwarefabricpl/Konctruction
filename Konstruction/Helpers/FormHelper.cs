using Konstruction.Model;
using Konstruction.Model.Class;
using Konstruction.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Konstruction.Helpers
{
    public class FormHelper
    {

        #region Session data form 2
        public static Form1PassZgRevisioNrData GetSessionForm1PassZgRevisionData(string ID)
        {
            var model = SessionDataHelper.GetForm1PassZgRevisionSessionData(ID);
            if (model != null)
            {
                return model;
            }
            else
            {
                model = new Form1PassZgRevisioNrData();
                model.Key = ID;

                SessionDataHelper.SetForm1PassZgRevisionSessionData(model, ID);
                return model;
            }
        }

        public static Form1PassZuweisungZsbNrData GetSessionForm1PassZuweisungZSBNrData(string ID)
        {
            var model = SessionDataHelper.GetForm1PassZuweisungZSBNrSessionData(ID);
            if (model != null)
            {
                return model;
            }
            else
            {
                model = new Form1PassZuweisungZsbNrData();
                model.Key = ID;

                SessionDataHelper.SetForm1PassZuweisungZSBNrSessionData(model, ID);
                return model;
            }
        }

        public static int GetLastPassZuweisungZsbNrID(string sessionKey)
        {
            int id = 1;

            var item = SessionDataHelper.GetForm1PassZuweisungZSBNrSessionData(sessionKey);

            if (item != null)
            {
                id = item.PassZuweisungZsbNrData.Count > 0 ? item.PassZuweisungZsbNrData.Max(x => x.ID) + 1 : 1;
            }
            else
            {
                Form1PassZuweisungZsbNrData newItem = new Form1PassZuweisungZsbNrData();
                newItem.Key = sessionKey;
                SessionDataHelper.SetForm1PassZuweisungZSBNrSessionData(newItem, sessionKey);
            }


            return id;
        }
        public static void RemovePassZuweisungZsbNr(string sessionKey, int? ID)
        {
            var item = SessionDataHelper.GetForm1PassZuweisungZSBNrSessionData(sessionKey);
            if (item != null && ID.HasValue)
            {

                PassZuweisungZsbNrViewModel itemToDelete = item.PassZuweisungZsbNrData.FirstOrDefault(x => x.ID == ID);
                if (itemToDelete != null)
                {
                    item.PassZuweisungZsbNrData.RemoveAt(item.PassZuweisungZsbNrData.IndexOf(itemToDelete));
                }

                SessionDataHelper.SetForm1PassZuweisungZSBNrSessionData(item, sessionKey);

            }
        }
        public static void AddtPassZuweisungZsbNr(string sessionKey, PassZuweisungZsbNrViewModel model)
        {
            var item = SessionDataHelper.GetForm1PassZuweisungZSBNrSessionData(sessionKey);
            if (item != null)
            {
                item.PassZuweisungZsbNrData.Add(model);
                SessionDataHelper.SetForm1PassZuweisungZSBNrSessionData(item, sessionKey);
            }
        }

        public static void UpdatePassZuweisungZsbNr(string sessionKey, PassZuweisungZsbNrViewModel model)
        {
            var item = SessionDataHelper.GetForm1PassZuweisungZSBNrSessionData(sessionKey);
            if (item != null)
            {

                PassZuweisungZsbNrViewModel itemToUpdate = item.PassZuweisungZsbNrData.FirstOrDefault(x => x.ID == model.ID);
                if (itemToUpdate != null)
                {
                    item.PassZuweisungZsbNrData[item.PassZuweisungZsbNrData.IndexOf(itemToUpdate)] = model;
                }

                SessionDataHelper.SetForm1PassZuweisungZSBNrSessionData(item, sessionKey);
            }
        }


        public static void RemovePassZgRevision(string sessionKey, int? ID)
        {
            var item = SessionDataHelper.GetForm1PassZgRevisionSessionData(sessionKey);
            if (item != null && ID.HasValue)
            {

                PassZgRevisionViewModel itemToDelete = item.PassZgRevisionData.FirstOrDefault(x => x.ID == ID);
                if (itemToDelete != null)
                {
                    item.PassZgRevisionData.RemoveAt(item.PassZgRevisionData.IndexOf(itemToDelete));
                }

                SessionDataHelper.SetForm1PassZgRevisionSessionData(item, sessionKey);

            }
        }

        public static int GetLastPassZgRevisionID(string sessionKey)
        {
            int id = 1;

            var item = SessionDataHelper.GetForm1PassZgRevisionSessionData(sessionKey);

            if (item != null)
            {
                id = item.PassZgRevisionData.Count > 0 ? item.PassZgRevisionData.Max(x => x.ID) + 1 : 1;
            }
            else
            {
                Form1PassZgRevisioNrData newItem = new Form1PassZgRevisioNrData();
                newItem.Key = sessionKey;
                SessionDataHelper.SetForm1PassZgRevisionSessionData(newItem, sessionKey);
            }


            return id;
        }

        public static void AddPassZgRevision(string sessionKey, PassZgRevisionViewModel model)
        {
            var item = SessionDataHelper.GetForm1PassZgRevisionSessionData(sessionKey);
            if (item != null)
            {
                item.PassZgRevisionData.Add(model);
                SessionDataHelper.SetForm1PassZgRevisionSessionData(item, sessionKey);
            }
        }

        public static void UpdatePassZgRevision(string sessionKey, PassZgRevisionViewModel model)
        {
            var item = SessionDataHelper.GetForm1PassZgRevisionSessionData(sessionKey);
            if (item != null)
            {

                PassZgRevisionViewModel itemToUpdate = item.PassZgRevisionData.FirstOrDefault(x => x.ID == model.ID);
                if (itemToUpdate != null)
                {
                    item.PassZgRevisionData[item.PassZgRevisionData.IndexOf(itemToUpdate)] = model;
                }

                SessionDataHelper.SetForm1PassZgRevisionSessionData(item, sessionKey);
            }
        }
        #endregion

        #region Session data form 2
        public static Form2KundeZuweisungZsbNrData GetSessionForm2KundeZuweisungZSBNrData(string ID)
        {
            var model = SessionDataHelper.GetForm2KundeZuweisungZSBNrSessionData(ID);
            if (model != null)
            {
                return model;
            }
            else
            {
                model = new Form2KundeZuweisungZsbNrData();
                model.Key = ID;

                SessionDataHelper.SetForm2KundeZuweisungZSBNrSessionData(model, ID);
                return model;
            }
        }
        public static void RemoveKundeZuweisungZsbNr(string sessionKey, int? ID)
        {
            var item = SessionDataHelper.GetForm2KundeZuweisungZSBNrSessionData(sessionKey);
            if (item != null && ID.HasValue)
            {

                KundeZuweisungZsbNrViewModel itemToDelete = item.KundeZuweisungZsbNrData.FirstOrDefault(x => x.ID == ID);
                if (itemToDelete != null)
                {
                    item.KundeZuweisungZsbNrData.RemoveAt(item.KundeZuweisungZsbNrData.IndexOf(itemToDelete));
                }

                SessionDataHelper.SetForm2KundeZuweisungZSBNrSessionData(item, sessionKey);

            }
        }

        public static int GetLastKundeZuweisungZsbNrID(string sessionKey)
        {
            int id = 1;

            var item = SessionDataHelper.GetForm2KundeZuweisungZSBNrSessionData(sessionKey);

            if (item != null)
            {
                id = item.KundeZuweisungZsbNrData.Count > 0 ? item.KundeZuweisungZsbNrData.Max(x => x.ID) + 1 : 1;
            }
            else
            {
                Form2KundeZuweisungZsbNrData newItem = new Form2KundeZuweisungZsbNrData();
                newItem.Key = sessionKey;
                SessionDataHelper.SetForm2KundeZuweisungZSBNrSessionData(newItem, sessionKey);
            }


            return id;
        }

        public static void AddKundeZuweisungZsbNr(string sessionKey, KundeZuweisungZsbNrViewModel model)
        {
            var item = SessionDataHelper.GetForm2KundeZuweisungZSBNrSessionData(sessionKey);
            if (item != null)
            {
                item.KundeZuweisungZsbNrData.Add(model);
                SessionDataHelper.SetForm2KundeZuweisungZSBNrSessionData(item, sessionKey);
            }
        }

        public static void UpdateKundeZuweisungZsbNr(string sessionKey, KundeZuweisungZsbNrViewModel model)
        {
            var item = SessionDataHelper.GetForm2KundeZuweisungZSBNrSessionData(sessionKey);
            if (item != null)
            {

                KundeZuweisungZsbNrViewModel itemToUpdate = item.KundeZuweisungZsbNrData.FirstOrDefault(x => x.ID == model.ID);
                if (itemToUpdate != null)
                {
                    item.KundeZuweisungZsbNrData[item.KundeZuweisungZsbNrData.IndexOf(itemToUpdate)] = model;
                }

                SessionDataHelper.SetForm2KundeZuweisungZSBNrSessionData(item, sessionKey);
            }
        }

        public static Form2PassKundeZuweisungZsbNrData GetSessionForm2PassKundeZuweisungZSBNrData(string ID)
        {
            var model = SessionDataHelper.GetForm2PassKundeZuweisungZSBNrSessionData(ID);
            if (model != null)
            {
                return model;
            }
            else
            {
                model = new Form2PassKundeZuweisungZsbNrData();
                model.Key = ID;

                SessionDataHelper.SetForm2PassKundeZuweisungZSBNrSessionData(model, ID);
                return model;
            }
        }
        public static void RemovePassKundeZuweisungZsbNr(string sessionKey, int? ID)
        {
            var item = SessionDataHelper.GetForm2PassKundeZuweisungZSBNrSessionData(sessionKey);
            if (item != null && ID.HasValue)
            {

                PassKundeZuweisungZsbNrViewModel itemToDelete = item.PassKundeZuweisungZsbNrData.FirstOrDefault(x => x.ID == ID);
                if (itemToDelete != null)
                {
                    item.PassKundeZuweisungZsbNrData.RemoveAt(item.PassKundeZuweisungZsbNrData.IndexOf(itemToDelete));
                }

                SessionDataHelper.SetForm2PassKundeZuweisungZSBNrSessionData(item, sessionKey);

            }
        }

        public static int GetLastPassKundeZuweisungZsbNrID(string sessionKey)
        {
            int id = 1;

            var item = SessionDataHelper.GetForm2PassKundeZuweisungZSBNrSessionData(sessionKey);

            if (item != null)
            {
                id = item.PassKundeZuweisungZsbNrData.Count > 0 ? item.PassKundeZuweisungZsbNrData.Max(x => x.ID) + 1 : 1;
            }
            else
            {
                Form2PassKundeZuweisungZsbNrData newItem = new Form2PassKundeZuweisungZsbNrData();
                newItem.Key = sessionKey;
                SessionDataHelper.SetForm2PassKundeZuweisungZSBNrSessionData(newItem, sessionKey);
            }


            return id;
        }

        public static void AddPassKundeZuweisungZsbNr(string sessionKey, PassKundeZuweisungZsbNrViewModel model)
        {
            var item = SessionDataHelper.GetForm2PassKundeZuweisungZSBNrSessionData(sessionKey);
            if (item != null)
            {
                item.PassKundeZuweisungZsbNrData.Add(model);
                SessionDataHelper.SetForm2PassKundeZuweisungZSBNrSessionData(item, sessionKey);
            }
        }

        public static void UpdatePassKundeZuweisungZsbNr(string sessionKey, PassKundeZuweisungZsbNrViewModel model)
        {
            var item = SessionDataHelper.GetForm2PassKundeZuweisungZSBNrSessionData(sessionKey);
            if (item != null)
            {

                PassKundeZuweisungZsbNrViewModel itemToUpdate = item.PassKundeZuweisungZsbNrData.FirstOrDefault(x => x.ID == model.ID);
                if (itemToUpdate != null)
                {
                    item.PassKundeZuweisungZsbNrData[item.PassKundeZuweisungZsbNrData.IndexOf(itemToUpdate)] = model;
                }

                SessionDataHelper.SetForm2PassKundeZuweisungZSBNrSessionData(item, sessionKey);
            }
        }

        public static Form2KundeZgRevisioNrData GetSessionForm2KundeZgRevisionData(string ID)
        {
            var model = SessionDataHelper.GetForm2KundeZgRevisionSessionData(ID);
            if (model != null)
            {
                return model;
            }
            else
            {
                model = new Form2KundeZgRevisioNrData();
                model.Key = ID;

                SessionDataHelper.SetForm2KundeZgRevisionSessionData(model, ID);
                return model;
            }
        }

        public static void RemoveKundeZgRevision(string sessionKey, int? ID)
        {
            var item = SessionDataHelper.GetForm2KundeZgRevisionSessionData(sessionKey);
            if (item != null && ID.HasValue)
            {

                KundeZgRevisionViewModel itemToDelete = item.KundeZgRevisionData.FirstOrDefault(x => x.ID == ID);
                if (itemToDelete != null)
                {
                    item.KundeZgRevisionData.RemoveAt(item.KundeZgRevisionData.IndexOf(itemToDelete));
                }

                SessionDataHelper.SetForm2KundeZgRevisionSessionData(item, sessionKey);

            }
        }
        public static int GetLastKundeZgRevisionID(string sessionKey)
        {
            int id = 1;

            var item = SessionDataHelper.GetForm2KundeZgRevisionSessionData(sessionKey);

            if (item != null)
            {
                id = item.KundeZgRevisionData.Count > 0 ? item.KundeZgRevisionData.Max(x => x.ID) + 1 : 1;
            }
            else
            {
                Form2KundeZgRevisioNrData newItem = new Form2KundeZgRevisioNrData();
                newItem.Key = sessionKey;
                SessionDataHelper.SetForm2KundeZgRevisionSessionData(newItem, sessionKey);
            }


            return id;
        }

        public static void AddKundeZgRevision(string sessionKey, KundeZgRevisionViewModel model)
        {
            var item = SessionDataHelper.GetForm2KundeZgRevisionSessionData(sessionKey);
            if (item != null)
            {
                item.KundeZgRevisionData.Add(model);
                SessionDataHelper.SetForm2KundeZgRevisionSessionData(item, sessionKey);
            }
        }

        public static void UpdateKundeZgRevision(string sessionKey, KundeZgRevisionViewModel model)
        {
            var item = SessionDataHelper.GetForm2KundeZgRevisionSessionData(sessionKey);
            if (item != null)
            {

                KundeZgRevisionViewModel itemToUpdate = item.KundeZgRevisionData.FirstOrDefault(x => x.ID == model.ID);
                if (itemToUpdate != null)
                {
                    item.KundeZgRevisionData[item.KundeZgRevisionData.IndexOf(itemToUpdate)] = model;
                }

                SessionDataHelper.SetForm2KundeZgRevisionSessionData(item, sessionKey);
            }
        }
        #endregion

        public static int SaveForm1(KundenTeileNrFormViewModel model)
        {
            int id = 0;
            using (var db = new KonstructionEntities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var item = new Kunden_Teile_nr();
                        item.data_format = model.Datenformat;
                        item.k_zg_nr = model.KZgNr.ToUpper();
                        item.k_zg_bz = model.KZgBz;
                        item.k_zg_date = model.KZgDate;
                        item.k_zg_memo = model.ZgMemo;
                        item.k_pda_stand = model.Pdastand;
                        item.Ersteller = model.Ersteller;
                        if (!string.IsNullOrEmpty(model.PassPdbNr) && model.PassPdbNr.Length == 12)
                            item.PassPdbNr = model.PassPdbNr;
                        else
                            item.PassPdbNr = null;

                        var ui = CommonHelper.GetUserInfo();
                        if (ui != null && ui.UserRole == UserRole.Full)
                        {
                            item.AssignedOn = DateTime.Now;
                            item.AssignedTo = ui.UserName;
                        }

                        db.Kunden_Teile_nr.Add(item);
                        db.SaveChanges();

                        var sessionData = GetSessionForm2KundeZgRevisionData(model.SessionKey);
                        if (sessionData != null && sessionData.KundeZgRevisionData.Any())
                        {
                            foreach (var rev in sessionData.KundeZgRevisionData)
                            {

                                var revNewItem = new Kunde_zg_revision();
                                revNewItem.k_rev_date = rev.RevDate;
                                revNewItem.k_rev_record = rev.RevRecord;
                                revNewItem.k_zg_nr = model.KZgNr;
                                revNewItem.k_zg_id = item.ID;

                                db.Kunde_zg_revision.Add(revNewItem);
                                db.SaveChanges();
                            }
                        }

                        var sessionData2 = GetSessionForm2KundeZuweisungZSBNrData(model.SessionKey);
                        if (sessionData2 != null && sessionData2.KundeZuweisungZsbNrData.Any())
                        {
                            foreach (var rev in sessionData2.KundeZuweisungZsbNrData)
                            {
                                var pzznr = db.Kunden_Teile_nr.FirstOrDefault(x => x.ID == rev.KundezuweisungZSBNr);
                                if (pzznr != null)
                                {
                                    var revNewItem = new Kunde_zuweisung_ZSB_Nr();
                                    revNewItem.k_unter_zsb_zg_nr = pzznr.k_zg_nr;
                                    revNewItem.k_unter_zsb_zg_id = pzznr.ID;

                                    revNewItem.k_zg_nr = model.KZgNr;
                                    revNewItem.k_zg_id = item.ID;

                                    db.Kunde_zuweisung_ZSB_Nr.Add(revNewItem);
                                    db.SaveChanges();
                                }
                            }
                        }

                        var sessionData3 = GetSessionForm2PassKundeZuweisungZSBNrData(model.SessionKey);
                        if (sessionData3 != null && sessionData3.PassKundeZuweisungZsbNrData.Any())
                        {
                            foreach (var rev in sessionData3.PassKundeZuweisungZsbNrData)
                            {
                                var pzznr = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == rev.PassKundezuweisungZSBNr);
                                if (pzznr != null)
                                {
                                    var revNewItem = new Pass_Kunde_zuweisung_ZSB_Nr();
                                    revNewItem.p_zg_nr = pzznr.p_zg_nr;
                                    revNewItem.p_zg_id = pzznr.ID;

                                    revNewItem.k_zg_nr = item.k_zg_nr;
                                    revNewItem.k_zg_id = item.ID;

                                    db.Pass_Kunde_zuweisung_ZSB_Nr.Add(revNewItem);
                                    db.SaveChanges();
                                }
                            }
                        }

                        tran.Commit();
                        id = item.ID;
                        SessionDataHelper.RemoveForm2KundeZuweisungZSBNrSessionData(model.SessionKey);
                        SessionDataHelper.RemoveForm2PassKundeZuweisungZSBNrSessionData(model.SessionKey);
                        SessionDataHelper.RemoveForm2KundeZgRevisionSessionData(model.SessionKey);
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }

            }

            return id;
        }

        public static int SaveForm2(PassTeileNrFormViewModel model)
        {
            int id = 0;
            using (var db = new KonstructionEntities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var lastNo = db.Last_Pass_Teile_nr.FirstOrDefault(x => x.ID == 1);
                        int noInt = lastNo.LastPasTeileNr + 1;
                        string noString = noInt.ToString().PadLeft(8, '0');
                        var item = new Pass_Teile_nr();
                        item.data_format = model.Datenformat;
                        item.p_zg_bz = model.Bezeichnung;
                        item.p_zg_date = model.Datensatz;
                        item.Customer_Number = model.CustomerNumber;
                        item.p_zg_memo = model.Bemerkung;
                        item.p_zg_nr = noString;
                        if (!string.IsNullOrEmpty(model.PassPdbNr) && model.PassPdbNr.Length == 12)
                            item.PassPdbNr = model.PassPdbNr;
                        else
                            item.PassPdbNr = null;

                        var ui = CommonHelper.GetUserInfo();
                        if (ui != null && ui.UserRole == UserRole.Full)
                        {
                            item.AssignedOn = DateTime.Now;
                            item.AssignedTo = ui.UserName;
                        }

                        db.Pass_Teile_nr.Add(item);
                        db.SaveChanges();

                        var sessionData = GetSessionForm1PassZgRevisionData(model.SessionKey);
                        if (sessionData != null && sessionData.PassZgRevisionData.Any())
                        {
                            foreach (var rev in sessionData.PassZgRevisionData)
                            {

                                var revNewItem = new Pass_zg_revision();
                                revNewItem.p_rev_date = rev.RevDate;
                                revNewItem.p_rev_record = rev.RevRecord;
                                revNewItem.p_zg_nr = noString;
                                revNewItem.p_zg_id = item.ID;

                                db.Pass_zg_revision.Add(revNewItem);
                                db.SaveChanges();
                            }
                        }

                        var sessionData2 = GetSessionForm1PassZuweisungZSBNrData(model.SessionKey);
                        if (sessionData2 != null && sessionData2.PassZuweisungZsbNrData.Any())
                        {
                            foreach (var rev in sessionData2.PassZuweisungZsbNrData)
                            {
                                var pzznr = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == rev.PasszuweisungZSBNr);
                                if (pzznr != null)
                                {
                                    var revNewItem = new Pass_zuweisung_ZSB_Nr();
                                    revNewItem.p_unter_zsb_zg_nr = pzznr.p_zg_nr;
                                    revNewItem.p_unter_zsb_zg_id = pzznr.ID;

                                    revNewItem.p_zg_nr = noString;
                                    revNewItem.p_zg_id = item.ID;

                                    db.Pass_zuweisung_ZSB_Nr.Add(revNewItem);
                                    db.SaveChanges();
                                }
                            }
                        }

                        lastNo.LastPasTeileNr = noInt;
                        db.SaveChanges();

                        tran.Commit();
                        id = item.ID;
                        SessionDataHelper.RemoveForm1PassZgRevisionSessionData(model.SessionKey);
                        SessionDataHelper.RemoveForm1PassZgRevisionSessionData(model.SessionKey);

                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }

            }
            return id;
        }

        public static void UpdateForm2(PassTeileNrFormViewModel model)
        {
            using (var db = new KonstructionEntities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var itemToUpdate = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == model.ID);
                        if (itemToUpdate != null)
                        {
                            itemToUpdate.data_format = model.Datenformat;
                            itemToUpdate.p_zg_bz = model.Bezeichnung;
                            itemToUpdate.p_zg_date = model.Datensatz;
                            itemToUpdate.p_zg_memo = model.Bemerkung;
                            itemToUpdate.Customer_Number = model.CustomerNumber;
                            itemToUpdate.p_zg_nr = model.ZgNr.PadLeft(8, '0');
                            if (!string.IsNullOrEmpty(model.PassPdbNr) && model.PassPdbNr.Length == 12)
                                itemToUpdate.PassPdbNr = model.PassPdbNr;
                            else
                                itemToUpdate.PassPdbNr = null;

                            db.SaveChanges();

                            tran.Commit();
                        }


                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void UpdateForm1(KundenTeileNrFormViewModel model)
        {
            using (var db = new KonstructionEntities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var itemToUpdate = db.Kunden_Teile_nr.FirstOrDefault(x => x.ID == model.ID);
                        if (itemToUpdate != null)
                        {
                            itemToUpdate.data_format = model.Datenformat;
                            itemToUpdate.k_zg_nr = model.KZgNr.ToUpper(); 
                            itemToUpdate.k_zg_bz = model.KZgBz;
                            itemToUpdate.k_zg_date = model.KZgDate;
                            itemToUpdate.k_zg_memo = model.ZgMemo;
                            itemToUpdate.k_pda_stand = model.Pdastand;
                            itemToUpdate.Ersteller = model.Ersteller;
                            if (!string.IsNullOrEmpty(model.PassPdbNr) && model.PassPdbNr.Length == 12)
                                itemToUpdate.PassPdbNr = model.PassPdbNr;
                            else
                                itemToUpdate.PassPdbNr = null;

                            db.SaveChanges();

                            tran.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }
            }
        }
        public static void AssignToForm1(string user, int ID, bool force)
        {
            using (var db = new KonstructionEntities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var itemToUpdate = db.Kunden_Teile_nr.FirstOrDefault(x => x.ID == ID);
                        if (itemToUpdate != null)
                        {
                            if (force)
                            {
                                itemToUpdate.AssignedTo = user;
                                itemToUpdate.AssignedOn = DateTime.Now;
                                db.SaveChanges();
                            }
                            else if (!itemToUpdate.AssignedOn.HasValue)
                            {
                                itemToUpdate.AssignedTo = user;
                                itemToUpdate.AssignedOn = DateTime.Now;
                                db.SaveChanges();
                            }
                            tran.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void AssignToForm2(string user, int ID, bool force)
        {
            using (var db = new KonstructionEntities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var itemToUpdate = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == ID);
                        if (itemToUpdate != null)
                        {
                            if (force)
                            {
                                itemToUpdate.AssignedTo = user;
                                itemToUpdate.AssignedOn = DateTime.Now;
                                db.SaveChanges();
                            }
                            else if (!itemToUpdate.AssignedOn.HasValue)
                            {
                                itemToUpdate.AssignedTo = user;
                                itemToUpdate.AssignedOn = DateTime.Now;
                                db.SaveChanges();
                            }
                            tran.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void DeletePassZgRevision(int ID)
        {
            using (var db = new KonstructionEntities())
            {
                var item = db.Pass_zg_revision.FirstOrDefault(x => x.ID == ID);
                if(item!=null)
                {
                    db.Pass_zg_revision.Remove(item);
                    db.SaveChanges();
                }
            }
        }
        public static void DeletePassZuweisungZSBNr(int ID)
        {
            using (var db = new KonstructionEntities())
            {
                var item = db.Pass_zuweisung_ZSB_Nr.FirstOrDefault(x => x.ID == ID);
                if (item != null)
                {
                    db.Pass_zuweisung_ZSB_Nr.Remove(item);
                    db.SaveChanges();
                }
            }
        }
        public static PassTeileNrFormViewModel GetForm2(int ID)
        {
            using (var db = new KonstructionEntities())
            {
                if (db.Pass_Teile_nr.Any(x => x.ID == ID))
                {
                    return (from l in db.Pass_Teile_nr.AsNoTracking()
                            where l.ID == ID
                            select new PassTeileNrFormViewModel
                            {
                                ID = l.ID,
                                Bezeichnung = l.p_zg_bz,
                                Datenformat = l.data_format,
                                Bemerkung = l.p_zg_memo,
                                PassPdbNr = l.PassPdbNr,
                                Datensatz = l.p_zg_date,
                                ZgNr = l.p_zg_nr,
                                AssignedOn = l.AssignedOn,
                                AssignedTo = l.AssignedTo,
                                CustomerNumber=l.Customer_Number
                            }).First();
                }
            }

            return null;
        }

        public static KundenTeileNrFormViewModel GetForm1(int ID)
        {
            using (var db = new KonstructionEntities())
            {
                if (db.Kunden_Teile_nr.Any(x => x.ID == ID))
                {
                    return (from l in db.Kunden_Teile_nr.AsNoTracking()
                            where l.ID == ID
                            select new KundenTeileNrFormViewModel
                            {
                                ID = l.ID,
                                KZgBz = l.k_zg_bz,
                                Datenformat = l.data_format,
                                Ersteller = l.Ersteller,
                                Pdastand = l.k_pda_stand,
                                KZgDate = l.k_zg_date,
                                KZgNr = l.k_zg_nr,
                                ZgMemo = l.k_zg_memo,
                                AssignedOn = l.AssignedOn,
                                AssignedTo = l.AssignedTo,
                                PassPdbNr = l.PassPdbNr
                            }).First();

                }

                return null;
            }
        }

        public static PassZgRevisionsViewModel GetPassZgRevisionItems(int ID)
        {
            PassZgRevisionsViewModel result = new PassZgRevisionsViewModel();
            result.Parent = ID;

            using (var db = new KonstructionEntities())
            {
                result.Source = (from l in db.Pass_zg_revision.AsNoTracking()
                          where l.p_zg_id == ID
                          select new PassZgRevisionViewModel
                          {
                              ID = l.ID,
                              RevDate = l.p_rev_date,
                              RevRecord = l.p_rev_record
                          }).ToList();

            }

            return result;
        }
        public static PassZuweisungZsbNrsViewModel GetPassZuweisungZsbNrItems(int ID)
        {
            PassZuweisungZsbNrsViewModel result = new PassZuweisungZsbNrsViewModel();
            result.Parent = ID;

            using (var db = new KonstructionEntities())
            {
                result.Source = (from l in db.Pass_zuweisung_ZSB_Nr.AsNoTracking()
                                 where l.p_zg_id == ID
                                 select new PassZuweisungZsbNrViewModel
                                 {
                                     ID = l.ID,
                                     PasszuweisungZSBNr = l.p_unter_zsb_zg_id.Value
                                 }).ToList();

            }

            return result;
        }


        public static KundeZgRevisionsViewModel GetKundeZgRevisionItems(int ID)
        {
            KundeZgRevisionsViewModel result = new KundeZgRevisionsViewModel();
            result.Parent = ID;

            using (var db = new KonstructionEntities())
            {
                result.Source = (from l in db.Kunde_zg_revision.AsNoTracking()
                                 where l.k_zg_id == ID
                                 select new KundeZgRevisionViewModel
                                 {
                                     ID = l.ID,
                                     RevDate = l.k_rev_date,
                                     RevRecord = l.k_rev_record
                                 }).ToList();

            }

            return result;
        }
        public static KundeZuweisungZsbsNrViewModel GetKundeZuweisungZsbsNrItems(int ID)
        {
            KundeZuweisungZsbsNrViewModel result = new KundeZuweisungZsbsNrViewModel();
            result.Parent = ID;

            using (var db = new KonstructionEntities())
            {
                result.Source = (from l in db.Kunde_zuweisung_ZSB_Nr.AsNoTracking()
                                 where l.k_zg_id == ID
                                 select new KundeZuweisungZsbNrViewModel
                                 {
                                     ID = l.ID,
                                     KundezuweisungZSBNr = l.k_unter_zsb_zg_id.Value
                                 }).ToList();

            }

            return result;
        }
        public static PassKundeZuweisungZsbNrsViewModel GetPassKundeZuweisungZsbsNrItems(int ID)
        {
            PassKundeZuweisungZsbNrsViewModel result = new PassKundeZuweisungZsbNrsViewModel();
            result.Parent = ID;

            using (var db = new KonstructionEntities())
            {
                result.Source = (from l in db.Pass_Kunde_zuweisung_ZSB_Nr.AsNoTracking()
                                 where l.k_zg_id == ID
                                 select new PassKundeZuweisungZsbNrViewModel
                                 {
                                     ID = l.ID,
                                     PassKundezuweisungZSBNr = l.p_zg_id.Value
                                 }).ToList();

            }

            return result;
        }

        public static void DeleteKundeZgRevision(int ID)
        {
            using (var db = new KonstructionEntities())
            {
                var item = db.Kunde_zg_revision.FirstOrDefault(x => x.ID == ID);
                if (item != null)
                {
                    db.Kunde_zg_revision.Remove(item);
                    db.SaveChanges();
                }
            }
        }

        public static void DeleteKundeZuweisungZSBNr(int ID)
        {
            using (var db = new KonstructionEntities())
            {
                var item = db.Kunde_zuweisung_ZSB_Nr.FirstOrDefault(x => x.ID == ID);
                if (item != null)
                {
                    db.Kunde_zuweisung_ZSB_Nr.Remove(item);
                    db.SaveChanges();
                }
            }
        }
        public static void DeletePassKundeZuweisungZSBNr(int ID)
        {
            using (var db = new KonstructionEntities())
            {
                var item = db.Pass_Kunde_zuweisung_ZSB_Nr.FirstOrDefault(x => x.ID == ID);
                if (item != null)
                {
                    db.Pass_Kunde_zuweisung_ZSB_Nr.Remove(item);
                    db.SaveChanges();
                }
            }
        }


        public static void PassTeileNrRebuild(int no)
        {
            using (var db = new KonstructionEntities())
            {
                foreach (var item in db.Pass_Teile_nr)
                {
                    item.p_zg_nr = item.p_zg_nr.PadLeft(no, '0');
    
                }
                db.SaveChanges();
            }
        }
        public static void KundenTeileNrRebuild(int no)
        {
            using (var db = new KonstructionEntities())
            {
                foreach (var item in db.Kunden_Teile_nr)
                {
                    item.k_zg_nr = item.k_zg_nr.PadLeft(no, '0');
                
                }
                db.SaveChanges();
            }
        }

    }
    
}