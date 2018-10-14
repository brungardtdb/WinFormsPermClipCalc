/**********************************************
 * Perimeter Clip Calculator WinForms 2.0
 * Author: David Brungardt
 * 
 * This program calculates the quantity of perimeter clips on a 
 * standing seam roof based on input from the user. 
 * The user selects "Start" or "Finish", then enters
 * the start or finish dimension for that corner zone of the roof.
 * The user then presses the "Calculate" button and is prompted to 
 * enter the first/next purlin run dimension. When the purlin
 * run dimensions exceed the vertical zone size, the calculation
 * will stop automatically. The program calculates the quantity of
 * perimeter clips per purlin by dividing the zone size called out
 * by design by 24 (each panel is 24" wide). 1 clip is then added
 * to the total for the panel start. One more clip is added if the 
 * zone size is not evenly divisible by 24 or if the start or finish is < 24. 
 * The user then begins to enter each purlin dimension separately
 * into a visual basic input box. The user will be prompted to enter
 * the next purlin dimension until the total dimensions entered exceed the
 * vertical zone size. For each dimension entered, a counter will be
 * increased by one. The total perimeter clips are then calculated 
 * by multiplying the total clips per purlin by the counter. 
 * *******************************************/

using System;
using System.Windows.Forms;
using WinFormsPermClipCalc.ClipCalculators;
using WinFormsPermClipCalc.Enums;
using WinFormsPermClipCalc.Exception_Handling;
using WinFormsPermClipCalc.Interfaces;
using Microsoft.VisualBasic;


namespace WinFormsPermClipCalc
{
    public partial class PermCalcFrm : Form
    {
        public PermCalcFrm()
        {
            InitializeComponent();
        }

        private void PermCalcFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // local fields for program
            double startFinishDim;
            double finishFinishDim;
            double horizontalZoneSize;
            double verticalZoneSize;
            bool startCalc = false;


            if (comStartFinish.SelectedItem != null)
            {

                StartFinish startOrFinish = new StartFinish();

                if (comStartFinish.SelectedItem.ToString() == "Start")
                {
                    // set StartFinish enum to "Finish"
                    startOrFinish = StartFinish.Start;

                    if (startOrFinish == StartFinish.Start)
                    {


                        if (txtStartFinish.Text != "" && txtHorizontalZone.Text != "" && txtVerticalZone.Text != "")
                        {
                            // Try to convert the text in textboxes to double values
                            if (double.TryParse(txtStartFinish.Text, out startFinishDim)) // try to parse startFinishDim
                            {
                                if (double.TryParse(txtHorizontalZone.Text, out horizontalZoneSize)) // try to parse horizontalZoneSize
                                {
                                    if (double.TryParse(txtVerticalZone.Text, out verticalZoneSize)) // try to parse verticalZoneSize
                                    {
                                        int clipsPerPurlin = Convert.ToInt32(Math.Floor(((horizontalZoneSize - startFinishDim) / 24))) + 2;

                                        // pass values to constructor
                                        ClipCalculator perimeterClipCalc = new PerimeterClipCalculator(startFinishDim, horizontalZoneSize, verticalZoneSize, startOrFinish);

                                        // start calculation
                                        startCalc = true;

                                        if (startCalc == true)
                                        {
                                            bool cornerZoneReached = false;
                                            double purlinString;
                                            int purlinQty = 0;

                                            // loop for user to enter purlin dimensions, terminates when dimensions entered by user exceed vertical zone size
                                            do
                                            {

                                                if (double.TryParse(Interaction.InputBox("Please enter the first/next purlin run in decimal inches.", "Purlin Run Dimension", "", 0), out purlinString))
                                                {
                                                    lstCalculate.Items.Add(purlinString);
                                                    perimeterClipCalc.TotalPurlinInches = perimeterClipCalc.TotalPurlinInches + purlinString;
                                                    purlinQty++;

                                                    if (perimeterClipCalc.TotalPurlinInches > verticalZoneSize)
                                                    {
                                                        // If zone size - start/finish dimension is divisible by 24, subtract 1 clip per purlin                                                        
                                                        if ((horizontalZoneSize - startFinishDim) % 24 == 0)
                                                        {
                                                            cornerZoneReached = true;
                                                            lblResult.Visible = true;
                                                            lblResultDefine.Visible = true;
                                                            lblResult.Text = Convert.ToString(perimeterClipCalc.Calculate(clipsPerPurlin, purlinQty) - purlinQty);
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            cornerZoneReached = true;
                                                            lblResult.Visible = true;
                                                            lblResultDefine.Visible = true;
                                                            lblResult.Text = Convert.ToString(perimeterClipCalc.Calculate(clipsPerPurlin, purlinQty));
                                                            break;
                                                        }

                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show(Consts.PurlinStringError);
                                                    break;
                                                }

                                            } while (cornerZoneReached == false);

                                        }


                                    }
                                    else
                                    {
                                        // show error for verticalZoneSize
                                        MessageBox.Show(Consts.VerticalZoneError);
                                        return;
                                    }
                                }
                                else
                                {
                                    // show error for horizontalZoneSize
                                    MessageBox.Show(Consts.HorizontalZoneError);
                                    return;
                                }

                            }
                            else
                            {
                                // show error for startFinishDim
                                MessageBox.Show(Consts.StartOutOfRange);
                                return;
                            }
                        }
                        else
                        {
                            // show error for invalid entry
                            MessageBox.Show(Consts.InvalidEntryError);
                            return;
                        }

                    }
                }
                else if (comStartFinish.SelectedItem.ToString() == "Finish")
                {
                    // set StartFinish enum to "Finish"
                    startOrFinish = StartFinish.Finish;

                    if (startOrFinish == StartFinish.Finish)
                    {

                        if (txtStartFinish.Text != "" && txtHorizontalZone.Text != "" && txtVerticalZone.Text != "")
                        {

                            // Try to convert the text in textboxes to double values
                            if (double.TryParse(txtStartFinish.Text, out finishFinishDim)) // try to parse startFinishDim
                            {
                                if (double.TryParse(txtHorizontalZone.Text, out horizontalZoneSize)) // try to parse horizontalZoneSize
                                {
                                    if (double.TryParse(txtVerticalZone.Text, out verticalZoneSize)) // try to parse verticalZoneSize
                                    {
                                        // Calculate clips per purlin

                                        int clipsPerPurlin = Convert.ToInt32(Math.Floor(((horizontalZoneSize - finishFinishDim) / 24))) + 2;

                                        // pass values to constructor
                                        ClipCalculator perimeterClipCalc = new PerimeterClipCalculator(finishFinishDim, horizontalZoneSize, verticalZoneSize, startOrFinish);

                                        // start calculation
                                        startCalc = true;

                                        if (startCalc == true)
                                        {
                                            bool cornerZoneReached = false;
                                            double purlinString;
                                            int purlinQty = 0;

                                            // loop for user to enter purlin dimensions, terminates when dimensions entered by user exceed vertical zone size
                                            do
                                            {

                                                if (double.TryParse(Interaction.InputBox("Please enter the first/next purlin run in decimal inches.", "Purlin Run Dimension", "", 0), out purlinString))
                                                {
                                                    lstCalculate.Items.Add(purlinString);
                                                    perimeterClipCalc.TotalPurlinInches = perimeterClipCalc.TotalPurlinInches + purlinString;
                                                    purlinQty++;

                                                    if (perimeterClipCalc.TotalPurlinInches > verticalZoneSize)
                                                    {
                                                        // If zone size - start/finish dimension is divisible by 24, subtract 1 clip per purlin                                                          
                                                        if ((horizontalZoneSize - finishFinishDim) % 24 == 0)
                                                        {
                                                            cornerZoneReached = true;
                                                            lblResult.Visible = true;
                                                            lblResultDefine.Visible = true;
                                                            lblResult.Text = Convert.ToString(perimeterClipCalc.Calculate(clipsPerPurlin, purlinQty) - purlinQty);
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            cornerZoneReached = true;
                                                            lblResult.Visible = true;
                                                            lblResultDefine.Visible = true;
                                                            lblResult.Text = Convert.ToString(perimeterClipCalc.Calculate(clipsPerPurlin, purlinQty));
                                                            break;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show(Consts.PurlinStringError);
                                                    break;
                                                }

                                            } while (cornerZoneReached == false);
                                        }



                                    }
                                    else
                                    {
                                        // show error for verticalZoneSize
                                        MessageBox.Show(Consts.VerticalZoneError);
                                        return;
                                    }
                                }
                                else
                                {
                                    // show error for horizontalZoneSize
                                    MessageBox.Show(Consts.HorizontalZoneError);
                                    return;
                                }
                            }
                            else
                            {
                                // show error for startFinishDim
                                MessageBox.Show(Consts.StartOutOfRange);
                                return;
                            }
                        }
                        else
                        {
                            // show error for invalid entry
                            MessageBox.Show(Consts.InvalidEntryError);
                            return;
                        }

                    }
                }



            }
            else
            {
                MessageBox.Show(Consts.StartFinishError);
                return;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStartFinish.Clear();
            txtHorizontalZone.Clear();
            txtVerticalZone.Clear();
            lstCalculate.Items.Clear();
            lblResult.Visible = false;
            lblResultDefine.Visible = false;

        }
    }
}

