using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DNDM
{
    public partial class DiceRoller : Form
    {
        public DiceRoller()
        {
            InitializeComponent();
        }

       // List<DiceRollerModel> dicePresets = new List<DiceRollerModel>();

        private void DiceRoller_Load(object sender, EventArgs e)
        {
            DiceRollerTitle.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;
            label19.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label20.BackColor = Color.Transparent;
            label21.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;

            PopulatePresetComboBox();
        }


        private void PopulatePresetComboBox() 
        {
            PresetsComboBox.DataSource = null;
            PresetsComboBox.DataSource = SQLiteDataAccess.LoadDiceRollerPresets();
            PresetsComboBox.DisplayMember = "name";
        
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var DMPanel = new DMScreen();
            DMPanel.Show();
            this.Close();
        }

        public int RollDice(Random rnd, int diceType , int diceAmount) {

            int total = 0;

            if (diceAmount == 1)
            {

                switch (diceType)
                {
                    case 2:
                        {
                            total += rnd.Next(1, 3);
                        }
                        break;

                    case 4:
                        {
                            total += rnd.Next(1, 5);
                        }
                        break;

                    case 6:
                        {
                            total += rnd.Next(1, 7);
                        }
                        break;

                    case 8:
                        {
                            total += rnd.Next(1, 9);
                        }
                        break;


                    case 10:
                        {
                            total += rnd.Next(1, 11);
                        }
                        break;

                    case 12:
                        {
                            total += rnd.Next(1, 13);
                        }
                        break;

                    case 20:
                        {
                            total += rnd.Next(1, 21);
                        }
                        break;

                    case 100:
                        {
                            total += rnd.Next(1, 101);
                        }
                        break;

                }


            }
            else if (diceAmount == 0) {
                return 0;
            }
            else
            {
                switch (diceType)
                {
                    case 2:
                        {
                            for(int i =0;i < diceAmount; i++) { 
                                 total += rnd.Next(1, 3);
                            }
                        }
                        break;

                    case 4:
                        {
                            for (int i = 0; i < diceAmount; i++)
                            {
                                total += rnd.Next(1, 5);
                            }
                        }
                        break;

                    case 6:
                        {
                            for (int i = 0; i < diceAmount; i++)
                            {
                                total += rnd.Next(1, 7);
                            }
                        }
                        break;

                    case 8:
                        {
                            for (int i = 0; i < diceAmount; i++)
                            {
                                total += rnd.Next(1, 9);
                            }
                        }
                        break;


                    case 10:
                        {
                            for (int i = 0; i < diceAmount; i++)
                            {
                                total += rnd.Next(1, 11);
                            }
                        }
                        break;

                    case 12:
                        {
                            for (int i = 0; i < diceAmount; i++)
                            {
                                total += rnd.Next(1, 13);
                            }
                        }
                        break;

                    case 20:
                        {
                            for (int i = 0; i < diceAmount; i++)
                            {
                                total += rnd.Next(1, 21);
                            }
                            total += rnd.Next(1, 21);
                        }
                        break;

                    case 100:
                        {
                            for (int i = 0; i < diceAmount; i++)
                            {
                                total += rnd.Next(1, 101);
                            }
                        }
                        break;

                }
            }

            return total;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            int D2=0, D4=0, D6=0, D8=0, D10=0, D12=0, D20=0, D100=0,
                D2VarMod=0, D4VarMod=0, D6VarMod=0, D8VarMod=0, D10VarMod=0, D12VarMod=0, D20VarMod=0, D100VarMod=0,
                D2Res, D4Res, D6Res, D8Res, D10Res, D12Res, D20Res, D100Res, TotalRes,defaultRes=0;

            Random rnd = new Random();

            if (int.TryParse(D2Amount.Text, out defaultRes)) D2 = defaultRes;
            if (int.TryParse(D4Amount.Text,out defaultRes)) D4= defaultRes;
            if (int.TryParse(D6Amount.Text, out defaultRes)) D6 = defaultRes;
            if (int.TryParse(D8Amount.Text, out defaultRes)) D8 = defaultRes;
            if (int.TryParse(D10Amount.Text, out defaultRes)) D10 = defaultRes;
            if (int.TryParse(D12Amount.Text, out defaultRes)) D12 = defaultRes;
            if (int.TryParse(D20Amount.Text, out defaultRes)) D20 = defaultRes;
            if (int.TryParse(D100Amount.Text, out defaultRes)) D100 = defaultRes;

            if (int.TryParse(D2Mod.Text, out defaultRes)) D2VarMod = defaultRes;
            if (int.TryParse(D4Mod.Text, out defaultRes)) D4VarMod = defaultRes;
            if (int.TryParse(D6Mod.Text, out defaultRes)) D6VarMod = defaultRes;
            if (int.TryParse(D8Mod.Text, out defaultRes)) D8VarMod = defaultRes;
            if (int.TryParse(D10Mod.Text, out defaultRes)) D10VarMod = defaultRes;
            if (int.TryParse(D12Mod.Text, out defaultRes)) D12VarMod = defaultRes;
            if (int.TryParse(D20Mod.Text, out defaultRes)) D20VarMod = defaultRes;
            if (int.TryParse(D100Mod.Text, out defaultRes)) D100VarMod = defaultRes;

            D2Res = RollDice(rnd,2,D2) + D2VarMod;
            D4Res = RollDice(rnd, 4, D4) + D4VarMod;
            D6Res = RollDice(rnd, 6, D6) + D6VarMod;
            D8Res = RollDice(rnd, 8, D8) + D8VarMod;
            D10Res = RollDice(rnd, 10, D10) + D10VarMod;
            D12Res = RollDice(rnd, 12, D12) + D12VarMod;
            D20Res = RollDice(rnd, 20, D20) + D20VarMod;
            D100Res = RollDice(rnd, 100, D100) + D100VarMod;
            TotalRes = (D2Res + D4Res + D6Res + D8Res + D10Res + D12Res + D20Res + D100Res);

            D2Result.Text = D2Res.ToString();
            D4Result.Text = D4Res.ToString();
            D6Result.Text = D6Res.ToString();
            D8Result.Text = D8Res.ToString();
            D10Result.Text = D10Res.ToString();
            D12Result.Text = D12Res.ToString();
            D20Result.Text = D20Res.ToString();
            D100Result.Text = D100Res.ToString();
            TotalResult.Text = TotalRes.ToString();

        }

        private void Check_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Check_KeyPressMod(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('-'))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }

        }

        private void SavePresetButton_Click(object sender, EventArgs e)
        {
            string PresetName = Prompt.ShowDialog("Please enter a preset name", "Dice Roller Presets");
            DiceRollerModel preset = new DiceRollerModel();
            int defaultRes = 0;

            if (PresetName.Equals("")) 
            {
                MessageBox.Show("Error ! Please enter a Preset name!");
            }else if (SQLiteDataAccess.CheckIfPresetExists(PresetName))
            {
                MessageBox.Show("Error ! Preset already exists , select another name!");
            }
            else {
 
                preset.name = PresetName;

                if (int.TryParse(D2Amount.Text, out defaultRes)) preset.D2Amount = defaultRes;
                if (int.TryParse(D4Amount.Text, out defaultRes)) preset.D4Amount = defaultRes;
                if (int.TryParse(D6Amount.Text, out defaultRes)) preset.D6Amount = defaultRes;
                if (int.TryParse(D8Amount.Text, out defaultRes)) preset.D8Amount = defaultRes;
                if (int.TryParse(D10Amount.Text, out defaultRes)) preset.D10Amount = defaultRes;
                if (int.TryParse(D12Amount.Text, out defaultRes)) preset.D12Amount = defaultRes;
                if (int.TryParse(D20Amount.Text, out defaultRes)) preset.D20Amount = defaultRes;
                if (int.TryParse(D100Amount.Text, out defaultRes)) preset.D100Amount = defaultRes;

                if (int.TryParse(D2Mod.Text, out defaultRes)) preset.D2Mod = defaultRes;
                if (int.TryParse(D4Mod.Text, out defaultRes)) preset.D4Mod = defaultRes;
                if (int.TryParse(D6Mod.Text, out defaultRes)) preset.D6Mod = defaultRes;
                if (int.TryParse(D8Mod.Text, out defaultRes)) preset.D8Mod = defaultRes;
                if (int.TryParse(D10Mod.Text, out defaultRes)) preset.D10Mod = defaultRes;
                if (int.TryParse(D12Mod.Text, out defaultRes)) preset.D12Mod = defaultRes;
                if (int.TryParse(D20Mod.Text, out defaultRes)) preset.D20Mod = defaultRes;
                if (int.TryParse(D100Mod.Text, out defaultRes)) preset.D100Mod = defaultRes;

                SQLiteDataAccess.SaveDiceRollerPresets(preset);
                PopulatePresetComboBox();
            }
        }

        private void LoadDataFromComboBox(object sender, EventArgs e)
        {
           

          DiceRollerModel selectedPreset = SQLiteDataAccess.LoadDiceRollerPresetByName(PresetsComboBox.Text);

            D2Amount.Text = selectedPreset.D2Amount.ToString();
            D4Amount.Text = selectedPreset.D4Amount.ToString();
            D6Amount.Text = selectedPreset.D6Amount.ToString();
            D8Amount.Text = selectedPreset.D8Amount.ToString();
            D10Amount.Text = selectedPreset.D10Amount.ToString();
            D12Amount.Text = selectedPreset.D12Amount.ToString();
            D20Amount.Text = selectedPreset.D20Amount.ToString();
            D100Amount.Text = selectedPreset.D100Amount.ToString();
            D2Mod.Text = selectedPreset.D2Mod.ToString();
            D4Mod.Text = selectedPreset.D4Mod.ToString();
            D6Mod.Text = selectedPreset.D6Mod.ToString();
            D8Mod.Text = selectedPreset.D8Mod.ToString();
            D10Mod.Text = selectedPreset.D10Mod.ToString();
            D12Mod.Text = selectedPreset.D12Mod.ToString();
            D20Mod.Text = selectedPreset.D20Mod.ToString();
            D100Mod.Text = selectedPreset.D100Mod.ToString(); 
        }

        private void DeletePresetButton_Click(object sender, EventArgs e)
        {
            SQLiteDataAccess.DeleteDiceRollerPreset(PresetsComboBox.Text);
            PopulatePresetComboBox();
        }

        private void UpdatePresetButton_Click(object sender, EventArgs e)
        {
            DiceRollerModel preset = new DiceRollerModel();
            int defaultRes = 0;

            preset.name = PresetsComboBox.Text;

            if (int.TryParse(D2Amount.Text, out defaultRes)) preset.D2Amount = defaultRes;
            if (int.TryParse(D4Amount.Text, out defaultRes)) preset.D4Amount = defaultRes;
            if (int.TryParse(D6Amount.Text, out defaultRes)) preset.D6Amount = defaultRes;
            if (int.TryParse(D8Amount.Text, out defaultRes)) preset.D8Amount = defaultRes;
            if (int.TryParse(D10Amount.Text, out defaultRes)) preset.D10Amount = defaultRes;
            if (int.TryParse(D12Amount.Text, out defaultRes)) preset.D12Amount = defaultRes;
            if (int.TryParse(D20Amount.Text, out defaultRes)) preset.D20Amount = defaultRes;
            if (int.TryParse(D100Amount.Text, out defaultRes)) preset.D100Amount = defaultRes;

            if (int.TryParse(D2Mod.Text, out defaultRes)) preset.D2Mod = defaultRes;
            if (int.TryParse(D4Mod.Text, out defaultRes)) preset.D4Mod = defaultRes;
            if (int.TryParse(D6Mod.Text, out defaultRes)) preset.D6Mod = defaultRes;
            if (int.TryParse(D8Mod.Text, out defaultRes)) preset.D8Mod = defaultRes;
            if (int.TryParse(D10Mod.Text, out defaultRes)) preset.D10Mod = defaultRes;
            if (int.TryParse(D12Mod.Text, out defaultRes)) preset.D12Mod = defaultRes;
            if (int.TryParse(D20Mod.Text, out defaultRes)) preset.D20Mod = defaultRes;
            if (int.TryParse(D100Mod.Text, out defaultRes)) preset.D100Mod = defaultRes;

            SQLiteDataAccess.UpdateDiceRollerPreset(preset);
            PopulatePresetComboBox();
        }
    }
}
