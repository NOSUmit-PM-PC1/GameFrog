﻿namespace GameFrog
{
    partial class FormGame
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
            this.dataGridViewGame = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGame)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGame
            // 
            this.dataGridViewGame.AllowUserToAddRows = false;
            this.dataGridViewGame.AllowUserToDeleteRows = false;
            this.dataGridViewGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGame.ColumnHeadersVisible = false;
            this.dataGridViewGame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridViewGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewGame.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGame.Name = "dataGridViewGame";
            this.dataGridViewGame.ReadOnly = true;
            this.dataGridViewGame.RowHeadersVisible = false;
            this.dataGridViewGame.RowTemplate.Height = 110;
            this.dataGridViewGame.Size = new System.Drawing.Size(1112, 150);
            this.dataGridViewGame.TabIndex = 0;
            this.dataGridViewGame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGame_CellClick);
            // 
            // Column
            // 
            this.Column.HeaderText = "Column1";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.dataGridViewGame);
            this.Name = "FormGame";
            this.Text = "Игра ЛЯГУШКИ";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGame;
        private System.Windows.Forms.DataGridViewImageColumn Column;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}

