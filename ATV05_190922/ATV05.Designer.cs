
namespace ATV05_190922
{
    partial class ATV05
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnl01 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Cod_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_Prod = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.pnl01.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pnl01);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 293);
            this.tabControl1.TabIndex = 0;
            // 
            // pnl01
            // 
            this.pnl01.Controls.Add(this.btnFoto);
            this.pnl01.Controls.Add(this.picBox);
            this.pnl01.Controls.Add(this.lblFoto);
            this.pnl01.Controls.Add(this.btnAdd);
            this.pnl01.Controls.Add(this.btnInserir);
            this.pnl01.Controls.Add(this.txtNome);
            this.pnl01.Controls.Add(this.txtCod);
            this.pnl01.Controls.Add(this.lblNome);
            this.pnl01.Controls.Add(this.lblCod);
            this.pnl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl01.Location = new System.Drawing.Point(4, 22);
            this.pnl01.Name = "pnl01";
            this.pnl01.Padding = new System.Windows.Forms.Padding(3);
            this.pnl01.Size = new System.Drawing.Size(521, 267);
            this.pnl01.TabIndex = 0;
            this.pnl01.Text = "Entrada de Dados";
            this.pnl01.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta de Dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Prod,
            this.Nome_Prod,
            this.img_Prod});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(19, 14);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(50, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(88, 14);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(416, 20);
            this.txtNome.TabIndex = 3;
            // 
            // btnInserir
            // 
            this.btnInserir.Image = global::ATV05_190922.Properties.Resources.add_icon_icons_com_74429;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserir.Location = new System.Drawing.Point(428, 193);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 58);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::ATV05_190922.Properties.Resources.check_ok_accept_apply_1582__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(338, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 58);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::ATV05_190922.Properties.Resources.delete_40623;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(354, 311);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 59);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::ATV05_190922.Properties.Resources.logout256_24927;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(445, 311);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 59);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ATV05_190922.Properties.Resources.Delete_27010;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(429, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 50);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(22, 78);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(36, 13);
            this.lblFoto.TabIndex = 6;
            this.lblFoto.Text = "Foto:";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Enabled = false;
            this.picBox.Location = new System.Drawing.Point(88, 78);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 90);
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Image = global::ATV05_190922.Properties.Resources.iPhoto_photo_picture_camera_2661;
            this.btnFoto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFoto.Location = new System.Drawing.Point(247, 193);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 58);
            this.btnFoto.TabIndex = 8;
            this.btnFoto.Text = "&Foto";
            this.btnFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Cod_Prod
            // 
            this.Cod_Prod.HeaderText = "Código";
            this.Cod_Prod.Name = "Cod_Prod";
            this.Cod_Prod.Width = 65;
            // 
            // Nome_Prod
            // 
            this.Nome_Prod.HeaderText = "Nome";
            this.Nome_Prod.Name = "Nome_Prod";
            this.Nome_Prod.Width = 60;
            // 
            // img_Prod
            // 
            this.img_Prod.HeaderText = "Imagem";
            this.img_Prod.Name = "img_Prod";
            this.img_Prod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.img_Prod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.img_Prod.Width = 69;
            // 
            // ATV05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 382);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tabControl1);
            this.Name = "ATV05";
            this.Text = "ATV05";
            this.tabControl1.ResumeLayout(false);
            this.pnl01.ResumeLayout(false);
            this.pnl01.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pnl01;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Prod;
        private System.Windows.Forms.DataGridViewImageColumn img_Prod;
    }
}

