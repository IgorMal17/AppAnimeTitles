namespace AppTitlesAnime {
	partial class FormAddStatus {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxStatusName = new TextBox();
            labelStatusName = new Label();
            panelFill = new Panel();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStatusName
            // 
            textBoxStatusName.Dock = DockStyle.Top;
            textBoxStatusName.Location = new Point(16, 42);
            textBoxStatusName.Margin = new Padding(8, 42, 8, 8);
            textBoxStatusName.Name = "textBoxStatusName";
            textBoxStatusName.Size = new Size(432, 33);
            textBoxStatusName.TabIndex = 1;
            textBoxStatusName.TextChanged += TextBoxGenreName_TextChanged;
            textBoxStatusName.Validating += TextBoxStatusName_Validating;
            // 
            // labelStatusName
            // 
            labelStatusName.AutoSize = true;
            labelStatusName.Dock = DockStyle.Top;
            labelStatusName.Location = new Point(16, 17);
            labelStatusName.Margin = new Padding(8, 0, 8, 0);
            labelStatusName.Name = "labelStatusName";
            labelStatusName.Size = new Size(128, 25);
            labelStatusName.TabIndex = 0;
            labelStatusName.Text = "Статус аниме";
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxStatusName);
            panelFill.Controls.Add(labelStatusName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Margin = new Padding(8);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(16, 17, 31, 17);
            panelFill.Size = new Size(479, 201);
            panelFill.TabIndex = 4;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 122);
            flowLayoutPanelBottom.Margin = new Padding(8);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(16, 17, 31, 17);
            flowLayoutPanelBottom.Size = new Size(479, 79);
            flowLayoutPanelBottom.TabIndex = 5;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(24, 25);
            btnSaveChanges.Margin = new Padding(8);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(155, 25);
            btnCancel.Margin = new Padding(8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(479, 201);
            Controls.Add(flowLayoutPanelBottom);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddStatus";
            Text = "Информация о статусе аниме";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected internal TextBox textBoxStatusName;
		private Label labelStatusName;
		private Panel panelFill;
		private ErrorProvider errorProvider;
		private FlowLayoutPanel flowLayoutPanelBottom;
		private Button btnSaveChanges;
		private Button btnCancel;
	}
}