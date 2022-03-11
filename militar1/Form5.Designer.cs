
namespace militar1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cURPSOLDADOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domiciliosoldadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadsoldadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexosoldadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonosoldadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsedeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinvestigacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.militarDataSet = new militar1.MilitarDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.soldadosTableAdapter = new militar1.MilitarDataSetTableAdapters.SoldadosTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cURPSOLDADOSDataGridViewTextBoxColumn,
            this.domiciliosoldadosDataGridViewTextBoxColumn,
            this.edadsoldadosDataGridViewTextBoxColumn,
            this.sexosoldadosDataGridViewTextBoxColumn,
            this.telefonosoldadosDataGridViewTextBoxColumn,
            this.idsedeDataGridViewTextBoxColumn,
            this.idinvestigacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.soldadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 150);
            this.dataGridView1.TabIndex = 108;
            // 
            // cURPSOLDADOSDataGridViewTextBoxColumn
            // 
            this.cURPSOLDADOSDataGridViewTextBoxColumn.DataPropertyName = "CURP_SOLDADOS";
            this.cURPSOLDADOSDataGridViewTextBoxColumn.HeaderText = "CURP_SOLDADOS";
            this.cURPSOLDADOSDataGridViewTextBoxColumn.Name = "cURPSOLDADOSDataGridViewTextBoxColumn";
            // 
            // domiciliosoldadosDataGridViewTextBoxColumn
            // 
            this.domiciliosoldadosDataGridViewTextBoxColumn.DataPropertyName = "Domicilio_soldados";
            this.domiciliosoldadosDataGridViewTextBoxColumn.HeaderText = "Domicilio_soldados";
            this.domiciliosoldadosDataGridViewTextBoxColumn.Name = "domiciliosoldadosDataGridViewTextBoxColumn";
            // 
            // edadsoldadosDataGridViewTextBoxColumn
            // 
            this.edadsoldadosDataGridViewTextBoxColumn.DataPropertyName = "Edad_soldados";
            this.edadsoldadosDataGridViewTextBoxColumn.HeaderText = "Edad_soldados";
            this.edadsoldadosDataGridViewTextBoxColumn.Name = "edadsoldadosDataGridViewTextBoxColumn";
            // 
            // sexosoldadosDataGridViewTextBoxColumn
            // 
            this.sexosoldadosDataGridViewTextBoxColumn.DataPropertyName = "Sexo_soldados";
            this.sexosoldadosDataGridViewTextBoxColumn.HeaderText = "Sexo_soldados";
            this.sexosoldadosDataGridViewTextBoxColumn.Name = "sexosoldadosDataGridViewTextBoxColumn";
            // 
            // telefonosoldadosDataGridViewTextBoxColumn
            // 
            this.telefonosoldadosDataGridViewTextBoxColumn.DataPropertyName = "Telefono_soldados";
            this.telefonosoldadosDataGridViewTextBoxColumn.HeaderText = "Telefono_soldados";
            this.telefonosoldadosDataGridViewTextBoxColumn.Name = "telefonosoldadosDataGridViewTextBoxColumn";
            // 
            // idsedeDataGridViewTextBoxColumn
            // 
            this.idsedeDataGridViewTextBoxColumn.DataPropertyName = "Id_sede";
            this.idsedeDataGridViewTextBoxColumn.HeaderText = "Id_sede";
            this.idsedeDataGridViewTextBoxColumn.Name = "idsedeDataGridViewTextBoxColumn";
            // 
            // idinvestigacionesDataGridViewTextBoxColumn
            // 
            this.idinvestigacionesDataGridViewTextBoxColumn.DataPropertyName = "Id_investigaciones";
            this.idinvestigacionesDataGridViewTextBoxColumn.HeaderText = "Id_investigaciones";
            this.idinvestigacionesDataGridViewTextBoxColumn.Name = "idinvestigacionesDataGridViewTextBoxColumn";
            // 
            // soldadosBindingSource
            // 
            this.soldadosBindingSource.DataMember = "Soldados";
            this.soldadosBindingSource.DataSource = this.militarDataSet;
            // 
            // militarDataSet
            // 
            this.militarDataSet.DataSetName = "MilitarDataSet";
            this.militarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(260, 206);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 21);
            this.comboBox2.TabIndex = 107;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(122, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Id Investigacion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 104;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(122, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Sexo del soldado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(122, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Telefono soldado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(122, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Id sede";
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(532, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 50);
            this.button5.TabIndex = 99;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(600, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 50);
            this.button4.TabIndex = 98;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(532, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 50);
            this.button3.TabIndex = 97;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(600, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 50);
            this.button2.TabIndex = 96;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(532, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 50);
            this.button1.TabIndex = 95;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(260, 102);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(198, 20);
            this.textBox10.TabIndex = 94;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(260, 128);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(198, 20);
            this.textBox11.TabIndex = 93;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(260, 76);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(198, 20);
            this.textBox20.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(122, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 91;
            this.label12.Text = "Curp del soldado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(122, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 90;
            this.label11.Text = "Domicilio soldado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(122, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 89;
            this.label10.Text = "Edad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(124, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 88;
            this.label9.Text = "Soldados";
            // 
            // soldadosTableAdapter
            // 
            this.soldadosTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(713, 421);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 109;
            this.button6.Text = "Reportes ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Soldados";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private MilitarDataSet militarDataSet;
        private System.Windows.Forms.BindingSource soldadosBindingSource;
        private MilitarDataSetTableAdapters.SoldadosTableAdapter soldadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURPSOLDADOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domiciliosoldadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadsoldadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexosoldadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonosoldadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinvestigacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
    }
}