namespace petstore.NET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.querySelectLabel = new System.Windows.Forms.Label();
            this.selectQuery = new System.Windows.Forms.ComboBox();
            this.queryDo = new System.Windows.Forms.Button();
            this.queryPanel1 = new System.Windows.Forms.Panel();
            this.result1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultHeader = new System.Windows.Forms.Label();
            this.queryPanel2 = new System.Windows.Forms.Panel();
            this.result2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryPanel3 = new System.Windows.Forms.Panel();
            this.result3 = new System.Windows.Forms.TextBox();
            this.resultLabel3 = new System.Windows.Forms.Label();
            this.queryPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result1)).BeginInit();
            this.queryPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result2)).BeginInit();
            this.queryPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // querySelectLabel
            // 
            this.querySelectLabel.AutoSize = true;
            this.querySelectLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.querySelectLabel.Location = new System.Drawing.Point(12, 10);
            this.querySelectLabel.Name = "querySelectLabel";
            this.querySelectLabel.Size = new System.Drawing.Size(151, 25);
            this.querySelectLabel.TabIndex = 0;
            this.querySelectLabel.Text = "Выбор запроса:";
            // 
            // selectQuery
            // 
            this.selectQuery.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectQuery.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selectQuery.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectQuery.FormattingEnabled = true;
            this.selectQuery.Items.AddRange(new object[] {
            "Сведения о заказах, сделанных за последний день",
            "Информация о товаре, который заказывали больше всего раз за последний месяц",
            "Суммарная выручка за неделю"});
            this.selectQuery.Location = new System.Drawing.Point(169, 6);
            this.selectQuery.Name = "selectQuery";
            this.selectQuery.Size = new System.Drawing.Size(893, 33);
            this.selectQuery.TabIndex = 1;
            this.selectQuery.SelectedIndexChanged += new System.EventHandler(this.selectQuery_SelectedIndexChanged);
            // 
            // queryDo
            // 
            this.queryDo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queryDo.Location = new System.Drawing.Point(435, 45);
            this.queryDo.Name = "queryDo";
            this.queryDo.Size = new System.Drawing.Size(220, 39);
            this.queryDo.TabIndex = 2;
            this.queryDo.Text = "Выполнить запрос";
            this.queryDo.UseVisualStyleBackColor = true;
            this.queryDo.Click += new System.EventHandler(this.queryDo_Click);
            // 
            // queryPanel1
            // 
            this.queryPanel1.Controls.Add(this.result1);
            this.queryPanel1.Location = new System.Drawing.Point(1070, 93);
            this.queryPanel1.Name = "queryPanel1";
            this.queryPanel1.Size = new System.Drawing.Size(1050, 442);
            this.queryPanel1.TabIndex = 3;
            this.queryPanel1.Visible = false;
            // 
            // result1
            // 
            this.result1.AllowUserToAddRows = false;
            this.result1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.result1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.result1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.user,
            this.datetime,
            this.status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.result1.DefaultCellStyle = dataGridViewCellStyle5;
            this.result1.Location = new System.Drawing.Point(3, 3);
            this.result1.Name = "result1";
            this.result1.ReadOnly = true;
            this.result1.RowTemplate.Height = 25;
            this.result1.Size = new System.Drawing.Size(1044, 436);
            this.result1.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "№ Заказа";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // user
            // 
            this.user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.DefaultCellStyle = dataGridViewCellStyle3;
            this.user.HeaderText = "Почта Заказчика";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // datetime
            // 
            this.datetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datetime.DefaultCellStyle = dataGridViewCellStyle4;
            this.datetime.HeaderText = "Дата и время заказа";
            this.datetime.Name = "datetime";
            this.datetime.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Статус Заказа";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // resultHeader
            // 
            this.resultHeader.AutoSize = true;
            this.resultHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultHeader.Location = new System.Drawing.Point(451, 93);
            this.resultHeader.Name = "resultHeader";
            this.resultHeader.Size = new System.Drawing.Size(189, 28);
            this.resultHeader.TabIndex = 4;
            this.resultHeader.Text = "Результат запроса";
            this.resultHeader.Visible = false;
            // 
            // queryPanel2
            // 
            this.queryPanel2.Controls.Add(this.result2);
            this.queryPanel2.Location = new System.Drawing.Point(12, 579);
            this.queryPanel2.Name = "queryPanel2";
            this.queryPanel2.Size = new System.Drawing.Size(1050, 442);
            this.queryPanel2.TabIndex = 4;
            this.queryPanel2.Visible = false;
            // 
            // result2
            // 
            this.result2.AllowUserToAddRows = false;
            this.result2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.result2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.result2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.result2.DefaultCellStyle = dataGridViewCellStyle10;
            this.result2.Location = new System.Drawing.Point(3, 3);
            this.result2.Name = "result2";
            this.result2.ReadOnly = true;
            this.result2.RowTemplate.Height = 25;
            this.result2.Size = new System.Drawing.Size(1044, 436);
            this.result2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "№ Товара";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество заказов";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // queryPanel3
            // 
            this.queryPanel3.Controls.Add(this.result3);
            this.queryPanel3.Controls.Add(this.resultLabel3);
            this.queryPanel3.Location = new System.Drawing.Point(14, 133);
            this.queryPanel3.Name = "queryPanel3";
            this.queryPanel3.Size = new System.Drawing.Size(1050, 442);
            this.queryPanel3.TabIndex = 5;
            this.queryPanel3.Visible = false;
            // 
            // result3
            // 
            this.result3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result3.Location = new System.Drawing.Point(201, 7);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(166, 32);
            this.result3.TabIndex = 1;
            // 
            // resultLabel3
            // 
            this.resultLabel3.AutoSize = true;
            this.resultLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel3.Location = new System.Drawing.Point(3, 11);
            this.resultLabel3.Name = "resultLabel3";
            this.resultLabel3.Size = new System.Drawing.Size(192, 25);
            this.resultLabel3.TabIndex = 0;
            this.resultLabel3.Text = "Выручка за неделю:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 587);
            this.Controls.Add(this.queryPanel3);
            this.Controls.Add(this.queryPanel2);
            this.Controls.Add(this.resultHeader);
            this.Controls.Add(this.queryPanel1);
            this.Controls.Add(this.queryDo);
            this.Controls.Add(this.selectQuery);
            this.Controls.Add(this.querySelectLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Зоомагазин \"Мокрый хвост\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.queryPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.result1)).EndInit();
            this.queryPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.result2)).EndInit();
            this.queryPanel3.ResumeLayout(false);
            this.queryPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label querySelectLabel;
        private ComboBox selectQuery;
        private Button queryDo;
        private Panel queryPanel1;
        private Label resultHeader;
        private DataGridView result1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn user;
        private DataGridViewTextBoxColumn datetime;
        private DataGridViewTextBoxColumn status;
        private Panel queryPanel2;
        private DataGridView result2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Panel queryPanel3;
        private TextBox result3;
        private Label resultLabel3;
    }
}