﻿
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
namespace System
{
    /// <summary>
    /// Summary description for InputBox.
    ///
    public class InputBoxDialogCode : System.Windows.Forms.Form
    {
        #region Windows Contols and Constructor
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtInput;
        private Label label1;

        /// <summary>
        /// Required designer variable.
        ///
        private System.ComponentModel.Container components = null;
        public InputBoxDialogCode()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponentcall
        //
}
        #endregion
        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        ///
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        ///
        private void InitializeComponent()
        {
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrompt.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(19, 13);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(288, 103);
            this.lblPrompt.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(0, 117);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(410, 26);
            this.txtInput.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(290, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 36);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(290, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please enter the clothing code";
            // 
            // InputBoxDialogCode
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(442, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBoxDialogCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CODE INPUT";
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnCancel;
        #endregion
        #region Private Variables
        string formCaption = string.Empty;
        string formPrompt = string.Empty;
        string inputResponse = string.Empty;
        string defaultValue = string.Empty;
        #endregion
        #region Public Properties
        public string FormCaption
        {
            get { return formCaption; }
            set { formCaption = value; }
        } // property FormCaption
        public string FormPrompt
        {
            get { return formPrompt; }
            set { formPrompt = value; }
        } // property FormPrompt
        public string InputResponse
        {
            get { return inputResponse; }
            set { inputResponse = value; }
        } // property InputResponse
        public string DefaultValue
        {
            get { return defaultValue; }
            set { defaultValue = value; }
        } // property DefaultValue
        #endregion
        #region Form and Control Events
        private void InputBox_Load(object sender, System.EventArgs e)
        {
            this.txtInput.Text = defaultValue;
            this.lblPrompt.Text = formPrompt;
            this.Text = formCaption;
            this.txtInput.SelectionStart = 0;
            this.txtInput.SelectionLength = this.txtInput.Text.Length;
            this.txtInput.Focus();
        }
        #endregion
        void BtnOKClick(object sender, EventArgs e)
        {
            InputResponse = this.txtInput.Text;
            this.Close();
        }
        void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

