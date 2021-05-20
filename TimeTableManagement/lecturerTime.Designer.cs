
namespace TimeTableManagement
{
    partial class lecturerTime
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSearchLectures = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubGroup = new System.Windows.Forms.ComboBox();
            this.BtnGenerateL = new System.Windows.Forms.Button();
            this.dataGridViewSearchL = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchL)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchLectures
            // 
            this.labelSearchLectures.AutoSize = true;
            this.labelSearchLectures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.labelSearchLectures.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSearchLectures.ForeColor = System.Drawing.Color.White;
            this.labelSearchLectures.Location = new System.Drawing.Point(621, 24);
            this.labelSearchLectures.Name = "labelSearchLectures";
            this.labelSearchLectures.Padding = new System.Windows.Forms.Padding(10);
            this.labelSearchLectures.Size = new System.Drawing.Size(326, 50);
            this.labelSearchLectures.TabIndex = 48;
            this.labelSearchLectures.Text = "Search Lecturer Time Table";
            this.labelSearchLectures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Lecturer Name : ";
            // 
            // cmbSubGroup
            // 
            this.cmbSubGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.cmbSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubGroup.FormattingEnabled = true;
            this.cmbSubGroup.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbSubGroup.Location = new System.Drawing.Point(292, 175);
            this.cmbSubGroup.Name = "cmbSubGroup";
            this.cmbSubGroup.Size = new System.Drawing.Size(246, 28);
            this.cmbSubGroup.TabIndex = 50;
            this.cmbSubGroup.SelectedIndexChanged += new System.EventHandler(this.cmbSubGroup_SelectedIndexChanged);
            // 
            // BtnGenerateL
            // 
            this.BtnGenerateL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(117)))));
            this.BtnGenerateL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGenerateL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerateL.ForeColor = System.Drawing.Color.White;
            this.BtnGenerateL.Location = new System.Drawing.Point(584, 154);
            this.BtnGenerateL.Name = "BtnGenerateL";
            this.BtnGenerateL.Size = new System.Drawing.Size(174, 49);
            this.BtnGenerateL.TabIndex = 51;
            this.BtnGenerateL.Text = "Generate Time Table";
            this.BtnGenerateL.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSearchL
            // 
            this.dataGridViewSearchL.AllowUserToAddRows = false;
            this.dataGridViewSearchL.AllowUserToDeleteRows = false;
            this.dataGridViewSearchL.AllowUserToResizeColumns = false;
            this.dataGridViewSearchL.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSearchL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSearchL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSearchL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.dataGridViewSearchL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSearchL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchL.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSearchL.GridColor = System.Drawing.Color.Black;
            this.dataGridViewSearchL.Location = new System.Drawing.Point(69, 255);
            this.dataGridViewSearchL.Name = "dataGridViewSearchL";
            this.dataGridViewSearchL.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchL.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSearchL.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSearchL.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewSearchL.RowTemplate.Height = 29;
            this.dataGridViewSearchL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchL.ShowEditingIcon = false;
            this.dataGridViewSearchL.Size = new System.Drawing.Size(854, 301);
            this.dataGridViewSearchL.TabIndex = 81;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(764, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 49);
            this.button1.TabIndex = 82;
            this.button1.Text = "Print Table";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lecturerTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(68)))), ((int)(((byte)(164)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSearchL);
            this.Controls.Add(this.BtnGenerateL);
            this.Controls.Add(this.cmbSubGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSearchLectures);
            this.Name = "lecturerTime";
            this.Size = new System.Drawing.Size(992, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchLectures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubGroup;
        private System.Windows.Forms.Button BtnGenerateL;
        private System.Windows.Forms.DataGridView dataGridViewSearchL;
        private System.Windows.Forms.Button button1;
    }
}
