
namespace ReallyBasicExampleProtector
{
    partial class ReallyBasicExampleProtector
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
            this.FileToProtectHATB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BrowserFileHABTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.ProtectFileHABTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.AntiDumpHACB = new MaterialSkin.Controls.MaterialCheckBox();
            this.ROTStringsHACB = new MaterialSkin.Controls.MaterialCheckBox();
            this.ProxyStringsHACB = new MaterialSkin.Controls.MaterialCheckBox();
            this.ProxyINTHACB = new MaterialSkin.Controls.MaterialCheckBox();
            this.CalliINTHACB = new MaterialSkin.Controls.MaterialCheckBox();
            this.AntiDebugHACB = new MaterialSkin.Controls.MaterialCheckBox();
            this.AntiTamperHACB = new MaterialSkin.Controls.MaterialCheckBox();
            this.PackerHACB = new MaterialSkin.Controls.MaterialCheckBox();
            this.HideMethodsHACB = new MaterialSkin.Controls.MaterialCheckBox();
            this.RenamerHACB = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // FileToProtectHATB
            // 
            this.FileToProtectHATB.Depth = 0;
            this.FileToProtectHATB.Hint = "";
            this.FileToProtectHATB.Location = new System.Drawing.Point(12, 86);
            this.FileToProtectHATB.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileToProtectHATB.Name = "FileToProtectHATB";
            this.FileToProtectHATB.PasswordChar = '\0';
            this.FileToProtectHATB.SelectedText = "";
            this.FileToProtectHATB.SelectionLength = 0;
            this.FileToProtectHATB.SelectionStart = 0;
            this.FileToProtectHATB.Size = new System.Drawing.Size(671, 23);
            this.FileToProtectHATB.TabIndex = 0;
            this.FileToProtectHATB.UseSystemPasswordChar = false;
            // 
            // BrowserFileHABTN
            // 
            this.BrowserFileHABTN.AutoSize = true;
            this.BrowserFileHABTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowserFileHABTN.Depth = 0;
            this.BrowserFileHABTN.Location = new System.Drawing.Point(690, 73);
            this.BrowserFileHABTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BrowserFileHABTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowserFileHABTN.Name = "BrowserFileHABTN";
            this.BrowserFileHABTN.Primary = false;
            this.BrowserFileHABTN.Size = new System.Drawing.Size(97, 36);
            this.BrowserFileHABTN.TabIndex = 1;
            this.BrowserFileHABTN.Text = "Browse File";
            this.BrowserFileHABTN.UseVisualStyleBackColor = true;
            this.BrowserFileHABTN.Click += new System.EventHandler(this.BrowserFileHABTN_Click);
            // 
            // ProtectFileHABTN
            // 
            this.ProtectFileHABTN.AutoSize = true;
            this.ProtectFileHABTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProtectFileHABTN.Depth = 0;
            this.ProtectFileHABTN.Location = new System.Drawing.Point(357, 399);
            this.ProtectFileHABTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ProtectFileHABTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProtectFileHABTN.Name = "ProtectFileHABTN";
            this.ProtectFileHABTN.Primary = false;
            this.ProtectFileHABTN.Size = new System.Drawing.Size(72, 36);
            this.ProtectFileHABTN.TabIndex = 2;
            this.ProtectFileHABTN.Text = "Protect";
            this.ProtectFileHABTN.UseVisualStyleBackColor = true;
            this.ProtectFileHABTN.Click += new System.EventHandler(this.ProtectFileHABTN_Click);
            // 
            // AntiDumpHACB
            // 
            this.AntiDumpHACB.AutoSize = true;
            this.AntiDumpHACB.Depth = 0;
            this.AntiDumpHACB.Font = new System.Drawing.Font("Roboto", 10F);
            this.AntiDumpHACB.Location = new System.Drawing.Point(13, 116);
            this.AntiDumpHACB.Margin = new System.Windows.Forms.Padding(0);
            this.AntiDumpHACB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AntiDumpHACB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AntiDumpHACB.Name = "AntiDumpHACB";
            this.AntiDumpHACB.Ripple = true;
            this.AntiDumpHACB.Size = new System.Drawing.Size(96, 30);
            this.AntiDumpHACB.TabIndex = 3;
            this.AntiDumpHACB.Text = "Anti-Dump";
            this.AntiDumpHACB.UseVisualStyleBackColor = true;
            // 
            // ROTStringsHACB
            // 
            this.ROTStringsHACB.AutoSize = true;
            this.ROTStringsHACB.Depth = 0;
            this.ROTStringsHACB.Font = new System.Drawing.Font("Roboto", 10F);
            this.ROTStringsHACB.Location = new System.Drawing.Point(80, 176);
            this.ROTStringsHACB.Margin = new System.Windows.Forms.Padding(0);
            this.ROTStringsHACB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ROTStringsHACB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ROTStringsHACB.Name = "ROTStringsHACB";
            this.ROTStringsHACB.Ripple = true;
            this.ROTStringsHACB.Size = new System.Drawing.Size(105, 30);
            this.ROTStringsHACB.TabIndex = 4;
            this.ROTStringsHACB.Text = "ROT-Strings";
            this.ROTStringsHACB.UseVisualStyleBackColor = true;
            // 
            // ProxyStringsHACB
            // 
            this.ProxyStringsHACB.AutoSize = true;
            this.ProxyStringsHACB.Depth = 0;
            this.ProxyStringsHACB.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProxyStringsHACB.Location = new System.Drawing.Point(13, 146);
            this.ProxyStringsHACB.Margin = new System.Windows.Forms.Padding(0);
            this.ProxyStringsHACB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProxyStringsHACB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProxyStringsHACB.Name = "ProxyStringsHACB";
            this.ProxyStringsHACB.Ripple = true;
            this.ProxyStringsHACB.Size = new System.Drawing.Size(113, 30);
            this.ProxyStringsHACB.TabIndex = 5;
            this.ProxyStringsHACB.Text = "Proxy-Strings";
            this.ProxyStringsHACB.UseVisualStyleBackColor = true;
            // 
            // ProxyINTHACB
            // 
            this.ProxyINTHACB.AutoSize = true;
            this.ProxyINTHACB.Depth = 0;
            this.ProxyINTHACB.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProxyINTHACB.Location = new System.Drawing.Point(144, 146);
            this.ProxyINTHACB.Margin = new System.Windows.Forms.Padding(0);
            this.ProxyINTHACB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProxyINTHACB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProxyINTHACB.Name = "ProxyINTHACB";
            this.ProxyINTHACB.Ripple = true;
            this.ProxyINTHACB.Size = new System.Drawing.Size(91, 30);
            this.ProxyINTHACB.TabIndex = 6;
            this.ProxyINTHACB.Text = "Proxy-INT";
            this.ProxyINTHACB.UseVisualStyleBackColor = true;
            // 
            // CalliINTHACB
            // 
            this.CalliINTHACB.AutoSize = true;
            this.CalliINTHACB.Depth = 0;
            this.CalliINTHACB.Font = new System.Drawing.Font("Roboto", 10F);
            this.CalliINTHACB.Location = new System.Drawing.Point(12, 176);
            this.CalliINTHACB.Margin = new System.Windows.Forms.Padding(0);
            this.CalliINTHACB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CalliINTHACB.MouseState = MaterialSkin.MouseState.HOVER;
            this.CalliINTHACB.Name = "CalliINTHACB";
            this.CalliINTHACB.Ripple = true;
            this.CalliINTHACB.Size = new System.Drawing.Size(57, 30);
            this.CalliINTHACB.TabIndex = 7;
            this.CalliINTHACB.Text = "Calli";
            this.CalliINTHACB.UseVisualStyleBackColor = true;
            // 
            // AntiDebugHACB
            // 
            this.AntiDebugHACB.AutoSize = true;
            this.AntiDebugHACB.Depth = 0;
            this.AntiDebugHACB.Font = new System.Drawing.Font("Roboto", 10F);
            this.AntiDebugHACB.Location = new System.Drawing.Point(126, 116);
            this.AntiDebugHACB.Margin = new System.Windows.Forms.Padding(0);
            this.AntiDebugHACB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AntiDebugHACB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AntiDebugHACB.Name = "AntiDebugHACB";
            this.AntiDebugHACB.Ripple = true;
            this.AntiDebugHACB.Size = new System.Drawing.Size(99, 30);
            this.AntiDebugHACB.TabIndex = 9;
            this.AntiDebugHACB.Text = "Anti-Debug";
            this.AntiDebugHACB.UseVisualStyleBackColor = true;
            // 
            // AntiTamperHACB
            // 
            this.AntiTamperHACB.AutoSize = true;
            this.AntiTamperHACB.Depth = 0;
            this.AntiTamperHACB.Enabled = false;
            this.AntiTamperHACB.Font = new System.Drawing.Font("Roboto", 10F);
            this.AntiTamperHACB.Location = new System.Drawing.Point(235, 116);
            this.AntiTamperHACB.Margin = new System.Windows.Forms.Padding(0);
            this.AntiTamperHACB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AntiTamperHACB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AntiTamperHACB.Name = "AntiTamperHACB";
            this.AntiTamperHACB.Ripple = true;
            this.AntiTamperHACB.Size = new System.Drawing.Size(107, 30);
            this.AntiTamperHACB.TabIndex = 10;
            this.AntiTamperHACB.Text = "Anti-Tamper";
            this.AntiTamperHACB.UseVisualStyleBackColor = true;
            // 
            // PackerHACB
            // 
            this.PackerHACB.AutoSize = true;
            this.PackerHACB.Depth = 0;
            this.PackerHACB.Enabled = false;
            this.PackerHACB.Font = new System.Drawing.Font("Roboto", 10F);
            this.PackerHACB.Location = new System.Drawing.Point(196, 176);
            this.PackerHACB.Margin = new System.Windows.Forms.Padding(0);
            this.PackerHACB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PackerHACB.MouseState = MaterialSkin.MouseState.HOVER;
            this.PackerHACB.Name = "PackerHACB";
            this.PackerHACB.Ripple = true;
            this.PackerHACB.Size = new System.Drawing.Size(73, 30);
            this.PackerHACB.TabIndex = 11;
            this.PackerHACB.Text = "Packer";
            this.PackerHACB.UseVisualStyleBackColor = true;
            // 
            // HideMethodsHACB
            // 
            this.HideMethodsHACB.AutoSize = true;
            this.HideMethodsHACB.Depth = 0;
            this.HideMethodsHACB.Font = new System.Drawing.Font("Roboto", 10F);
            this.HideMethodsHACB.Location = new System.Drawing.Point(13, 206);
            this.HideMethodsHACB.Margin = new System.Windows.Forms.Padding(0);
            this.HideMethodsHACB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.HideMethodsHACB.MouseState = MaterialSkin.MouseState.HOVER;
            this.HideMethodsHACB.Name = "HideMethodsHACB";
            this.HideMethodsHACB.Ripple = true;
            this.HideMethodsHACB.Size = new System.Drawing.Size(116, 30);
            this.HideMethodsHACB.TabIndex = 13;
            this.HideMethodsHACB.Text = "Hide Methods";
            this.HideMethodsHACB.UseVisualStyleBackColor = true;
            // 
            // RenamerHACB
            // 
            this.RenamerHACB.AutoSize = true;
            this.RenamerHACB.Depth = 0;
            this.RenamerHACB.Font = new System.Drawing.Font("Roboto", 10F);
            this.RenamerHACB.Location = new System.Drawing.Point(144, 206);
            this.RenamerHACB.Margin = new System.Windows.Forms.Padding(0);
            this.RenamerHACB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RenamerHACB.MouseState = MaterialSkin.MouseState.HOVER;
            this.RenamerHACB.Name = "RenamerHACB";
            this.RenamerHACB.Ripple = true;
            this.RenamerHACB.Size = new System.Drawing.Size(85, 30);
            this.RenamerHACB.TabIndex = 14;
            this.RenamerHACB.Text = "Renamer";
            this.RenamerHACB.UseVisualStyleBackColor = true;
            // 
            // ReallyBasicExampleProtector
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RenamerHACB);
            this.Controls.Add(this.HideMethodsHACB);
            this.Controls.Add(this.PackerHACB);
            this.Controls.Add(this.AntiTamperHACB);
            this.Controls.Add(this.AntiDebugHACB);
            this.Controls.Add(this.CalliINTHACB);
            this.Controls.Add(this.ProxyINTHACB);
            this.Controls.Add(this.ProxyStringsHACB);
            this.Controls.Add(this.ROTStringsHACB);
            this.Controls.Add(this.AntiDumpHACB);
            this.Controls.Add(this.ProtectFileHABTN);
            this.Controls.Add(this.BrowserFileHABTN);
            this.Controls.Add(this.FileToProtectHATB);
            this.MaximizeBox = false;
            this.Name = "ReallyBasicExampleProtector";
            this.Opacity = 0.9D;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Really Basic Example Protector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField FileToProtectHATB;
        private MaterialSkin.Controls.MaterialFlatButton BrowserFileHABTN;
        private MaterialSkin.Controls.MaterialFlatButton ProtectFileHABTN;
        private MaterialSkin.Controls.MaterialCheckBox AntiDumpHACB;
        private MaterialSkin.Controls.MaterialCheckBox ROTStringsHACB;
        private MaterialSkin.Controls.MaterialCheckBox ProxyStringsHACB;
        private MaterialSkin.Controls.MaterialCheckBox ProxyINTHACB;
        private MaterialSkin.Controls.MaterialCheckBox CalliINTHACB;
        private MaterialSkin.Controls.MaterialCheckBox AntiDebugHACB;
        private MaterialSkin.Controls.MaterialCheckBox AntiTamperHACB;
        private MaterialSkin.Controls.MaterialCheckBox PackerHACB;
        private MaterialSkin.Controls.MaterialCheckBox HideMethodsHACB;
        private MaterialSkin.Controls.MaterialCheckBox RenamerHACB;
    }
}

