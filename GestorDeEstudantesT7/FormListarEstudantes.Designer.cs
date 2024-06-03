namespace GestorDeEstudantesT7
{
    partial class FormListarEstudantes
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
            this.dataGridViewListaDeEstudantes1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeEstudantes1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaDeEstudantes1
            // 
            this.dataGridViewListaDeEstudantes1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaDeEstudantes1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeEstudantes1.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewListaDeEstudantes1.Name = "dataGridViewListaDeEstudantes1";
            this.dataGridViewListaDeEstudantes1.Size = new System.Drawing.Size(767, 356);
            this.dataGridViewListaDeEstudantes1.TabIndex = 0;
            this.dataGridViewListaDeEstudantes1.DoubleClick += new System.EventHandler(this.dataGridViewListaDeEstudantes1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(767, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // FormListarEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewListaDeEstudantes1);
            this.Name = "FormListarEstudantes";
            this.Text = "FormListarEstudantes";
            this.Load += new System.EventHandler(this.FormListarEstudantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeEstudantes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaDeEstudantes1;
        private System.Windows.Forms.Button button1;
    }
}