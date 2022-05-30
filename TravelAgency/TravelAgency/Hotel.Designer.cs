
namespace TravelAgency
{
    partial class Hotel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nHotel = new System.Windows.Forms.TextBox();
            this.NoD = new System.Windows.Forms.TextBox();
            this.IDHotel = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.TypeRoom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 399);
            this.dataGridView1.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Name Hotel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Number of Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Type room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID Hotel";
            // 
            // nHotel
            // 
            this.nHotel.Location = new System.Drawing.Point(132, 201);
            this.nHotel.Name = "nHotel";
            this.nHotel.Size = new System.Drawing.Size(131, 20);
            this.nHotel.TabIndex = 33;
            // 
            // NoD
            // 
            this.NoD.Location = new System.Drawing.Point(132, 152);
            this.NoD.Name = "NoD";
            this.NoD.Size = new System.Drawing.Size(131, 20);
            this.NoD.TabIndex = 32;
            // 
            // IDHotel
            // 
            this.IDHotel.Location = new System.Drawing.Point(132, 26);
            this.IDHotel.Name = "IDHotel";
            this.IDHotel.Size = new System.Drawing.Size(131, 20);
            this.IDHotel.TabIndex = 29;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(246, 266);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(72, 22);
            this.Select.TabIndex = 28;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(168, 266);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(72, 22);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(90, 266);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(72, 22);
            this.Update.TabIndex = 26;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(12, 266);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(72, 22);
            this.Insert.TabIndex = 25;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // TypeRoom
            // 
            this.TypeRoom.FormattingEnabled = true;
            this.TypeRoom.Location = new System.Drawing.Point(132, 62);
            this.TypeRoom.Name = "TypeRoom";
            this.TypeRoom.Size = new System.Drawing.Size(121, 21);
            this.TypeRoom.TabIndex = 48;
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypeRoom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nHotel);
            this.Controls.Add(this.NoD);
            this.Controls.Add(this.IDHotel);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Hotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nHotel;
        private System.Windows.Forms.TextBox NoD;
        private System.Windows.Forms.TextBox IDHotel;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.ComboBox TypeRoom;
    }
}