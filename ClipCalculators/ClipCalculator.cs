// Abstract clip calculator class
// Inherits Icalculate interface

using WinFormsPermClipCalc.Enums;
using WinFormsPermClipCalc.Interfaces;
using WinFormsPermClipCalc.Exception_Handling;
using System;
using System.Windows.Forms;

namespace WinFormsPermClipCalc.ClipCalculators
{
    public abstract class ClipCalculator : ICalculate
    {
        // Fields for abstract ClipCalculator class
        private double startFinishDim; // The start dimension entered by the user.
        private double finishFinishDim; // The finish dimension entered by the user.
        private double horizontalZoneSize; // The horizontal zone size entered by the user.
        private double verticalZoneSize; // The vertical zone size etered by the user.
        private double cornerZoneActual; // The start/finish dim subtracted from the initial corner zone size.
        private int clipsPerPurlin; // The amount of clips per run of purlins
        private int totalClips; // total clips for calculated section of roof.
        private double totalPurlinInches; // total inches for purlin runs in corner zone       


        // Create new instace of static exception message class

        private StartFinish startFinish; // property to obtain start/finish enum

        // property to obtain start / finish dimension
        public double StartFinishDim
        {
            get
            {
                return this.startFinishDim;
            }
            set
            {
                if (value >= 10.625 && value <= 24.125)
                {
                    this.startFinishDim = value;
                }
                else
                {
                    MessageBox.Show(Consts.StartOutOfRange);

                }
            }
        }

        // property to obtain start / finish dimension
        public double FinishFinishDim
        {
            get
            {
                return this.finishFinishDim;
            }
            set
            {
                if (value >= 12.125 && value <= 24.125)
                {
                    this.finishFinishDim = value;
                }
                else
                {
                    MessageBox.Show(Consts.FinishOutOfRange);
                }
            }
        }


        // property to obtain horizontal zone size
        public double HorizontalZoneSize
        {
            get
            {
                return this.horizontalZoneSize;
            }
            set
            {
                if (value > 0)
                {
                    this.horizontalZoneSize = value;
                }
                else
                {
                    MessageBox.Show(Consts.HorizontalZoneError);
                }
            }
        }

        // property to obtain vertical zone size
        public double VerticalZoneSize
        {
            get
            {
                return this.verticalZoneSize;
            }
            set
            {
                if (value > 0)
                {
                    this.verticalZoneSize = value;
                }
                else
                {
                    MessageBox.Show(Consts.VerticalZoneError);
                }
            }
        }

        // property to obtain true size of corner zone
        // (horizontal zone sice - start / finish dimension
        public double CornerZoneActual
        {
            get
            {
                return this.cornerZoneActual;
            }
            set
            {
                this.cornerZoneActual = this.horizontalZoneSize - this.startFinishDim;
            }
        }

        // property to obtain total clips per run of purlins
        public int ClipsPerPurlin
        {
            get
            {
                return this.clipsPerPurlin;
            }
            set
            {
                this.clipsPerPurlin = (Convert.ToInt32(Math.Round(cornerZoneActual / 24)) + 2);
            }
        }

        // property to obtain total number of clips
        public int TotalClips
        {
            get
            {
                return this.totalClips;
            }
            set
            {
                this.totalClips = value;
            }
        }

        // property to obtain total purlin run inches in corner zone
        public double TotalPurlinInches
        {
            get
            {
                return this.totalPurlinInches;
            }
            set
            {
                this.totalPurlinInches = value;
            }

        }



        // property to obtain enum determining if dimension is a 
        // start dimension or a finish dimension
        public StartFinish StartFinish
        {
            get
            {
                return this.startFinish;
            }
            set
            {
                this.startFinish = value;
            }
        }

        // Empty constructor for abstract method.
        protected ClipCalculator()
        {

        }

        // abstract method to be instantiated by inheriting class
        // method is abstract so as to leave actual implementation
        // of method up to the class that's inheriting the abstract
        // class and method
        public abstract int Calculate(int clipsPerPurlin, int counter);

    }
}

