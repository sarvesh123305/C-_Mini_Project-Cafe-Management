
namespace CafeMenu.All_User_Controls
{
    partial class placeorder_uc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DG_place = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.elipse_placeOrder = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.database1DataSet1 = new CafeMenu.Database1DataSet1();
            this.menudataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menudataTableAdapter = new CafeMenu.Database1DataSet1TableAdapters.menudataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DG_place)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menudataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(141, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 43);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Amount";
            // 
            // DG_place
            // 
            this.DG_place.AllowUserToAddRows = false;
            this.DG_place.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.DG_place.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DG_place.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_place.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DG_place.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DG_place.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DG_place.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_place.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_place.DefaultCellStyle = dataGridViewCellStyle12;
            this.DG_place.EnableHeadersVisualStyles = false;
            this.DG_place.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.DG_place.Location = new System.Drawing.Point(121, 187);
            this.DG_place.Name = "DG_place";
            this.DG_place.ReadOnly = true;
            this.DG_place.RowHeadersVisible = false;
            this.DG_place.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DG_place.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_place.Size = new System.Drawing.Size(586, 187);
            this.DG_place.TabIndex = 6;
            this.DG_place.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.DG_place.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.DG_place.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DG_place.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DG_place.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DG_place.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DG_place.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.DG_place.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.DG_place.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.DG_place.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DG_place.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DG_place.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DG_place.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DG_place.ThemeStyle.HeaderStyle.Height = 23;
            this.DG_place.ThemeStyle.ReadOnly = true;
            this.DG_place.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.DG_place.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DG_place.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DG_place.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DG_place.ThemeStyle.RowsStyle.Height = 22;
            this.DG_place.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.DG_place.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Wheat;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderThickness = 10;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Maroon;
            this.guna2Panel1.Location = new System.Drawing.Point(255, 78);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(314, 77);
            this.guna2Panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // elipse_placeOrder
            // 
            this.elipse_placeOrder.BorderRadius = 40;
            this.elipse_placeOrder.TargetControl = this;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menudataBindingSource
            // 
            this.menudataBindingSource.DataMember = "menudata";
            this.menudataBindingSource.DataSource = this.database1DataSet1;
            // 
            // menudataTableAdapter
            // 
            this.menudataTableAdapter.ClearBeforeFill = true;
            // 
            // placeorder_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DG_place);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "placeorder_uc";
            this.Size = new System.Drawing.Size(828, 586);
            this.Load += new System.EventHandler(this.placeorder_uc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_place)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menudataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView DG_place;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse elipse_placeOrder;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource menudataBindingSource;
        private Database1DataSet1TableAdapters.menudataTableAdapter menudataTableAdapter;
    }
}
