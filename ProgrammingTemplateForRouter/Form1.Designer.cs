namespace ProgrammingTemplateForRouter
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
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.SwitchRadio = new System.Windows.Forms.RadioButton();
            this.RouterRadio = new System.Windows.Forms.RadioButton();
            this.NameIn = new System.Windows.Forms.TextBox();
            this.SecretIN = new System.Windows.Forms.TextBox();
            this.ConPassIn = new System.Windows.Forms.TextBox();
            this.AuxPassIn = new System.Windows.Forms.TextBox();
            this.VtyPassIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfigOut = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.VlanIp1st = new System.Windows.Forms.TextBox();
            this.Vlan = new System.Windows.Forms.Label();
            this.VlanNumIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VlanSub1st = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DefGat1st = new System.Windows.Forms.TextBox();
            this.VLanCheck = new System.Windows.Forms.CheckBox();
            this.VlanIp2nd = new System.Windows.Forms.TextBox();
            this.VlanIp3rd = new System.Windows.Forms.TextBox();
            this.VlanIp4th = new System.Windows.Forms.TextBox();
            this.VlanSub2nd = new System.Windows.Forms.TextBox();
            this.VlanSub3rd = new System.Windows.Forms.TextBox();
            this.VlanSub4th = new System.Windows.Forms.TextBox();
            this.DefGat2nd = new System.Windows.Forms.TextBox();
            this.DefGat3rd = new System.Windows.Forms.TextBox();
            this.DefGat4th = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(391, 12);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(208, 23);
            this.GenerateBtn.TabIndex = 0;
            this.GenerateBtn.Text = "GenerateConfig";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // SwitchRadio
            // 
            this.SwitchRadio.AutoSize = true;
            this.SwitchRadio.Location = new System.Drawing.Point(51, 80);
            this.SwitchRadio.Name = "SwitchRadio";
            this.SwitchRadio.Size = new System.Drawing.Size(57, 17);
            this.SwitchRadio.TabIndex = 2;
            this.SwitchRadio.TabStop = true;
            this.SwitchRadio.Text = "Switch";
            this.SwitchRadio.UseVisualStyleBackColor = true;
            this.SwitchRadio.CheckedChanged += new System.EventHandler(this.SwitchRadio_CheckedChanged);
            // 
            // RouterRadio
            // 
            this.RouterRadio.AutoSize = true;
            this.RouterRadio.Location = new System.Drawing.Point(51, 103);
            this.RouterRadio.Name = "RouterRadio";
            this.RouterRadio.Size = new System.Drawing.Size(57, 17);
            this.RouterRadio.TabIndex = 3;
            this.RouterRadio.TabStop = true;
            this.RouterRadio.Text = "Router";
            this.RouterRadio.UseVisualStyleBackColor = true;
            this.RouterRadio.CheckedChanged += new System.EventHandler(this.RouterRadio_CheckedChanged);
            // 
            // NameIn
            // 
            this.NameIn.Location = new System.Drawing.Point(51, 173);
            this.NameIn.Name = "NameIn";
            this.NameIn.ShortcutsEnabled = false;
            this.NameIn.Size = new System.Drawing.Size(100, 20);
            this.NameIn.TabIndex = 4;
            // 
            // SecretIN
            // 
            this.SecretIN.Location = new System.Drawing.Point(51, 221);
            this.SecretIN.Name = "SecretIN";
            this.SecretIN.ShortcutsEnabled = false;
            this.SecretIN.Size = new System.Drawing.Size(100, 20);
            this.SecretIN.TabIndex = 5;
            // 
            // ConPassIn
            // 
            this.ConPassIn.Location = new System.Drawing.Point(51, 268);
            this.ConPassIn.Name = "ConPassIn";
            this.ConPassIn.ShortcutsEnabled = false;
            this.ConPassIn.Size = new System.Drawing.Size(100, 20);
            this.ConPassIn.TabIndex = 6;
            // 
            // AuxPassIn
            // 
            this.AuxPassIn.Location = new System.Drawing.Point(51, 311);
            this.AuxPassIn.Name = "AuxPassIn";
            this.AuxPassIn.ShortcutsEnabled = false;
            this.AuxPassIn.Size = new System.Drawing.Size(100, 20);
            this.AuxPassIn.TabIndex = 7;
            // 
            // VtyPassIn
            // 
            this.VtyPassIn.Location = new System.Drawing.Point(51, 361);
            this.VtyPassIn.Name = "VtyPassIn";
            this.VtyPassIn.ShortcutsEnabled = false;
            this.VtyPassIn.Size = new System.Drawing.Size(100, 20);
            this.VtyPassIn.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Device Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Secret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Console Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aux Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vty Password";
            // 
            // ConfigOut
            // 
            this.ConfigOut.AcceptsReturn = true;
            this.ConfigOut.AcceptsTab = true;
            this.ConfigOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ConfigOut.Location = new System.Drawing.Point(391, 103);
            this.ConfigOut.Multiline = true;
            this.ConfigOut.Name = "ConfigOut";
            this.ConfigOut.ReadOnly = true;
            this.ConfigOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConfigOut.ShortcutsEnabled = false;
            this.ConfigOut.Size = new System.Drawing.Size(234, 480);
            this.ConfigOut.TabIndex = 14;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(423, 41);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(141, 24);
            this.CopyButton.TabIndex = 15;
            this.CopyButton.Text = "Copy (After Creation)";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // VlanIp1st
            // 
            this.VlanIp1st.Location = new System.Drawing.Point(51, 502);
            this.VlanIp1st.Name = "VlanIp1st";
            this.VlanIp1st.ShortcutsEnabled = false;
            this.VlanIp1st.Size = new System.Drawing.Size(24, 20);
            this.VlanIp1st.TabIndex = 16;
            // 
            // Vlan
            // 
            this.Vlan.AutoSize = true;
            this.Vlan.Location = new System.Drawing.Point(81, 479);
            this.Vlan.Name = "Vlan";
            this.Vlan.Size = new System.Drawing.Size(38, 13);
            this.Vlan.TabIndex = 17;
            this.Vlan.Text = "Vlan #";
            // 
            // VlanNumIn
            // 
            this.VlanNumIn.Location = new System.Drawing.Point(51, 476);
            this.VlanNumIn.Name = "VlanNumIn";
            this.VlanNumIn.ShortcutsEnabled = false;
            this.VlanNumIn.Size = new System.Drawing.Size(24, 20);
            this.VlanNumIn.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Vlan Ip Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Vlan Ip SubNet";
            // 
            // VlanSub1st
            // 
            this.VlanSub1st.Location = new System.Drawing.Point(51, 530);
            this.VlanSub1st.Name = "VlanSub1st";
            this.VlanSub1st.ShortcutsEnabled = false;
            this.VlanSub1st.Size = new System.Drawing.Size(24, 20);
            this.VlanSub1st.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Default-Gateway for Switch";
            // 
            // DefGat1st
            // 
            this.DefGat1st.Location = new System.Drawing.Point(51, 556);
            this.DefGat1st.Name = "DefGat1st";
            this.DefGat1st.ShortcutsEnabled = false;
            this.DefGat1st.Size = new System.Drawing.Size(24, 20);
            this.DefGat1st.TabIndex = 23;
            // 
            // VLanCheck
            // 
            this.VLanCheck.AutoSize = true;
            this.VLanCheck.Location = new System.Drawing.Point(51, 441);
            this.VLanCheck.Name = "VLanCheck";
            this.VLanCheck.Size = new System.Drawing.Size(101, 17);
            this.VLanCheck.TabIndex = 24;
            this.VLanCheck.Text = "Configure Vlan?";
            this.VLanCheck.UseVisualStyleBackColor = true;
            // 
            // VlanIp2nd
            // 
            this.VlanIp2nd.Location = new System.Drawing.Point(81, 502);
            this.VlanIp2nd.Name = "VlanIp2nd";
            this.VlanIp2nd.ShortcutsEnabled = false;
            this.VlanIp2nd.Size = new System.Drawing.Size(24, 20);
            this.VlanIp2nd.TabIndex = 25;
            // 
            // VlanIp3rd
            // 
            this.VlanIp3rd.Location = new System.Drawing.Point(111, 502);
            this.VlanIp3rd.Name = "VlanIp3rd";
            this.VlanIp3rd.ShortcutsEnabled = false;
            this.VlanIp3rd.Size = new System.Drawing.Size(24, 20);
            this.VlanIp3rd.TabIndex = 26;
            // 
            // VlanIp4th
            // 
            this.VlanIp4th.Location = new System.Drawing.Point(141, 502);
            this.VlanIp4th.Name = "VlanIp4th";
            this.VlanIp4th.ShortcutsEnabled = false;
            this.VlanIp4th.Size = new System.Drawing.Size(24, 20);
            this.VlanIp4th.TabIndex = 27;
            // 
            // VlanSub2nd
            // 
            this.VlanSub2nd.Location = new System.Drawing.Point(80, 530);
            this.VlanSub2nd.Name = "VlanSub2nd";
            this.VlanSub2nd.ShortcutsEnabled = false;
            this.VlanSub2nd.Size = new System.Drawing.Size(25, 20);
            this.VlanSub2nd.TabIndex = 28;
            // 
            // VlanSub3rd
            // 
            this.VlanSub3rd.Location = new System.Drawing.Point(111, 530);
            this.VlanSub3rd.Name = "VlanSub3rd";
            this.VlanSub3rd.ShortcutsEnabled = false;
            this.VlanSub3rd.Size = new System.Drawing.Size(24, 20);
            this.VlanSub3rd.TabIndex = 29;
            // 
            // VlanSub4th
            // 
            this.VlanSub4th.Location = new System.Drawing.Point(140, 530);
            this.VlanSub4th.Name = "VlanSub4th";
            this.VlanSub4th.ShortcutsEnabled = false;
            this.VlanSub4th.Size = new System.Drawing.Size(25, 20);
            this.VlanSub4th.TabIndex = 30;
            // 
            // DefGat2nd
            // 
            this.DefGat2nd.Location = new System.Drawing.Point(80, 556);
            this.DefGat2nd.Name = "DefGat2nd";
            this.DefGat2nd.ShortcutsEnabled = false;
            this.DefGat2nd.Size = new System.Drawing.Size(24, 20);
            this.DefGat2nd.TabIndex = 31;
            // 
            // DefGat3rd
            // 
            this.DefGat3rd.Location = new System.Drawing.Point(110, 556);
            this.DefGat3rd.Name = "DefGat3rd";
            this.DefGat3rd.ShortcutsEnabled = false;
            this.DefGat3rd.Size = new System.Drawing.Size(24, 20);
            this.DefGat3rd.TabIndex = 32;
            // 
            // DefGat4th
            // 
            this.DefGat4th.Location = new System.Drawing.Point(140, 556);
            this.DefGat4th.Name = "DefGat4th";
            this.DefGat4th.ShortcutsEnabled = false;
            this.DefGat4th.Size = new System.Drawing.Size(24, 20);
            this.DefGat4th.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 646);
            this.Controls.Add(this.DefGat4th);
            this.Controls.Add(this.DefGat3rd);
            this.Controls.Add(this.DefGat2nd);
            this.Controls.Add(this.VlanSub4th);
            this.Controls.Add(this.VlanSub3rd);
            this.Controls.Add(this.VlanSub2nd);
            this.Controls.Add(this.VlanIp4th);
            this.Controls.Add(this.VlanIp3rd);
            this.Controls.Add(this.VlanIp2nd);
            this.Controls.Add(this.VLanCheck);
            this.Controls.Add(this.DefGat1st);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VlanSub1st);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VlanNumIn);
            this.Controls.Add(this.Vlan);
            this.Controls.Add(this.VlanIp1st);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ConfigOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VtyPassIn);
            this.Controls.Add(this.AuxPassIn);
            this.Controls.Add(this.ConPassIn);
            this.Controls.Add(this.SecretIN);
            this.Controls.Add(this.NameIn);
            this.Controls.Add(this.RouterRadio);
            this.Controls.Add(this.SwitchRadio);
            this.Controls.Add(this.GenerateBtn);
            this.Name = "Form1";
            this.Text = "RouterSwitching";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.RadioButton SwitchRadio;
        private System.Windows.Forms.RadioButton RouterRadio;
        private System.Windows.Forms.TextBox NameIn;
        private System.Windows.Forms.TextBox SecretIN;
        private System.Windows.Forms.TextBox ConPassIn;
        private System.Windows.Forms.TextBox AuxPassIn;
        private System.Windows.Forms.TextBox VtyPassIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ConfigOut;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.TextBox VlanIp1st;
        private System.Windows.Forms.Label Vlan;
        private System.Windows.Forms.TextBox VlanNumIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VlanSub1st;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DefGat1st;
        private System.Windows.Forms.CheckBox VLanCheck;
        private System.Windows.Forms.TextBox VlanIp2nd;
        private System.Windows.Forms.TextBox VlanIp3rd;
        private System.Windows.Forms.TextBox VlanIp4th;
        private System.Windows.Forms.TextBox VlanSub2nd;
        private System.Windows.Forms.TextBox VlanSub3rd;
        private System.Windows.Forms.TextBox VlanSub4th;
        private System.Windows.Forms.TextBox DefGat2nd;
        private System.Windows.Forms.TextBox DefGat3rd;
        private System.Windows.Forms.TextBox DefGat4th;
    }
}

