namespace AppTitlesAnime {
	partial class FormListStatuses {
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
		private void InitializeComponent() {
			flowLayoutPanelTop = new FlowLayoutPanel();
			btnAddStatus = new Button();
			btnUpdateStatus = new Button();
			btnDeleteStatus = new Button();
			panelFill = new Panel();
			dataGridViewStatuses = new DataGridView();
			flowLayoutPanelTop.SuspendLayout();
			panelFill.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).BeginInit();
			SuspendLayout();
			// 
			// flowLayoutPanelTop
			// 
			flowLayoutPanelTop.Controls.Add(btnAddStatus);
			flowLayoutPanelTop.Controls.Add(btnUpdateStatus);
			flowLayoutPanelTop.Controls.Add(btnDeleteStatus);
			flowLayoutPanelTop.Dock = DockStyle.Top;
			flowLayoutPanelTop.Location = new Point(0, 0);
			flowLayoutPanelTop.Margin = new Padding(5);
			flowLayoutPanelTop.Name = "flowLayoutPanelTop";
			flowLayoutPanelTop.Padding = new Padding(16, 17, 16, 17);
			flowLayoutPanelTop.Size = new Size(758, 99);
			flowLayoutPanelTop.TabIndex = 2;
			// 
			// btnAddStatus
			// 
			btnAddStatus.AutoSize = true;
			btnAddStatus.Location = new Point(21, 22);
			btnAddStatus.Margin = new Padding(5);
			btnAddStatus.Name = "btnAddStatus";
			btnAddStatus.Size = new Size(106, 35);
			btnAddStatus.TabIndex = 0;
			btnAddStatus.Text = "Добавить";
			btnAddStatus.UseVisualStyleBackColor = true;
			btnAddStatus.Click += BtnAddStatus_Click;
			// 
			// btnUpdateStatus
			// 
			btnUpdateStatus.AutoSize = true;
			btnUpdateStatus.Location = new Point(137, 22);
			btnUpdateStatus.Margin = new Padding(5);
			btnUpdateStatus.Name = "btnUpdateStatus";
			btnUpdateStatus.Size = new Size(151, 35);
			btnUpdateStatus.TabIndex = 1;
			btnUpdateStatus.Text = "Редактировать";
			btnUpdateStatus.UseVisualStyleBackColor = true;
			btnUpdateStatus.Click += BtnUpdateStatus_Click;
			// 
			// btnDeleteStatus
			// 
			btnDeleteStatus.AutoSize = true;
			btnDeleteStatus.Location = new Point(298, 22);
			btnDeleteStatus.Margin = new Padding(5);
			btnDeleteStatus.Name = "btnDeleteStatus";
			btnDeleteStatus.Size = new Size(106, 35);
			btnDeleteStatus.TabIndex = 2;
			btnDeleteStatus.Text = "Удалить";
			btnDeleteStatus.UseVisualStyleBackColor = true;
			btnDeleteStatus.Click += btnDeleteStatus_Click;
			// 
			// panelFill
			// 
			panelFill.Controls.Add(dataGridViewStatuses);
			panelFill.Dock = DockStyle.Fill;
			panelFill.Location = new Point(0, 0);
			panelFill.Margin = new Padding(5);
			panelFill.Name = "panelFill";
			panelFill.Size = new Size(758, 443);
			panelFill.TabIndex = 3;
			// 
			// dataGridViewStatuses
			// 
			dataGridViewStatuses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewStatuses.BackgroundColor = Color.White;
			dataGridViewStatuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewStatuses.Dock = DockStyle.Bottom;
			dataGridViewStatuses.Location = new Point(0, 97);
			dataGridViewStatuses.MultiSelect = false;
			dataGridViewStatuses.Name = "dataGridViewStatuses";
			dataGridViewStatuses.ReadOnly = true;
			dataGridViewStatuses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewStatuses.Size = new Size(758, 346);
			dataGridViewStatuses.TabIndex = 1;
			// 
			// FormListStatuses
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(758, 443);
			Controls.Add(flowLayoutPanelTop);
			Controls.Add(panelFill);
			Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(5);
			Name = "FormListStatuses";
			Text = "Список статусов аниме";
			flowLayoutPanelTop.ResumeLayout(false);
			flowLayoutPanelTop.PerformLayout();
			panelFill.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanelTop;
		private Button btnAddStatus;
		private Button btnUpdateStatus;
		private Button btnDeleteStatus;
		private Panel panelFill;
		private DataGridView dataGridViewStatuses;
	}
}