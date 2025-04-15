using Microsoft.EntityFrameworkCore;
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
            this.db = new AppContext();
            this.db.Types.Load();
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();

            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            dataGridViewTypes.Columns["TypeName"].HeaderText = "Тип аниме";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new();
            DialogResult result = formAddType.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
            
            Type type = new Type();
            type.TypeName = formAddType.textBoxTypeName.Text;
        }
    }
}
