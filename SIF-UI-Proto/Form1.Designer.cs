namespace SIF_UI_Proto
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
            this.parameterListBox = new System.Windows.Forms.ListBox();
            this.variablesListBox = new System.Windows.Forms.ListBox();
            this.tasksListBox = new System.Windows.Forms.ListBox();
            this.parameterInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.parameterNameLabel = new System.Windows.Forms.Label();
            this.parameterDefaultLabel = new System.Windows.Forms.Label();
            this.parameterValueLabel = new System.Windows.Forms.Label();
            this.parameterDescriptionLabel = new System.Windows.Forms.Label();
            this.variableInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.variableCalcdValueLabel = new System.Windows.Forms.Label();
            this.variableOriginalValueLabel = new System.Windows.Forms.Label();
            this.variableNameLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.taskInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.taskTypeLabel = new System.Windows.Forms.Label();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.taskParametersTree = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.parameterInfoGroupBox.SuspendLayout();
            this.variableInfoGroupBox.SuspendLayout();
            this.taskInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // parameterListBox
            // 
            this.parameterListBox.FormattingEnabled = true;
            this.parameterListBox.ItemHeight = 16;
            this.parameterListBox.Location = new System.Drawing.Point(12, 40);
            this.parameterListBox.Name = "parameterListBox";
            this.parameterListBox.Size = new System.Drawing.Size(169, 276);
            this.parameterListBox.TabIndex = 0;
            this.parameterListBox.SelectedIndexChanged += new System.EventHandler(this.parameterListBox_SelectedIndexChanged);
            // 
            // variablesListBox
            // 
            this.variablesListBox.FormattingEnabled = true;
            this.variablesListBox.ItemHeight = 16;
            this.variablesListBox.Location = new System.Drawing.Point(187, 40);
            this.variablesListBox.Name = "variablesListBox";
            this.variablesListBox.Size = new System.Drawing.Size(186, 276);
            this.variablesListBox.TabIndex = 0;
            this.variablesListBox.SelectedIndexChanged += new System.EventHandler(this.variablesListBox_SelectedIndexChanged);
            // 
            // tasksListBox
            // 
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.ItemHeight = 16;
            this.tasksListBox.Location = new System.Drawing.Point(379, 40);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(186, 276);
            this.tasksListBox.TabIndex = 0;
            this.tasksListBox.SelectedIndexChanged += new System.EventHandler(this.tasksListBox_SelectedIndexChanged);
            // 
            // parameterInfoGroupBox
            // 
            this.parameterInfoGroupBox.Controls.Add(this.label4);
            this.parameterInfoGroupBox.Controls.Add(this.label3);
            this.parameterInfoGroupBox.Controls.Add(this.label2);
            this.parameterInfoGroupBox.Controls.Add(this.parameterDescriptionLabel);
            this.parameterInfoGroupBox.Controls.Add(this.parameterValueLabel);
            this.parameterInfoGroupBox.Controls.Add(this.parameterDefaultLabel);
            this.parameterInfoGroupBox.Controls.Add(this.parameterNameLabel);
            this.parameterInfoGroupBox.Controls.Add(this.label1);
            this.parameterInfoGroupBox.Location = new System.Drawing.Point(12, 343);
            this.parameterInfoGroupBox.Name = "parameterInfoGroupBox";
            this.parameterInfoGroupBox.Size = new System.Drawing.Size(553, 156);
            this.parameterInfoGroupBox.TabIndex = 1;
            this.parameterInfoGroupBox.TabStop = false;
            this.parameterInfoGroupBox.Text = "Parameter Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Default Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // parameterNameLabel
            // 
            this.parameterNameLabel.AutoSize = true;
            this.parameterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterNameLabel.Location = new System.Drawing.Point(104, 47);
            this.parameterNameLabel.Name = "parameterNameLabel";
            this.parameterNameLabel.Size = new System.Drawing.Size(20, 17);
            this.parameterNameLabel.TabIndex = 0;
            this.parameterNameLabel.Text = "--";
            // 
            // parameterDefaultLabel
            // 
            this.parameterDefaultLabel.AutoSize = true;
            this.parameterDefaultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterDefaultLabel.Location = new System.Drawing.Point(104, 77);
            this.parameterDefaultLabel.Name = "parameterDefaultLabel";
            this.parameterDefaultLabel.Size = new System.Drawing.Size(20, 17);
            this.parameterDefaultLabel.TabIndex = 0;
            this.parameterDefaultLabel.Text = "--";
            // 
            // parameterValueLabel
            // 
            this.parameterValueLabel.AutoSize = true;
            this.parameterValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterValueLabel.Location = new System.Drawing.Point(104, 105);
            this.parameterValueLabel.Name = "parameterValueLabel";
            this.parameterValueLabel.Size = new System.Drawing.Size(20, 17);
            this.parameterValueLabel.TabIndex = 0;
            this.parameterValueLabel.Text = "--";
            // 
            // parameterDescriptionLabel
            // 
            this.parameterDescriptionLabel.AutoSize = true;
            this.parameterDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterDescriptionLabel.Location = new System.Drawing.Point(104, 133);
            this.parameterDescriptionLabel.Name = "parameterDescriptionLabel";
            this.parameterDescriptionLabel.Size = new System.Drawing.Size(20, 17);
            this.parameterDescriptionLabel.TabIndex = 0;
            this.parameterDescriptionLabel.Text = "--";
            // 
            // variableInfoGroupBox
            // 
            this.variableInfoGroupBox.Controls.Add(this.label6);
            this.variableInfoGroupBox.Controls.Add(this.label7);
            this.variableInfoGroupBox.Controls.Add(this.variableCalcdValueLabel);
            this.variableInfoGroupBox.Controls.Add(this.variableOriginalValueLabel);
            this.variableInfoGroupBox.Controls.Add(this.variableNameLabel);
            this.variableInfoGroupBox.Controls.Add(this.label12);
            this.variableInfoGroupBox.Location = new System.Drawing.Point(21, 515);
            this.variableInfoGroupBox.Name = "variableInfoGroupBox";
            this.variableInfoGroupBox.Size = new System.Drawing.Size(553, 123);
            this.variableInfoGroupBox.TabIndex = 2;
            this.variableInfoGroupBox.TabStop = false;
            this.variableInfoGroupBox.Text = "Variable Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Calc\'d Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Original Value";
            // 
            // variableCalcdValueLabel
            // 
            this.variableCalcdValueLabel.AutoSize = true;
            this.variableCalcdValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableCalcdValueLabel.Location = new System.Drawing.Point(104, 105);
            this.variableCalcdValueLabel.Name = "variableCalcdValueLabel";
            this.variableCalcdValueLabel.Size = new System.Drawing.Size(20, 17);
            this.variableCalcdValueLabel.TabIndex = 0;
            this.variableCalcdValueLabel.Text = "--";
            // 
            // variableOriginalValueLabel
            // 
            this.variableOriginalValueLabel.AutoSize = true;
            this.variableOriginalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableOriginalValueLabel.Location = new System.Drawing.Point(104, 77);
            this.variableOriginalValueLabel.Name = "variableOriginalValueLabel";
            this.variableOriginalValueLabel.Size = new System.Drawing.Size(20, 17);
            this.variableOriginalValueLabel.TabIndex = 0;
            this.variableOriginalValueLabel.Text = "--";
            // 
            // variableNameLabel
            // 
            this.variableNameLabel.AutoSize = true;
            this.variableNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableNameLabel.Location = new System.Drawing.Point(104, 47);
            this.variableNameLabel.Name = "variableNameLabel";
            this.variableNameLabel.Size = new System.Drawing.Size(20, 17);
            this.variableNameLabel.TabIndex = 0;
            this.variableNameLabel.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name";
            // 
            // taskInfoGroupBox
            // 
            this.taskInfoGroupBox.Controls.Add(this.taskParametersTree);
            this.taskInfoGroupBox.Controls.Add(this.label5);
            this.taskInfoGroupBox.Controls.Add(this.label8);
            this.taskInfoGroupBox.Controls.Add(this.taskTypeLabel);
            this.taskInfoGroupBox.Controls.Add(this.taskNameLabel);
            this.taskInfoGroupBox.Controls.Add(this.label13);
            this.taskInfoGroupBox.Location = new System.Drawing.Point(580, 40);
            this.taskInfoGroupBox.Name = "taskInfoGroupBox";
            this.taskInfoGroupBox.Size = new System.Drawing.Size(663, 425);
            this.taskInfoGroupBox.TabIndex = 2;
            this.taskInfoGroupBox.TabStop = false;
            this.taskInfoGroupBox.Text = "Task Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Parameters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Type";
            // 
            // taskTypeLabel
            // 
            this.taskTypeLabel.AutoSize = true;
            this.taskTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTypeLabel.Location = new System.Drawing.Point(104, 77);
            this.taskTypeLabel.Name = "taskTypeLabel";
            this.taskTypeLabel.Size = new System.Drawing.Size(20, 17);
            this.taskTypeLabel.TabIndex = 0;
            this.taskTypeLabel.Text = "--";
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.Location = new System.Drawing.Point(104, 47);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(20, 17);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Name";
            // 
            // taskParametersTree
            // 
            this.taskParametersTree.Location = new System.Drawing.Point(107, 105);
            this.taskParametersTree.Name = "taskParametersTree";
            this.taskParametersTree.ShowNodeToolTips = true;
            this.taskParametersTree.Size = new System.Drawing.Size(550, 307);
            this.taskParametersTree.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Parameters";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Variables";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tasks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 791);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.taskInfoGroupBox);
            this.Controls.Add(this.variableInfoGroupBox);
            this.Controls.Add(this.parameterInfoGroupBox);
            this.Controls.Add(this.tasksListBox);
            this.Controls.Add(this.variablesListBox);
            this.Controls.Add(this.parameterListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.parameterInfoGroupBox.ResumeLayout(false);
            this.parameterInfoGroupBox.PerformLayout();
            this.variableInfoGroupBox.ResumeLayout(false);
            this.variableInfoGroupBox.PerformLayout();
            this.taskInfoGroupBox.ResumeLayout(false);
            this.taskInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox parameterListBox;
        private System.Windows.Forms.ListBox variablesListBox;
        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.GroupBox parameterInfoGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label parameterNameLabel;
        private System.Windows.Forms.Label parameterDescriptionLabel;
        private System.Windows.Forms.Label parameterValueLabel;
        private System.Windows.Forms.Label parameterDefaultLabel;
        private System.Windows.Forms.GroupBox variableInfoGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label variableCalcdValueLabel;
        private System.Windows.Forms.Label variableOriginalValueLabel;
        private System.Windows.Forms.Label variableNameLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox taskInfoGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label taskTypeLabel;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TreeView taskParametersTree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

