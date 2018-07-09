﻿namespace Decoder
{
    partial class CameraConfig
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPasssword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtCameraName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnAddCamera = new System.Windows.Forms.Button();
            this.lblCIP = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.tvCameras = new System.Windows.Forms.TreeView();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gpBHelp = new System.Windows.Forms.GroupBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.FNodeStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.CMS.SuspendLayout();
            this.gpBHelp.SuspendLayout();
            this.FNodeStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpBHelp);
            this.panel1.Controls.Add(this.txtPasssword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtIPAddress);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtCameraName);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.btnAddCamera);
            this.panel1.Controls.Add(this.lblCIP);
            this.panel1.Controls.Add(this.lblCName);
            this.panel1.Controls.Add(this.tvCameras);
            this.panel1.Location = new System.Drawing.Point(13, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 375);
            this.panel1.TabIndex = 0;
            // 
            // txtPasssword
            // 
            this.txtPasssword.Location = new System.Drawing.Point(318, 151);
            this.txtPasssword.Name = "txtPasssword";
            this.txtPasssword.Size = new System.Drawing.Size(197, 21);
            this.txtPasssword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(318, 113);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(197, 21);
            this.txtUsername.TabIndex = 5;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(318, 76);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(197, 21);
            this.txtIPAddress.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(234, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 12);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "密码：";
            // 
            // txtCameraName
            // 
            this.txtCameraName.HideSelection = false;
            this.txtCameraName.Location = new System.Drawing.Point(318, 38);
            this.txtCameraName.Name = "txtCameraName";
            this.txtCameraName.Size = new System.Drawing.Size(197, 21);
            this.txtCameraName.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(234, 116);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 12);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "用户名：";
            // 
            // btnAddCamera
            // 
            this.btnAddCamera.Location = new System.Drawing.Point(318, 188);
            this.btnAddCamera.Name = "btnAddCamera";
            this.btnAddCamera.Size = new System.Drawing.Size(75, 23);
            this.btnAddCamera.TabIndex = 7;
            this.btnAddCamera.Text = "添加";
            this.btnAddCamera.UseVisualStyleBackColor = true;
            this.btnAddCamera.Click += new System.EventHandler(this.btnAddCamera_Click);
            // 
            // lblCIP
            // 
            this.lblCIP.AutoSize = true;
            this.lblCIP.Location = new System.Drawing.Point(234, 79);
            this.lblCIP.Name = "lblCIP";
            this.lblCIP.Size = new System.Drawing.Size(65, 12);
            this.lblCIP.TabIndex = 1;
            this.lblCIP.Text = "摄像机IP：";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(234, 41);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(77, 12);
            this.lblCName.TabIndex = 1;
            this.lblCName.Text = "摄像机名称：";
            // 
            // tvCameras
            // 
            this.tvCameras.AllowDrop = true;
            this.tvCameras.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvCameras.HideSelection = false;
            this.tvCameras.Indent = 19;
            this.tvCameras.ItemHeight = 22;
            this.tvCameras.Location = new System.Drawing.Point(4, 4);
            this.tvCameras.Name = "tvCameras";
            this.tvCameras.ShowNodeToolTips = true;
            this.tvCameras.Size = new System.Drawing.Size(180, 371);
            this.tvCameras.TabIndex = 1;
            this.tvCameras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvCameras_MouseDown);
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.上移ToolStripMenuItem,
            this.下移ToolStripMenuItem});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(101, 70);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 上移ToolStripMenuItem
            // 
            this.上移ToolStripMenuItem.Name = "上移ToolStripMenuItem";
            this.上移ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.上移ToolStripMenuItem.Text = "上移";
            // 
            // 下移ToolStripMenuItem
            // 
            this.下移ToolStripMenuItem.Name = "下移ToolStripMenuItem";
            this.下移ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.下移ToolStripMenuItem.Text = "下移";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(531, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存更改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(450, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "恢复";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gpBHelp
            // 
            this.gpBHelp.Controls.Add(this.txtHelp);
            this.gpBHelp.Location = new System.Drawing.Point(236, 216);
            this.gpBHelp.Name = "gpBHelp";
            this.gpBHelp.Size = new System.Drawing.Size(357, 156);
            this.gpBHelp.TabIndex = 11;
            this.gpBHelp.TabStop = false;
            this.gpBHelp.Text = "说明：";
            // 
            // txtHelp
            // 
            this.txtHelp.AutoCompleteCustomSource.AddRange(new string[] {
            "1、用户名密码可留空，默认为root/pass",
            "2、摄像机名称和IP地址不可重复；",
            "3、可在根节点右键自定义分组，并将其他节点拖到该分组用于轮播；"});
            this.txtHelp.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHelp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHelp.Location = new System.Drawing.Point(25, 20);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(302, 117);
            this.txtHelp.TabIndex = 12;
            this.txtHelp.Text = "1、用户名密码可留空，默认为root/pass\r\n2、摄像机名称和IP地址不可重复；\r\n3、可在根节点右键自定义分组，并将其他节点拖到该分组用于轮播";
            // 
            // FNodeStrip
            // 
            this.FNodeStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.FNodeStrip.Name = "FNodeStrip";
            this.FNodeStrip.Size = new System.Drawing.Size(137, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "新建分组";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "删除该分组";
            // 
            // CameraConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "CameraConfig";
            this.Text = "摄像机配置";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CMS.ResumeLayout(false);
            this.gpBHelp.ResumeLayout(false);
            this.gpBHelp.PerformLayout();
            this.FNodeStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCamera;
        private System.Windows.Forms.Label lblCIP;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.TreeView tvCameras;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtCameraName;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移ToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPasssword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox gpBHelp;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.ContextMenuStrip FNodeStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}