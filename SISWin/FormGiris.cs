namespace SISWin
{
    public partial class FormKullanýcýGiris : Form
    {
        public FormKullanýcýGiris()
        {
            InitializeComponent();
        }

        private void FormKullanýcýGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            //kullanýcý giriþi doðrulama
            if (string.IsNullOrEmpty(txtKullanici.Text))
            {
                MessageBox.Show("Kullanýcý bilgisini boþ geçemezsiniz");
                txtKullanici.SelectAll();
                txtKullanici.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Parola bilgisini boþ geçemezsiniz");
                txtParola.SelectAll();
                txtParola.Focus();
                return;
            }
            int calisanNo = 0;
            //Servis çaðýrýlýyor
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