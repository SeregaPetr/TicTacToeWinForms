namespace TicTacToeWinForms
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCross = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonZero = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelMarker = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBoxSelectUser = new System.Windows.Forms.ComboBox();
            this.linkLabelAddUser = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelLevel = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonLevel1 = new System.Windows.Forms.RadioButton();
            this.radioButtonLevel2 = new System.Windows.Forms.RadioButton();
            this.radioButtonLevel3 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelMarker.SuspendLayout();
            this.flowLayoutPanelLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбрать пользователя:";
            // 
            // radioButtonCross
            // 
            this.radioButtonCross.AutoSize = true;
            this.radioButtonCross.Checked = true;
            this.radioButtonCross.Location = new System.Drawing.Point(3, 3);
            this.radioButtonCross.Name = "radioButtonCross";
            this.radioButtonCross.Size = new System.Drawing.Size(66, 17);
            this.radioButtonCross.TabIndex = 4;
            this.radioButtonCross.TabStop = true;
            this.radioButtonCross.Text = "крестик";
            this.radioButtonCross.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вы играете:";
            // 
            // radioButtonZero
            // 
            this.radioButtonZero.AutoSize = true;
            this.radioButtonZero.Location = new System.Drawing.Point(75, 3);
            this.radioButtonZero.Name = "radioButtonZero";
            this.radioButtonZero.Size = new System.Drawing.Size(55, 17);
            this.radioButtonZero.TabIndex = 6;
            this.radioButtonZero.Text = "нолик";
            this.radioButtonZero.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMarker
            // 
            this.flowLayoutPanelMarker.Controls.Add(this.radioButtonCross);
            this.flowLayoutPanelMarker.Controls.Add(this.radioButtonZero);
            this.flowLayoutPanelMarker.Location = new System.Drawing.Point(175, 83);
            this.flowLayoutPanelMarker.Name = "flowLayoutPanelMarker";
            this.flowLayoutPanelMarker.Size = new System.Drawing.Size(218, 21);
            this.flowLayoutPanelMarker.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(58, 196);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(206, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxSelectUser
            // 
            this.comboBoxSelectUser.FormattingEnabled = true;
            this.comboBoxSelectUser.Items.AddRange(new object[] {
            "Аноним"});
            this.comboBoxSelectUser.Location = new System.Drawing.Point(175, 12);
            this.comboBoxSelectUser.Name = "comboBoxSelectUser";
            this.comboBoxSelectUser.Size = new System.Drawing.Size(218, 21);
            this.comboBoxSelectUser.TabIndex = 10;
            // 
            // linkLabelAddUser
            // 
            this.linkLabelAddUser.AutoSize = true;
            this.linkLabelAddUser.Location = new System.Drawing.Point(216, 49);
            this.linkLabelAddUser.Name = "linkLabelAddUser";
            this.linkLabelAddUser.Size = new System.Drawing.Size(131, 13);
            this.linkLabelAddUser.TabIndex = 11;
            this.linkLabelAddUser.TabStop = true;
            this.linkLabelAddUser.Text = "Добавить пользователя";
            this.linkLabelAddUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddUser_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Уровень игры:";
            // 
            // flowLayoutPanelLevel
            // 
            this.flowLayoutPanelLevel.Controls.Add(this.radioButtonLevel1);
            this.flowLayoutPanelLevel.Controls.Add(this.radioButtonLevel2);
            this.flowLayoutPanelLevel.Controls.Add(this.radioButtonLevel3);
            this.flowLayoutPanelLevel.Location = new System.Drawing.Point(175, 130);
            this.flowLayoutPanelLevel.Name = "flowLayoutPanelLevel";
            this.flowLayoutPanelLevel.Size = new System.Drawing.Size(218, 37);
            this.flowLayoutPanelLevel.TabIndex = 13;
            // 
            // radioButtonLevel1
            // 
            this.radioButtonLevel1.AutoSize = true;
            this.radioButtonLevel1.Checked = true;
            this.radioButtonLevel1.Location = new System.Drawing.Point(3, 3);
            this.radioButtonLevel1.Name = "radioButtonLevel1";
            this.radioButtonLevel1.Size = new System.Drawing.Size(60, 17);
            this.radioButtonLevel1.TabIndex = 4;
            this.radioButtonLevel1.TabStop = true;
            this.radioButtonLevel1.Text = "легкий";
            this.radioButtonLevel1.UseVisualStyleBackColor = true;
            // 
            // radioButtonLevel2
            // 
            this.radioButtonLevel2.AutoSize = true;
            this.radioButtonLevel2.Location = new System.Drawing.Point(69, 3);
            this.radioButtonLevel2.Name = "radioButtonLevel2";
            this.radioButtonLevel2.Size = new System.Drawing.Size(67, 17);
            this.radioButtonLevel2.TabIndex = 6;
            this.radioButtonLevel2.Text = "средний";
            this.radioButtonLevel2.UseVisualStyleBackColor = true;
            // 
            // radioButtonLevel3
            // 
            this.radioButtonLevel3.AutoSize = true;
            this.radioButtonLevel3.Location = new System.Drawing.Point(142, 3);
            this.radioButtonLevel3.Name = "radioButtonLevel3";
            this.radioButtonLevel3.Size = new System.Drawing.Size(71, 17);
            this.radioButtonLevel3.TabIndex = 7;
            this.radioButtonLevel3.Text = "сложный";
            this.radioButtonLevel3.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 242);
            this.Controls.Add(this.flowLayoutPanelLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelAddUser);
            this.Controls.Add(this.comboBoxSelectUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.flowLayoutPanelMarker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки игры";
            this.flowLayoutPanelMarker.ResumeLayout(false);
            this.flowLayoutPanelMarker.PerformLayout();
            this.flowLayoutPanelLevel.ResumeLayout(false);
            this.flowLayoutPanelLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton radioButtonCross;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton radioButtonZero;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMarker;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.ComboBox comboBoxSelectUser;
        private System.Windows.Forms.LinkLabel linkLabelAddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLevel;
        public System.Windows.Forms.RadioButton radioButtonLevel1;
        public System.Windows.Forms.RadioButton radioButtonLevel2;
        public System.Windows.Forms.RadioButton radioButtonLevel3;
    }
}
