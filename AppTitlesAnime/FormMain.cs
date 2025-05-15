namespace AppTitlesAnime
{
	public partial class FormMain : Form 
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void BtnShowTypes_Click(object sender, EventArgs e) 
		{
			FormListTypes formListTypes = new FormListTypes();
            //FormListTypes formListTypes2 = new FormListTypes();
			//Вывод диалогового окна
            formListTypes.Show();
            //Вызывает модальное окно - это окно появляющегося поверх страницы в ответ на действия пользователя и блокирующего доступ к основному содержимому страницы
            //formListTypes2.ShowDialog();
        }

		private void BtnShowGenres_Click(object sender, EventArgs e) {
			FormListGenres formListGenres = new FormListGenres();
			formListGenres.Show();
		}

		private void BtnShowStatuses_Click(object sender, EventArgs e) {
			FormListStatuses formListStatuses = new FormListStatuses();
			formListStatuses.Show();
		}
	}
}

