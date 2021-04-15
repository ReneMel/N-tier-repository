
namespace Program.Presentacion
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
            this.Insert = new System.Windows.Forms.Button();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.ApellidoBox = new System.Windows.Forms.TextBox();
            this.EdadBox = new System.Windows.Forms.TextBox();
            this.TelBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserDataView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(651, 136);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insertar";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(128, 40);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(223, 20);
            this.NombreBox.TabIndex = 1;
            // 
            // ApellidoBox
            // 
            this.ApellidoBox.Location = new System.Drawing.Point(128, 89);
            this.ApellidoBox.Name = "ApellidoBox";
            this.ApellidoBox.Size = new System.Drawing.Size(223, 20);
            this.ApellidoBox.TabIndex = 2;
            // 
            // EdadBox
            // 
            this.EdadBox.Location = new System.Drawing.Point(491, 89);
            this.EdadBox.Name = "EdadBox";
            this.EdadBox.Size = new System.Drawing.Size(235, 20);
            this.EdadBox.TabIndex = 3;
            // 
            // TelBox
            // 
            this.TelBox.Location = new System.Drawing.Point(491, 40);
            this.TelBox.Name = "TelBox";
            this.TelBox.Size = new System.Drawing.Size(235, 20);
            this.TelBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teléfono";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UserDataView
            // 
            this.UserDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataView.Location = new System.Drawing.Point(87, 191);
            this.UserDataView.Name = "UserDataView";
            this.UserDataView.Size = new System.Drawing.Size(639, 203);
            this.UserDataView.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tarea 01 -Programación N-capas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserDataView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelBox);
            this.Controls.Add(this.EdadBox);
            this.Controls.Add(this.ApellidoBox);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.Insert);
            this.Name = "Form1";
            this.Text = "Ingresar Datos";
            ((System.ComponentModel.ISupportInitialize)(this.UserDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox ApellidoBox;
        private System.Windows.Forms.TextBox EdadBox;
        private System.Windows.Forms.TextBox TelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView UserDataView;
        private System.Windows.Forms.Label label5;
    }
}

