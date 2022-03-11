
namespace militar1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idINVESTIGACIONESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUGARINVESTIGACIONESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaINVESTIGACIONESsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsedeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investigacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.militarDataSet = new militar1.MilitarDataSet();
            this.investigacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.armamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.armamentoTableAdapter = new militar1.MilitarDataSetTableAdapters.ArmamentoTableAdapter();
            this.investigacionesTableAdapter = new militar1.MilitarDataSetTableAdapters.InvestigacionesTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investigacionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investigacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idINVESTIGACIONESDataGridViewTextBoxColumn,
            this.lUGARINVESTIGACIONESDataGridViewTextBoxColumn,
            this.fechaINVESTIGACIONESsDataGridViewTextBoxColumn,
            this.idsedeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.investigacionesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(160, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 150);
            this.dataGridView1.TabIndex = 92;
            // 
            // idINVESTIGACIONESDataGridViewTextBoxColumn
            // 
            this.idINVESTIGACIONESDataGridViewTextBoxColumn.DataPropertyName = "Id_INVESTIGACIONES";
            this.idINVESTIGACIONESDataGridViewTextBoxColumn.HeaderText = "Id_INVESTIGACIONES";
            this.idINVESTIGACIONESDataGridViewTextBoxColumn.Name = "idINVESTIGACIONESDataGridViewTextBoxColumn";
            // 
            // lUGARINVESTIGACIONESDataGridViewTextBoxColumn
            // 
            this.lUGARINVESTIGACIONESDataGridViewTextBoxColumn.DataPropertyName = "LUGAR_INVESTIGACIONES";
            this.lUGARINVESTIGACIONESDataGridViewTextBoxColumn.HeaderText = "LUGAR_INVESTIGACIONES";
            this.lUGARINVESTIGACIONESDataGridViewTextBoxColumn.Name = "lUGARINVESTIGACIONESDataGridViewTextBoxColumn";
            // 
            // fechaINVESTIGACIONESsDataGridViewTextBoxColumn
            // 
            this.fechaINVESTIGACIONESsDataGridViewTextBoxColumn.DataPropertyName = "Fecha_INVESTIGACIONESs";
            this.fechaINVESTIGACIONESsDataGridViewTextBoxColumn.HeaderText = "Fecha_INVESTIGACIONESs";
            this.fechaINVESTIGACIONESsDataGridViewTextBoxColumn.Name = "fechaINVESTIGACIONESsDataGridViewTextBoxColumn";
            // 
            // idsedeDataGridViewTextBoxColumn
            // 
            this.idsedeDataGridViewTextBoxColumn.DataPropertyName = "Id_sede";
            this.idsedeDataGridViewTextBoxColumn.HeaderText = "Id_sede";
            this.idsedeDataGridViewTextBoxColumn.Name = "idsedeDataGridViewTextBoxColumn";
            // 
            // investigacionesBindingSource1
            // 
            this.investigacionesBindingSource1.DataMember = "Investigaciones";
            this.investigacionesBindingSource1.DataSource = this.militarDataSet;
            // 
            // militarDataSet
            // 
            this.militarDataSet.DataSetName = "MilitarDataSet";
            this.militarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // investigacionesBindingSource
            // 
            this.investigacionesBindingSource.DataMember = "Investigaciones";
            this.investigacionesBindingSource.DataSource = this.militarDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(269, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 21);
            this.comboBox1.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(157, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Id sede";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 20);
            this.textBox2.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(133, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Fecha investigacion";
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(549, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 50);
            this.button5.TabIndex = 87;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(617, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 50);
            this.button4.TabIndex = 86;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(549, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 50);
            this.button3.TabIndex = 85;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(549, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 50);
            this.button1.TabIndex = 84;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(617, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 50);
            this.button2.TabIndex = 83;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(269, 120);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(230, 20);
            this.textBox26.TabIndex = 82;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(269, 83);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(230, 20);
            this.textBox25.TabIndex = 81;
            this.textBox25.TextChanged += new System.EventHandler(this.textBox25_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(122, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Lugar de la investigacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(142, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Id investigacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(133, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Investigaciones";
            // 
            // armamentoBindingSource
            // 
            this.armamentoBindingSource.DataMember = "Armamento";
            this.armamentoBindingSource.DataSource = this.militarDataSet;
            // 
            // armamentoTableAdapter
            // 
            this.armamentoTableAdapter.ClearBeforeFill = true;
            // 
            // investigacionesTableAdapter
            // 
            this.investigacionesTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(686, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 22);
            this.button6.TabIndex = 93;
            this.button6.Text = "Reporte";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Investigaciones";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investigacionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investigacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MilitarDataSet militarDataSet;
        private System.Windows.Forms.BindingSource armamentoBindingSource;
        private MilitarDataSetTableAdapters.ArmamentoTableAdapter armamentoTableAdapter;
        private System.Windows.Forms.BindingSource investigacionesBindingSource;
        private MilitarDataSetTableAdapters.InvestigacionesTableAdapter investigacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idINVESTIGACIONESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUGARINVESTIGACIONESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaINVESTIGACIONESsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource investigacionesBindingSource1;
        private System.Windows.Forms.Button button6;
    }
}