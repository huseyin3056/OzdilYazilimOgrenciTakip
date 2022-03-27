using DevExpress.XtraEditors;

namespace OzdilYazilimOgrenciTakip.UI.Win.UserControls.Controls.Navigators
{
    public partial class LongNavigator : XtraUserControl
    {
        public LongNavigator()
        {
            InitializeComponent();

            this.Navigator.ShowToolTips = true;
            this.Navigator.Buttons.Append.Hint = "Ekle";
            this.Navigator.Buttons.Remove.Hint = "Sil";
            this.Navigator.Buttons.Next.Hint = "Sonraki Kayıt";
            this.Navigator.Buttons.Prev.Hint = "Önceki Kayıt";
            this.Navigator.Buttons.NextPage.Hint = "Sonraki Sayfa";
            this.Navigator.Buttons.PrevPage.Hint = "Önceki Sayfa";
            this.Navigator.Buttons.Last.Hint = "Son Kayıt";
            this.Navigator.Buttons.First.Hint = "İlk Kayıt";


        }
    }
}
