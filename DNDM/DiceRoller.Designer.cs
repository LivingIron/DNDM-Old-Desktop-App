
namespace DNDM
{
    partial class DiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRoller));
            this.DiceRollerTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PresetsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.D2Amount = new System.Windows.Forms.TextBox();
            this.D4Amount = new System.Windows.Forms.TextBox();
            this.D6Amount = new System.Windows.Forms.TextBox();
            this.D8Amount = new System.Windows.Forms.TextBox();
            this.D10Amount = new System.Windows.Forms.TextBox();
            this.D12Amount = new System.Windows.Forms.TextBox();
            this.D20Amount = new System.Windows.Forms.TextBox();
            this.D100Amount = new System.Windows.Forms.TextBox();
            this.D2Mod = new System.Windows.Forms.TextBox();
            this.D4Mod = new System.Windows.Forms.TextBox();
            this.D6Mod = new System.Windows.Forms.TextBox();
            this.D8Mod = new System.Windows.Forms.TextBox();
            this.D10Mod = new System.Windows.Forms.TextBox();
            this.D12Mod = new System.Windows.Forms.TextBox();
            this.D20Mod = new System.Windows.Forms.TextBox();
            this.D100Mod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.D100Result = new System.Windows.Forms.TextBox();
            this.D20Result = new System.Windows.Forms.TextBox();
            this.D12Result = new System.Windows.Forms.TextBox();
            this.D10Result = new System.Windows.Forms.TextBox();
            this.D8Result = new System.Windows.Forms.TextBox();
            this.D6Result = new System.Windows.Forms.TextBox();
            this.D4Result = new System.Windows.Forms.TextBox();
            this.D2Result = new System.Windows.Forms.TextBox();
            this.TotalResult = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.RollButton = new System.Windows.Forms.Button();
            this.SavePresetButton = new System.Windows.Forms.Button();
            this.UpdatePresetButton = new System.Windows.Forms.Button();
            this.DeletePresetButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DiceRollerTitle
            // 
            this.DiceRollerTitle.AutoSize = true;
            this.DiceRollerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.DiceRollerTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DiceRollerTitle.Location = new System.Drawing.Point(249, 10);
            this.DiceRollerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiceRollerTitle.Name = "DiceRollerTitle";
            this.DiceRollerTitle.Size = new System.Drawing.Size(437, 91);
            this.DiceRollerTitle.TabIndex = 0;
            this.DiceRollerTitle.Text = "Dice Roller";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(5, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Presets :";
            // 
            // PresetsComboBox
            // 
            this.PresetsComboBox.FormattingEnabled = true;
            this.PresetsComboBox.Location = new System.Drawing.Point(149, 122);
            this.PresetsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PresetsComboBox.Name = "PresetsComboBox";
            this.PresetsComboBox.Size = new System.Drawing.Size(272, 24);
            this.PresetsComboBox.TabIndex = 2;
            this.PresetsComboBox.SelectionChangeCommitted += new System.EventHandler(this.LoadDataFromComboBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "D2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "D4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "D6:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "D8:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(13, 379);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "D12:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(13, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "D20:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(13, 340);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "D10:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(13, 452);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "D100:";
            // 
            // D2Amount
            // 
            this.D2Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D2Amount.Location = new System.Drawing.Point(109, 192);
            this.D2Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D2Amount.Name = "D2Amount";
            this.D2Amount.Size = new System.Drawing.Size(312, 25);
            this.D2Amount.TabIndex = 11;
            this.D2Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // D4Amount
            // 
            this.D4Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D4Amount.Location = new System.Drawing.Point(109, 230);
            this.D4Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D4Amount.Name = "D4Amount";
            this.D4Amount.Size = new System.Drawing.Size(312, 25);
            this.D4Amount.TabIndex = 12;
            this.D4Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // D6Amount
            // 
            this.D6Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D6Amount.Location = new System.Drawing.Point(109, 268);
            this.D6Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D6Amount.Name = "D6Amount";
            this.D6Amount.Size = new System.Drawing.Size(312, 25);
            this.D6Amount.TabIndex = 13;
            this.D6Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // D8Amount
            // 
            this.D8Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D8Amount.Location = new System.Drawing.Point(109, 304);
            this.D8Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D8Amount.Name = "D8Amount";
            this.D8Amount.Size = new System.Drawing.Size(312, 25);
            this.D8Amount.TabIndex = 14;
            this.D8Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // D10Amount
            // 
            this.D10Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D10Amount.Location = new System.Drawing.Point(109, 343);
            this.D10Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D10Amount.Name = "D10Amount";
            this.D10Amount.Size = new System.Drawing.Size(312, 25);
            this.D10Amount.TabIndex = 15;
            this.D10Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // D12Amount
            // 
            this.D12Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D12Amount.Location = new System.Drawing.Point(109, 382);
            this.D12Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D12Amount.Name = "D12Amount";
            this.D12Amount.Size = new System.Drawing.Size(312, 25);
            this.D12Amount.TabIndex = 16;
            this.D12Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // D20Amount
            // 
            this.D20Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D20Amount.Location = new System.Drawing.Point(109, 417);
            this.D20Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D20Amount.Name = "D20Amount";
            this.D20Amount.Size = new System.Drawing.Size(312, 25);
            this.D20Amount.TabIndex = 17;
            this.D20Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // D100Amount
            // 
            this.D100Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D100Amount.Location = new System.Drawing.Point(109, 455);
            this.D100Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D100Amount.Name = "D100Amount";
            this.D100Amount.Size = new System.Drawing.Size(312, 25);
            this.D100Amount.TabIndex = 18;
            this.D100Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPress);
            // 
            // D2Mod
            // 
            this.D2Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D2Mod.Location = new System.Drawing.Point(463, 192);
            this.D2Mod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D2Mod.Name = "D2Mod";
            this.D2Mod.Size = new System.Drawing.Size(33, 25);
            this.D2Mod.TabIndex = 19;
            this.D2Mod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPressMod);
            // 
            // D4Mod
            // 
            this.D4Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D4Mod.Location = new System.Drawing.Point(463, 230);
            this.D4Mod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D4Mod.Name = "D4Mod";
            this.D4Mod.Size = new System.Drawing.Size(33, 25);
            this.D4Mod.TabIndex = 20;
            this.D4Mod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPressMod);
            // 
            // D6Mod
            // 
            this.D6Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D6Mod.Location = new System.Drawing.Point(463, 268);
            this.D6Mod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D6Mod.Name = "D6Mod";
            this.D6Mod.Size = new System.Drawing.Size(33, 25);
            this.D6Mod.TabIndex = 21;
            this.D6Mod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPressMod);
            // 
            // D8Mod
            // 
            this.D8Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D8Mod.Location = new System.Drawing.Point(463, 306);
            this.D8Mod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D8Mod.Name = "D8Mod";
            this.D8Mod.Size = new System.Drawing.Size(33, 25);
            this.D8Mod.TabIndex = 22;
            this.D8Mod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPressMod);
            // 
            // D10Mod
            // 
            this.D10Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D10Mod.Location = new System.Drawing.Point(463, 343);
            this.D10Mod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D10Mod.Name = "D10Mod";
            this.D10Mod.Size = new System.Drawing.Size(33, 25);
            this.D10Mod.TabIndex = 23;
            this.D10Mod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPressMod);
            // 
            // D12Mod
            // 
            this.D12Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D12Mod.Location = new System.Drawing.Point(463, 382);
            this.D12Mod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D12Mod.Name = "D12Mod";
            this.D12Mod.Size = new System.Drawing.Size(33, 25);
            this.D12Mod.TabIndex = 24;
            this.D12Mod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPressMod);
            // 
            // D20Mod
            // 
            this.D20Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D20Mod.Location = new System.Drawing.Point(463, 417);
            this.D20Mod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D20Mod.Name = "D20Mod";
            this.D20Mod.Size = new System.Drawing.Size(33, 25);
            this.D20Mod.TabIndex = 25;
            this.D20Mod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPressMod);
            // 
            // D100Mod
            // 
            this.D100Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D100Mod.Location = new System.Drawing.Point(463, 455);
            this.D100Mod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D100Mod.Name = "D100Mod";
            this.D100Mod.Size = new System.Drawing.Size(33, 25);
            this.D100Mod.TabIndex = 26;
            this.D100Mod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_KeyPressMod);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(223, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 29);
            this.label10.TabIndex = 27;
            this.label10.Text = "Amount :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(449, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 29);
            this.label11.TabIndex = 28;
            this.label11.Text = "Mod:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(520, 192);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 29);
            this.label12.TabIndex = 29;
            this.label12.Text = "=";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(520, 228);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 29);
            this.label13.TabIndex = 30;
            this.label13.Text = "=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(520, 266);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 29);
            this.label14.TabIndex = 31;
            this.label14.Text = "=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(520, 303);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 29);
            this.label15.TabIndex = 32;
            this.label15.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(520, 340);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 29);
            this.label16.TabIndex = 33;
            this.label16.Text = "=";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(520, 379);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 29);
            this.label17.TabIndex = 34;
            this.label17.Text = "=";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(520, 414);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 29);
            this.label18.TabIndex = 35;
            this.label18.Text = "=";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(264, 353);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(273, 22);
            this.textBox17.TabIndex = 44;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(264, 317);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(273, 22);
            this.textBox18.TabIndex = 43;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(264, 284);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(273, 22);
            this.textBox19.TabIndex = 42;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(264, 248);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(273, 22);
            this.textBox20.TabIndex = 41;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(264, 211);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(273, 22);
            this.textBox21.TabIndex = 40;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(264, 178);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(273, 22);
            this.textBox22.TabIndex = 39;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(264, 142);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(273, 22);
            this.textBox23.TabIndex = 38;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(264, 106);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(273, 22);
            this.textBox24.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(520, 452);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 29);
            this.label19.TabIndex = 36;
            this.label19.Text = "=";
            // 
            // D100Result
            // 
            this.D100Result.Enabled = false;
            this.D100Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D100Result.Location = new System.Drawing.Point(564, 455);
            this.D100Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D100Result.Name = "D100Result";
            this.D100Result.Size = new System.Drawing.Size(123, 25);
            this.D100Result.TabIndex = 44;
            // 
            // D20Result
            // 
            this.D20Result.Enabled = false;
            this.D20Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D20Result.Location = new System.Drawing.Point(564, 417);
            this.D20Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D20Result.Name = "D20Result";
            this.D20Result.Size = new System.Drawing.Size(123, 25);
            this.D20Result.TabIndex = 43;
            // 
            // D12Result
            // 
            this.D12Result.Enabled = false;
            this.D12Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D12Result.Location = new System.Drawing.Point(564, 382);
            this.D12Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D12Result.Name = "D12Result";
            this.D12Result.Size = new System.Drawing.Size(123, 25);
            this.D12Result.TabIndex = 42;
            // 
            // D10Result
            // 
            this.D10Result.Enabled = false;
            this.D10Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D10Result.Location = new System.Drawing.Point(564, 343);
            this.D10Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D10Result.Name = "D10Result";
            this.D10Result.Size = new System.Drawing.Size(123, 25);
            this.D10Result.TabIndex = 41;
            // 
            // D8Result
            // 
            this.D8Result.Enabled = false;
            this.D8Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D8Result.Location = new System.Drawing.Point(564, 304);
            this.D8Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D8Result.Name = "D8Result";
            this.D8Result.Size = new System.Drawing.Size(123, 25);
            this.D8Result.TabIndex = 40;
            // 
            // D6Result
            // 
            this.D6Result.Enabled = false;
            this.D6Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D6Result.Location = new System.Drawing.Point(564, 268);
            this.D6Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D6Result.Name = "D6Result";
            this.D6Result.Size = new System.Drawing.Size(123, 25);
            this.D6Result.TabIndex = 39;
            // 
            // D4Result
            // 
            this.D4Result.Enabled = false;
            this.D4Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D4Result.Location = new System.Drawing.Point(564, 230);
            this.D4Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D4Result.Name = "D4Result";
            this.D4Result.Size = new System.Drawing.Size(123, 25);
            this.D4Result.TabIndex = 38;
            // 
            // D2Result
            // 
            this.D2Result.Enabled = false;
            this.D2Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.D2Result.Location = new System.Drawing.Point(564, 192);
            this.D2Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D2Result.Name = "D2Result";
            this.D2Result.Size = new System.Drawing.Size(123, 25);
            this.D2Result.TabIndex = 37;
            // 
            // TotalResult
            // 
            this.TotalResult.Enabled = false;
            this.TotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.TotalResult.Location = new System.Drawing.Point(564, 496);
            this.TotalResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotalResult.Name = "TotalResult";
            this.TotalResult.Size = new System.Drawing.Size(123, 25);
            this.TotalResult.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(584, 164);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 29);
            this.label20.TabIndex = 46;
            this.label20.Text = "Result:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(492, 496);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 29);
            this.label21.TabIndex = 47;
            this.label21.Text = "Total:";
            // 
            // RollButton
            // 
            this.RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RollButton.Location = new System.Drawing.Point(736, 192);
            this.RollButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(140, 60);
            this.RollButton.TabIndex = 48;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // SavePresetButton
            // 
            this.SavePresetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.SavePresetButton.Location = new System.Drawing.Point(736, 270);
            this.SavePresetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SavePresetButton.Name = "SavePresetButton";
            this.SavePresetButton.Size = new System.Drawing.Size(140, 60);
            this.SavePresetButton.TabIndex = 49;
            this.SavePresetButton.Text = "Save Preset";
            this.SavePresetButton.UseVisualStyleBackColor = true;
            this.SavePresetButton.Click += new System.EventHandler(this.SavePresetButton_Click);
            // 
            // UpdatePresetButton
            // 
            this.UpdatePresetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.UpdatePresetButton.Location = new System.Drawing.Point(736, 346);
            this.UpdatePresetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdatePresetButton.Name = "UpdatePresetButton";
            this.UpdatePresetButton.Size = new System.Drawing.Size(140, 60);
            this.UpdatePresetButton.TabIndex = 50;
            this.UpdatePresetButton.Text = "Update Preset";
            this.UpdatePresetButton.UseVisualStyleBackColor = true;
            this.UpdatePresetButton.Click += new System.EventHandler(this.UpdatePresetButton_Click);
            // 
            // DeletePresetButton
            // 
            this.DeletePresetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.DeletePresetButton.Location = new System.Drawing.Point(736, 420);
            this.DeletePresetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeletePresetButton.Name = "DeletePresetButton";
            this.DeletePresetButton.Size = new System.Drawing.Size(140, 60);
            this.DeletePresetButton.TabIndex = 51;
            this.DeletePresetButton.Text = "Delete Preset";
            this.DeletePresetButton.UseVisualStyleBackColor = true;
            this.DeletePresetButton.Click += new System.EventHandler(this.DeletePresetButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BackButton.Location = new System.Drawing.Point(736, 486);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(140, 36);
            this.BackButton.TabIndex = 52;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 550);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeletePresetButton);
            this.Controls.Add(this.UpdatePresetButton);
            this.Controls.Add(this.SavePresetButton);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TotalResult);
            this.Controls.Add(this.D100Result);
            this.Controls.Add(this.D20Result);
            this.Controls.Add(this.D12Result);
            this.Controls.Add(this.D10Result);
            this.Controls.Add(this.D8Result);
            this.Controls.Add(this.D6Result);
            this.Controls.Add(this.D4Result);
            this.Controls.Add(this.D2Result);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.D100Mod);
            this.Controls.Add(this.D20Mod);
            this.Controls.Add(this.D12Mod);
            this.Controls.Add(this.D10Mod);
            this.Controls.Add(this.D8Mod);
            this.Controls.Add(this.D6Mod);
            this.Controls.Add(this.D4Mod);
            this.Controls.Add(this.D2Mod);
            this.Controls.Add(this.D100Amount);
            this.Controls.Add(this.D20Amount);
            this.Controls.Add(this.D12Amount);
            this.Controls.Add(this.D10Amount);
            this.Controls.Add(this.D8Amount);
            this.Controls.Add(this.D6Amount);
            this.Controls.Add(this.D4Amount);
            this.Controls.Add(this.D2Amount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PresetsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiceRollerTitle);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DiceRoller";
            this.Text = "Dice Roller";
            this.Load += new System.EventHandler(this.DiceRoller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiceRollerTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PresetsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox D2Amount;
        private System.Windows.Forms.TextBox D4Amount;
        private System.Windows.Forms.TextBox D6Amount;
        private System.Windows.Forms.TextBox D8Amount;
        private System.Windows.Forms.TextBox D10Amount;
        private System.Windows.Forms.TextBox D12Amount;
        private System.Windows.Forms.TextBox D20Amount;
        private System.Windows.Forms.TextBox D100Amount;
        private System.Windows.Forms.TextBox D2Mod;
        private System.Windows.Forms.TextBox D4Mod;
        private System.Windows.Forms.TextBox D6Mod;
        private System.Windows.Forms.TextBox D8Mod;
        private System.Windows.Forms.TextBox D10Mod;
        private System.Windows.Forms.TextBox D12Mod;
        private System.Windows.Forms.TextBox D20Mod;
        private System.Windows.Forms.TextBox D100Mod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox D100Result;
        private System.Windows.Forms.TextBox D20Result;
        private System.Windows.Forms.TextBox D12Result;
        private System.Windows.Forms.TextBox D10Result;
        private System.Windows.Forms.TextBox D8Result;
        private System.Windows.Forms.TextBox D6Result;
        private System.Windows.Forms.TextBox D4Result;
        private System.Windows.Forms.TextBox D2Result;
        private System.Windows.Forms.TextBox TotalResult;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button SavePresetButton;
        private System.Windows.Forms.Button UpdatePresetButton;
        private System.Windows.Forms.Button DeletePresetButton;
        private System.Windows.Forms.Button BackButton;
    }
}