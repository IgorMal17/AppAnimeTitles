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
using AppContext = AppAnimeTitles.Models.AppContext;

namespace AppAnimeTitles
{
    public partial class FormAddType : Form
    {
        private AppContext db;
        public FormAddType()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddType_Load(object sender, EventArgs e)
        {

        }
    }
}
