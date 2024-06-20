namespace Nochu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtAddressBar = new TextBox();
            btnGo = new Button();
            btnBack = new Button();
            btnForward = new Button();
            btnHome = new Button();
            btnReload = new Button();
            btnNewTab = new Button();
            tabControl1 = new TabControl();
            SuspendLayout();
            // 
            // txtAddressBar
            // 
            txtAddressBar.Location = new Point(88, 9);
            txtAddressBar.Name = "txtAddressBar";
            txtAddressBar.Size = new Size(526, 23);
            txtAddressBar.TabIndex = 0;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(621, 9);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(44, 22);
            btnGo.TabIndex = 1;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(9, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(26, 22);
            btnBack.TabIndex = 2;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnForward
            // 
            btnForward.Location = new Point(44, 9);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(26, 22);
            btnForward.TabIndex = 3;
            btnForward.Text = ">";
            btnForward.UseVisualStyleBackColor = true;
            btnForward.Click += btnForward_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(674, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(44, 22);
            btnHome.TabIndex = 4;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(726, 9);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(44, 22);
            btnReload.TabIndex = 5;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnNewTab
            // 
            btnNewTab.Location = new Point(779, 9);
            btnNewTab.Name = "btnNewTab";
            btnNewTab.Size = new Size(61, 22);
            btnNewTab.TabIndex = 6;
            btnNewTab.Text = "New Tab";
            btnNewTab.UseVisualStyleBackColor = true;
            btnNewTab.Click += btnNewTab_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Location = new Point(-1, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1145, 637);
            tabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1144, 675);
            Controls.Add(tabControl1);
            Controls.Add(btnNewTab);
            Controls.Add(btnReload);
            Controls.Add(btnHome);
            Controls.Add(btnForward);
            Controls.Add(btnBack);
            Controls.Add(btnGo);
            Controls.Add(txtAddressBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Nochu Web Browser";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAddressBar;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.TabControl tabControl1;
    }
}