﻿namespace hotel_system
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.sidePanel = new System.Windows.Forms.Panel();
            this.rooms_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.users_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.customers_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.book_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.logout_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.exit_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.customers1 = new hotel_system.Customers();
            this.admin_AddUser1 = new hotel_system.Admin_AddUser();
            this.admin_Rooms1 = new hotel_system.Admin_Rooms();
            this.book_Room1 = new hotel_system.Book_Room();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::hotel_system.Properties.Resources.close3;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageCheckedTracking = global::hotel_system.Properties.Resources.close3;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::hotel_system.Properties.Resources.close3;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::hotel_system.Properties.Resources.close3;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidePanel.Controls.Add(this.rooms_button);
            this.sidePanel.Controls.Add(this.users_button);
            this.sidePanel.Controls.Add(this.customers_button);
            this.sidePanel.Controls.Add(this.book_button);
            this.sidePanel.Controls.Add(this.logout_button);
            this.sidePanel.Controls.Add(this.exit_button);
            this.sidePanel.Controls.Add(this.kryptonButton1);
            this.sidePanel.Location = new System.Drawing.Point(12, 12);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(230, 527);
            this.sidePanel.TabIndex = 0;
            // 
            // rooms_button
            // 
            this.rooms_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rooms_button.Location = new System.Drawing.Point(38, 232);
            this.rooms_button.Name = "rooms_button";
            this.rooms_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.rooms_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.rooms_button.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.rooms_button.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.rooms_button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rooms_button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.rooms_button.OverrideDefault.Border.Rounding = 20;
            this.rooms_button.OverrideDefault.Border.Width = 1;
            this.rooms_button.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.rooms_button.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.rooms_button.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.rooms_button.Size = new System.Drawing.Size(154, 42);
            this.rooms_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.rooms_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.rooms_button.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.rooms_button.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.rooms_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rooms_button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.rooms_button.StateCommon.Border.Rounding = 20;
            this.rooms_button.StateCommon.Border.Width = 1;
            this.rooms_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.rooms_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.rooms_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.rooms_button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.rooms_button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.rooms_button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.rooms_button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rooms_button.StatePressed.Border.Rounding = 20;
            this.rooms_button.StatePressed.Border.Width = 1;
            this.rooms_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.rooms_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.rooms_button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.rooms_button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.rooms_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rooms_button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.rooms_button.StateTracking.Border.Rounding = 20;
            this.rooms_button.StateTracking.Border.Width = 1;
            this.rooms_button.TabIndex = 3;
            this.rooms_button.Values.Text = "R O O M S";
            this.rooms_button.Click += new System.EventHandler(this.Rooms_button_Click);
            // 
            // users_button
            // 
            this.users_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.users_button.Location = new System.Drawing.Point(38, 165);
            this.users_button.Name = "users_button";
            this.users_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.users_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.users_button.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.users_button.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.users_button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.users_button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.users_button.OverrideDefault.Border.Rounding = 20;
            this.users_button.OverrideDefault.Border.Width = 1;
            this.users_button.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.users_button.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.users_button.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.users_button.Size = new System.Drawing.Size(154, 42);
            this.users_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.users_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.users_button.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.users_button.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.users_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.users_button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.users_button.StateCommon.Border.Rounding = 20;
            this.users_button.StateCommon.Border.Width = 1;
            this.users_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.users_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.users_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.users_button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.users_button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.users_button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.users_button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.users_button.StatePressed.Border.Rounding = 20;
            this.users_button.StatePressed.Border.Width = 1;
            this.users_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.users_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.users_button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.users_button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.users_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.users_button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.users_button.StateTracking.Border.Rounding = 20;
            this.users_button.StateTracking.Border.Width = 1;
            this.users_button.TabIndex = 2;
            this.users_button.Values.Text = "U S E R S";
            this.users_button.Click += new System.EventHandler(this.Users_button_Click);
            // 
            // customers_button
            // 
            this.customers_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customers_button.Location = new System.Drawing.Point(38, 98);
            this.customers_button.Name = "customers_button";
            this.customers_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.customers_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.customers_button.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.customers_button.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.customers_button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.customers_button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.customers_button.OverrideDefault.Border.Rounding = 20;
            this.customers_button.OverrideDefault.Border.Width = 1;
            this.customers_button.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.customers_button.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.customers_button.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.customers_button.Size = new System.Drawing.Size(154, 42);
            this.customers_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.customers_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.customers_button.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.customers_button.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.customers_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.customers_button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.customers_button.StateCommon.Border.Rounding = 20;
            this.customers_button.StateCommon.Border.Width = 1;
            this.customers_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.customers_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.customers_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.customers_button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.customers_button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.customers_button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.customers_button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.customers_button.StatePressed.Border.Rounding = 20;
            this.customers_button.StatePressed.Border.Width = 1;
            this.customers_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.customers_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.customers_button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.customers_button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.customers_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.customers_button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.customers_button.StateTracking.Border.Rounding = 20;
            this.customers_button.StateTracking.Border.Width = 1;
            this.customers_button.TabIndex = 1;
            this.customers_button.Values.Text = "Customers";
            this.customers_button.Click += new System.EventHandler(this.Customers_button_Click);
            // 
            // book_button
            // 
            this.book_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.book_button.Location = new System.Drawing.Point(38, 31);
            this.book_button.Name = "book_button";
            this.book_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.book_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.book_button.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.book_button.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.book_button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.book_button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_button.OverrideDefault.Border.Rounding = 20;
            this.book_button.OverrideDefault.Border.Width = 1;
            this.book_button.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.book_button.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.book_button.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.book_button.Size = new System.Drawing.Size(154, 42);
            this.book_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.book_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.book_button.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.book_button.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.book_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.book_button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_button.StateCommon.Border.Rounding = 20;
            this.book_button.StateCommon.Border.Width = 1;
            this.book_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.book_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.book_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.book_button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.book_button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.book_button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.book_button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.book_button.StatePressed.Border.Rounding = 20;
            this.book_button.StatePressed.Border.Width = 1;
            this.book_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.book_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.book_button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.book_button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.book_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.book_button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.book_button.StateTracking.Border.Rounding = 20;
            this.book_button.StateTracking.Border.Width = 1;
            this.book_button.TabIndex = 0;
            this.book_button.Values.Text = "B O O K";
            this.book_button.Click += new System.EventHandler(this.Book_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_button.Location = new System.Drawing.Point(24, 407);
            this.logout_button.Name = "logout_button";
            this.logout_button.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.logout_button.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.logout_button.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.logout_button.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.logout_button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logout_button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_button.OverrideDefault.Border.Rounding = 20;
            this.logout_button.OverrideDefault.Border.Width = 1;
            this.logout_button.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.logout_button.Size = new System.Drawing.Size(182, 46);
            this.logout_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.logout_button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.logout_button.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.logout_button.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.logout_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logout_button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_button.StateCommon.Border.Rounding = 20;
            this.logout_button.StateCommon.Border.Width = 1;
            this.logout_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.logout_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.logout_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.logout_button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.logout_button.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.logout_button.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.logout_button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logout_button.StatePressed.Border.Rounding = 20;
            this.logout_button.StatePressed.Border.Width = 2;
            this.logout_button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.logout_button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.logout_button.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.logout_button.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.logout_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logout_button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.logout_button.StateTracking.Border.Rounding = 20;
            this.logout_button.StateTracking.Border.Width = 1;
            this.logout_button.TabIndex = 4;
            this.logout_button.Values.Text = "Logout";
            this.logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.Location = new System.Drawing.Point(24, 461);
            this.exit_button.Name = "exit_button";
            this.exit_button.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.exit_button.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            this.exit_button.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.exit_button.OverrideDefault.Border.Color2 = System.Drawing.Color.Red;
            this.exit_button.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exit_button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.exit_button.OverrideDefault.Border.Rounding = 20;
            this.exit_button.OverrideDefault.Border.Width = 1;
            this.exit_button.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.exit_button.Size = new System.Drawing.Size(182, 46);
            this.exit_button.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.exit_button.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.exit_button.StateCommon.Border.Color1 = System.Drawing.Color.Red;
            this.exit_button.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.exit_button.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exit_button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.exit_button.StateCommon.Border.Rounding = 20;
            this.exit_button.StateCommon.Border.Width = 1;
            this.exit_button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.exit_button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.exit_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.exit_button.StatePressed.Back.Color2 = System.Drawing.Color.Red;
            this.exit_button.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.exit_button.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.exit_button.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exit_button.StatePressed.Border.Rounding = 20;
            this.exit_button.StatePressed.Border.Width = 2;
            this.exit_button.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.exit_button.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.exit_button.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.exit_button.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.exit_button.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exit_button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.exit_button.StateTracking.Border.Rounding = 20;
            this.exit_button.StateTracking.Border.Width = 1;
            this.exit_button.TabIndex = 5;
            this.exit_button.Values.Text = "Exit";
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.Enabled = false;
            this.kryptonButton1.Location = new System.Drawing.Point(3, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(224, 521);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 8;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Text = "";
            // 
            // customers1
            // 
            this.customers1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.customers1.Location = new System.Drawing.Point(248, 12);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(703, 527);
            this.customers1.TabIndex = 0;
            // 
            // admin_AddUser1
            // 
            this.admin_AddUser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_AddUser1.Location = new System.Drawing.Point(248, 12);
            this.admin_AddUser1.Name = "admin_AddUser1";
            this.admin_AddUser1.Size = new System.Drawing.Size(703, 527);
            this.admin_AddUser1.TabIndex = 3;
            // 
            // admin_Rooms1
            // 
            this.admin_Rooms1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_Rooms1.Location = new System.Drawing.Point(248, 12);
            this.admin_Rooms1.Name = "admin_Rooms1";
            this.admin_Rooms1.Size = new System.Drawing.Size(703, 527);
            this.admin_Rooms1.TabIndex = 2;
            // 
            // book_Room1
            // 
            this.book_Room1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.book_Room1.Location = new System.Drawing.Point(248, 12);
            this.book_Room1.Name = "book_Room1";
            this.book_Room1.Size = new System.Drawing.Size(703, 527);
            this.book_Room1.TabIndex = 1;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(963, 551);
            this.Controls.Add(this.customers1);
            this.Controls.Add(this.admin_AddUser1);
            this.Controls.Add(this.admin_Rooms1);
            this.Controls.Add(this.book_Room1);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel sidePanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton exit_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton logout_button;
        private Book_Room book_Room1;
        private Admin_Rooms admin_Rooms1;
        private Admin_AddUser admin_AddUser1;
        private Customers customers1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton book_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton rooms_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton users_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton customers_button;
    }
}