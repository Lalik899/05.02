namespace Записная_книжка_контактов
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.colNmae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNmae,
            this.colPhone,
            this.colEmail,
            this.colCategory});
            this.dgvContacts.Location = new System.Drawing.Point(131, 12);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.Size = new System.Drawing.Size(531, 277);
            this.dgvContacts.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 314);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(174, 314);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(295, 314);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "Семья",
            "Работа",
            "Друзья"});
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(624, 314);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(131, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(470, 341);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(212, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(425, 315);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // colNmae
            // 
            this.colNmae.HeaderText = "ФИО";
            this.colNmae.Name = "colNmae";
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Телефон";
            this.colPhone.Name = "colPhone";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Категория";
            this.colCategory.Name = "colCategory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvContacts);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записная книжка контактов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNmae;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
    }
}

