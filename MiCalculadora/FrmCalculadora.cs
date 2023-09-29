using Entidades;


namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private ESistema sistema;
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void txbxPrimerOperando_TextChanged(object sender, EventArgs e)
        {
        }
    }
}