﻿
namespace Preminder.Forms
{
    partial class FormLihatSemua
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvActiviy = new System.Windows.Forms.Label();
            this.dgvCourseSchedule = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCourseScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preminderDataSet = new Preminder.PreminderDataSet();
            this.dgvToDo = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenggatPengumpulanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBTugasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefres = new System.Windows.Forms.Button();
            this.lb_Kegiatan = new System.Windows.Forms.ListBox();
            this.tBTugasTableAdapter = new Preminder.PreminderDataSetTableAdapters.TBTugasTableAdapter();
            this.tblCourseScheduleTableAdapter = new Preminder.PreminderDataSetTableAdapters.TblCourseScheduleTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_FilterByDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_SearchByCourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_SearchByTodo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preminderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTugasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jadwal Kuliah :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tugas : ";
            // 
            // dgvActiviy
            // 
            this.dgvActiviy.AutoSize = true;
            this.dgvActiviy.Location = new System.Drawing.Point(22, 315);
            this.dgvActiviy.Name = "dgvActiviy";
            this.dgvActiviy.Size = new System.Drawing.Size(55, 13);
            this.dgvActiviy.TabIndex = 9;
            this.dgvActiviy.Text = "Kegiatan :";
            // 
            // dgvCourseSchedule
            // 
            this.dgvCourseSchedule.AutoGenerateColumns = false;
            this.dgvCourseSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.hourDataGridViewTextBoxColumn});
            this.dgvCourseSchedule.DataSource = this.tblCourseScheduleBindingSource;
            this.dgvCourseSchedule.Location = new System.Drawing.Point(25, 63);
            this.dgvCourseSchedule.Name = "dgvCourseSchedule";
            this.dgvCourseSchedule.Size = new System.Drawing.Size(688, 109);
            this.dgvCourseSchedule.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Nama Jadwal";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Hari";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.Width = 220;
            // 
            // hourDataGridViewTextBoxColumn
            // 
            this.hourDataGridViewTextBoxColumn.DataPropertyName = "Hour";
            this.hourDataGridViewTextBoxColumn.HeaderText = "Jam";
            this.hourDataGridViewTextBoxColumn.Name = "hourDataGridViewTextBoxColumn";
            this.hourDataGridViewTextBoxColumn.Width = 220;
            // 
            // tblCourseScheduleBindingSource
            // 
            this.tblCourseScheduleBindingSource.DataMember = "TblCourseSchedule";
            this.tblCourseScheduleBindingSource.DataSource = this.preminderDataSet;
            // 
            // preminderDataSet
            // 
            this.preminderDataSet.DataSetName = "PreminderDataSet";
            this.preminderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvToDo
            // 
            this.dgvToDo.AutoGenerateColumns = false;
            this.dgvToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.tugasDataGridViewTextBoxColumn,
            this.tenggatPengumpulanDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.dgvToDo.DataSource = this.tBTugasBindingSource;
            this.dgvToDo.Location = new System.Drawing.Point(25, 199);
            this.dgvToDo.Name = "dgvToDo";
            this.dgvToDo.Size = new System.Drawing.Size(688, 109);
            this.dgvToDo.TabIndex = 11;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Width = 40;
            // 
            // tugasDataGridViewTextBoxColumn
            // 
            this.tugasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tugasDataGridViewTextBoxColumn.DataPropertyName = "Tugas";
            this.tugasDataGridViewTextBoxColumn.HeaderText = "Tugas";
            this.tugasDataGridViewTextBoxColumn.Name = "tugasDataGridViewTextBoxColumn";
            // 
            // tenggatPengumpulanDataGridViewTextBoxColumn
            // 
            this.tenggatPengumpulanDataGridViewTextBoxColumn.DataPropertyName = "Tenggat_Pengumpulan";
            this.tenggatPengumpulanDataGridViewTextBoxColumn.HeaderText = "Tenggat pengumpulan";
            this.tenggatPengumpulanDataGridViewTextBoxColumn.Name = "tenggatPengumpulanDataGridViewTextBoxColumn";
            this.tenggatPengumpulanDataGridViewTextBoxColumn.Width = 220;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.Width = 220;
            // 
            // tBTugasBindingSource
            // 
            this.tBTugasBindingSource.DataMember = "TBTugas";
            this.tBTugasBindingSource.DataSource = this.preminderDataSet;
            // 
            // btnRefres
            // 
            this.btnRefres.Location = new System.Drawing.Point(745, 12);
            this.btnRefres.Name = "btnRefres";
            this.btnRefres.Size = new System.Drawing.Size(116, 34);
            this.btnRefres.TabIndex = 13;
            this.btnRefres.Text = "Refresh";
            this.btnRefres.UseVisualStyleBackColor = true;
            this.btnRefres.Click += new System.EventHandler(this.btnRefres_Click);
            // 
            // lb_Kegiatan
            // 
            this.lb_Kegiatan.FormattingEnabled = true;
            this.lb_Kegiatan.Location = new System.Drawing.Point(25, 335);
            this.lb_Kegiatan.Name = "lb_Kegiatan";
            this.lb_Kegiatan.Size = new System.Drawing.Size(688, 108);
            this.lb_Kegiatan.TabIndex = 14;
            // 
            // tBTugasTableAdapter
            // 
            this.tBTugasTableAdapter.ClearBeforeFill = true;
            // 
            // tblCourseScheduleTableAdapter
            // 
            this.tblCourseScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Filter (Hari)";
            // 
            // tb_FilterByDay
            // 
            this.tb_FilterByDay.Location = new System.Drawing.Point(745, 144);
            this.tb_FilterByDay.Name = "tb_FilterByDay";
            this.tb_FilterByDay.Size = new System.Drawing.Size(116, 20);
            this.tb_FilterByDay.TabIndex = 26;
            this.tb_FilterByDay.TextChanged += new System.EventHandler(this.tb_FilterByDay_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cari Jadwal";
            // 
            // tb_SearchByCourse
            // 
            this.tb_SearchByCourse.Location = new System.Drawing.Point(745, 99);
            this.tb_SearchByCourse.Name = "tb_SearchByCourse";
            this.tb_SearchByCourse.Size = new System.Drawing.Size(116, 20);
            this.tb_SearchByCourse.TabIndex = 24;
            this.tb_SearchByCourse.TextChanged += new System.EventHandler(this.tb_SearchByCourse_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cari Tugas";
            // 
            // tb_SearchByTodo
            // 
            this.tb_SearchByTodo.Location = new System.Drawing.Point(745, 236);
            this.tb_SearchByTodo.Name = "tb_SearchByTodo";
            this.tb_SearchByTodo.Size = new System.Drawing.Size(116, 20);
            this.tb_SearchByTodo.TabIndex = 28;
            this.tb_SearchByTodo.TextChanged += new System.EventHandler(this.tb_SearchByTodo_TextChanged);
            // 
            // FormLihatSemua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_SearchByTodo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_FilterByDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_SearchByCourse);
            this.Controls.Add(this.lb_Kegiatan);
            this.Controls.Add(this.btnRefres);
            this.Controls.Add(this.dgvToDo);
            this.Controls.Add(this.dgvCourseSchedule);
            this.Controls.Add(this.dgvActiviy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLihatSemua";
            this.Text = "LihatSemua";
            this.Load += new System.EventHandler(this.FormLihatSemua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preminderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTugasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dgvActiviy;
        private System.Windows.Forms.DataGridView dgvCourseSchedule;
        private System.Windows.Forms.DataGridView dgvToDo;
        private System.Windows.Forms.Button btnRefres;
        private System.Windows.Forms.ListBox lb_Kegiatan;
        private PreminderDataSet preminderDataSet;
        private System.Windows.Forms.BindingSource tBTugasBindingSource;
        private PreminderDataSetTableAdapters.TBTugasTableAdapter tBTugasTableAdapter;
        private System.Windows.Forms.BindingSource tblCourseScheduleBindingSource;
        private PreminderDataSetTableAdapters.TblCourseScheduleTableAdapter tblCourseScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenggatPengumpulanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_FilterByDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_SearchByCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_SearchByTodo;
    }
}