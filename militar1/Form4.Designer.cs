
namespace militar1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idarmamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeMantenimientoArmamentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMunicionARMAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURPSOLDADOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.militarDataSet = new militar1.MilitarDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.militarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.armamentoTableAdapter = new militar1.MilitarDataSetTableAdapters.ArmamentoTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militarDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idarmamentoDataGridViewTextBoxColumn,
            this.fechaDeMantenimientoArmamentosDataGridViewTextBoxColumn,
            this.tipoMunicionARMAMENTODataGridViewTextBoxColumn,
            this.cURPSOLDADOSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.armamentoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(196, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 150);
            this.dataGridView1.TabIndex = 87;
            // 
            // idarmamentoDataGridViewTextBoxColumn
            // 
            this.idarmamentoDataGridViewTextBoxColumn.DataPropertyName = "Id_armamento";
            this.idarmamentoDataGridViewTextBoxColumn.HeaderText = "Id_armamento";
            this.idarmamentoDataGridViewTextBoxColumn.Name = "idarmamentoDataGridViewTextBoxColumn";
            // 
            // fechaDeMantenimientoArmamentosDataGridViewTextBoxColumn
            // 
            this.fechaDeMantenimientoArmamentosDataGridViewTextBoxColumn.DataPropertyName = "FechaDeMantenimiento_Armamentos";
            this.fechaDeMantenimientoArmamentosDataGridViewTextBoxColumn.HeaderText = "FechaDeMantenimiento_Armamentos";
            this.fechaDeMantenimientoArmamentosDataGridViewTextBoxColumn.Name = "fechaDeMantenimientoArmamentosDataGridViewTextBoxColumn";
            // 
            // tipoMunicionARMAMENTODataGridViewTextBoxColumn
            // 
            this.tipoMunicionARMAMENTODataGridViewTextBoxColumn.DataPropertyName = "TipoMunicion_ARMAMENTO";
            this.tipoMunicionARMAMENTODataGridViewTextBoxColumn.HeaderText = "TipoMunicion_ARMAMENTO";
            this.tipoMunicionARMAMENTODataGridViewTextBoxColumn.Name = "tipoMunicionARMAMENTODataGridViewTextBoxColumn";
            // 
            // cURPSOLDADOSDataGridViewTextBoxColumn
            // 
            this.cURPSOLDADOSDataGridViewTextBoxColumn.DataPropertyName = "CURP_SOLDADOS";
            this.cURPSOLDADOSDataGridViewTextBoxColumn.HeaderText = "CURP_SOLDADOS";
            this.cURPSOLDADOSDataGridViewTextBoxColumn.Name = "cURPSOLDADOSDataGridViewTextBoxColumn";
            // 
            // armamentoBindingSource
            // 
            this.armamentoBindingSource.DataMember = "Armamento";
            this.armamentoBindingSource.DataSource = this.militarDataSet;
            // 
            // militarDataSet
            // 
            this.militarDataSet.DataSetName = "MilitarDataSet";
            this.militarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(293, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(157, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Curp Soldados";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(293, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 20);
            this.textBox3.TabIndex = 84;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(293, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 83;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 82;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(536, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 50);
            this.button5.TabIndex = 81;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(604, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 50);
            this.button4.TabIndex = 80;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(536, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 50);
            this.button3.TabIndex = 79;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(536, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 50);
            this.button1.TabIndex = 78;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(165, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 77;
            this.label16.Text = "Id armamento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(157, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "Tipo de municion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(134, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "Fecha de ultimo mantenimiento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(157, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 74;
            this.label13.Text = "Armamento";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(604, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 50);
            this.button2.TabIndex = 73;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // militarDataSetBindingSource
            // 
            this.militarDataSetBindingSource.DataSource = this.militarDataSet;
            this.militarDataSetBindingSource.Position = 0;
            // 
            // armamentoTableAdapter
            // 
            this.armamentoTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(713, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 88;
            this.button6.Text = "Reporte";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Armamento";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militarDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource militarDataSetBindingSource;
        private MilitarDataSet militarDataSet;
        private System.Windows.Forms.BindingSource armamentoBindingSource;
        private MilitarDataSetTableAdapters.ArmamentoTableAdapter armamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarmamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeMantenimientoArmamentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMunicionARMAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURPSOLDADOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
    }
}