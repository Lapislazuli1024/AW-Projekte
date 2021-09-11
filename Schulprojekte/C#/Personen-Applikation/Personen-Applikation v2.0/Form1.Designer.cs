namespace Personen_Applikation_v2._0
{
   partial class Personen_Applikation
   {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personen_Applikation));
			this.btn_OnFirst = new System.Windows.Forms.Button();
			this.btn_Previous = new System.Windows.Forms.Button();
			this.btn_OnNext = new System.Windows.Forms.Button();
			this.btn_OnLast = new System.Windows.Forms.Button();
			this.tbx_Anzahl = new System.Windows.Forms.TextBox();
			this.panel_Top = new System.Windows.Forms.Panel();
			this.btn_Minus = new System.Windows.Forms.Button();
			this.btn_Plus = new System.Windows.Forms.Button();
			this.panel_Bot = new System.Windows.Forms.Panel();
			this.btn_SaveChanges = new System.Windows.Forms.Button();
			this.btn_DiscardChanges = new System.Windows.Forms.Button();
			this.panel_Mid = new System.Windows.Forms.Panel();
			this.lbl_Pensum = new System.Windows.Forms.Label();
			this.tbx_Pensum = new System.Windows.Forms.TextBox();
			this.lbl_Salaer = new System.Windows.Forms.Label();
			this.tbx_Salaer = new System.Windows.Forms.TextBox();
			this.lbl_EintrittsJahr = new System.Windows.Forms.Label();
			this.tbx_Eintrittsjahr = new System.Windows.Forms.TextBox();
			this.lbl_Ort = new System.Windows.Forms.Label();
			this.tbx_Ort = new System.Windows.Forms.TextBox();
			this.tbx_Plz = new System.Windows.Forms.TextBox();
			this.lbl_Plz = new System.Windows.Forms.Label();
			this.tbx_Vornamen = new System.Windows.Forms.TextBox();
			this.tbx_Namen = new System.Windows.Forms.TextBox();
			this.tbx_PNr = new System.Windows.Forms.TextBox();
			this.lbl_Vorname = new System.Windows.Forms.Label();
			this.lbl_Namen = new System.Windows.Forms.Label();
			this.lbl_PNr = new System.Windows.Forms.Label();
			this.panel_Top.SuspendLayout();
			this.panel_Bot.SuspendLayout();
			this.panel_Mid.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_OnFirst
			// 
			this.btn_OnFirst.Location = new System.Drawing.Point(100, 26);
			this.btn_OnFirst.Margin = new System.Windows.Forms.Padding(4);
			this.btn_OnFirst.Name = "btn_OnFirst";
			this.btn_OnFirst.Size = new System.Drawing.Size(53, 37);
			this.btn_OnFirst.TabIndex = 1;
			this.btn_OnFirst.Text = "|<--";
			this.btn_OnFirst.UseVisualStyleBackColor = true;
			this.btn_OnFirst.Click += new System.EventHandler(this.btn_OnFirst_Click);
			// 
			// btn_Previous
			// 
			this.btn_Previous.Location = new System.Drawing.Point(162, 26);
			this.btn_Previous.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Previous.Name = "btn_Previous";
			this.btn_Previous.Size = new System.Drawing.Size(53, 37);
			this.btn_Previous.TabIndex = 2;
			this.btn_Previous.Text = "<--";
			this.btn_Previous.UseVisualStyleBackColor = true;
			this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
			// 
			// btn_OnNext
			// 
			this.btn_OnNext.Location = new System.Drawing.Point(299, 26);
			this.btn_OnNext.Margin = new System.Windows.Forms.Padding(4);
			this.btn_OnNext.Name = "btn_OnNext";
			this.btn_OnNext.Size = new System.Drawing.Size(53, 37);
			this.btn_OnNext.TabIndex = 3;
			this.btn_OnNext.Text = "-->";
			this.btn_OnNext.UseVisualStyleBackColor = true;
			this.btn_OnNext.Click += new System.EventHandler(this.btn_OnNext_Click);
			// 
			// btn_OnLast
			// 
			this.btn_OnLast.Location = new System.Drawing.Point(360, 26);
			this.btn_OnLast.Margin = new System.Windows.Forms.Padding(4);
			this.btn_OnLast.Name = "btn_OnLast";
			this.btn_OnLast.Size = new System.Drawing.Size(53, 37);
			this.btn_OnLast.TabIndex = 4;
			this.btn_OnLast.Text = "-->|";
			this.btn_OnLast.UseVisualStyleBackColor = true;
			this.btn_OnLast.Click += new System.EventHandler(this.btn_OnLast_Click);
			// 
			// tbx_Anzahl
			// 
			this.tbx_Anzahl.Location = new System.Drawing.Point(223, 33);
			this.tbx_Anzahl.Margin = new System.Windows.Forms.Padding(4);
			this.tbx_Anzahl.Name = "tbx_Anzahl";
			this.tbx_Anzahl.ReadOnly = true;
			this.tbx_Anzahl.Size = new System.Drawing.Size(59, 22);
			this.tbx_Anzahl.TabIndex = 5;
			// 
			// panel_Top
			// 
			this.panel_Top.Controls.Add(this.btn_Minus);
			this.panel_Top.Controls.Add(this.btn_Plus);
			this.panel_Top.Controls.Add(this.btn_OnNext);
			this.panel_Top.Controls.Add(this.tbx_Anzahl);
			this.panel_Top.Controls.Add(this.btn_OnFirst);
			this.panel_Top.Controls.Add(this.btn_OnLast);
			this.panel_Top.Controls.Add(this.btn_Previous);
			this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_Top.Location = new System.Drawing.Point(0, 0);
			this.panel_Top.Margin = new System.Windows.Forms.Padding(4);
			this.panel_Top.Name = "panel_Top";
			this.panel_Top.Size = new System.Drawing.Size(820, 84);
			this.panel_Top.TabIndex = 6;
			// 
			// btn_Minus
			// 
			this.btn_Minus.Location = new System.Drawing.Point(647, 26);
			this.btn_Minus.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Minus.Name = "btn_Minus";
			this.btn_Minus.Size = new System.Drawing.Size(53, 37);
			this.btn_Minus.TabIndex = 7;
			this.btn_Minus.Text = "-";
			this.btn_Minus.UseVisualStyleBackColor = true;
			this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
			// 
			// btn_Plus
			// 
			this.btn_Plus.Location = new System.Drawing.Point(586, 26);
			this.btn_Plus.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Plus.Name = "btn_Plus";
			this.btn_Plus.Size = new System.Drawing.Size(53, 37);
			this.btn_Plus.TabIndex = 6;
			this.btn_Plus.Text = "+";
			this.btn_Plus.UseVisualStyleBackColor = true;
			this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
			// 
			// panel_Bot
			// 
			this.panel_Bot.Controls.Add(this.btn_SaveChanges);
			this.panel_Bot.Controls.Add(this.btn_DiscardChanges);
			this.panel_Bot.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_Bot.Location = new System.Drawing.Point(0, 413);
			this.panel_Bot.Margin = new System.Windows.Forms.Padding(4);
			this.panel_Bot.Name = "panel_Bot";
			this.panel_Bot.Size = new System.Drawing.Size(820, 50);
			this.panel_Bot.TabIndex = 7;
			// 
			// btn_SaveChanges
			// 
			this.btn_SaveChanges.Location = new System.Drawing.Point(435, 9);
			this.btn_SaveChanges.Margin = new System.Windows.Forms.Padding(4);
			this.btn_SaveChanges.Name = "btn_SaveChanges";
			this.btn_SaveChanges.Size = new System.Drawing.Size(265, 28);
			this.btn_SaveChanges.TabIndex = 2;
			this.btn_SaveChanges.Text = "Änderungen speichern";
			this.btn_SaveChanges.UseVisualStyleBackColor = true;
			this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
			// 
			// btn_DiscardChanges
			// 
			this.btn_DiscardChanges.Location = new System.Drawing.Point(87, 9);
			this.btn_DiscardChanges.Margin = new System.Windows.Forms.Padding(4);
			this.btn_DiscardChanges.Name = "btn_DiscardChanges";
			this.btn_DiscardChanges.Size = new System.Drawing.Size(265, 28);
			this.btn_DiscardChanges.TabIndex = 1;
			this.btn_DiscardChanges.Text = "Änderungen verwerfen";
			this.btn_DiscardChanges.UseVisualStyleBackColor = true;
			this.btn_DiscardChanges.Click += new System.EventHandler(this.btn_DiscardChanges_Click);
			// 
			// panel_Mid
			// 
			this.panel_Mid.Controls.Add(this.lbl_Pensum);
			this.panel_Mid.Controls.Add(this.tbx_Pensum);
			this.panel_Mid.Controls.Add(this.lbl_Salaer);
			this.panel_Mid.Controls.Add(this.tbx_Salaer);
			this.panel_Mid.Controls.Add(this.lbl_EintrittsJahr);
			this.panel_Mid.Controls.Add(this.tbx_Eintrittsjahr);
			this.panel_Mid.Controls.Add(this.lbl_Ort);
			this.panel_Mid.Controls.Add(this.tbx_Ort);
			this.panel_Mid.Controls.Add(this.tbx_Plz);
			this.panel_Mid.Controls.Add(this.lbl_Plz);
			this.panel_Mid.Controls.Add(this.tbx_Vornamen);
			this.panel_Mid.Controls.Add(this.tbx_Namen);
			this.panel_Mid.Controls.Add(this.tbx_PNr);
			this.panel_Mid.Controls.Add(this.lbl_Vorname);
			this.panel_Mid.Controls.Add(this.lbl_Namen);
			this.panel_Mid.Controls.Add(this.lbl_PNr);
			this.panel_Mid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Mid.Location = new System.Drawing.Point(0, 84);
			this.panel_Mid.Margin = new System.Windows.Forms.Padding(4);
			this.panel_Mid.Name = "panel_Mid";
			this.panel_Mid.Size = new System.Drawing.Size(820, 329);
			this.panel_Mid.TabIndex = 8;
			// 
			// lbl_Pensum
			// 
			this.lbl_Pensum.AutoSize = true;
			this.lbl_Pensum.Location = new System.Drawing.Point(55, 253);
			this.lbl_Pensum.Name = "lbl_Pensum";
			this.lbl_Pensum.Size = new System.Drawing.Size(59, 17);
			this.lbl_Pensum.TabIndex = 15;
			this.lbl_Pensum.Text = "Pensum";
			// 
			// tbx_Pensum
			// 
			this.tbx_Pensum.Location = new System.Drawing.Point(162, 250);
			this.tbx_Pensum.Name = "tbx_Pensum";
			this.tbx_Pensum.Size = new System.Drawing.Size(132, 22);
			this.tbx_Pensum.TabIndex = 14;
			// 
			// lbl_Salaer
			// 
			this.lbl_Salaer.AutoSize = true;
			this.lbl_Salaer.Location = new System.Drawing.Point(55, 224);
			this.lbl_Salaer.Name = "lbl_Salaer";
			this.lbl_Salaer.Size = new System.Drawing.Size(41, 17);
			this.lbl_Salaer.TabIndex = 13;
			this.lbl_Salaer.Text = "Salär";
			// 
			// tbx_Salaer
			// 
			this.tbx_Salaer.Location = new System.Drawing.Point(162, 221);
			this.tbx_Salaer.Name = "tbx_Salaer";
			this.tbx_Salaer.Size = new System.Drawing.Size(132, 22);
			this.tbx_Salaer.TabIndex = 12;
			// 
			// lbl_EintrittsJahr
			// 
			this.lbl_EintrittsJahr.AutoSize = true;
			this.lbl_EintrittsJahr.Location = new System.Drawing.Point(55, 195);
			this.lbl_EintrittsJahr.Name = "lbl_EintrittsJahr";
			this.lbl_EintrittsJahr.Size = new System.Drawing.Size(79, 17);
			this.lbl_EintrittsJahr.TabIndex = 11;
			this.lbl_EintrittsJahr.Text = "Eintrittsjahr";
			// 
			// tbx_Eintrittsjahr
			// 
			this.tbx_Eintrittsjahr.Location = new System.Drawing.Point(162, 192);
			this.tbx_Eintrittsjahr.Name = "tbx_Eintrittsjahr";
			this.tbx_Eintrittsjahr.Size = new System.Drawing.Size(132, 22);
			this.tbx_Eintrittsjahr.TabIndex = 10;
			// 
			// lbl_Ort
			// 
			this.lbl_Ort.AutoSize = true;
			this.lbl_Ort.Location = new System.Drawing.Point(55, 163);
			this.lbl_Ort.Name = "lbl_Ort";
			this.lbl_Ort.Size = new System.Drawing.Size(28, 17);
			this.lbl_Ort.TabIndex = 9;
			this.lbl_Ort.Text = "Ort";
			// 
			// tbx_Ort
			// 
			this.tbx_Ort.Location = new System.Drawing.Point(162, 163);
			this.tbx_Ort.Name = "tbx_Ort";
			this.tbx_Ort.Size = new System.Drawing.Size(132, 22);
			this.tbx_Ort.TabIndex = 8;
			// 
			// tbx_Plz
			// 
			this.tbx_Plz.Location = new System.Drawing.Point(162, 134);
			this.tbx_Plz.Name = "tbx_Plz";
			this.tbx_Plz.Size = new System.Drawing.Size(132, 22);
			this.tbx_Plz.TabIndex = 7;
			// 
			// lbl_Plz
			// 
			this.lbl_Plz.AutoSize = true;
			this.lbl_Plz.Location = new System.Drawing.Point(55, 134);
			this.lbl_Plz.Name = "lbl_Plz";
			this.lbl_Plz.Size = new System.Drawing.Size(27, 17);
			this.lbl_Plz.TabIndex = 6;
			this.lbl_Plz.Text = "Plz";
			// 
			// tbx_Vornamen
			// 
			this.tbx_Vornamen.Location = new System.Drawing.Point(162, 105);
			this.tbx_Vornamen.Margin = new System.Windows.Forms.Padding(4);
			this.tbx_Vornamen.Name = "tbx_Vornamen";
			this.tbx_Vornamen.Size = new System.Drawing.Size(132, 22);
			this.tbx_Vornamen.TabIndex = 5;
			// 
			// tbx_Namen
			// 
			this.tbx_Namen.Location = new System.Drawing.Point(162, 74);
			this.tbx_Namen.Margin = new System.Windows.Forms.Padding(4);
			this.tbx_Namen.Name = "tbx_Namen";
			this.tbx_Namen.Size = new System.Drawing.Size(132, 22);
			this.tbx_Namen.TabIndex = 4;
			// 
			// tbx_PNr
			// 
			this.tbx_PNr.Location = new System.Drawing.Point(162, 45);
			this.tbx_PNr.Margin = new System.Windows.Forms.Padding(4);
			this.tbx_PNr.Name = "tbx_PNr";
			this.tbx_PNr.ReadOnly = true;
			this.tbx_PNr.Size = new System.Drawing.Size(132, 22);
			this.tbx_PNr.TabIndex = 3;
			// 
			// lbl_Vorname
			// 
			this.lbl_Vorname.AutoSize = true;
			this.lbl_Vorname.Location = new System.Drawing.Point(55, 106);
			this.lbl_Vorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Vorname.Name = "lbl_Vorname";
			this.lbl_Vorname.Size = new System.Drawing.Size(69, 17);
			this.lbl_Vorname.TabIndex = 2;
			this.lbl_Vorname.Text = "Vorname:";
			// 
			// lbl_Namen
			// 
			this.lbl_Namen.AutoSize = true;
			this.lbl_Namen.Location = new System.Drawing.Point(55, 75);
			this.lbl_Namen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Namen.Name = "lbl_Namen";
			this.lbl_Namen.Size = new System.Drawing.Size(57, 17);
			this.lbl_Namen.TabIndex = 1;
			this.lbl_Namen.Text = "Namen:";
			// 
			// lbl_PNr
			// 
			this.lbl_PNr.AutoSize = true;
			this.lbl_PNr.Location = new System.Drawing.Point(55, 46);
			this.lbl_PNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_PNr.Name = "lbl_PNr";
			this.lbl_PNr.Size = new System.Drawing.Size(36, 17);
			this.lbl_PNr.TabIndex = 0;
			this.lbl_PNr.Text = "PNr:";
			// 
			// Personen_Applikation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 463);
			this.Controls.Add(this.panel_Mid);
			this.Controls.Add(this.panel_Bot);
			this.Controls.Add(this.panel_Top);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Personen_Applikation";
			this.Text = "Personenverwaltung v2.0";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Personen_Applikation_FormClosed);
			this.Load += new System.EventHandler(this.Personen_Applikation_Load);
			this.panel_Top.ResumeLayout(false);
			this.panel_Top.PerformLayout();
			this.panel_Bot.ResumeLayout(false);
			this.panel_Mid.ResumeLayout(false);
			this.panel_Mid.PerformLayout();
			this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btn_OnFirst;
      private System.Windows.Forms.Button btn_Previous;
      private System.Windows.Forms.Button btn_OnNext;
      private System.Windows.Forms.Button btn_OnLast;
      private System.Windows.Forms.TextBox tbx_Anzahl;
      private System.Windows.Forms.Panel panel_Top;
      private System.Windows.Forms.Button btn_Minus;
      private System.Windows.Forms.Button btn_Plus;
      private System.Windows.Forms.Panel panel_Bot;
      private System.Windows.Forms.Panel panel_Mid;
      private System.Windows.Forms.Label lbl_Namen;
      private System.Windows.Forms.Label lbl_PNr;
      private System.Windows.Forms.TextBox tbx_Vornamen;
      private System.Windows.Forms.TextBox tbx_Namen;
      private System.Windows.Forms.TextBox tbx_PNr;
      private System.Windows.Forms.Label lbl_Vorname;
      private System.Windows.Forms.Button btn_DiscardChanges;
        private System.Windows.Forms.Button btn_SaveChanges;
        private System.Windows.Forms.TextBox tbx_Plz;
        private System.Windows.Forms.Label lbl_Plz;
        private System.Windows.Forms.Label lbl_EintrittsJahr;
        private System.Windows.Forms.TextBox tbx_Eintrittsjahr;
        private System.Windows.Forms.Label lbl_Ort;
        private System.Windows.Forms.TextBox tbx_Ort;
        private System.Windows.Forms.Label lbl_Pensum;
        private System.Windows.Forms.TextBox tbx_Pensum;
        private System.Windows.Forms.Label lbl_Salaer;
        private System.Windows.Forms.TextBox tbx_Salaer;
    }
}

