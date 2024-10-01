namespace Pizza_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.grbCrustType = new System.Windows.Forms.GroupBox();
            this.rdbThink = new System.Windows.Forms.RadioButton();
            this.rdbThinCrust = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSizeEdit = new System.Windows.Forms.Label();
            this.lblToppingsEdit = new System.Windows.Forms.Label();
            this.lblCuresttypeChange = new System.Windows.Forms.Label();
            this.lblWheretoEatEdit = new System.Windows.Forms.Label();
            this.lblTotalPriceEdit = new System.Windows.Forms.Label();
            this.grbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdbTakeOut = new System.Windows.Forms.RadioButton();
            this.rdbEatin = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPappers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.grbCrustType.SuspendLayout();
            this.grbWhereToEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(266, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rdbMedium);
            this.gbSize.Controls.Add(this.rdbSmall);
            this.gbSize.Controls.Add(this.rdbLarge);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(12, 93);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(162, 157);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Checked = true;
            this.rdbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMedium.Location = new System.Drawing.Point(34, 74);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(82, 22);
            this.rdbMedium.TabIndex = 6;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Tag = "30";
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSmall.Location = new System.Drawing.Point(34, 116);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(66, 22);
            this.rdbSmall.TabIndex = 5;
            this.rdbSmall.Tag = "20";
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.rdbSmall_CheckedChanged);
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLarge.Location = new System.Drawing.Point(34, 36);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(66, 22);
            this.rdbLarge.TabIndex = 4;
            this.rdbLarge.Tag = "40";
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            this.rdbLarge.CheckedChanged += new System.EventHandler(this.rdbLarge_CheckedChanged);
            // 
            // grbCrustType
            // 
            this.grbCrustType.Controls.Add(this.rdbThink);
            this.grbCrustType.Controls.Add(this.rdbThinCrust);
            this.grbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCrustType.Location = new System.Drawing.Point(12, 297);
            this.grbCrustType.Name = "grbCrustType";
            this.grbCrustType.Size = new System.Drawing.Size(137, 135);
            this.grbCrustType.TabIndex = 5;
            this.grbCrustType.TabStop = false;
            this.grbCrustType.Text = "Crust Type";
            // 
            // rdbThink
            // 
            this.rdbThink.AutoSize = true;
            this.rdbThink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbThink.Location = new System.Drawing.Point(26, 101);
            this.rdbThink.Name = "rdbThink";
            this.rdbThink.Size = new System.Drawing.Size(105, 22);
            this.rdbThink.TabIndex = 6;
            this.rdbThink.TabStop = true;
            this.rdbThink.Tag = "10";
            this.rdbThink.Text = "Think Crust";
            this.rdbThink.UseVisualStyleBackColor = true;
            this.rdbThink.CheckedChanged += new System.EventHandler(this.rdbThink_CheckedChanged);
            // 
            // rdbThinCrust
            // 
            this.rdbThinCrust.AutoSize = true;
            this.rdbThinCrust.Checked = true;
            this.rdbThinCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbThinCrust.Location = new System.Drawing.Point(26, 59);
            this.rdbThinCrust.Name = "rdbThinCrust";
            this.rdbThinCrust.Size = new System.Drawing.Size(97, 22);
            this.rdbThinCrust.TabIndex = 4;
            this.rdbThinCrust.TabStop = true;
            this.rdbThinCrust.Tag = "0";
            this.rdbThinCrust.Text = "Thin Crust";
            this.rdbThinCrust.UseVisualStyleBackColor = true;
            this.rdbThinCrust.CheckedChanged += new System.EventHandler(this.rdbThinCrust_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(710, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Order Summary";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(733, 145);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(49, 22);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "Size:";
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopping.Location = new System.Drawing.Point(733, 208);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(90, 22);
            this.lblTopping.TabIndex = 15;
            this.lblTopping.Text = "Toppings:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(733, 289);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(104, 22);
            this.lblCrustType.TabIndex = 16;
            this.lblCrustType.Text = "Crust Type:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(733, 320);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(118, 22);
            this.lblWhereToEat.TabIndex = 17;
            this.lblWhereToEat.Text = "Where to eat:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(733, 380);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(102, 22);
            this.lblTotalPrice.TabIndex = 18;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblSizeEdit
            // 
            this.lblSizeEdit.AutoSize = true;
            this.lblSizeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeEdit.Location = new System.Drawing.Point(788, 147);
            this.lblSizeEdit.Name = "lblSizeEdit";
            this.lblSizeEdit.Size = new System.Drawing.Size(68, 20);
            this.lblSizeEdit.TabIndex = 19;
            this.lblSizeEdit.Text = "Medium";
            // 
            // lblToppingsEdit
            // 
            this.lblToppingsEdit.AutoSize = true;
            this.lblToppingsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsEdit.Location = new System.Drawing.Point(788, 239);
            this.lblToppingsEdit.Name = "lblToppingsEdit";
            this.lblToppingsEdit.Size = new System.Drawing.Size(103, 20);
            this.lblToppingsEdit.TabIndex = 20;
            this.lblToppingsEdit.Text = "No Toppings";
            // 
            // lblCuresttypeChange
            // 
            this.lblCuresttypeChange.AutoSize = true;
            this.lblCuresttypeChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuresttypeChange.Location = new System.Drawing.Point(857, 291);
            this.lblCuresttypeChange.Name = "lblCuresttypeChange";
            this.lblCuresttypeChange.Size = new System.Drawing.Size(87, 20);
            this.lblCuresttypeChange.TabIndex = 21;
            this.lblCuresttypeChange.Text = "Thin Crust";
            // 
            // lblWheretoEatEdit
            // 
            this.lblWheretoEatEdit.AutoSize = true;
            this.lblWheretoEatEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheretoEatEdit.Location = new System.Drawing.Point(843, 356);
            this.lblWheretoEatEdit.Name = "lblWheretoEatEdit";
            this.lblWheretoEatEdit.Size = new System.Drawing.Size(57, 20);
            this.lblWheretoEatEdit.TabIndex = 22;
            this.lblWheretoEatEdit.Text = "Eat in ";
            // 
            // lblTotalPriceEdit
            // 
            this.lblTotalPriceEdit.AutoSize = true;
            this.lblTotalPriceEdit.Font = new System.Drawing.Font("Gigi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceEdit.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalPriceEdit.Location = new System.Drawing.Point(847, 419);
            this.lblTotalPriceEdit.Name = "lblTotalPriceEdit";
            this.lblTotalPriceEdit.Size = new System.Drawing.Size(112, 83);
            this.lblTotalPriceEdit.TabIndex = 23;
            this.lblTotalPriceEdit.Text = "$30";
            // 
            // grbWhereToEat
            // 
            this.grbWhereToEat.Controls.Add(this.rdbTakeOut);
            this.grbWhereToEat.Controls.Add(this.rdbEatin);
            this.grbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbWhereToEat.Location = new System.Drawing.Point(348, 289);
            this.grbWhereToEat.Name = "grbWhereToEat";
            this.grbWhereToEat.Size = new System.Drawing.Size(258, 87);
            this.grbWhereToEat.TabIndex = 24;
            this.grbWhereToEat.TabStop = false;
            this.grbWhereToEat.Text = "Where To Eat";
            // 
            // rdbTakeOut
            // 
            this.rdbTakeOut.AutoSize = true;
            this.rdbTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTakeOut.Location = new System.Drawing.Point(153, 48);
            this.rdbTakeOut.Name = "rdbTakeOut";
            this.rdbTakeOut.Size = new System.Drawing.Size(87, 22);
            this.rdbTakeOut.TabIndex = 6;
            this.rdbTakeOut.TabStop = true;
            this.rdbTakeOut.Text = "Take out";
            this.rdbTakeOut.UseVisualStyleBackColor = true;
            this.rdbTakeOut.CheckedChanged += new System.EventHandler(this.rdbTakeOut_CheckedChanged);
            // 
            // rdbEatin
            // 
            this.rdbEatin.AutoSize = true;
            this.rdbEatin.Checked = true;
            this.rdbEatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEatin.Location = new System.Drawing.Point(6, 48);
            this.rdbEatin.Name = "rdbEatin";
            this.rdbEatin.Size = new System.Drawing.Size(70, 22);
            this.rdbEatin.TabIndex = 4;
            this.rdbEatin.TabStop = true;
            this.rdbEatin.Text = "Eat in ";
            this.rdbEatin.UseVisualStyleBackColor = true;
            this.rdbEatin.CheckedChanged += new System.EventHandler(this.rdbEatin_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(292, 428);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(132, 45);
            this.btnOrderPizza.TabIndex = 25;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(527, 428);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(132, 45);
            this.btnResetForm.TabIndex = 26;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPappers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushroom);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Location = new System.Drawing.Point(307, 123);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(261, 136);
            this.gbToppings.TabIndex = 27;
            this.gbToppings.TabStop = false;
            // 
            // chkGreenPappers
            // 
            this.chkGreenPappers.AutoSize = true;
            this.chkGreenPappers.Location = new System.Drawing.Point(125, 93);
            this.chkGreenPappers.Name = "chkGreenPappers";
            this.chkGreenPappers.Size = new System.Drawing.Size(121, 20);
            this.chkGreenPappers.TabIndex = 18;
            this.chkGreenPappers.Tag = "5";
            this.chkGreenPappers.Text = "Green Pappers";
            this.chkGreenPappers.UseVisualStyleBackColor = true;
            this.chkGreenPappers.CheckedChanged += new System.EventHandler(this.chkGreenPappers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkOlives.Location = new System.Drawing.Point(152, 58);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 20);
            this.chkOlives.TabIndex = 17;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(153, 21);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 16;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged_1);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(10, 93);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(91, 20);
            this.chkTomatoes.TabIndex = 15;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(9, 58);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(92, 20);
            this.chkMushroom.TabIndex = 14;
            this.chkMushroom.Tag = "5";
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged_1);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(5, 22);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(101, 20);
            this.chkExtraChees.TabIndex = 13;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(316, 493);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 30);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "Pizza Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.download__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.grbWhereToEat);
            this.Controls.Add(this.lblTotalPriceEdit);
            this.Controls.Add(this.lblWheretoEatEdit);
            this.Controls.Add(this.lblCuresttypeChange);
            this.Controls.Add(this.lblToppingsEdit);
            this.Controls.Add(this.lblSizeEdit);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblWhereToEat);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.lblTopping);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.grbCrustType.ResumeLayout(false);
            this.grbCrustType.PerformLayout();
            this.grbWhereToEat.ResumeLayout(false);
            this.grbWhereToEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.GroupBox grbCrustType;
        private System.Windows.Forms.RadioButton rdbThink;
        private System.Windows.Forms.RadioButton rdbThinCrust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSizeEdit;
        private System.Windows.Forms.Label lblToppingsEdit;
        private System.Windows.Forms.Label lblCuresttypeChange;
        private System.Windows.Forms.Label lblWheretoEatEdit;
        private System.Windows.Forms.Label lblTotalPriceEdit;
        private System.Windows.Forms.GroupBox grbWhereToEat;
        private System.Windows.Forms.RadioButton rdbTakeOut;
        private System.Windows.Forms.RadioButton rdbEatin;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPappers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
    }
}

