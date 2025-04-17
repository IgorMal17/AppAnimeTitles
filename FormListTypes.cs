using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using AppContext = AppAnimeTitles.Models.AppContext;
using Type = AppAnimeTitles.Models.Type;

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

            db.Types.Add(type);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }

        private void BtnUpdateType_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Type type = db.Types.Find(id);
            FormAddType formAddType = new();
            formAddType.textBoxTypeName.Text = type.TypeName;

            DialogResult result = formAddType.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            type.TypeName = formAddType.textBoxTypeName.Text;
            db.Types.Update(type);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }

        private void BtnDeleteType_Click(Object sender, EventArgs e)
        {

            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \n Все связанные данные будут удалены.",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Type type = db.Types.Find(id);

            db.Types.Remove(type);
            db.SaveChanges();

            MessageBox.Show("Объект удален");

            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }

        private void FormListTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
