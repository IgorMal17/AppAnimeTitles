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
using AppContext = AppTitlesAnime.Models.AppContext;
using Genre = AppTitlesAnime.Models.Genre;

namespace AppTitlesAnime {
	public partial class FormAddGenre : Form {
        private AppContext db;

        public FormAddGenre()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Statuses.Load();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void TextBoxGenreName_Validating(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(textBoxGenreName.Text)) {
				errorProvider.SetError(textBoxGenreName, "Поле не может быть пустым");
				btnSaveChanges.Enabled = false;
			}
            else if (db.Genres.Local.Any(t => t.GenreName.Equals(textBoxGenreName.Text, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(textBoxGenreName, "Значение уже есть");
                btnSaveChanges.Enabled = false;
            }
            else 
            {
				errorProvider.Clear();
				btnSaveChanges.Enabled = true;
			}
		}

		private void TextBoxGenreName_TextChanged(object sender, EventArgs e) {
			if (String.IsNullOrEmpty(textBoxGenreName.Text)) {
				errorProvider.SetError(textBoxGenreName, "Поле не может быть пустым");
				btnSaveChanges.Enabled = false;
			} else {
				errorProvider.Clear();
				btnSaveChanges.Enabled = true;
			}
		}

		private void FormAddGenre_Load(object sender, EventArgs e) {

		}
	}
}
