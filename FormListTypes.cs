using AppAnimeTitles.Models;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> be6e07acb2a918c8f811e2c8378800e5ff38c402
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

<<<<<<< HEAD
        public FormListTypes ()
=======
        public FormListTypes()
>>>>>>> be6e07acb2a918c8f811e2c8378800e5ff38c402
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db  = new AppContext();
<<<<<<< HEAD
            this.db.Types.Load();
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o=>o.TypeName).ToList();

            //скрытие столбцов
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewTypes.Columns["TypeName"].HeaderText = "Тип аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
=======
>>>>>>> be6e07acb2a918c8f811e2c8378800e5ff38c402
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
