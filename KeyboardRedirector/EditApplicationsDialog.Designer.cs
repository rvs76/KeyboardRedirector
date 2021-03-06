#region Copyright (C) 2009 Nate

/* 
 *	Copyright (C) 2009 Nate
 *	http://nate.dynalias.net
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *   
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *   
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA. 
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */

#endregion

namespace KeyboardRedirector
{
    partial class EditApplicationsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditApplicationsDialog));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageListApplicationIcons = new System.Windows.Forms.ImageList(this.components);
            this.labelFindFromWindow = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxUseExecutable = new System.Windows.Forms.CheckBox();
            this.checkBoxUseWindowTitle = new System.Windows.Forms.CheckBox();
            this.pictureBoxExeIcon = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxWindowTitle = new System.Windows.Forms.TextBox();
            this.textBoxExecutable = new System.Windows.Forms.TextBox();
            this.textBoxApplicationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewApplications = new KeyboardRedirector.BindingListView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewApplications);
            this.splitContainer1.Panel1.Controls.Add(this.labelFindFromWindow);
            this.splitContainer1.Panel1.Controls.Add(this.buttonRemove);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxUseExecutable);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxUseWindowTitle);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxExeIcon);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainer1.Panel2.Controls.Add(this.buttonOK);
            this.splitContainer1.Panel2.Controls.Add(this.buttonBrowse);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxWindowTitle);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxExecutable);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxApplicationName);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(413, 275);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 0;
            // 
            // imageListApplicationIcons
            // 
            this.imageListApplicationIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListApplicationIcons.ImageStream")));
            this.imageListApplicationIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListApplicationIcons.Images.SetKeyName(0, "DefaultApplication.png");
            this.imageListApplicationIcons.Images.SetKeyName(1, "DefaultApplicationNotFound.png");
            // 
            // labelFindFromWindow
            // 
            this.labelFindFromWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFindFromWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFindFromWindow.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.labelFindFromWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFindFromWindow.Location = new System.Drawing.Point(214, 58);
            this.labelFindFromWindow.Name = "labelFindFromWindow";
            this.labelFindFromWindow.Size = new System.Drawing.Size(187, 84);
            this.labelFindFromWindow.TabIndex = 3;
            this.labelFindFromWindow.Text = "Click here and drag to find an application from it\'s window";
            this.labelFindFromWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFindFromWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonFindFromWindow_MouseMove);
            this.labelFindFromWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFindFromWindow_MouseDown);
            this.labelFindFromWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelFindFromWindow_MouseUp);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(214, 32);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(62, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(214, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(62, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxUseExecutable
            // 
            this.checkBoxUseExecutable.AutoSize = true;
            this.checkBoxUseExecutable.Location = new System.Drawing.Point(107, 67);
            this.checkBoxUseExecutable.Name = "checkBoxUseExecutable";
            this.checkBoxUseExecutable.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUseExecutable.TabIndex = 6;
            this.checkBoxUseExecutable.UseVisualStyleBackColor = true;
            this.checkBoxUseExecutable.CheckedChanged += new System.EventHandler(this.checkBoxUseExecutable_CheckedChanged);
            // 
            // checkBoxUseWindowTitle
            // 
            this.checkBoxUseWindowTitle.AutoSize = true;
            this.checkBoxUseWindowTitle.Location = new System.Drawing.Point(107, 40);
            this.checkBoxUseWindowTitle.Name = "checkBoxUseWindowTitle";
            this.checkBoxUseWindowTitle.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUseWindowTitle.TabIndex = 3;
            this.checkBoxUseWindowTitle.UseVisualStyleBackColor = true;
            this.checkBoxUseWindowTitle.CheckedChanged += new System.EventHandler(this.checkBoxUseWindowTitle_CheckedChanged);
            // 
            // pictureBoxExeIcon
            // 
            this.pictureBoxExeIcon.Location = new System.Drawing.Point(85, 66);
            this.pictureBoxExeIcon.Name = "pictureBoxExeIcon";
            this.pictureBoxExeIcon.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxExeIcon.TabIndex = 8;
            this.pictureBoxExeIcon.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(326, 90);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(245, 90);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(373, 64);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(28, 21);
            this.buttonBrowse.TabIndex = 8;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxWindowTitle
            // 
            this.textBoxWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWindowTitle.Location = new System.Drawing.Point(128, 37);
            this.textBoxWindowTitle.Name = "textBoxWindowTitle";
            this.textBoxWindowTitle.Size = new System.Drawing.Size(239, 21);
            this.textBoxWindowTitle.TabIndex = 4;
            this.textBoxWindowTitle.TextChanged += new System.EventHandler(this.textBoxWindowTitle_TextChanged);
            this.textBoxWindowTitle.Leave += new System.EventHandler(this.textBoxExecutable_Leave);
            // 
            // textBoxExecutable
            // 
            this.textBoxExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExecutable.Location = new System.Drawing.Point(128, 64);
            this.textBoxExecutable.Name = "textBoxExecutable";
            this.textBoxExecutable.Size = new System.Drawing.Size(239, 21);
            this.textBoxExecutable.TabIndex = 7;
            this.textBoxExecutable.TextChanged += new System.EventHandler(this.textBoxExecutable_TextChanged);
            this.textBoxExecutable.Leave += new System.EventHandler(this.textBoxExecutable_Leave);
            // 
            // textBoxApplicationName
            // 
            this.textBoxApplicationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApplicationName.Location = new System.Drawing.Point(107, 10);
            this.textBoxApplicationName.Name = "textBoxApplicationName";
            this.textBoxApplicationName.Size = new System.Drawing.Size(294, 21);
            this.textBoxApplicationName.TabIndex = 1;
            this.textBoxApplicationName.TextChanged += new System.EventHandler(this.textBoxApplicationName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Window Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Executable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Application Name";
            // 
            // listViewApplications
            // 
            this.listViewApplications.AllowColumnSort = false;
            this.listViewApplications.AllowDrop = true;
            this.listViewApplications.AllowReorder = false;
            this.listViewApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewApplications.DataSource = null;
            this.listViewApplications.Filter = "";
            this.listViewApplications.FullRowSelect = true;
            this.listViewApplications.HideSelection = false;
            this.listViewApplications.Location = new System.Drawing.Point(3, 3);
            this.listViewApplications.MultiSelect = false;
            this.listViewApplications.Name = "listViewApplications";
            this.listViewApplications.OwnerDraw = true;
            this.listViewApplications.SelectedIndex = -1;
            this.listViewApplications.SelectedItem = null;
            this.listViewApplications.Size = new System.Drawing.Size(205, 139);
            this.listViewApplications.SmallImageList = this.imageListApplicationIcons;
            this.listViewApplications.TabIndex = 0;
            this.listViewApplications.UseCompatibleStateImageBehavior = false;
            this.listViewApplications.View = System.Windows.Forms.View.Details;
            this.listViewApplications.SelectedIndexChanged += new System.EventHandler(this.listViewApplications_SelectedIndexChanged);
            // 
            // EditApplicationsDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 275);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditApplicationsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Application";
            this.Load += new System.EventHandler(this.EditApplicationsDialog_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ImageList imageListApplicationIcons;
        private System.Windows.Forms.TextBox textBoxApplicationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExecutable;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonOK;
        private BindingListView listViewApplications;
        private System.Windows.Forms.Label labelFindFromWindow;
        private System.Windows.Forms.PictureBox pictureBoxExeIcon;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxUseExecutable;
        private System.Windows.Forms.CheckBox checkBoxUseWindowTitle;
        private System.Windows.Forms.TextBox textBoxWindowTitle;
        private System.Windows.Forms.Label label1;
    }
}