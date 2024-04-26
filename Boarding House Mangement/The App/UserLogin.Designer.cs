namespace The_App
{
    partial class UserLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialButtonLogin = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRadioButtonLandlord = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTextBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialRadioButtonTenant = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonCancel = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxUsername = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // materialButtonLogin
            // 
            this.materialButtonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonLogin.Depth = 0;
            this.materialButtonLogin.HighEmphasis = true;
            this.materialButtonLogin.Icon = null;
            this.materialButtonLogin.Location = new System.Drawing.Point(264, 454);
            this.materialButtonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonLogin.MinimumSize = new System.Drawing.Size(180, 20);
            this.materialButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonLogin.Name = "materialButtonLogin";
            this.materialButtonLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonLogin.Size = new System.Drawing.Size(180, 36);
            this.materialButtonLogin.TabIndex = 5;
            this.materialButtonLogin.Text = "Login";
            this.materialButtonLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonLogin.UseAccentColor = false;
            this.materialButtonLogin.UseVisualStyleBackColor = true;
            this.materialButtonLogin.Click += new System.EventHandler(this.materialButtonLogin_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel3.Location = new System.Drawing.Point(186, 43);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(140, 58);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "LOGIN";
            // 
            // materialRadioButtonLandlord
            // 
            this.materialRadioButtonLandlord.AutoSize = true;
            this.materialRadioButtonLandlord.BackColor = System.Drawing.SystemColors.Window;
            this.materialRadioButtonLandlord.Depth = 0;
            this.materialRadioButtonLandlord.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialRadioButtonLandlord.Location = new System.Drawing.Point(46, 168);
            this.materialRadioButtonLandlord.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButtonLandlord.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButtonLandlord.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButtonLandlord.Name = "materialRadioButtonLandlord";
            this.materialRadioButtonLandlord.Ripple = true;
            this.materialRadioButtonLandlord.Size = new System.Drawing.Size(98, 37);
            this.materialRadioButtonLandlord.TabIndex = 6;
            this.materialRadioButtonLandlord.TabStop = true;
            this.materialRadioButtonLandlord.Text = "Landlord";
            this.materialRadioButtonLandlord.UseVisualStyleBackColor = false;
            this.materialRadioButtonLandlord.CheckedChanged += new System.EventHandler(this.materialRadioButtonLandlord_CheckedChanged);
            // 
            // materialTextBoxPassword
            // 
            this.materialTextBoxPassword.AnimateReadOnly = false;
            this.materialTextBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxPassword.Depth = 0;
            this.materialTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxPassword.HideSelection = true;
            this.materialTextBoxPassword.LeadingIcon = null;
            this.materialTextBoxPassword.Location = new System.Drawing.Point(46, 366);
            this.materialTextBoxPassword.MaxLength = 32767;
            this.materialTextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPassword.Name = "materialTextBoxPassword";
            this.materialTextBoxPassword.PasswordChar = '\0';
            this.materialTextBoxPassword.PrefixSuffixText = null;
            this.materialTextBoxPassword.ReadOnly = false;
            this.materialTextBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxPassword.SelectedText = "";
            this.materialTextBoxPassword.SelectionLength = 0;
            this.materialTextBoxPassword.SelectionStart = 0;
            this.materialTextBoxPassword.ShortcutsEnabled = true;
            this.materialTextBoxPassword.Size = new System.Drawing.Size(398, 48);
            this.materialTextBoxPassword.TabIndex = 3;
            this.materialTextBoxPassword.TabStop = false;
            this.materialTextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxPassword.TrailingIcon = null;
            this.materialTextBoxPassword.UseSystemPasswordChar = false;
            // 
            // materialRadioButtonTenant
            // 
            this.materialRadioButtonTenant.AutoSize = true;
            this.materialRadioButtonTenant.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialRadioButtonTenant.Depth = 0;
            this.materialRadioButtonTenant.Location = new System.Drawing.Point(196, 168);
            this.materialRadioButtonTenant.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButtonTenant.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButtonTenant.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButtonTenant.Name = "materialRadioButtonTenant";
            this.materialRadioButtonTenant.Ripple = true;
            this.materialRadioButtonTenant.Size = new System.Drawing.Size(85, 37);
            this.materialRadioButtonTenant.TabIndex = 7;
            this.materialRadioButtonTenant.TabStop = true;
            this.materialRadioButtonTenant.Text = "Tenant";
            this.materialRadioButtonTenant.UseVisualStyleBackColor = false;
            this.materialRadioButtonTenant.CheckedChanged += new System.EventHandler(this.materialRadioButtonTenant_CheckedChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(42, 339);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Password";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(42, 136);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 24);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Role";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(42, 233);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "User Name";
            // 
            // materialButtonCancel
            // 
            this.materialButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCancel.Depth = 0;
            this.materialButtonCancel.HighEmphasis = true;
            this.materialButtonCancel.Icon = null;
            this.materialButtonCancel.Location = new System.Drawing.Point(46, 454);
            this.materialButtonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCancel.MinimumSize = new System.Drawing.Size(180, 20);
            this.materialButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCancel.Name = "materialButtonCancel";
            this.materialButtonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCancel.Size = new System.Drawing.Size(180, 36);
            this.materialButtonCancel.TabIndex = 9;
            this.materialButtonCancel.Text = "Cancel";
            this.materialButtonCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCancel.UseAccentColor = false;
            this.materialButtonCancel.UseVisualStyleBackColor = true;
            this.materialButtonCancel.Click += new System.EventHandler(this.materialButtonCancel_Click);
            // 
            // materialTextBoxUsername
            // 
            this.materialTextBoxUsername.AnimateReadOnly = false;
            this.materialTextBoxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxUsername.Depth = 0;
            this.materialTextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxUsername.HideSelection = true;
            this.materialTextBoxUsername.LeadingIcon = null;
            this.materialTextBoxUsername.Location = new System.Drawing.Point(46, 260);
            this.materialTextBoxUsername.MaxLength = 32767;
            this.materialTextBoxUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxUsername.Name = "materialTextBoxUsername";
            this.materialTextBoxUsername.PasswordChar = '\0';
            this.materialTextBoxUsername.PrefixSuffixText = null;
            this.materialTextBoxUsername.ReadOnly = false;
            this.materialTextBoxUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxUsername.SelectedText = "";
            this.materialTextBoxUsername.SelectionLength = 0;
            this.materialTextBoxUsername.SelectionStart = 0;
            this.materialTextBoxUsername.ShortcutsEnabled = true;
            this.materialTextBoxUsername.Size = new System.Drawing.Size(398, 48);
            this.materialTextBoxUsername.TabIndex = 2;
            this.materialTextBoxUsername.TabStop = false;
            this.materialTextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxUsername.TrailingIcon = null;
            this.materialTextBoxUsername.UseSystemPasswordChar = false;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTextBoxUsername);
            this.Controls.Add(this.materialButtonCancel);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButtonLogin);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialRadioButtonLandlord);
            this.Controls.Add(this.materialRadioButtonTenant);
            this.Controls.Add(this.materialTextBoxPassword);
            this.Name = "UserLogin";
            this.Size = new System.Drawing.Size(489, 559);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonLandlord;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxPassword;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonTenant;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButtonCancel;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxUsername;
    }
}
