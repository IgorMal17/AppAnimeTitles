using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;
using Type = AppTitlesAnime.Models.Type;

namespace AppTitlesAnime {
	public partial class FormAddType : Form {
		private AppContext db;

		public FormAddType() {
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			this.db = new AppContext();
			this.db.Types.Load();
		}

		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);

			this.db?.Dispose();
			this.db = null;
		}

		private void TextBoxTypeName_Validating(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(textBoxTypeName.Text)) {
				errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
				btnSaveChanges.Enabled = false;
			} else if (db.Types.Local.Any(t => t.TypeName.Equals(textBoxTypeName.Text, StringComparison.OrdinalIgnoreCase))) {
				errorProvider.SetError(textBoxTypeName, "Значение уже есть");
				btnSaveChanges.Enabled = false;
			}else {
				errorProvider.Clear();
				btnSaveChanges.Enabled = true;
			}
		}

		private void TextBoxTypeName_TextChanged(object sender, EventArgs e) {
			if (String.IsNullOrEmpty(textBoxTypeName.Text)) {
				errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
				btnSaveChanges.Enabled = false;
			} else {
				errorProvider.Clear();
				btnSaveChanges.Enabled = true;
			}
		}


		private void FormAddType_Load(object sender, EventArgs e) {

		}
	}
}
