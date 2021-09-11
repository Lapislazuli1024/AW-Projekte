namespace Personen_Applikation_v2._0
{
    partial class FormNeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNeu));
            this.tbx_Namen = new System.Windows.Forms.TextBox();
            this.tbx_Vornamen = new System.Windows.Forms.TextBox();
            this.lbl_Namen = new System.Windows.Forms.Label();
            this.lbl_Vornamen = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tbn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_Namen
            // 
            resources.ApplyResources(this.tbx_Namen, "tbx_Namen");
            this.tbx_Namen.Name = "tbx_Namen";
            // 
            // tbx_Vornamen
            // 
            resources.ApplyResources(this.tbx_Vornamen, "tbx_Vornamen");
            this.tbx_Vornamen.Name = "tbx_Vornamen";
            // 
            // lbl_Namen
            // 
            resources.ApplyResources(this.lbl_Namen, "lbl_Namen");
            this.lbl_Namen.Name = "lbl_Namen";
            // 
            // lbl_Vornamen
            // 
            resources.ApplyResources(this.lbl_Vornamen, "lbl_Vornamen");
            this.lbl_Vornamen.Name = "lbl_Vornamen";
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tbn_Save
            // 
            resources.ApplyResources(this.tbn_Save, "tbn_Save");
            this.tbn_Save.Name = "tbn_Save";
            this.tbn_Save.UseVisualStyleBackColor = true;
            this.tbn_Save.Click += new System.EventHandler(this.tbn_Save_Click);
            // 
            // FormNeu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Vornamen);
            this.Controls.Add(this.lbl_Namen);
            this.Controls.Add(this.tbx_Vornamen);
            this.Controls.Add(this.tbx_Namen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNeu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Namen;
        private System.Windows.Forms.TextBox tbx_Vornamen;
        private System.Windows.Forms.Label lbl_Namen;
        private System.Windows.Forms.Label lbl_Vornamen;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button tbn_Save;
    }
}