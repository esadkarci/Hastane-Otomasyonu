namespace SISWin
{
    public partial class FormKullan�c�Giris : Form
    {
        public FormKullan�c�Giris()
        {
            InitializeComponent();
        }

        private void FormKullan�c�Giris_Load(object sender, EventArgs e)
        {

        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            //kullan�c� giri�i do�rulama
            if (string.IsNullOrEmpty(txtKullanici.Text))
            {
                MessageBox.Show("Kullan�c� bilgisini bo� ge�emezsiniz");
                txtKullanici.SelectAll();
                txtKullanici.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Parola bilgisini bo� ge�emezsiniz");
                txtParola.SelectAll();
                txtParola.Focus();
                return;
            }
            int calisanNo = 0;
            //Servis �a��r�l�yor
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}