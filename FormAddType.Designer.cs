namespace AppAnimeTitles
{
    partial class FormAddType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            panel1 = new Panel();
            PanelFill = new Panel();
            textBoxTypeName = new TextBox();
            labelTypeName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            PanelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PanelFill);
            panel1.Controls.Add(flowLayoutPanelBottom);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(434, 176);
            panel1.TabIndex = 0;
            // 
            // PanelFill
            // 
            PanelFill.Controls.Add(textBoxTypeName);
            PanelFill.Controls.Add(labelTypeName);
            PanelFill.Dock = DockStyle.Fill;
            PanelFill.Location = new Point(10, 10);
            PanelFill.Margin = new Padding(3, 0, 3, 0);
            PanelFill.Name = "PanelFill";
            PanelFill.Padding = new Padding(10);
            PanelFill.Size = new Size(414, 95);
            PanelFill.TabIndex = 2;
            // 
            // textBoxTypeName
            // 
            textBoxTypeName.Dock = DockStyle.Top;
            textBoxTypeName.Location = new Point(10, 35);
            textBoxTypeName.Name = "textBoxTypeName";
            textBoxTypeName.Size = new Size(394, 33);
            textBoxTypeName.TabIndex = 1;
            // 
            // labelTypeName
            // 
            labelTypeName.AutoSize = true;
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Location = new Point(10, 10);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(104, 25);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Тип аниме";
            labelTypeName.Click += label1_Click;
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(10, 105);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(414, 61);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(134, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddType
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 176);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddType";
            Text = "Информация о типе аниме";
            Load += FormAddType_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelFill.ResumeLayout(false);
            PanelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel PanelFill;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label labelTypeName;
        private TextBox textBoxTypeName;
    }
}