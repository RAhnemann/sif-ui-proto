namespace SIF_UI_Proto
{
    partial class PSRunner
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
            this.outputTabControl = new System.Windows.Forms.TabControl();
            this.allTab = new System.Windows.Forms.TabPage();
            this.allOutputTextbox = new System.Windows.Forms.RichTextBox();
            this.errorTab = new System.Windows.Forms.TabPage();
            this.errorTextbox = new System.Windows.Forms.RichTextBox();
            this.warningTab = new System.Windows.Forms.TabPage();
            this.warningTextbox = new System.Windows.Forms.RichTextBox();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.infoTextbox = new System.Windows.Forms.RichTextBox();
            this.debugTab = new System.Windows.Forms.TabPage();
            this.debugTextbox = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.outputTabControl.SuspendLayout();
            this.allTab.SuspendLayout();
            this.errorTab.SuspendLayout();
            this.warningTab.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTabControl
            // 
            this.outputTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTabControl.Controls.Add(this.tabPage1);
            this.outputTabControl.Controls.Add(this.allTab);
            this.outputTabControl.Controls.Add(this.errorTab);
            this.outputTabControl.Controls.Add(this.warningTab);
            this.outputTabControl.Controls.Add(this.infoTab);
            this.outputTabControl.Controls.Add(this.debugTab);
            this.outputTabControl.Location = new System.Drawing.Point(12, 12);
            this.outputTabControl.Name = "outputTabControl";
            this.outputTabControl.SelectedIndex = 0;
            this.outputTabControl.Size = new System.Drawing.Size(1011, 620);
            this.outputTabControl.TabIndex = 1;
            // 
            // allTab
            // 
            this.allTab.Controls.Add(this.allOutputTextbox);
            this.allTab.Location = new System.Drawing.Point(4, 22);
            this.allTab.Name = "allTab";
            this.allTab.Padding = new System.Windows.Forms.Padding(3);
            this.allTab.Size = new System.Drawing.Size(1003, 594);
            this.allTab.TabIndex = 0;
            this.allTab.Text = "All Output";
            this.allTab.UseVisualStyleBackColor = true;
            // 
            // allOutputTextbox
            // 
            this.allOutputTextbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.allOutputTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allOutputTextbox.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.allOutputTextbox.Location = new System.Drawing.Point(3, 3);
            this.allOutputTextbox.Name = "allOutputTextbox";
            this.allOutputTextbox.Size = new System.Drawing.Size(997, 588);
            this.allOutputTextbox.TabIndex = 0;
            this.allOutputTextbox.Text = "";
            // 
            // errorTab
            // 
            this.errorTab.Controls.Add(this.errorTextbox);
            this.errorTab.Location = new System.Drawing.Point(4, 22);
            this.errorTab.Name = "errorTab";
            this.errorTab.Padding = new System.Windows.Forms.Padding(3);
            this.errorTab.Size = new System.Drawing.Size(1003, 594);
            this.errorTab.TabIndex = 1;
            this.errorTab.Text = "Errors";
            this.errorTab.UseVisualStyleBackColor = true;
            // 
            // errorTextbox
            // 
            this.errorTextbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.errorTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTextbox.Location = new System.Drawing.Point(3, 3);
            this.errorTextbox.Name = "errorTextbox";
            this.errorTextbox.Size = new System.Drawing.Size(997, 588);
            this.errorTextbox.TabIndex = 1;
            this.errorTextbox.Text = "";
            // 
            // warningTab
            // 
            this.warningTab.Controls.Add(this.warningTextbox);
            this.warningTab.Location = new System.Drawing.Point(4, 22);
            this.warningTab.Name = "warningTab";
            this.warningTab.Padding = new System.Windows.Forms.Padding(3);
            this.warningTab.Size = new System.Drawing.Size(1003, 594);
            this.warningTab.TabIndex = 2;
            this.warningTab.Text = "Warnings";
            this.warningTab.UseVisualStyleBackColor = true;
            // 
            // warningTextbox
            // 
            this.warningTextbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.warningTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warningTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningTextbox.Location = new System.Drawing.Point(3, 3);
            this.warningTextbox.Name = "warningTextbox";
            this.warningTextbox.Size = new System.Drawing.Size(997, 588);
            this.warningTextbox.TabIndex = 1;
            this.warningTextbox.Text = "";
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.infoTextbox);
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Name = "infoTab";
            this.infoTab.Size = new System.Drawing.Size(1003, 594);
            this.infoTab.TabIndex = 4;
            this.infoTab.Text = "Info";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // infoTextbox
            // 
            this.infoTextbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.infoTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTextbox.Location = new System.Drawing.Point(0, 0);
            this.infoTextbox.Name = "infoTextbox";
            this.infoTextbox.Size = new System.Drawing.Size(1003, 594);
            this.infoTextbox.TabIndex = 1;
            this.infoTextbox.Text = "";
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.debugTextbox);
            this.debugTab.Location = new System.Drawing.Point(4, 22);
            this.debugTab.Name = "debugTab";
            this.debugTab.Size = new System.Drawing.Size(1003, 594);
            this.debugTab.TabIndex = 3;
            this.debugTab.Text = "Debug";
            this.debugTab.UseVisualStyleBackColor = true;
            // 
            // debugTextbox
            // 
            this.debugTextbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.debugTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugTextbox.Location = new System.Drawing.Point(0, 0);
            this.debugTextbox.Name = "debugTextbox";
            this.debugTextbox.Size = new System.Drawing.Size(1003, 594);
            this.debugTextbox.TabIndex = 1;
            this.debugTextbox.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1003, 594);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Parameters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PSRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 657);
            this.Controls.Add(this.outputTabControl);
            this.Name = "PSRunner";
            this.Text = "PSRunner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PSRunner_FormClosing);
            this.Load += new System.EventHandler(this.PSRunner_Load);
            this.outputTabControl.ResumeLayout(false);
            this.allTab.ResumeLayout(false);
            this.errorTab.ResumeLayout(false);
            this.warningTab.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.debugTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl outputTabControl;
        private System.Windows.Forms.TabPage allTab;
        private System.Windows.Forms.RichTextBox allOutputTextbox;
        private System.Windows.Forms.TabPage errorTab;
        private System.Windows.Forms.RichTextBox errorTextbox;
        private System.Windows.Forms.TabPage warningTab;
        private System.Windows.Forms.RichTextBox warningTextbox;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.RichTextBox infoTextbox;
        private System.Windows.Forms.TabPage debugTab;
        private System.Windows.Forms.RichTextBox debugTextbox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
    }
}