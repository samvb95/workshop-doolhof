namespace DoolhofApp
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
            this.picDoolhof = new System.Windows.Forms.PictureBox();
            this.btnGaOost = new System.Windows.Forms.Button();
            this.btnGaZuid = new System.Windows.Forms.Button();
            this.btnGaWest = new System.Windows.Forms.Button();
            this.btnGaNoord = new System.Windows.Forms.Button();
            this.btnGenereer = new System.Windows.Forms.Button();
            this.btnCreëer = new System.Windows.Forms.Button();
            this.nudAantalRijen = new System.Windows.Forms.NumericUpDown();
            this.nudAantalKolommen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInitialiseer = new System.Windows.Forms.Button();
            this.nudPauze = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartZoektocht = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDoolhof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalRijen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalKolommen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauze)).BeginInit();
            this.SuspendLayout();
            // 
            // picDoolhof
            // 
            this.picDoolhof.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picDoolhof.BackColor = System.Drawing.SystemColors.Control;
            this.picDoolhof.Location = new System.Drawing.Point(329, 6);
            this.picDoolhof.Name = "picDoolhof";
            this.picDoolhof.Size = new System.Drawing.Size(605, 517);
            this.picDoolhof.TabIndex = 15;
            this.picDoolhof.TabStop = false;
            // 
            // btnGaOost
            // 
            this.btnGaOost.Location = new System.Drawing.Point(190, 374);
            this.btnGaOost.Name = "btnGaOost";
            this.btnGaOost.Size = new System.Drawing.Size(52, 36);
            this.btnGaOost.TabIndex = 19;
            this.btnGaOost.Text = "O";
            this.btnGaOost.UseVisualStyleBackColor = true;
            this.btnGaOost.Click += new System.EventHandler(this.btnBeweeg_Click);
            // 
            // btnGaZuid
            // 
            this.btnGaZuid.Location = new System.Drawing.Point(125, 424);
            this.btnGaZuid.Name = "btnGaZuid";
            this.btnGaZuid.Size = new System.Drawing.Size(52, 36);
            this.btnGaZuid.TabIndex = 20;
            this.btnGaZuid.Text = "Z";
            this.btnGaZuid.UseVisualStyleBackColor = true;
            this.btnGaZuid.Click += new System.EventHandler(this.btnBeweeg_Click);
            // 
            // btnGaWest
            // 
            this.btnGaWest.Location = new System.Drawing.Point(60, 374);
            this.btnGaWest.Name = "btnGaWest";
            this.btnGaWest.Size = new System.Drawing.Size(52, 36);
            this.btnGaWest.TabIndex = 21;
            this.btnGaWest.Text = "W";
            this.btnGaWest.UseVisualStyleBackColor = true;
            this.btnGaWest.Click += new System.EventHandler(this.btnBeweeg_Click);
            // 
            // btnGaNoord
            // 
            this.btnGaNoord.Location = new System.Drawing.Point(125, 324);
            this.btnGaNoord.Name = "btnGaNoord";
            this.btnGaNoord.Size = new System.Drawing.Size(52, 36);
            this.btnGaNoord.TabIndex = 18;
            this.btnGaNoord.Text = "N";
            this.btnGaNoord.UseVisualStyleBackColor = true;
            this.btnGaNoord.Click += new System.EventHandler(this.btnBeweeg_Click);
            // 
            // btnGenereer
            // 
            this.btnGenereer.Enabled = false;
            this.btnGenereer.Location = new System.Drawing.Point(15, 221);
            this.btnGenereer.Name = "btnGenereer";
            this.btnGenereer.Size = new System.Drawing.Size(292, 36);
            this.btnGenereer.TabIndex = 16;
            this.btnGenereer.Text = "Genereer";
            this.btnGenereer.UseVisualStyleBackColor = true;
            this.btnGenereer.Click += new System.EventHandler(this.btnGenereer_Click);
            // 
            // btnCreëer
            // 
            this.btnCreëer.Location = new System.Drawing.Point(15, 89);
            this.btnCreëer.Name = "btnCreëer";
            this.btnCreëer.Size = new System.Drawing.Size(292, 36);
            this.btnCreëer.TabIndex = 14;
            this.btnCreëer.Text = "Creëer";
            this.btnCreëer.UseVisualStyleBackColor = true;
            this.btnCreëer.Click += new System.EventHandler(this.btnCreëer_Click);
            // 
            // nudAantalRijen
            // 
            this.nudAantalRijen.Location = new System.Drawing.Point(228, 6);
            this.nudAantalRijen.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAantalRijen.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAantalRijen.Name = "nudAantalRijen";
            this.nudAantalRijen.Size = new System.Drawing.Size(80, 30);
            this.nudAantalRijen.TabIndex = 10;
            this.nudAantalRijen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAantalRijen.ValueChanged += new System.EventHandler(this.nudAantal_ValueChanged);
            // 
            // nudAantalKolommen
            // 
            this.nudAantalKolommen.Location = new System.Drawing.Point(228, 48);
            this.nudAantalKolommen.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAantalKolommen.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAantalKolommen.Name = "nudAantalKolommen";
            this.nudAantalKolommen.Size = new System.Drawing.Size(80, 30);
            this.nudAantalKolommen.TabIndex = 13;
            this.nudAantalKolommen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAantalKolommen.ValueChanged += new System.EventHandler(this.nudAantal_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Aantal kolommen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aantal rijen:";
            // 
            // btnInitialiseer
            // 
            this.btnInitialiseer.Enabled = false;
            this.btnInitialiseer.Location = new System.Drawing.Point(15, 131);
            this.btnInitialiseer.Name = "btnInitialiseer";
            this.btnInitialiseer.Size = new System.Drawing.Size(292, 36);
            this.btnInitialiseer.TabIndex = 23;
            this.btnInitialiseer.Text = "Initialiseer";
            this.btnInitialiseer.UseVisualStyleBackColor = true;
            this.btnInitialiseer.Click += new System.EventHandler(this.btnInitialiseer_Click);
            // 
            // nudPauze
            // 
            this.nudPauze.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPauze.Location = new System.Drawing.Point(227, 178);
            this.nudPauze.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudPauze.Name = "nudPauze";
            this.nudPauze.Size = new System.Drawing.Size(80, 30);
            this.nudPauze.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Pauze:";
            // 
            // btnStartZoektocht
            // 
            this.btnStartZoektocht.Enabled = false;
            this.btnStartZoektocht.Location = new System.Drawing.Point(15, 263);
            this.btnStartZoektocht.Name = "btnStartZoektocht";
            this.btnStartZoektocht.Size = new System.Drawing.Size(292, 36);
            this.btnStartZoektocht.TabIndex = 26;
            this.btnStartZoektocht.Text = "Start zoektocht";
            this.btnStartZoektocht.UseVisualStyleBackColor = true;
            this.btnStartZoektocht.Click += new System.EventHandler(this.btnStartZoektocht_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 535);
            this.Controls.Add(this.btnStartZoektocht);
            this.Controls.Add(this.nudPauze);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInitialiseer);
            this.Controls.Add(this.picDoolhof);
            this.Controls.Add(this.btnGaOost);
            this.Controls.Add(this.btnGaZuid);
            this.Controls.Add(this.btnGaWest);
            this.Controls.Add(this.btnGaNoord);
            this.Controls.Add(this.btnGenereer);
            this.Controls.Add(this.btnCreëer);
            this.Controls.Add(this.nudAantalRijen);
            this.Controls.Add(this.nudAantalKolommen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "WinFormsBegin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picDoolhof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalRijen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalKolommen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picDoolhof;
		private System.Windows.Forms.Button btnGaOost;
		private System.Windows.Forms.Button btnGaZuid;
		private System.Windows.Forms.Button btnGaWest;
		private System.Windows.Forms.Button btnGaNoord;
		private System.Windows.Forms.Button btnGenereer;
		private System.Windows.Forms.Button btnCreëer;
		private System.Windows.Forms.NumericUpDown nudAantalRijen;
		private System.Windows.Forms.NumericUpDown nudAantalKolommen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnInitialiseer;
		private System.Windows.Forms.NumericUpDown nudPauze;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnStartZoektocht;
	}
}

