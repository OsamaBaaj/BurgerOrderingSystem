namespace SomeProjects
{
    partial class frmBurger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBurger));
            this.pnCookingLevels = new System.Windows.Forms.Panel();
            this.lbCookingLevels = new System.Windows.Forms.Label();
            this.rbWell = new System.Windows.Forms.RadioButton();
            this.rbMediumWell = new System.Windows.Forms.RadioButton();
            this.rbMediumRare = new System.Windows.Forms.RadioButton();
            this.rbRare = new System.Windows.Forms.RadioButton();
            this.pnToppings = new System.Windows.Forms.Panel();
            this.lbToppings = new System.Windows.Forms.Label();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.pnWhereToEat = new System.Windows.Forms.Panel();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.cbWhereToEat = new System.Windows.Forms.ComboBox();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnQuantity = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.errPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbOrderSummary = new System.Windows.Forms.Label();
            this.pnSummary = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbQuantity_Summary = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPhoneNumber_Summary = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAddress_Summary = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbWhereToEat_Summary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWhatToppings_Summary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbWhatCookingLevel_Summary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCookingLevels.SuspendLayout();
            this.pnToppings.SuspendLayout();
            this.pnWhereToEat.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhoneNumber)).BeginInit();
            this.pnSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCookingLevels
            // 
            this.pnCookingLevels.BackColor = System.Drawing.Color.Transparent;
            this.pnCookingLevels.Controls.Add(this.lbCookingLevels);
            this.pnCookingLevels.Controls.Add(this.rbWell);
            this.pnCookingLevels.Controls.Add(this.rbMediumWell);
            this.pnCookingLevels.Controls.Add(this.rbMediumRare);
            this.pnCookingLevels.Controls.Add(this.rbRare);
            this.pnCookingLevels.Font = new System.Drawing.Font("Tahoma", 14F);
            this.pnCookingLevels.Location = new System.Drawing.Point(16, 17);
            this.pnCookingLevels.Name = "pnCookingLevels";
            this.pnCookingLevels.Size = new System.Drawing.Size(214, 215);
            this.pnCookingLevels.TabIndex = 0;
            // 
            // lbCookingLevels
            // 
            this.lbCookingLevels.AutoSize = true;
            this.lbCookingLevels.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCookingLevels.ForeColor = System.Drawing.Color.White;
            this.lbCookingLevels.Location = new System.Drawing.Point(4, 13);
            this.lbCookingLevels.Name = "lbCookingLevels";
            this.lbCookingLevels.Size = new System.Drawing.Size(186, 49);
            this.lbCookingLevels.TabIndex = 4;
            this.lbCookingLevels.Text = "Cooking Level";
            // 
            // rbWell
            // 
            this.rbWell.AutoSize = true;
            this.rbWell.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWell.ForeColor = System.Drawing.Color.White;
            this.rbWell.Location = new System.Drawing.Point(10, 168);
            this.rbWell.Name = "rbWell";
            this.rbWell.Size = new System.Drawing.Size(88, 49);
            this.rbWell.TabIndex = 3;
            this.rbWell.Tag = "7";
            this.rbWell.Text = "Well";
            this.rbWell.UseVisualStyleBackColor = true;
            this.rbWell.CheckedChanged += new System.EventHandler(this.CookingLevelCheckedChanged);
            // 
            // rbMediumWell
            // 
            this.rbMediumWell.AutoSize = true;
            this.rbMediumWell.Checked = true;
            this.rbMediumWell.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMediumWell.ForeColor = System.Drawing.Color.White;
            this.rbMediumWell.Location = new System.Drawing.Point(10, 135);
            this.rbMediumWell.Name = "rbMediumWell";
            this.rbMediumWell.Size = new System.Drawing.Size(184, 49);
            this.rbMediumWell.TabIndex = 2;
            this.rbMediumWell.TabStop = true;
            this.rbMediumWell.Tag = "6";
            this.rbMediumWell.Text = "Medium Well";
            this.rbMediumWell.UseVisualStyleBackColor = true;
            this.rbMediumWell.CheckedChanged += new System.EventHandler(this.CookingLevelCheckedChanged);
            // 
            // rbMediumRare
            // 
            this.rbMediumRare.AutoSize = true;
            this.rbMediumRare.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMediumRare.ForeColor = System.Drawing.Color.White;
            this.rbMediumRare.Location = new System.Drawing.Point(10, 102);
            this.rbMediumRare.Name = "rbMediumRare";
            this.rbMediumRare.Size = new System.Drawing.Size(186, 49);
            this.rbMediumRare.TabIndex = 1;
            this.rbMediumRare.Tag = "5";
            this.rbMediumRare.Text = "Medium Rare";
            this.rbMediumRare.UseVisualStyleBackColor = true;
            this.rbMediumRare.CheckedChanged += new System.EventHandler(this.CookingLevelCheckedChanged);
            // 
            // rbRare
            // 
            this.rbRare.AutoSize = true;
            this.rbRare.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRare.ForeColor = System.Drawing.Color.White;
            this.rbRare.Location = new System.Drawing.Point(10, 69);
            this.rbRare.Name = "rbRare";
            this.rbRare.Size = new System.Drawing.Size(90, 49);
            this.rbRare.TabIndex = 0;
            this.rbRare.Tag = "4";
            this.rbRare.Text = "Rare";
            this.rbRare.UseVisualStyleBackColor = true;
            this.rbRare.CheckedChanged += new System.EventHandler(this.CookingLevelCheckedChanged);
            // 
            // pnToppings
            // 
            this.pnToppings.BackColor = System.Drawing.Color.Transparent;
            this.pnToppings.Controls.Add(this.lbToppings);
            this.pnToppings.Controls.Add(this.chkCheese);
            this.pnToppings.Controls.Add(this.chkTomatoes);
            this.pnToppings.Controls.Add(this.chkLettuce);
            this.pnToppings.Font = new System.Drawing.Font("Tahoma", 20F);
            this.pnToppings.Location = new System.Drawing.Point(235, 17);
            this.pnToppings.Name = "pnToppings";
            this.pnToppings.Size = new System.Drawing.Size(181, 205);
            this.pnToppings.TabIndex = 4;
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.ForeColor = System.Drawing.Color.White;
            this.lbToppings.Location = new System.Drawing.Point(3, 13);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(132, 49);
            this.lbToppings.TabIndex = 5;
            this.lbToppings.Text = "Toppings";
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.BackColor = System.Drawing.Color.Transparent;
            this.chkCheese.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheese.ForeColor = System.Drawing.Color.White;
            this.chkCheese.Location = new System.Drawing.Point(15, 136);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(118, 49);
            this.chkCheese.TabIndex = 2;
            this.chkCheese.Tag = "3";
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = false;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.ToppingsCheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.ForeColor = System.Drawing.Color.White;
            this.chkTomatoes.Location = new System.Drawing.Point(15, 103);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(152, 37);
            this.chkTomatoes.TabIndex = 1;
            this.chkTomatoes.Tag = "2";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.ToppingsCheckedChanged);
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLettuce.ForeColor = System.Drawing.Color.White;
            this.chkLettuce.Location = new System.Drawing.Point(15, 65);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(124, 49);
            this.chkLettuce.TabIndex = 0;
            this.chkLettuce.Tag = "2";
            this.chkLettuce.Text = "Lettuce";
            this.chkLettuce.UseVisualStyleBackColor = true;
            this.chkLettuce.CheckedChanged += new System.EventHandler(this.ToppingsCheckedChanged);
            // 
            // pnWhereToEat
            // 
            this.pnWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.pnWhereToEat.Controls.Add(this.lbAddress);
            this.pnWhereToEat.Controls.Add(this.tbPhoneNumber);
            this.pnWhereToEat.Controls.Add(this.lbPhoneNumber);
            this.pnWhereToEat.Controls.Add(this.tbAddress);
            this.pnWhereToEat.Controls.Add(this.cbWhereToEat);
            this.pnWhereToEat.Controls.Add(this.lbWhereToEat);
            this.pnWhereToEat.Font = new System.Drawing.Font("Tahoma", 14F);
            this.pnWhereToEat.Location = new System.Drawing.Point(16, 238);
            this.pnWhereToEat.Name = "pnWhereToEat";
            this.pnWhereToEat.Size = new System.Drawing.Size(337, 241);
            this.pnWhereToEat.TabIndex = 4;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.White;
            this.lbAddress.Location = new System.Drawing.Point(24, 67);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(86, 36);
            this.lbAddress.TabIndex = 10;
            this.lbAddress.Text = "Address";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(30, 178);
            this.tbPhoneNumber.Mask = "0000000000";
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(269, 30);
            this.tbPhoneNumber.TabIndex = 12;
            this.tbPhoneNumber.ValidatingType = typeof(int);
            this.tbPhoneNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbPhoneNumber_MaskInputRejected);
            this.tbPhoneNumber.Click += new System.EventHandler(this.tbPhoneNumber_Click);
            this.tbPhoneNumber.Enter += new System.EventHandler(this.tbPhoneNumber_Enter);
            this.tbPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhoneNumber_Error);
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lbPhoneNumber.Location = new System.Drawing.Point(24, 139);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(146, 36);
            this.lbPhoneNumber.TabIndex = 11;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.White;
            this.tbAddress.Location = new System.Drawing.Point(30, 106);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(269, 30);
            this.tbAddress.TabIndex = 8;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // cbWhereToEat
            // 
            this.cbWhereToEat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWhereToEat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbWhereToEat.FormattingEnabled = true;
            this.cbWhereToEat.Items.AddRange(new object[] {
            "Inside",
            "Take Away",
            "Delivery"});
            this.cbWhereToEat.Location = new System.Drawing.Point(194, 17);
            this.cbWhereToEat.Name = "cbWhereToEat";
            this.cbWhereToEat.Size = new System.Drawing.Size(105, 27);
            this.cbWhereToEat.TabIndex = 7;
            this.cbWhereToEat.SelectedIndexChanged += new System.EventHandler(this.cbWhereToEat_SelectedIndexChanged);
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.ForeColor = System.Drawing.Color.White;
            this.lbWhereToEat.Location = new System.Drawing.Point(1, 3);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(187, 49);
            this.lbWhereToEat.TabIndex = 6;
            this.lbWhereToEat.Text = "Where To Eat";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.nudQuantity);
            this.panel4.Controls.Add(this.pnQuantity);
            this.panel4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.panel4.Location = new System.Drawing.Point(16, 485);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 57);
            this.panel4.TabIndex = 8;
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.White;
            this.nudQuantity.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(138, 14);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(65, 40);
            this.nudQuantity.TabIndex = 7;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // pnQuantity
            // 
            this.pnQuantity.AutoSize = true;
            this.pnQuantity.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnQuantity.ForeColor = System.Drawing.Color.White;
            this.pnQuantity.Location = new System.Drawing.Point(4, 5);
            this.pnQuantity.Name = "pnQuantity";
            this.pnQuantity.Size = new System.Drawing.Size(128, 49);
            this.pnQuantity.TabIndex = 6;
            this.pnQuantity.Text = "Quantity";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lbTotalPrice.Location = new System.Drawing.Point(199, 478);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(50, 45);
            this.lbTotalPrice.TabIndex = 10;
            this.lbTotalPrice.Text = "0$";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errPhoneNumber
            // 
            this.errPhoneNumber.ContainerControl = this;
            // 
            // lbOrderSummary
            // 
            this.lbOrderSummary.AutoSize = true;
            this.lbOrderSummary.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderSummary.ForeColor = System.Drawing.Color.White;
            this.lbOrderSummary.Location = new System.Drawing.Point(54, 7);
            this.lbOrderSummary.Name = "lbOrderSummary";
            this.lbOrderSummary.Size = new System.Drawing.Size(209, 49);
            this.lbOrderSummary.TabIndex = 11;
            this.lbOrderSummary.Text = "Order Summary";
            // 
            // pnSummary
            // 
            this.pnSummary.BackColor = System.Drawing.Color.Transparent;
            this.pnSummary.Controls.Add(this.label6);
            this.pnSummary.Controls.Add(this.lbQuantity_Summary);
            this.pnSummary.Controls.Add(this.lbTotalPrice);
            this.pnSummary.Controls.Add(this.label7);
            this.pnSummary.Controls.Add(this.lbPhoneNumber_Summary);
            this.pnSummary.Controls.Add(this.label8);
            this.pnSummary.Controls.Add(this.lbAddress_Summary);
            this.pnSummary.Controls.Add(this.label5);
            this.pnSummary.Controls.Add(this.lbWhereToEat_Summary);
            this.pnSummary.Controls.Add(this.label3);
            this.pnSummary.Controls.Add(this.lbWhatToppings_Summary);
            this.pnSummary.Controls.Add(this.label4);
            this.pnSummary.Controls.Add(this.lbWhatCookingLevel_Summary);
            this.pnSummary.Controls.Add(this.label1);
            this.pnSummary.Controls.Add(this.lbOrderSummary);
            this.pnSummary.Font = new System.Drawing.Font("Tahoma", 20F);
            this.pnSummary.Location = new System.Drawing.Point(1015, 30);
            this.pnSummary.Name = "pnSummary";
            this.pnSummary.Size = new System.Drawing.Size(307, 535);
            this.pnSummary.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 45);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total Price:";
            // 
            // lbQuantity_Summary
            // 
            this.lbQuantity_Summary.AutoSize = true;
            this.lbQuantity_Summary.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity_Summary.ForeColor = System.Drawing.Color.White;
            this.lbQuantity_Summary.Location = new System.Drawing.Point(139, 406);
            this.lbQuantity_Summary.Name = "lbQuantity_Summary";
            this.lbQuantity_Summary.Size = new System.Drawing.Size(29, 40);
            this.lbQuantity_Summary.TabIndex = 22;
            this.lbQuantity_Summary.Text = "n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 45);
            this.label7.TabIndex = 21;
            this.label7.Text = "Quantity :";
            // 
            // lbPhoneNumber_Summary
            // 
            this.lbPhoneNumber_Summary.AutoSize = true;
            this.lbPhoneNumber_Summary.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber_Summary.ForeColor = System.Drawing.Color.White;
            this.lbPhoneNumber_Summary.Location = new System.Drawing.Point(17, 368);
            this.lbPhoneNumber_Summary.Name = "lbPhoneNumber_Summary";
            this.lbPhoneNumber_Summary.Size = new System.Drawing.Size(29, 40);
            this.lbPhoneNumber_Summary.TabIndex = 20;
            this.lbPhoneNumber_Summary.Text = "n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 45);
            this.label8.TabIndex = 19;
            this.label8.Text = "Phone Number : ";
            // 
            // lbAddress_Summary
            // 
            this.lbAddress_Summary.AutoSize = true;
            this.lbAddress_Summary.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress_Summary.ForeColor = System.Drawing.Color.White;
            this.lbAddress_Summary.Location = new System.Drawing.Point(17, 292);
            this.lbAddress_Summary.Name = "lbAddress_Summary";
            this.lbAddress_Summary.Size = new System.Drawing.Size(29, 40);
            this.lbAddress_Summary.TabIndex = 18;
            this.lbAddress_Summary.Text = "n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 45);
            this.label5.TabIndex = 17;
            this.label5.Text = "Address : ";
            // 
            // lbWhereToEat_Summary
            // 
            this.lbWhereToEat_Summary.AutoSize = true;
            this.lbWhereToEat_Summary.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat_Summary.ForeColor = System.Drawing.Color.White;
            this.lbWhereToEat_Summary.Location = new System.Drawing.Point(190, 211);
            this.lbWhereToEat_Summary.Name = "lbWhereToEat_Summary";
            this.lbWhereToEat_Summary.Size = new System.Drawing.Size(29, 40);
            this.lbWhereToEat_Summary.TabIndex = 16;
            this.lbWhereToEat_Summary.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "Where To Eat : ";
            // 
            // lbWhatToppings_Summary
            // 
            this.lbWhatToppings_Summary.AutoSize = true;
            this.lbWhatToppings_Summary.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhatToppings_Summary.ForeColor = System.Drawing.Color.White;
            this.lbWhatToppings_Summary.Location = new System.Drawing.Point(17, 176);
            this.lbWhatToppings_Summary.Name = "lbWhatToppings_Summary";
            this.lbWhatToppings_Summary.Size = new System.Drawing.Size(29, 40);
            this.lbWhatToppings_Summary.TabIndex = 14;
            this.lbWhatToppings_Summary.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 45);
            this.label4.TabIndex = 13;
            this.label4.Text = "Toppings :";
            // 
            // lbWhatCookingLevel_Summary
            // 
            this.lbWhatCookingLevel_Summary.AutoSize = true;
            this.lbWhatCookingLevel_Summary.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhatCookingLevel_Summary.ForeColor = System.Drawing.Color.White;
            this.lbWhatCookingLevel_Summary.Location = new System.Drawing.Point(108, 89);
            this.lbWhatCookingLevel_Summary.Name = "lbWhatCookingLevel_Summary";
            this.lbWhatCookingLevel_Summary.Size = new System.Drawing.Size(29, 40);
            this.lbWhatCookingLevel_Summary.TabIndex = 12;
            this.lbWhatCookingLevel_Summary.Text = "n";
            this.lbWhatCookingLevel_Summary.Click += new System.EventHandler(this.lbWhatCookingLevel_Summary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cooking Level :";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.LawnGreen;
            this.btnOrder.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(678, 553);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(128, 44);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnOrder.MouseLeave += new System.EventHandler(this.btnOrder_MouseLeave);
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.BackColor = System.Drawing.Color.Silver;
            this.btnResetOrder.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetOrder.Location = new System.Drawing.Point(525, 553);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(147, 44);
            this.btnResetOrder.TabIndex = 11;
            this.btnResetOrder.Text = "Reset Order";
            this.btnResetOrder.UseVisualStyleBackColor = false;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            this.btnResetOrder.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnResetOrder.MouseLeave += new System.EventHandler(this.btnResetOrder_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(454, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 40);
            this.label2.TabIndex = 24;
            this.label2.Text = "Osama\'s Burgers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmBurger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SomeProjects.Properties.Resources.NormalBurger;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.pnSummary);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnWhereToEat);
            this.Controls.Add(this.pnToppings);
            this.Controls.Add(this.pnCookingLevels);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBurger";
            this.Text = "Burger App";
            this.pnCookingLevels.ResumeLayout(false);
            this.pnCookingLevels.PerformLayout();
            this.pnToppings.ResumeLayout(false);
            this.pnToppings.PerformLayout();
            this.pnWhereToEat.ResumeLayout(false);
            this.pnWhereToEat.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhoneNumber)).EndInit();
            this.pnSummary.ResumeLayout(false);
            this.pnSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCookingLevels;
        private System.Windows.Forms.RadioButton rbWell;
        private System.Windows.Forms.RadioButton rbMediumWell;
        private System.Windows.Forms.RadioButton rbMediumRare;
        private System.Windows.Forms.RadioButton rbRare;
        private System.Windows.Forms.Panel pnToppings;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.Label lbCookingLevels;
        private System.Windows.Forms.Panel pnWhereToEat;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.ComboBox cbWhereToEat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label pnQuantity;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.MaskedTextBox tbPhoneNumber;
        private System.Windows.Forms.ErrorProvider errPhoneNumber;
        private System.Windows.Forms.Panel pnSummary;
        private System.Windows.Forms.Label lbWhatToppings_Summary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbWhatCookingLevel_Summary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOrderSummary;
        private System.Windows.Forms.Label lbWhereToEat_Summary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPhoneNumber_Summary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbAddress_Summary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbQuantity_Summary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label label2;
    }
}

