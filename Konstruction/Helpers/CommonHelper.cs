using DevExpress.Utils;
using DevExpress.Web;
using DevExpress.Web.Mvc;
using Konstruction.Model;
using Konstruction.Model.Class;
using Konstruction.Model.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Konstruction.Helpers
{
    public class CommonHelper
    {
        public static Display DefaultEditorErrorDisplayMode = Display.Dynamic;
        public static string DefaultClearFilterImageName = "fa fa-minus-circle fa-1x-filter";
        public static void ApplyCommonSettings<T>(FormLayoutSettings<T> settings, bool popup = false, bool doNotPersist = false)
        {
            settings.Width = Unit.Percentage(100);
            settings.EncodeHtml = false;
            settings.SettingsAdaptivity.AdaptivityMode = FormLayoutAdaptivityMode.SingleColumnWindowLimit;
            settings.SettingsAdaptivity.SwitchToSingleColumnAtWindowInnerWidth = popup ? 480 : 800;
            settings.ControlStyle.CssClass = "formLayout";
        }

        public static void ApplyCommonSettings(GridViewSettings settings)
        {
            settings.Width = Unit.Percentage(100);
            settings.Height = Unit.Percentage(100);
            settings.SettingsPager.Visible = true;
            settings.SettingsPager.PageSize = 40;
            settings.Settings.ShowFilterRow = true;
            settings.Settings.ShowFilterRowMenu = true;
            settings.Settings.VerticalScrollBarMode = ScrollBarMode.Visible;
            settings.Settings.VerticalScrollableHeight = 320;
            settings.ControlStyle.Paddings.Padding = Unit.Pixel(0);
            settings.ControlStyle.Border.BorderWidth = Unit.Pixel(0);

            settings.Styles.AlternatingRow.Enabled = DefaultBoolean.True;

            settings.SettingsContextMenu.Enabled = true;
            settings.SettingsContextMenu.EnableGroupPanelMenu = DefaultBoolean.True;
            settings.SettingsContextMenu.EnableFooterMenu = DefaultBoolean.False;
            settings.SettingsContextMenu.EnableColumnMenu = DefaultBoolean.True;
            settings.SettingsBehavior.EnableCustomizationWindow = true;
            settings.SettingsContextMenu.RowMenuItemVisibility.DeleteRow = false;
            settings.SettingsContextMenu.RowMenuItemVisibility.EditRow = false;
            settings.SettingsContextMenu.RowMenuItemVisibility.NewRow = false;
            settings.Settings.ShowFilterRowMenuLikeItem = true;
            settings.SettingsAdaptivity.AdaptivityMode = GridViewAdaptivityMode.HideDataCellsWindowLimit;
            settings.SettingsAdaptivity.HideDataCellsAtWindowInnerWidth = 600;
            settings.SettingsAdaptivity.AllowOnlyOneAdaptiveDetailExpanded = true;
            settings.EditFormLayoutProperties.SettingsAdaptivity.AdaptivityMode = FormLayoutAdaptivityMode.SingleColumnWindowLimit;
            settings.EditFormLayoutProperties.SettingsAdaptivity.SwitchToSingleColumnAtWindowInnerWidth = 600;

            settings.SettingsBehavior.AllowSelectByRowClick = true;
          //  settings.Styles.SelectedRow.BackColor = Color.Blue;

            settings.GroupSummary.Add(DevExpress.Data.SummaryItemType.Count, string.Empty);
            settings.AutoFilterCellEditorInitialize = (sender, e) =>
            {
                if (e.Column.FilterExpression != "")
                {
                    e.Editor.BackColor = Color.FromArgb(211, 228, 246);
                }
            };
        }
        public static void ApplyCommonBatchEditSettings(GridViewSettings settings)
        {
            settings.Width = Unit.Percentage(100);
            settings.Height = Unit.Percentage(100);
            settings.SettingsPager.Visible = false;
            settings.Settings.ShowFilterRow = true;
            settings.Settings.ShowFilterRowMenu = true;
            settings.ControlStyle.Paddings.Padding = Unit.Pixel(0);
            settings.ControlStyle.Border.BorderWidth = Unit.Pixel(0);
            settings.Styles.AlternatingRow.Enabled = DefaultBoolean.True;
            settings.SettingsContextMenu.Enabled = true;
            settings.SettingsContextMenu.EnableGroupPanelMenu = DefaultBoolean.True;
            settings.SettingsContextMenu.EnableFooterMenu = DefaultBoolean.False;
            settings.SettingsContextMenu.EnableColumnMenu = DefaultBoolean.True;
            settings.SettingsBehavior.EnableCustomizationWindow = true;
            settings.SettingsContextMenu.RowMenuItemVisibility.DeleteRow = false;
            settings.SettingsContextMenu.RowMenuItemVisibility.EditRow = false;
            settings.SettingsContextMenu.RowMenuItemVisibility.NewRow = false;
            settings.Settings.ShowFilterRowMenuLikeItem = true;
            settings.SettingsAdaptivity.AdaptivityMode = GridViewAdaptivityMode.HideDataCellsWindowLimit;
            settings.SettingsAdaptivity.HideDataCellsAtWindowInnerWidth = 600;
            settings.SettingsAdaptivity.AllowOnlyOneAdaptiveDetailExpanded = true;
            settings.EditFormLayoutProperties.SettingsAdaptivity.AdaptivityMode = FormLayoutAdaptivityMode.SingleColumnWindowLimit;
            settings.EditFormLayoutProperties.SettingsAdaptivity.SwitchToSingleColumnAtWindowInnerWidth = 600;
            settings.SettingsBehavior.AllowSelectByRowClick = true;
            settings.GroupSummary.Add(DevExpress.Data.SummaryItemType.Count, string.Empty);
            settings.Styles.Header.Paddings.Padding = Unit.Pixel(2);
            settings.Styles.Header.Font.Size = FontUnit.Point(8);
            settings.Styles.Cell.CssClass = "grid-widget-cell-style";
            settings.SettingsPager.Mode = GridViewPagerMode.ShowAllRecords;
            settings.SettingsBehavior.EnableCustomizationWindow = true;
            settings.SettingsEditing.Mode = GridViewEditingMode.Batch;
            settings.SettingsEditing.BatchEditSettings.EditMode = GridViewBatchEditMode.Row;
            settings.SettingsEditing.BatchEditSettings.StartEditAction = GridViewBatchStartEditAction.Click;
            settings.Settings.ShowFilterRow = false;
            settings.ControlStyle.Paddings.Padding = Unit.Pixel(5);
            settings.ControlStyle.BorderBottom.BorderWidth = Unit.Pixel(1);
            settings.SettingsText.CommandBatchEditUpdate = "Änderungen speichern";
            settings.SettingsText.CommandBatchEditCancel = "Änderungen verwerfen";
            settings.Styles.BatchEditModifiedCell.BackColor = System.Drawing.Color.GreenYellow;
            settings.AutoFilterCellEditorInitialize = (sender, e) =>
            {
                if (e.Column.FilterExpression != "")
                {
                    e.Editor.BackColor = Color.FromArgb(211, 228, 246);
                }
            };
        }
        public static void ApplyCommonReadOnlySettings(GridViewSettings settings)
        {
            settings.Width = Unit.Percentage(100);
            settings.Height = Unit.Percentage(100);
            settings.SettingsPager.Visible = false;
            settings.Settings.ShowFilterRow = true;
            settings.Settings.ShowFilterRowMenu = true;
            settings.ControlStyle.Paddings.Padding = Unit.Pixel(0);
            settings.ControlStyle.Border.BorderWidth = Unit.Pixel(0);
            settings.Styles.AlternatingRow.Enabled = DefaultBoolean.True;
            settings.SettingsContextMenu.Enabled = true;
            settings.SettingsContextMenu.EnableGroupPanelMenu = DefaultBoolean.True;
            settings.SettingsContextMenu.EnableFooterMenu = DefaultBoolean.False;
            settings.SettingsContextMenu.EnableColumnMenu = DefaultBoolean.True;
            settings.SettingsBehavior.EnableCustomizationWindow = true;
            settings.SettingsContextMenu.RowMenuItemVisibility.DeleteRow = false;
            settings.SettingsContextMenu.RowMenuItemVisibility.EditRow = false;
            settings.SettingsContextMenu.RowMenuItemVisibility.NewRow = false;
            settings.Settings.ShowFilterRowMenuLikeItem = true;
            settings.SettingsAdaptivity.AdaptivityMode = GridViewAdaptivityMode.HideDataCellsWindowLimit;
            settings.SettingsAdaptivity.HideDataCellsAtWindowInnerWidth = 600;
            settings.SettingsAdaptivity.AllowOnlyOneAdaptiveDetailExpanded = true;
            settings.EditFormLayoutProperties.SettingsAdaptivity.AdaptivityMode = FormLayoutAdaptivityMode.SingleColumnWindowLimit;
            settings.EditFormLayoutProperties.SettingsAdaptivity.SwitchToSingleColumnAtWindowInnerWidth = 600;
            settings.SettingsBehavior.AllowSelectByRowClick = true;
            settings.GroupSummary.Add(DevExpress.Data.SummaryItemType.Count, string.Empty);
            settings.Styles.Header.Paddings.Padding = Unit.Pixel(2);
            settings.Styles.Header.Font.Size = FontUnit.Point(8);
            settings.Styles.Cell.CssClass = "grid-widget-cell-style";
            settings.SettingsPager.Mode = GridViewPagerMode.ShowAllRecords;
            settings.SettingsBehavior.EnableCustomizationWindow = true;
            settings.Settings.ShowFilterRow = false;
            settings.ControlStyle.Paddings.Padding = Unit.Pixel(5);
            settings.ControlStyle.BorderBottom.BorderWidth = Unit.Pixel(1);
            settings.AutoFilterCellEditorInitialize = (sender, e) =>
            {
                if (e.Column.FilterExpression != "")
                {
                    e.Editor.BackColor = Color.FromArgb(0, 114, 198);
                }
            };
        }
        public static void ApplyCommandColumnCommonSettings(ViewContext context, GridViewSettings grid, MVCxGridViewColumn column, Unit? width = null, string header = null)
        {
            column.Caption = string.Empty;
            column.CellStyle.HorizontalAlign = HorizontalAlign.Center;
            column.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
            column.CellStyle.VerticalAlign = VerticalAlign.Middle;
            column.Settings.AllowDragDrop = DefaultBoolean.False;
            column.Settings.AllowSort = DefaultBoolean.False;

            column.SetHeaderTemplateContent(c =>
            {
                if (!string.IsNullOrEmpty(header))
                {
                    context.Writer.Write(header);
                }

                if (!string.IsNullOrEmpty(c.Column.Grid.FilterExpression))
                {
                    if (!string.IsNullOrEmpty(header))
                        context.Writer.Write("&nbsp;");
                    context.Writer.Write("<a href=\"javascript:;\" onclick=\"javascript:" + grid.Name + ".ClearFilter();\"\">");
                    context.Writer.Write("<i class=\"" + DefaultClearFilterImageName + "\"  aria-hidden=\"true\" title=\"Clear Filters\"></i></a>");
                }
            });

            if (width.HasValue)
                column.Width = width.Value;
            else
                column.Width = Unit.Pixel(80);
        }

        public static void ApplyDateCommonSettings(MVCxGridViewColumn column, int? width = null)
        {
            if (!width.HasValue)
                column.Width = Unit.Pixel(140);
            else
                column.Width = Unit.Pixel(width.Value);

            column.Settings.AutoFilterCondition = AutoFilterCondition.Equals;
            column.ColumnType = MVCxGridViewColumnType.DateEdit;
            DateEditProperties properties = column.PropertiesEdit as DateEditProperties;
            properties.EditFormat = EditFormat.Date;
            properties.DisplayFormatString = "d";

        }
        public static void ApplyTextBoxReadonlySettings(TextBoxSettings settings)
        {
            settings.Width = Unit.Percentage(100);
            settings.ReadOnly = true;
            settings.Properties.ReadOnlyStyle.CssClass = "readonly";
            settings.Properties.EnableFocusedStyle = false;
        }

        public static List<ComboBoxViewModel> GetDatenformatItems()
        {
            List<ComboBoxViewModel> result = new List<ComboBoxViewModel>();

            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Datenformat.AsNoTracking()
                          orderby l.data_format
                          select new ComboBoxViewModel
                          {
                              ID = l.ID,
                              Name = l.data_format,
                          }).ToList();

            }

            return result;
        }
        public static List<ComboBoxViewModel> GetErstellerItems()
        {
            List<ComboBoxViewModel> result = new List<ComboBoxViewModel>();

            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Ersteller.AsNoTracking()
                          orderby l.Ersteller1
                          select new ComboBoxViewModel
                          {
                              ID = l.ID,
                              Name = l.Ersteller1,
                          }).ToList();

            }

            return result;
        }

        public static List<ComboBoxViewModel> GetPassZuweisungZSBNrItems()
        {
            List<ComboBoxViewModel> result = new List<ComboBoxViewModel>();

            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Pass_Teile_nr.AsNoTracking()
                          orderby l.p_zg_nr
                          select new ComboBoxViewModel
                          {
                              ID = l.ID,
                              Name = l.p_zg_nr,
                          }).ToList();

            }

            return result;
        }
        public static List<ComboBoxViewModel> GetPassKundeZuweisungZSBNrItems()
        {
            List<ComboBoxViewModel> result = new List<ComboBoxViewModel>();

            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Pass_Teile_nr.AsNoTracking()
                          orderby l.p_zg_nr
                          select new ComboBoxViewModel
                          {
                              ID = l.ID,
                              Name = l.p_zg_nr,
                          }).ToList();

            }

            return result;
        }
        public static object GetPasszuweisungZSBNrItem(ListEditItemRequestedByValueEventArgs args)
        {
            int id;
            if (args.Value == null || !int.TryParse(args.Value.ToString(), out id))
                return null;
            return GetPasszuweisungZSBNrItem(id);
        }

        public static object GetPasszuweisungZSBNrItem(int? id)
        {
            using (var db = new KonstructionEntities())
            {
                if (id.HasValue)
                {
                    List<PasszuweisungZSBNrComboBoxView> result = new List<PasszuweisungZSBNrComboBoxView>();
                    result = (from l in db.Pass_Teile_nr.AsNoTracking()
                              where l.ID == id.Value
                              select new PasszuweisungZSBNrComboBoxView
                              {
                                  ID = l.ID,
                                  p_zg_nr = l.p_zg_nr,
                              }).Take(1).ToList();

                    return result;
                }
            }
            return null;
        }

        public static object GetPasszuweisungZSBNrItemsRange(ListEditItemsRequestedByFilterConditionEventArgs args)
        {
            var skip = args.BeginIndex;
            var take = args.EndIndex - args.BeginIndex + 1;
            List<PasszuweisungZSBNrComboBoxView> result = new List<PasszuweisungZSBNrComboBoxView>();
            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Pass_Teile_nr.AsNoTracking()
                          where !string.IsNullOrEmpty(l.p_zg_nr)
                          orderby l.p_zg_nr
                          select new PasszuweisungZSBNrComboBoxView
                          {
                              ID = l.ID,
                              p_zg_nr = l.p_zg_nr,
                          }).ToList();


                if (!string.IsNullOrWhiteSpace(args.Filter))
                    result = result.Where(w => w.p_zg_nr.Contains(args.Filter)).ToList();
                result = result.Skip(skip).Take(take).ToList();
                if (SessionDataHelper.PasszuweisungZSBNrValueData.HasValue && !result.Any(x => x.ID == SessionDataHelper.PasszuweisungZSBNrValueData.Value))
                {
                    var item = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == SessionDataHelper.PasszuweisungZSBNrValueData.Value);
                    if (item != null)
                        result.Insert(0, new PasszuweisungZSBNrComboBoxView(item));
                }
            }

            return result;
        }


        public static object GetPassTeileNrItemsRange(ListEditItemsRequestedByFilterConditionEventArgs args)
        {
            var skip = args.BeginIndex;
            var take = args.EndIndex - args.BeginIndex + 1;
            List<PasszuweisungZSBNrComboBoxView> result = new List<PasszuweisungZSBNrComboBoxView>();
            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Pass_Teile_nr.AsNoTracking()
                          where !string.IsNullOrEmpty(l.p_zg_nr)
                          orderby l.p_zg_nr
                          select new PasszuweisungZSBNrComboBoxView
                          {
                              ID = l.ID,
                              p_zg_nr = l.p_zg_nr,
                          }).ToList();


                if (!string.IsNullOrWhiteSpace(args.Filter))
                    result = result.Where(w => w.p_zg_nr.Contains(args.Filter)).ToList();
                result = result.Skip(skip).Take(take).ToList();
            }

            return result;
        }

        public static object GetPassTeileNrItem(ListEditItemRequestedByValueEventArgs args)
        {
            int id;
            if (args.Value == null || !int.TryParse(args.Value.ToString(), out id))
                return null;
            return GetPassTeileNrItem(id);
        }

        public static object GetPassTeileNrItem(int? id)
        {
            using (var db = new KonstructionEntities())
            {
                if (id.HasValue)
                {
                    List<PasszuweisungZSBNrComboBoxView> result = new List<PasszuweisungZSBNrComboBoxView>();
                    result = (from l in db.Pass_Teile_nr.AsNoTracking()
                              where l.ID == id.Value
                              select new PasszuweisungZSBNrComboBoxView
                              {
                                  ID = l.ID,
                                  p_zg_nr = l.p_zg_nr,
                              }).Take(1).ToList();

                    return result;
                }
            }
            return null;
        }
        public static object GetPassKundeZuweisungZSBNrItem(ListEditItemRequestedByValueEventArgs args)
        {
            int id;
            if (args.Value == null || !int.TryParse(args.Value.ToString(), out id))
                return null;
            return GetPassKundeZuweisungZSBNrItem(id);
        }

        public static object GetPassKundeZuweisungZSBNrItem(int? id)
        {
            using (var db = new KonstructionEntities())
            {
                if (id.HasValue)
                {
                    List<PassKundeZuweisungZSBNrComboBoxView> result = new List<PassKundeZuweisungZSBNrComboBoxView>();
                    result = (from l in db.Pass_Teile_nr.AsNoTracking()
                              where l.ID == id.Value
                              select new PassKundeZuweisungZSBNrComboBoxView
                              {
                                  ID = l.ID,
                                  p_zg_nr = l.p_zg_nr,
                              }).Take(1).ToList();

                    return result;
                }
            }
            return null;
        }

        public static object GetPassKundeZuweisungZSBNrItemsRange(ListEditItemsRequestedByFilterConditionEventArgs args)
        {
            var skip = args.BeginIndex;
            var take = args.EndIndex - args.BeginIndex + 1;
            List<PassKundeZuweisungZSBNrComboBoxView> result = new List<PassKundeZuweisungZSBNrComboBoxView>();
            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Pass_Teile_nr.AsNoTracking()
                          where !string.IsNullOrEmpty(l.p_zg_nr)
                          orderby l.p_zg_nr
                          select new PassKundeZuweisungZSBNrComboBoxView
                          {
                              ID = l.ID,
                              p_zg_nr = l.p_zg_nr,
                          }).ToList();


                if (!string.IsNullOrWhiteSpace(args.Filter))
                    result = result.Where(w => w.p_zg_nr.Contains(args.Filter)).ToList();
                result = result.Skip(skip).Take(take).ToList();
                if (SessionDataHelper.PassKundezuweisungZSBNrValueData.HasValue && !result.Any(x => x.ID == SessionDataHelper.PassKundezuweisungZSBNrValueData.Value))
                {
                    var item = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == SessionDataHelper.PassKundezuweisungZSBNrValueData.Value);
                    if (item != null)
                        result.Insert(0, new PassKundeZuweisungZSBNrComboBoxView(item));
                }
            }

            return result;
        }

        public static object GetKundeZuweisungZSBNrItem(ListEditItemRequestedByValueEventArgs args)
        {
            int id;
            if (args.Value == null || !int.TryParse(args.Value.ToString(), out id))
                return null;
            return GetKundeZuweisungZSBNrItem(id);
        }

        public static object GetKundeZuweisungZSBNrItem(int? id)
        {
            using (var db = new KonstructionEntities())
            {
                if (id.HasValue)
                {
                    List<KundeZuweisungZSBNrComboBoxView> result = new List<KundeZuweisungZSBNrComboBoxView>();
                    result = (from l in db.Kunden_Teile_nr.AsNoTracking()
                              where l.ID == id.Value
                              select new KundeZuweisungZSBNrComboBoxView
                              {
                                  ID = l.ID,
                                  k_zg_nr = l.k_zg_nr,
                              }).Take(1).ToList();

                    return result;
                }
            }
            return null;
        }

        public static object GetKundeZuweisungZSBNrItemsRange(ListEditItemsRequestedByFilterConditionEventArgs args)
        {
            var skip = args.BeginIndex;
            var take = args.EndIndex - args.BeginIndex + 1;
            List<KundeZuweisungZSBNrComboBoxView> result = new List<KundeZuweisungZSBNrComboBoxView>();
            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Kunden_Teile_nr.AsNoTracking()
                          where !string.IsNullOrEmpty(l.k_zg_nr)
                          orderby l.k_zg_nr
                          select new KundeZuweisungZSBNrComboBoxView
                          {
                              ID = l.ID,
                              k_zg_nr = l.k_zg_nr,
                          }).ToList();


                if (!string.IsNullOrWhiteSpace(args.Filter))
                    result = result.Where(w => w.k_zg_nr.Contains(args.Filter)).ToList();
                result = result.Skip(skip).Take(take).ToList();
                if (SessionDataHelper.KundezuweisungZSBNrValueData.HasValue && !result.Any(x => x.ID == SessionDataHelper.KundezuweisungZSBNrValueData.Value))
                {
                    var item = db.Kunden_Teile_nr.FirstOrDefault(x => x.ID == SessionDataHelper.KundezuweisungZSBNrValueData.Value);
                    if (item != null)
                        result.Insert(0, new KundeZuweisungZSBNrComboBoxView(item));
                }
            }

            return result;
        }


        public static object GetKundenTeileNrItem(ListEditItemRequestedByValueEventArgs args)
        {
            int id;
            if (args.Value == null || !int.TryParse(args.Value.ToString(), out id))
                return null;
            return GetKundenTeileNrItem(id);
        }

        public static object GetKundenTeileNrItem(int? id)
        {
            using (var db = new KonstructionEntities())
            {
                if (id.HasValue)
                {
                    List<KundeZuweisungZSBNrComboBoxView> result = new List<KundeZuweisungZSBNrComboBoxView>();
                    result = (from l in db.Kunden_Teile_nr.AsNoTracking()
                              where l.ID == id.Value
                              select new KundeZuweisungZSBNrComboBoxView
                              {
                                  ID = l.ID,
                                  k_zg_nr = l.k_zg_nr,
                              }).Take(1).ToList();

                    return result;
                }
            }
            return null;
        }

        public static object GetKundenTeileNrItemsRange(ListEditItemsRequestedByFilterConditionEventArgs args)
        {
            var skip = args.BeginIndex;
            var take = args.EndIndex - args.BeginIndex + 1;
            List<KundeZuweisungZSBNrComboBoxView> result = new List<KundeZuweisungZSBNrComboBoxView>();
            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Kunden_Teile_nr.AsNoTracking()
                          where !string.IsNullOrEmpty(l.k_zg_nr)
                          orderby l.k_zg_nr
                          select new KundeZuweisungZSBNrComboBoxView
                          {
                              ID = l.ID,
                              k_zg_nr = l.k_zg_nr,
                          }).ToList();


                if (!string.IsNullOrWhiteSpace(args.Filter))
                    result = result.Where(w => w.k_zg_nr.Contains(args.Filter)).ToList();
                result = result.Skip(skip).Take(take).ToList();
            }

            return result;
        }





        public static List<ComboBoxViewModel> GetKundeZuweisungZSBNrItems()
        {
            List<ComboBoxViewModel> result = new List<ComboBoxViewModel>();

            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Kunde_zuweisung_ZSB_Nr.AsNoTracking()
                          orderby l.k_zg_nr
                          select new ComboBoxViewModel
                          {
                              ID = l.ID,
                              Name = l.k_zg_nr,
                          }).ToList();

            }

            return result;
        }

        public static UserInfo GetUserInfo()
        {
            return SessionDataHelper.UserInfoData;
        }
        public static FormAssignedInfo Form1AssignedInfo(int ID)
        {
            var model = new FormAssignedInfo();
            using (var db = new KonstructionEntities())
            {
                var item = db.Kunden_Teile_nr.FirstOrDefault(x => x.ID == ID);
                if (item!=null)
                {
                    model.AssignedOn = item.AssignedOn;
                    model.AssignedTo = item.AssignedTo;
                }
            }

            return model;
        }

        public static FormAssignedInfo Form2AssignedInfo(int ID)
        {
            var model = new FormAssignedInfo();
            using (var db = new KonstructionEntities())
            {
                var item = db.Pass_Teile_nr.FirstOrDefault(x => x.ID == ID);
                if (item != null)
                {
                    model.AssignedOn = item.AssignedOn;
                    model.AssignedTo = item.AssignedTo;
                }
            }

            return model;
        }
    }
}