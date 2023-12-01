using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ICS
{
    public partial class ICS : Form
    {
        private object extraGroupBox;

        public ICS()
        {
            InitializeComponent();
            Checked1.Value = 0;
            Checked2.Value = 0;
            Checked3.Value = 0;
            Checked4.Value = 0;

        }


        private void NameSurname_TextChanged(object sender, EventArgs e)
        {
            
            
            CheckEnableTypeOfMilkGroupBox();

            {
                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;

                if (!string.IsNullOrEmpty(textBox.Text) && textBox.Text.Length >= 1)
                {
                    string[] nameParts = textBox.Text.Split(' ');

                    for (int i = 0; i < nameParts.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(nameParts[i]))
                        {
                            nameParts[i] = char.ToUpper(nameParts[i][0]) + nameParts[i].Substring(1);
                        }
                    }

                    textBox.Text = string.Join(" ", nameParts);
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                }
            }
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void TOM1_CheckedChanged(object sender, EventArgs e)
        {
            //Diet
        }

        private void TOM2_CheckedChanged(object sender, EventArgs e)
        {
            //Low Fat
            
        }

        private void TOM3_CheckedChanged(object sender, EventArgs e)
        {
            //Fat

        }

        private void Additions1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalFee();

            UpdateIceCreamImages();

            UpdateNumericUpDownActivation();
        }


        private void UpdateIceCreamImages()
        {
            LemonPic.Image = Additions1.GetItemChecked(0) ? IceCreams.Images["Lemon"] : null;
            BananaPic.Image = Additions1.GetItemChecked(1) ? IceCreams.Images["Banana"] : null;
            StrawberryPic.Image = Additions1.GetItemChecked(2) ? IceCreams.Images["Strawberry"] : null;
            ChocolatePic.Image = Additions1.GetItemChecked(3) ? IceCreams.Images["Chocolate"] : null;
        }

        private void UpdateNumericUpDownActivation()
        {
            Checked1.Enabled = Checked2.Enabled = Checked3.Enabled = Checked4.Enabled = false;

            foreach (int selectedIndex in Additions1.CheckedIndices)
            {
                switch (selectedIndex)
                {
                    case 0:
                        Checked1.Enabled = true;
                        break;
                    case 1:
                        Checked2.Enabled = true;
                        break;
                    case 2:
                        Checked3.Enabled = true;
                        break;
                    case 3:
                        Checked4.Enabled = true;
                        break;
                }
            }
        }

        private void Checked1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalFee();
            UpdateTotalCalories();
        }

        private void Checked2_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalFee();
            UpdateTotalCalories();
        }

        private void Checked3_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalFee();
            UpdateTotalCalories();
        }

        private void Checked4_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalFee();
            UpdateTotalCalories();
        }


        private void UpdateTotalFee()
        {
            decimal totalFee = 0;

            totalFee += CalculateTotalFee(Checked1, "Ice Lemon");
            totalFee += CalculateTotalFee(Checked2, "Ice Banana");
            totalFee += CalculateTotalFee(Checked3, "Ice Strawberry");
            totalFee += CalculateTotalFee(Checked4, "Ice Chocolate");

            COP1.Text = totalFee.ToString("");

            decimal grandTotal = totalFee * (int)COP3.Value;
            COP4.Text = grandTotal.ToString("");
        }

        private decimal CalculateTotalFee(NumericUpDown numericUpDown, string iceCreamType)
        {
            return CalculateSingleIceCreamFee(numericUpDown, iceCreamType, GetSelectedTypeOfMilk());
        }

        private decimal CalculateSingleIceCreamFee(NumericUpDown numericUpDown, string iceCreamType, string typeOfMilk)
        {
            decimal unitPrice = GetUnitPriceForIceCream(iceCreamType, typeOfMilk);
            int quantity = (int)numericUpDown.Value;
            return quantity * unitPrice;
        }

        private decimal GetUnitPriceForIceCream(string iceCreamType, string typeOfMilk)
        {
            switch (iceCreamType)
            {
                case "Ice Lemon":
                    return GetUnitPriceForTypeOfMilk(typeOfMilk, 0.25m, 0.35m, 0.40m);
                case "Ice Banana":
                    return GetUnitPriceForTypeOfMilk(typeOfMilk, 0.55m, 0.65m, 0.80m);
                case "Ice Strawberry":
                    return GetUnitPriceForTypeOfMilk(typeOfMilk, 0.75m, 0.80m, 0.85m);
                case "Ice Chocolate":
                    return GetUnitPriceForTypeOfMilk(typeOfMilk, 0.80m, 0.90m, 1.00m);
                default:
                    return 0;
            }
        }

        private decimal GetUnitPriceForTypeOfMilk(string typeOfMilk, decimal dietPrice, decimal lowFatPrice, decimal fatPrice)
        {
            switch (typeOfMilk)
            {
                case "Diet":
                    return dietPrice;
                case "Low Fat":
                    return lowFatPrice;
                case "Fat":
                    return fatPrice;
                default:
                    return 0;
            }
        }

        private void UpdateTotalCalories()
        {
            int totalIceCreams = (int)Checked1.Value + (int)Checked2.Value + (int)Checked3.Value + (int)Checked4.Value;
            decimal totalCalories = 0;

            totalCalories += CalculateTotalIceCreamCalories(Checked1, "Ice Lemon");
            totalCalories += CalculateTotalIceCreamCalories(Checked2, "Ice Banana");
            totalCalories += CalculateTotalIceCreamCalories(Checked3, "Ice Strawberry");
            totalCalories += CalculateTotalIceCreamCalories(Checked4, "Ice Chocolate");

            if (Extra1.Checked) // Peanut
            {
                totalCalories += CalculateSauceCalories(totalIceCreams, 30);
            }

            if (Extra2.Checked) // HazelNut
            {
                totalCalories += CalculateSauceCalories(totalIceCreams, 45);
            }

            if (Extra3.Checked) // Pistachio Nut
            {
                totalCalories += CalculateSauceCalories(totalIceCreams, 75);
            }

            COP2.Text = totalCalories.ToString();
        }

        private decimal CalculateTotalIceCreamCalories(NumericUpDown numericUpDown, string iceCreamType)
        {
            if ((int)numericUpDown.Value > 0 && (int)numericUpDown.Value <= 100)
            {
                return CalculateSingleIceCreamCalories(numericUpDown, iceCreamType, GetSelectedTypeOfMilk());
            }
            return 0;
        }

        private decimal CalculateSingleIceCreamCalories(NumericUpDown numericUpDown, string iceCreamType, string typeOfMilk)
        {
            decimal unitCalories = GetUnitCaloriesForIceCream(iceCreamType, typeOfMilk);
            int quantity = (int)numericUpDown.Value;
            return quantity * unitCalories;
        }

        private decimal GetUnitCaloriesForIceCream(string iceCreamType, string typeOfMilk)
        {
            switch (iceCreamType)
            {
                case "Ice Lemon":
                    return GetBaseCaloriesForTypeOfMilk(typeOfMilk, 115, 235, 175);
                case "Ice Banana":
                    return GetBaseCaloriesForTypeOfMilk(typeOfMilk, 175, 325, 365);
                case "Ice Strawberry":
                    return GetBaseCaloriesForTypeOfMilk(typeOfMilk, 135, 225, 280);
                case "Ice Chocolate":
                    return GetBaseCaloriesForTypeOfMilk(typeOfMilk, 235, 340, 400);
                default:
                    return 0;
            }
        }
        private decimal CalculateSauceCalories(int totalIceCreams, int caloriesPerIceCream)
        {
            return totalIceCreams * caloriesPerIceCream;
        }

        private decimal GetBaseCaloriesForTypeOfMilk(string typeOfMilk, decimal dietCalories, decimal lowFatCalories, decimal fatCalories)
        {
            switch (typeOfMilk)
            {
                case "Diet":
                    return dietCalories;
                case "Low Fat":
                    return lowFatCalories;
                case "Fat":
                    return fatCalories;
                default:
                    return 0;
            }
        }

        private string GetSelectedTypeOfMilk()
        {
            foreach (Control control in TOM.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return "";
        }

        private void Extra1_CheckedChanged(object sender, EventArgs e)
        {
            //Peanut
            UpdateTotalCalories();
        }

        private void Extra2_CheckedChanged(object sender, EventArgs e)
        {
            //HazelNut
            UpdateTotalCalories();
        }

        private void Extra3_CheckedChanged(object sender, EventArgs e)
        {
            //AntepNut
            UpdateTotalCalories();
        }


        private void COP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void COP2_TextChanged(object sender, EventArgs e)
        {

        }

        private void COP3_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalFee();

            Insert.Enabled = true;
        }

        private void COP4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            AddOrderToListView();
            InVoice.Enabled = true;
            Insert.Enabled = false;
            NewOrder.Enabled = true;
            UpdateOverallTotal();
        }

        private void AddOrderToListView()
        {
            string extras = GetSelectedExtras();
            string selectedTypeOfMilk = GetSelectedTypeOfMilk();

            int countIceLemon = (int)Checked1.Value;
            int countIceBanana = (int)Checked2.Value;
            int countIceStrawberry = (int)Checked3.Value;
            int countIceChocolate = (int)Checked4.Value;

            if (string.IsNullOrWhiteSpace(NameSurname.Text) ||
                string.IsNullOrWhiteSpace(extras) ||
                countIceLemon <= 0 && countIceBanana <= 0 && countIceStrawberry <= 0 && countIceChocolate <= 0)
            {
                return;
            }

            List<string> selectedIceCreams = new List<string>();

            if (countIceLemon > 0)
            {
                selectedIceCreams.Add($"{countIceLemon} x Lem");
            }

            if (countIceBanana > 0)
            {
                selectedIceCreams.Add($"{countIceBanana} x Ban");
            }

            if (countIceStrawberry > 0)
            {
                selectedIceCreams.Add($"{countIceStrawberry} x Str");
            }

            if (countIceChocolate > 0)
            {
                selectedIceCreams.Add($"{countIceChocolate} x Cho");
            }

            string selectedIceCreamsText = string.Join(", ", selectedIceCreams);

            ListViewItem item = new ListViewItem(NameSurname.Text);
            item.SubItems.Add(selectedTypeOfMilk);
            item.SubItems.Add(selectedIceCreamsText);
            item.SubItems.Add(extras);
            item.SubItems.Add(COP3.Text);
            item.SubItems.Add(COP4.Text);
            item.SubItems.Add(COP1.Text);
            item.SubItems.Add(COP2.Text);

            List.Items.Add(item);
        }

        private string GetSelectedExtras()
        {
            List<string> selectedExtras = new List<string>();

            if (Extra1.Checked)
            {
                selectedExtras.Add("PeaNut");
            }

            if (Extra2.Checked)
            {
                selectedExtras.Add("HazelNut");
            }

            if (Extra3.Checked)
            {
                selectedExtras.Add("AntepNut");
            }

            return string.Join(", ", selectedExtras);
        }

        private void UpdateOverallTotal()
        {
            decimal overallTotal = CalculateOverallTotal();
            GrandTotal.Text = overallTotal.ToString("");
        }

        private decimal CalculateOverallTotal()
        {
            decimal overallTotal = 0;

            foreach (ListViewItem item in List.Items)
            {
                decimal orderTotal;
                if (decimal.TryParse(item.SubItems[5].Text, out orderTotal))
                {
                    overallTotal += orderTotal;
                }
            }

            return overallTotal;
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            ClearForm();
            NSA.Enabled = true;
            NewOrder.Enabled = false;
            Insert.Enabled = false;
        }

        private void ClearForm()
        {
            foreach (Control control in TOM.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            foreach (int index in Additions1.CheckedIndices)
            {
                Additions1.SetItemChecked(index, false);
            }

            foreach (Control control in Extra.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            Checked1.Value = 0;
            Checked2.Value = 0;
            Checked3.Value = 0;
            Checked4.Value = 0;

            Checked1.Enabled = Checked2.Enabled = Checked3.Enabled = Checked4.Enabled = false;

            LemonPic.Image = null;
            BananaPic.Image = null;
            StrawberryPic.Image = null;
            ChocolatePic.Image = null;

            COP1.Text = "0.00";
            COP2.Text = "0";
            COP3.Value = 0;
            COP4.Text = "0.00";

            TOM.Enabled = true;
            Additions.Enabled = false;
            Extra.Enabled = false;
            COP.Enabled = false;
            
            Additions.Enabled = TOM1.Checked || TOM2.Checked || TOM3.Checked;
            Extra.Enabled = TOM1.Checked || TOM2.Checked || TOM3.Checked;
            COP.Enabled = TOM1.Checked || TOM2.Checked || TOM3.Checked;

        }


        private void NewCustomer_Click(object sender, EventArgs e)
        {
            NSA.Enabled = true;
            ClearAllForms();
        }

        private void ClearAllForms()
        {
            foreach (Control control in TOM.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            foreach (int index in Additions1.CheckedIndices)
            {
                Additions1.SetItemChecked(index, false);
            }

            foreach (Control control in Extra.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            Checked1.Value = 0;
            Checked2.Value = 0;
            Checked3.Value = 0;
            Checked4.Value = 0;

            Checked1.Enabled = Checked2.Enabled = Checked3.Enabled = Checked4.Enabled = false;

            LemonPic.Image = null;
            BananaPic.Image = null;
            StrawberryPic.Image = null;
            ChocolatePic.Image = null;

            NameSurname.Text = "";
            Address.Text = "";
            COP1.Text = "0.00";
            COP2.Text = "0";
            COP3.Value = 0;
            COP4.Text = "0.00";

            NSA.Enabled = true;
            TOM.Enabled = false;
            Additions.Enabled = false;
            Extra.Enabled = false;
            COP.Enabled = false;
            InVoice.Enabled = false;

            Additions.Enabled = TOM1.Checked || TOM2.Checked || TOM3.Checked;
            Extra.Enabled = TOM1.Checked || TOM2.Checked || TOM3.Checked;
            COP.Enabled = TOM1.Checked || TOM2.Checked || TOM3.Checked;

            List.Items.Clear();

            UpdateGrandTotal();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete.Enabled = List.SelectedItems.Count > 0;
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in List.SelectedItems.Cast<ListViewItem>().ToList())
            {
                List.Items.Remove(item);
            }

            Delete.Enabled = false;

            UpdateGrandTotal();
        }

        private void UpdateGrandTotal()
        {
            decimal grandTotal = 0;

            foreach (ListViewItem item in List.Items)
            {
                decimal totalPrice;
                if (decimal.TryParse(item.SubItems[5].Text, out totalPrice))
                {
                    grandTotal += totalPrice;
                }
            }

            GrandTotal.Text = grandTotal.ToString("0.00");
        }

        private void GrandTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckEnableTypeOfMilkGroupBox()
        {
            if (string.IsNullOrEmpty(NameSurname.Text))
            {
                TOM.Enabled = false;
            }
            else
            {
                TOM.Enabled = true;
            }
        }

        private void TOM_Enter(object sender, EventArgs e)
        {
            if (TOM1.Enabled || TOM2.Enabled || TOM3.Enabled == true) 
            {
                Additions.Enabled = true;
            }
        }

        private void ICS_Load(object sender, EventArgs e)
        {
            NameSurname.KeyDown += NameSurname_KeyDown;
            Address.KeyDown += NameSurname_KeyDown;

            Checked1.ValueChanged += Checked1_ValueChanged;
            Checked2.ValueChanged += Checked2_ValueChanged;
            Checked3.ValueChanged += Checked3_ValueChanged;
            Checked4.ValueChanged += Checked4_ValueChanged;
        }

        private void NameSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Control nextControl = GetNextControl((Control)sender, true);
                if (nextControl != null)
                {
                    nextControl.Focus();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Additions_Enter(object sender, EventArgs e)
        {
            Extra.Enabled = true;
            COP.Enabled = true;
        }
    }
}

