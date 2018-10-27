namespace b1ac
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDeletar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnSelf = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMain = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rangelol = new Bunifu.Framework.UI.BunifuRange();
            this.btnExtender = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rodar = new System.Windows.Forms.Timer(this.components);
            this.btnAC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkDeletar);
            this.panel1.Controls.Add(this.btnSelf);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMain);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // chkDeletar
            // 
            this.chkDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.chkDeletar.ChechedOffColor = System.Drawing.Color.DimGray;
            this.chkDeletar.Checked = true;
            this.chkDeletar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.chkDeletar.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.chkDeletar, "chkDeletar");
            this.chkDeletar.Name = "chkDeletar";
            // 
            // btnSelf
            // 
            this.btnSelf.Active = false;
            this.btnSelf.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnSelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            resources.ApplyResources(this.btnSelf, "btnSelf");
            this.btnSelf.BorderRadius = 5;
            this.btnSelf.ButtonText = "SelfDestruct";
            this.btnSelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelf.DisabledColor = System.Drawing.Color.Gray;
            this.btnSelf.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSelf.Iconimage = global::b1ac.Properties.Resources.round_sentiment_very_dissatisfied_white_18dp;
            this.btnSelf.Iconimage_right = null;
            this.btnSelf.Iconimage_right_Selected = null;
            this.btnSelf.Iconimage_Selected = null;
            this.btnSelf.IconMarginLeft = 0;
            this.btnSelf.IconMarginRight = 0;
            this.btnSelf.IconRightVisible = true;
            this.btnSelf.IconRightZoom = 0D;
            this.btnSelf.IconVisible = true;
            this.btnSelf.IconZoom = 65D;
            this.btnSelf.IsTab = false;
            this.btnSelf.Name = "btnSelf";
            this.btnSelf.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnSelf.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(82)))), ((int)(((byte)(181)))));
            this.btnSelf.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSelf.selected = false;
            this.btnSelf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelf.Textcolor = System.Drawing.Color.White;
            this.btnSelf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelf.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btnMain
            // 
            this.btnMain.Active = false;
            this.btnMain.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            resources.ApplyResources(this.btnMain, "btnMain");
            this.btnMain.BorderRadius = 5;
            this.btnMain.ButtonText = "Main";
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMain.DisabledColor = System.Drawing.Color.Gray;
            this.btnMain.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMain.Iconimage = global::b1ac.Properties.Resources.round_home_white_18dp;
            this.btnMain.Iconimage_right = null;
            this.btnMain.Iconimage_right_Selected = null;
            this.btnMain.Iconimage_Selected = null;
            this.btnMain.IconMarginLeft = 0;
            this.btnMain.IconMarginRight = 0;
            this.btnMain.IconRightVisible = true;
            this.btnMain.IconRightZoom = 0D;
            this.btnMain.IconVisible = true;
            this.btnMain.IconZoom = 60D;
            this.btnMain.IsTab = false;
            this.btnMain.Name = "btnMain";
            this.btnMain.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnMain.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnMain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMain.selected = false;
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMain.Textcolor = System.Drawing.Color.White;
            this.btnMain.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bunifuCheckbox1);
            this.panel2.Controls.Add(this.lblMax);
            this.panel2.Controls.Add(this.lblMin);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rangelol);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.DimGray;
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bunifuCheckbox1, "bunifuCheckbox1");
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            // 
            // lblMax
            // 
            resources.ApplyResources(this.lblMax, "lblMax");
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Name = "lblMax";
            // 
            // lblMin
            // 
            resources.ApplyResources(this.lblMin, "lblMin");
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Name = "lblMin";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // rangelol
            // 
            this.rangelol.BackColor = System.Drawing.Color.Transparent;
            this.rangelol.BackgroudColor = System.Drawing.Color.DimGray;
            this.rangelol.BorderRadius = 5;
            this.rangelol.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            resources.ApplyResources(this.rangelol, "rangelol");
            this.rangelol.MaximumRange = 21;
            this.rangelol.Name = "rangelol";
            this.rangelol.RangeMax = 10;
            this.rangelol.RangeMin = 0;
            this.rangelol.RangeChanged += new System.EventHandler(this.rangelol_RangeChanged);
            // 
            // btnExtender
            // 
            this.btnExtender.Active = false;
            this.btnExtender.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnExtender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            resources.ApplyResources(this.btnExtender, "btnExtender");
            this.btnExtender.BorderRadius = 5;
            this.btnExtender.ButtonText = ">";
            this.btnExtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtender.DisabledColor = System.Drawing.Color.Gray;
            this.btnExtender.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExtender.Iconimage = null;
            this.btnExtender.Iconimage_right = null;
            this.btnExtender.Iconimage_right_Selected = null;
            this.btnExtender.Iconimage_Selected = null;
            this.btnExtender.IconMarginLeft = 0;
            this.btnExtender.IconMarginRight = 0;
            this.btnExtender.IconRightVisible = true;
            this.btnExtender.IconRightZoom = 0D;
            this.btnExtender.IconVisible = true;
            this.btnExtender.IconZoom = 59D;
            this.btnExtender.IsTab = false;
            this.btnExtender.Name = "btnExtender";
            this.btnExtender.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnExtender.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(82)))), ((int)(((byte)(181)))));
            this.btnExtender.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExtender.selected = false;
            this.btnExtender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExtender.Textcolor = System.Drawing.Color.White;
            this.btnExtender.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtender.Click += new System.EventHandler(this.btnExtender_Click);
            // 
            // rodar
            // 
            this.rodar.Interval = 50;
            this.rodar.Tick += new System.EventHandler(this.rodar_Tick);
            // 
            // btnAC
            // 
            this.btnAC.Active = false;
            this.btnAC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            resources.ApplyResources(this.btnAC, "btnAC");
            this.btnAC.BorderRadius = 5;
            this.btnAC.ButtonText = "Autoclicker";
            this.btnAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAC.DisabledColor = System.Drawing.Color.Gray;
            this.btnAC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAC.Iconimage = global::b1ac.Properties.Resources.round_mouse_white_18dp;
            this.btnAC.Iconimage_right = null;
            this.btnAC.Iconimage_right_Selected = null;
            this.btnAC.Iconimage_Selected = null;
            this.btnAC.IconMarginLeft = 0;
            this.btnAC.IconMarginRight = 0;
            this.btnAC.IconRightVisible = true;
            this.btnAC.IconRightZoom = 0D;
            this.btnAC.IconVisible = true;
            this.btnAC.IconZoom = 59D;
            this.btnAC.IsTab = false;
            this.btnAC.Name = "btnAC";
            this.btnAC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnAC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(82)))), ((int)(((byte)(181)))));
            this.btnAC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAC.selected = false;
            this.btnAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAC.Textcolor = System.Drawing.Color.White;
            this.btnAC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // mainform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.btnExtender);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMain;
        private Bunifu.Framework.UI.BunifuFlatButton btnAC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExtender;
        private Bunifu.Framework.UI.BunifuRange rangelol;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Timer rodar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSelf;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox chkDeletar;
    }
}

