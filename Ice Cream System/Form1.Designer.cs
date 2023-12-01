namespace ICS
{
    partial class ICS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ICS));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameSurname = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.NSA = new System.Windows.Forms.GroupBox();
            this.TOM = new System.Windows.Forms.GroupBox();
            this.TOM3 = new System.Windows.Forms.RadioButton();
            this.TOM2 = new System.Windows.Forms.RadioButton();
            this.TOM1 = new System.Windows.Forms.RadioButton();
            this.Additions = new System.Windows.Forms.GroupBox();
            this.Checked4 = new System.Windows.Forms.NumericUpDown();
            this.Checked3 = new System.Windows.Forms.NumericUpDown();
            this.Checked2 = new System.Windows.Forms.NumericUpDown();
            this.Checked1 = new System.Windows.Forms.NumericUpDown();
            this.Additions1 = new System.Windows.Forms.CheckedListBox();
            this.Extra = new System.Windows.Forms.GroupBox();
            this.Extra3 = new System.Windows.Forms.RadioButton();
            this.Extra2 = new System.Windows.Forms.RadioButton();
            this.Extra1 = new System.Windows.Forms.RadioButton();
            this.COP = new System.Windows.Forms.GroupBox();
            this.COP3 = new System.Windows.Forms.NumericUpDown();
            this.COP1 = new System.Windows.Forms.TextBox();
            this.COP2 = new System.Windows.Forms.TextBox();
            this.COP4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AP = new System.Windows.Forms.GroupBox();
            this.BananaPic = new System.Windows.Forms.PictureBox();
            this.LemonPic = new System.Windows.Forms.PictureBox();
            this.ChocolatePic = new System.Windows.Forms.PictureBox();
            this.StrawberryPic = new System.Windows.Forms.PictureBox();
            this.Insert = new System.Windows.Forms.Button();
            this.NewOrder = new System.Windows.Forms.Button();
            this.NewCustomer = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.InVoice = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.GrandTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.ListView();
            this.NameSurnameC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeOfMilkC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdditionsC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtrasC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IceCreams = new System.Windows.Forms.ImageList(this.components);
            this.NSA.SuspendLayout();
            this.TOM.SuspendLayout();
            this.Additions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Checked4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checked3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checked2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checked1)).BeginInit();
            this.Extra.SuspendLayout();
            this.COP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COP3)).BeginInit();
            this.AP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BananaPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LemonPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChocolatePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrawberryPic)).BeginInit();
            this.InVoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name / Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // NameSurname
            // 
            this.NameSurname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameSurname.Location = new System.Drawing.Point(6, 49);
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.Size = new System.Drawing.Size(201, 20);
            this.NameSurname.TabIndex = 2;
            this.NameSurname.TextChanged += new System.EventHandler(this.NameSurname_TextChanged);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(9, 101);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(198, 60);
            this.Address.TabIndex = 3;
            this.Address.Tag = "";
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // NSA
            // 
            this.NSA.Controls.Add(this.NameSurname);
            this.NSA.Controls.Add(this.Address);
            this.NSA.Controls.Add(this.label1);
            this.NSA.Controls.Add(this.label2);
            this.NSA.Enabled = false;
            this.NSA.Location = new System.Drawing.Point(12, 12);
            this.NSA.Name = "NSA";
            this.NSA.Size = new System.Drawing.Size(213, 175);
            this.NSA.TabIndex = 4;
            this.NSA.TabStop = false;
            this.NSA.Text = "Customer Information";
            // 
            // TOM
            // 
            this.TOM.Controls.Add(this.TOM3);
            this.TOM.Controls.Add(this.TOM2);
            this.TOM.Controls.Add(this.TOM1);
            this.TOM.Enabled = false;
            this.TOM.Location = new System.Drawing.Point(12, 193);
            this.TOM.Name = "TOM";
            this.TOM.Size = new System.Drawing.Size(213, 65);
            this.TOM.TabIndex = 5;
            this.TOM.TabStop = false;
            this.TOM.Text = "Type Of Milk";
            this.TOM.Enter += new System.EventHandler(this.TOM_Enter);
            // 
            // TOM3
            // 
            this.TOM3.AutoSize = true;
            this.TOM3.Location = new System.Drawing.Point(128, 30);
            this.TOM3.Name = "TOM3";
            this.TOM3.Size = new System.Drawing.Size(40, 17);
            this.TOM3.TabIndex = 2;
            this.TOM3.TabStop = true;
            this.TOM3.Text = "Fat";
            this.TOM3.UseVisualStyleBackColor = true;
            this.TOM3.CheckedChanged += new System.EventHandler(this.TOM3_CheckedChanged);
            // 
            // TOM2
            // 
            this.TOM2.AutoSize = true;
            this.TOM2.Location = new System.Drawing.Point(59, 30);
            this.TOM2.Name = "TOM2";
            this.TOM2.Size = new System.Drawing.Size(63, 17);
            this.TOM2.TabIndex = 1;
            this.TOM2.TabStop = true;
            this.TOM2.Text = "Low Fat";
            this.TOM2.UseVisualStyleBackColor = true;
            this.TOM2.CheckedChanged += new System.EventHandler(this.TOM2_CheckedChanged);
            // 
            // TOM1
            // 
            this.TOM1.AutoSize = true;
            this.TOM1.Location = new System.Drawing.Point(9, 30);
            this.TOM1.Name = "TOM1";
            this.TOM1.Size = new System.Drawing.Size(44, 17);
            this.TOM1.TabIndex = 0;
            this.TOM1.TabStop = true;
            this.TOM1.Text = "Diet";
            this.TOM1.UseVisualStyleBackColor = true;
            this.TOM1.CheckedChanged += new System.EventHandler(this.TOM1_CheckedChanged);
            // 
            // Additions
            // 
            this.Additions.Controls.Add(this.Checked4);
            this.Additions.Controls.Add(this.Checked3);
            this.Additions.Controls.Add(this.Checked2);
            this.Additions.Controls.Add(this.Checked1);
            this.Additions.Controls.Add(this.Additions1);
            this.Additions.Enabled = false;
            this.Additions.Location = new System.Drawing.Point(12, 264);
            this.Additions.Name = "Additions";
            this.Additions.Size = new System.Drawing.Size(213, 128);
            this.Additions.TabIndex = 6;
            this.Additions.TabStop = false;
            this.Additions.Text = "Additions";
            this.Additions.EnabledChanged += new System.EventHandler(this.TOM_Enter);
            this.Additions.Enter += new System.EventHandler(this.Additions_Enter);
            // 
            // Checked4
            // 
            this.Checked4.Enabled = false;
            this.Checked4.Location = new System.Drawing.Point(142, 94);
            this.Checked4.Name = "Checked4";
            this.Checked4.Size = new System.Drawing.Size(65, 20);
            this.Checked4.TabIndex = 18;
            this.Checked4.ValueChanged += new System.EventHandler(this.Checked4_ValueChanged);
            // 
            // Checked3
            // 
            this.Checked3.Enabled = false;
            this.Checked3.Location = new System.Drawing.Point(142, 68);
            this.Checked3.Name = "Checked3";
            this.Checked3.Size = new System.Drawing.Size(65, 20);
            this.Checked3.TabIndex = 17;
            this.Checked3.ValueChanged += new System.EventHandler(this.Checked3_ValueChanged);
            // 
            // Checked2
            // 
            this.Checked2.Enabled = false;
            this.Checked2.Location = new System.Drawing.Point(142, 42);
            this.Checked2.Name = "Checked2";
            this.Checked2.Size = new System.Drawing.Size(65, 20);
            this.Checked2.TabIndex = 16;
            this.Checked2.ValueChanged += new System.EventHandler(this.Checked2_ValueChanged);
            // 
            // Checked1
            // 
            this.Checked1.Enabled = false;
            this.Checked1.Location = new System.Drawing.Point(142, 16);
            this.Checked1.Name = "Checked1";
            this.Checked1.Size = new System.Drawing.Size(65, 20);
            this.Checked1.TabIndex = 15;
            this.Checked1.ValueChanged += new System.EventHandler(this.Checked1_ValueChanged);
            // 
            // Additions1
            // 
            this.Additions1.FormattingEnabled = true;
            this.Additions1.Items.AddRange(new object[] {
            "Ice Lemon",
            "Ice Banana",
            "Ice Strawberry",
            "Ice Chocolate"});
            this.Additions1.Location = new System.Drawing.Point(3, 16);
            this.Additions1.Name = "Additions1";
            this.Additions1.Size = new System.Drawing.Size(133, 64);
            this.Additions1.TabIndex = 0;
            this.Additions1.SelectedIndexChanged += new System.EventHandler(this.Additions1_SelectedIndexChanged);
            // 
            // Extra
            // 
            this.Extra.Controls.Add(this.Extra3);
            this.Extra.Controls.Add(this.Extra2);
            this.Extra.Controls.Add(this.Extra1);
            this.Extra.Enabled = false;
            this.Extra.Location = new System.Drawing.Point(12, 398);
            this.Extra.Name = "Extra";
            this.Extra.Size = new System.Drawing.Size(94, 111);
            this.Extra.TabIndex = 7;
            this.Extra.TabStop = false;
            this.Extra.Text = "Extra";
            this.Extra.EnabledChanged += new System.EventHandler(this.TOM_Enter);
            // 
            // Extra3
            // 
            this.Extra3.AutoSize = true;
            this.Extra3.Location = new System.Drawing.Point(6, 76);
            this.Extra3.Name = "Extra3";
            this.Extra3.Size = new System.Drawing.Size(70, 17);
            this.Extra3.TabIndex = 2;
            this.Extra3.TabStop = true;
            this.Extra3.Text = "AntepNut";
            this.Extra3.UseVisualStyleBackColor = true;
            this.Extra3.CheckedChanged += new System.EventHandler(this.Extra3_CheckedChanged);
            // 
            // Extra2
            // 
            this.Extra2.AutoSize = true;
            this.Extra2.Location = new System.Drawing.Point(6, 53);
            this.Extra2.Name = "Extra2";
            this.Extra2.Size = new System.Drawing.Size(69, 17);
            this.Extra2.TabIndex = 1;
            this.Extra2.TabStop = true;
            this.Extra2.Text = "HazelNut";
            this.Extra2.UseVisualStyleBackColor = true;
            this.Extra2.CheckedChanged += new System.EventHandler(this.Extra2_CheckedChanged);
            // 
            // Extra1
            // 
            this.Extra1.AutoSize = true;
            this.Extra1.Location = new System.Drawing.Point(6, 30);
            this.Extra1.Name = "Extra1";
            this.Extra1.Size = new System.Drawing.Size(61, 17);
            this.Extra1.TabIndex = 0;
            this.Extra1.TabStop = true;
            this.Extra1.Text = "PeaNut";
            this.Extra1.UseVisualStyleBackColor = true;
            this.Extra1.CheckedChanged += new System.EventHandler(this.Extra1_CheckedChanged);
            // 
            // COP
            // 
            this.COP.Controls.Add(this.COP3);
            this.COP.Controls.Add(this.COP1);
            this.COP.Controls.Add(this.COP2);
            this.COP.Controls.Add(this.COP4);
            this.COP.Controls.Add(this.label6);
            this.COP.Controls.Add(this.label3);
            this.COP.Controls.Add(this.label4);
            this.COP.Controls.Add(this.label5);
            this.COP.Enabled = false;
            this.COP.Location = new System.Drawing.Point(118, 398);
            this.COP.Name = "COP";
            this.COP.Size = new System.Drawing.Size(118, 111);
            this.COP.TabIndex = 8;
            this.COP.TabStop = false;
            this.COP.Text = "Calori and Price";
            this.COP.EnabledChanged += new System.EventHandler(this.TOM_Enter);
            // 
            // COP3
            // 
            this.COP3.Location = new System.Drawing.Point(68, 57);
            this.COP3.Name = "COP3";
            this.COP3.Size = new System.Drawing.Size(44, 20);
            this.COP3.TabIndex = 19;
            this.COP3.ValueChanged += new System.EventHandler(this.COP3_ValueChanged);
            // 
            // COP1
            // 
            this.COP1.Location = new System.Drawing.Point(68, 12);
            this.COP1.Name = "COP1";
            this.COP1.ReadOnly = true;
            this.COP1.Size = new System.Drawing.Size(44, 20);
            this.COP1.TabIndex = 9;
            this.COP1.Text = "0";
            this.COP1.TextChanged += new System.EventHandler(this.COP1_TextChanged);
            // 
            // COP2
            // 
            this.COP2.Location = new System.Drawing.Point(68, 34);
            this.COP2.Name = "COP2";
            this.COP2.ReadOnly = true;
            this.COP2.Size = new System.Drawing.Size(45, 20);
            this.COP2.TabIndex = 10;
            this.COP2.Text = "0";
            this.COP2.TextChanged += new System.EventHandler(this.COP2_TextChanged);
            // 
            // COP4
            // 
            this.COP4.Location = new System.Drawing.Point(68, 81);
            this.COP4.Name = "COP4";
            this.COP4.ReadOnly = true;
            this.COP4.Size = new System.Drawing.Size(44, 20);
            this.COP4.TabIndex = 11;
            this.COP4.Text = "0";
            this.COP4.TextChanged += new System.EventHandler(this.COP4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unit Calori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount";
            // 
            // AP
            // 
            this.AP.Controls.Add(this.BananaPic);
            this.AP.Controls.Add(this.LemonPic);
            this.AP.Controls.Add(this.ChocolatePic);
            this.AP.Controls.Add(this.StrawberryPic);
            this.AP.Location = new System.Drawing.Point(313, 34);
            this.AP.Name = "AP";
            this.AP.Size = new System.Drawing.Size(114, 120);
            this.AP.TabIndex = 9;
            this.AP.TabStop = false;
            this.AP.Text = "Additions Pictures";
            // 
            // BananaPic
            // 
            this.BananaPic.Location = new System.Drawing.Point(56, 19);
            this.BananaPic.Name = "BananaPic";
            this.BananaPic.Size = new System.Drawing.Size(44, 44);
            this.BananaPic.TabIndex = 18;
            this.BananaPic.TabStop = false;
            // 
            // LemonPic
            // 
            this.LemonPic.Location = new System.Drawing.Point(6, 19);
            this.LemonPic.Name = "LemonPic";
            this.LemonPic.Size = new System.Drawing.Size(44, 44);
            this.LemonPic.TabIndex = 15;
            this.LemonPic.TabStop = false;
            // 
            // ChocolatePic
            // 
            this.ChocolatePic.Location = new System.Drawing.Point(56, 69);
            this.ChocolatePic.Name = "ChocolatePic";
            this.ChocolatePic.Size = new System.Drawing.Size(44, 44);
            this.ChocolatePic.TabIndex = 17;
            this.ChocolatePic.TabStop = false;
            // 
            // StrawberryPic
            // 
            this.StrawberryPic.Location = new System.Drawing.Point(6, 70);
            this.StrawberryPic.Name = "StrawberryPic";
            this.StrawberryPic.Size = new System.Drawing.Size(44, 44);
            this.StrawberryPic.TabIndex = 16;
            this.StrawberryPic.TabStop = false;
            // 
            // Insert
            // 
            this.Insert.Enabled = false;
            this.Insert.Location = new System.Drawing.Point(313, 214);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 35);
            this.Insert.TabIndex = 10;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.EnabledChanged += new System.EventHandler(this.TOM_Enter);
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // NewOrder
            // 
            this.NewOrder.Enabled = false;
            this.NewOrder.Location = new System.Drawing.Point(413, 214);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(75, 35);
            this.NewOrder.TabIndex = 11;
            this.NewOrder.Text = "New Order";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.EnabledChanged += new System.EventHandler(this.TOM_Enter);
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // NewCustomer
            // 
            this.NewCustomer.Location = new System.Drawing.Point(512, 214);
            this.NewCustomer.Name = "NewCustomer";
            this.NewCustomer.Size = new System.Drawing.Size(75, 35);
            this.NewCustomer.TabIndex = 12;
            this.NewCustomer.Text = "New Customer";
            this.NewCustomer.UseVisualStyleBackColor = true;
            this.NewCustomer.Click += new System.EventHandler(this.NewCustomer_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(644, 214);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 35);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // InVoice
            // 
            this.InVoice.Controls.Add(this.Delete);
            this.InVoice.Controls.Add(this.GrandTotal);
            this.InVoice.Controls.Add(this.label7);
            this.InVoice.Controls.Add(this.List);
            this.InVoice.Enabled = false;
            this.InVoice.Location = new System.Drawing.Point(313, 306);
            this.InVoice.Name = "InVoice";
            this.InVoice.Size = new System.Drawing.Size(446, 203);
            this.InVoice.TabIndex = 14;
            this.InVoice.TabStop = false;
            this.InVoice.Text = "InVoice";
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(63, 143);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 23);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // GrandTotal
            // 
            this.GrandTotal.Location = new System.Drawing.Point(331, 145);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.ReadOnly = true;
            this.GrandTotal.Size = new System.Drawing.Size(100, 20);
            this.GrandTotal.TabIndex = 11;
            this.GrandTotal.Text = "0";
            this.GrandTotal.TextChanged += new System.EventHandler(this.GrandTotal_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Grand Total";
            // 
            // List
            // 
            this.List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameSurnameC,
            this.TypeOfMilkC,
            this.AdditionsC,
            this.ExtrasC,
            this.AmountC,
            this.TotalPriceC});
            this.List.HideSelection = false;
            this.List.Location = new System.Drawing.Point(6, 19);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(434, 97);
            this.List.TabIndex = 9;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // NameSurnameC
            // 
            this.NameSurnameC.Text = "Name / Surname";
            this.NameSurnameC.Width = 100;
            // 
            // TypeOfMilkC
            // 
            this.TypeOfMilkC.Text = "TOM";
            this.TypeOfMilkC.Width = 50;
            // 
            // AdditionsC
            // 
            this.AdditionsC.Text = "Additions";
            this.AdditionsC.Width = 120;
            // 
            // ExtrasC
            // 
            this.ExtrasC.Text = "Extras";
            // 
            // AmountC
            // 
            this.AmountC.Text = "Amount";
            this.AmountC.Width = 50;
            // 
            // TotalPriceC
            // 
            this.TotalPriceC.Text = "Total";
            this.TotalPriceC.Width = 50;
            // 
            // IceCreams
            // 
            this.IceCreams.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IceCreams.ImageStream")));
            this.IceCreams.TransparentColor = System.Drawing.Color.Transparent;
            this.IceCreams.Images.SetKeyName(0, "Lemon");
            this.IceCreams.Images.SetKeyName(1, "Banana");
            this.IceCreams.Images.SetKeyName(2, "Strawberry");
            this.IceCreams.Images.SetKeyName(3, "Chocolate");
            // 
            // ICS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.InVoice);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewCustomer);
            this.Controls.Add(this.NewOrder);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.AP);
            this.Controls.Add(this.COP);
            this.Controls.Add(this.Extra);
            this.Controls.Add(this.Additions);
            this.Controls.Add(this.TOM);
            this.Controls.Add(this.NSA);
            this.Name = "ICS";
            this.Text = "Ice Cream System";
            this.Load += new System.EventHandler(this.ICS_Load);
            this.NSA.ResumeLayout(false);
            this.NSA.PerformLayout();
            this.TOM.ResumeLayout(false);
            this.TOM.PerformLayout();
            this.Additions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Checked4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checked3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checked2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checked1)).EndInit();
            this.Extra.ResumeLayout(false);
            this.Extra.PerformLayout();
            this.COP.ResumeLayout(false);
            this.COP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COP3)).EndInit();
            this.AP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BananaPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LemonPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChocolatePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrawberryPic)).EndInit();
            this.InVoice.ResumeLayout(false);
            this.InVoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameSurname;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.GroupBox NSA;
        private System.Windows.Forms.GroupBox TOM;
        private System.Windows.Forms.RadioButton TOM1;
        private System.Windows.Forms.GroupBox Additions;
        private System.Windows.Forms.RadioButton TOM3;
        private System.Windows.Forms.RadioButton TOM2;
        private System.Windows.Forms.CheckedListBox Additions1;
        private System.Windows.Forms.GroupBox Extra;
        private System.Windows.Forms.RadioButton Extra3;
        private System.Windows.Forms.RadioButton Extra2;
        private System.Windows.Forms.RadioButton Extra1;
        private System.Windows.Forms.GroupBox COP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox COP1;
        private System.Windows.Forms.TextBox COP2;
        private System.Windows.Forms.TextBox COP4;
        private System.Windows.Forms.GroupBox AP;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button NewCustomer;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox InVoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView List;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox GrandTotal;
        private System.Windows.Forms.ImageList IceCreams;
        private System.Windows.Forms.PictureBox BananaPic;
        private System.Windows.Forms.PictureBox LemonPic;
        private System.Windows.Forms.PictureBox ChocolatePic;
        private System.Windows.Forms.PictureBox StrawberryPic;
        private System.Windows.Forms.NumericUpDown Checked4;
        private System.Windows.Forms.NumericUpDown Checked3;
        private System.Windows.Forms.NumericUpDown Checked2;
        private System.Windows.Forms.NumericUpDown Checked1;
        private System.Windows.Forms.NumericUpDown COP3;
        private System.Windows.Forms.ColumnHeader NameSurnameC;
        private System.Windows.Forms.ColumnHeader AdditionsC;
        private System.Windows.Forms.ColumnHeader ExtrasC;
        private System.Windows.Forms.ColumnHeader AmountC;
        private System.Windows.Forms.ColumnHeader TotalPriceC;
        private System.Windows.Forms.ColumnHeader TypeOfMilkC;
    }
}

