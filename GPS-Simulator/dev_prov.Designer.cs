﻿namespace GPS_Simulator
{
    partial class dev_prov
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.start_prov_btn = new System.Windows.Forms.Button();
            this.devinfo = new System.Windows.Forms.Label();
            this.detailed_devinfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // start_prov_btn
            // 
            this.start_prov_btn.Location = new System.Drawing.Point(27, 640);
            this.start_prov_btn.Name = "start_prov_btn";
            this.start_prov_btn.Size = new System.Drawing.Size(456, 43);
            this.start_prov_btn.TabIndex = 0;
            this.start_prov_btn.TabStop = false;
            this.start_prov_btn.Text = "Provision";
            this.start_prov_btn.UseVisualStyleBackColor = true;
            this.start_prov_btn.Click += new System.EventHandler(this.start_prov_btn_Click);
            // 
            // devinfo
            // 
            this.devinfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.devinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.devinfo.Location = new System.Drawing.Point(27, 20);
            this.devinfo.Name = "devinfo";
            this.devinfo.Size = new System.Drawing.Size(456, 276);
            this.devinfo.TabIndex = 0;
            // 
            // detailed_devinfo
            // 
            this.detailed_devinfo.Location = new System.Drawing.Point(27, 79);
            this.detailed_devinfo.Name = "detailed_devinfo";
            this.detailed_devinfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.detailed_devinfo.Size = new System.Drawing.Size(456, 553);
            this.detailed_devinfo.TabIndex = 0;
            this.detailed_devinfo.Text = "";
            // 
            // dev_prov
            // 
            this.ClientSize = new System.Drawing.Size(509, 709);
            this.Controls.Add(this.detailed_devinfo);
            this.Controls.Add(this.devinfo);
            this.Controls.Add(this.start_prov_btn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dev_prov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_prov_btn;
        private System.Windows.Forms.Label devinfo;
        private System.Windows.Forms.RichTextBox detailed_devinfo;
    }
}
