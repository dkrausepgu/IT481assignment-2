namespace WindowsFormsApp2
{
    partial class Form1
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
            this.connectioncheck = new System.Windows.Forms.Label();
            this.numrec = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.compname = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.compnametext = new System.Windows.Forms.TextBox();
            this.updatedb = new System.Windows.Forms.Button();
            this.countrec = new System.Windows.Forms.Button();
            this.viewdb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.northwndDataSet = new WindowsFormsApp2.northwndDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApp2.northwndDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwndDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // connectioncheck
            // 
            this.connectioncheck.AutoSize = true;
            this.connectioncheck.Location = new System.Drawing.Point(564, 32);
            this.connectioncheck.Name = "connectioncheck";
            this.connectioncheck.Size = new System.Drawing.Size(95, 13);
            this.connectioncheck.TabIndex = 0;
            this.connectioncheck.Text = "Connection Check";
            // 
            // numrec
            // 
            this.numrec.AutoSize = true;
            this.numrec.Location = new System.Drawing.Point(564, 99);
            this.numrec.Name = "numrec";
            this.numrec.Size = new System.Drawing.Size(99, 13);
            this.numrec.TabIndex = 1;
            this.numrec.Text = "Number of Records";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(35, 32);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 2;
            this.id.Text = "ID";
            // 
            // compname
            // 
            this.compname.AutoSize = true;
            this.compname.Location = new System.Drawing.Point(35, 99);
            this.compname.Name = "compname";
            this.compname.Size = new System.Drawing.Size(82, 13);
            this.compname.TabIndex = 3;
            this.compname.Text = "Company Name";
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(158, 32);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(100, 20);
            this.idtext.TabIndex = 4;
            // 
            // compnametext
            // 
            this.compnametext.Location = new System.Drawing.Point(158, 99);
            this.compnametext.Name = "compnametext";
            this.compnametext.Size = new System.Drawing.Size(100, 20);
            this.compnametext.TabIndex = 5;

            // 
            // updatedb
            // 
            this.updatedb.Location = new System.Drawing.Point(57, 159);
            this.updatedb.Name = "updatedb";
            this.updatedb.Size = new System.Drawing.Size(178, 23);
            this.updatedb.TabIndex = 6;
            this.updatedb.Text = "Update Data Base";
            this.updatedb.UseVisualStyleBackColor = true;
            this.updatedb.Click += new System.EventHandler(this.updatedb_Click);
            // 
            // countrec
            // 
            this.countrec.Location = new System.Drawing.Point(567, 159);
            this.countrec.Name = "countrec";
            this.countrec.Size = new System.Drawing.Size(96, 23);
            this.countrec.TabIndex = 7;
            this.countrec.Text = "Count Records";
            this.countrec.UseVisualStyleBackColor = true;
            this.countrec.Click += new System.EventHandler(this.countrec_Click);
            // 
            // viewdb
            // 
            this.viewdb.Location = new System.Drawing.Point(37, 409);
            this.viewdb.Name = "viewdb";
            this.viewdb.Size = new System.Drawing.Size(626, 23);
            this.viewdb.TabIndex = 8;
            this.viewdb.Text = "View DataBase";
            this.viewdb.UseVisualStyleBackColor = true;
            this.viewdb.Click += new System.EventHandler(this.viewdb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // northwndDataSet
            // 
            this.northwndDataSet.DataSetName = "northwndDataSet";
            this.northwndDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwndDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewdb);
            this.Controls.Add(this.countrec);
            this.Controls.Add(this.updatedb);
            this.Controls.Add(this.compnametext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.compname);
            this.Controls.Add(this.id);
            this.Controls.Add(this.numrec);
            this.Controls.Add(this.connectioncheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwndDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connectioncheck;
        private System.Windows.Forms.Label numrec;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label compname;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox compnametext;
        private System.Windows.Forms.Button updatedb;
        private System.Windows.Forms.Button countrec;
        private System.Windows.Forms.Button viewdb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private northwndDataSet northwndDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private northwndDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}

