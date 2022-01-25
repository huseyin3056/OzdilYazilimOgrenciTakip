using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using OzdilYazilimOgrenciTakip.Common.Enums;
using OzdilYazilimOgrenciTakip.Model.Dto;
using OzdilYazilimOgrenciTakip.Model.Entities;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.BankaForms;
using OzdilYazilimOgrenciTakip.UI.Win.Forms.YakinlikForms;
using OzdilYazilimOgrenciTakip.UI.Win.Show;
using System;
using System.Windows.Forms;

namespace OzdilYazilimOgrenciTakip.UI.Win.Functions
{

  
    public static  class SelectRepositoryFunctions
    {
        private static GridView _tablo;
        private static ControlNavigator _navigator;
        private static RepositoryItemButtonEdit _buttonEdit;
        private static GridColumn _idColumn;
        private static GridColumn _nameColumn;

        private static void RemoveEvent()
        {
            if (_buttonEdit == null) return;
            _buttonEdit.ButtonClick -= ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown -= ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick -= ButtonEdit_DoubleClick;

            _tablo.KeyDown -= Tablo_KeyDown;


        }

        public static void Sec(this  GridColumn nameColumn, GridView tablo, ControlNavigator navigator,RepositoryItemButtonEdit buttonEdit,GridColumn idColumn)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;

            _tablo.KeyDown += Tablo_KeyDown;
                
        }
        private static void ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap();
        }

        private static void ButtonEdit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);

                    break;

                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }
        }

        private static void ButtonEdit_DoubleClick(object sender, System.EventArgs e)
        {
            SecimYap();
        }

        private static void Tablo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (_tablo.FocusedColumn.ColumnEdit == null) return;

            var type = _tablo.FocusedColumn.ColumnEdit.GetType();
            if (type != typeof(RepositoryItemButtonEdit)) return;

            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _tablo.SetFocusedRowCellValue(_idColumn, null);
                    _tablo.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);

                    break;

                case Keys.F4:
                case Keys.Down when e.Alt:
                    SecimYap();
                    break;
            }


        }

        private static void SecimYap()
        {
            switch (_buttonEdit.Name)
            {
               
                case "repositoryYakinlik":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);
                        var entity = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.YakinlikAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;

                case "repositoryBanka":
                    {
                        var id = _tablo.GetRowCellId(_idColumn);
                        var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, id);
                        if (entity != null)
                        {
                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.BankaAdi);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;

            }
        }




    }
}
