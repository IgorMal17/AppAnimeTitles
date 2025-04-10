using AppAnimeTitles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAnimeTitles
{
    public partial class FormListTypes : Form
    {
        private AppContext db;

        public FormListTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db  = new AppContext();
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new FormAddType();
            formAddType.ShowDialog();
        }

        private void FormListTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
