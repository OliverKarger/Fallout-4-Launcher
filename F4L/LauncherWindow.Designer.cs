namespace OliverKarger.F4L
{
    partial class LauncherWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_f4 = new System.Windows.Forms.Label();
            this.l_start = new System.Windows.Forms.Label();
            this.l_game_settings = new System.Windows.Forms.Label();
            this.l_launcher_settings = new System.Windows.Forms.Label();
            this.l_exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_f4
            // 
            this.l_f4.AutoSize = true;
            this.l_f4.BackColor = System.Drawing.Color.Transparent;
            this.l_f4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_f4.Location = new System.Drawing.Point(55, 37);
            this.l_f4.Name = "l_f4";
            this.l_f4.Size = new System.Drawing.Size(207, 65);
            this.l_f4.TabIndex = 0;
            this.l_f4.Text = "Fallout 4";
            // 
            // l_start
            // 
            this.l_start.AutoSize = true;
            this.l_start.BackColor = System.Drawing.Color.Transparent;
            this.l_start.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_start.Location = new System.Drawing.Point(55, 128);
            this.l_start.Name = "l_start";
            this.l_start.Size = new System.Drawing.Size(76, 40);
            this.l_start.TabIndex = 1;
            this.l_start.Text = "Start";
            // 
            // l_game_settings
            // 
            this.l_game_settings.AutoSize = true;
            this.l_game_settings.BackColor = System.Drawing.Color.Transparent;
            this.l_game_settings.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_game_settings.Location = new System.Drawing.Point(55, 168);
            this.l_game_settings.Name = "l_game_settings";
            this.l_game_settings.Size = new System.Drawing.Size(202, 40);
            this.l_game_settings.TabIndex = 2;
            this.l_game_settings.Text = "Game Settings";
            // 
            // l_launcher_settings
            // 
            this.l_launcher_settings.AutoSize = true;
            this.l_launcher_settings.BackColor = System.Drawing.Color.Transparent;
            this.l_launcher_settings.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_launcher_settings.Location = new System.Drawing.Point(55, 208);
            this.l_launcher_settings.Name = "l_launcher_settings";
            this.l_launcher_settings.Size = new System.Drawing.Size(242, 40);
            this.l_launcher_settings.TabIndex = 3;
            this.l_launcher_settings.Text = "Launcher Settings";
            // 
            // l_exit
            // 
            this.l_exit.AutoSize = true;
            this.l_exit.BackColor = System.Drawing.Color.Transparent;
            this.l_exit.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_exit.Location = new System.Drawing.Point(55, 248);
            this.l_exit.Name = "l_exit";
            this.l_exit.Size = new System.Drawing.Size(62, 40);
            this.l_exit.TabIndex = 4;
            this.l_exit.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version 1.0.0";
            // 
            // LauncherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_exit);
            this.Controls.Add(this.l_launcher_settings);
            this.Controls.Add(this.l_game_settings);
            this.Controls.Add(this.l_start);
            this.Controls.Add(this.l_f4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LauncherWindow";
            this.Text = "Fallout 4 Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_f4;
        private Label l_start;
        private Label l_game_settings;
        private Label l_launcher_settings;
        private Label l_exit;
        private Label label1;
    }
}