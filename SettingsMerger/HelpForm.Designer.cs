namespace SettingsMerger
{
    partial class HelpForm
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
            tbxHelp = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // tbxHelp
            // 
            tbxHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxHelp.BackColor = Color.White;
            tbxHelp.BorderStyle = BorderStyle.None;
            tbxHelp.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxHelp.ForeColor = Color.Black;
            tbxHelp.Location = new Point(0, 0);
            tbxHelp.Margin = new Padding(0);
            tbxHelp.Multiline = true;
            tbxHelp.Name = "tbxHelp";
            tbxHelp.ReadOnly = true;
            tbxHelp.ScrollBars = ScrollBars.Both;
            tbxHelp.Size = new Size(791, 411);
            tbxHelp.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(343, 415);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOk);
            Controls.Add(tbxHelp);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HelpForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Help";
            Load += HelpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxHelp;
        private Button btnOk;
    }
}