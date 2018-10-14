/*
 PerimeterClipCalculator class used 
 to calculate quantities of perimeter clips 
 inherits abstract ClipCalculator class and 
 ICalculate interface
 */

using WinFormsPermClipCalc.Enums;
using WinFormsPermClipCalc.Interfaces;

namespace WinFormsPermClipCalc.ClipCalculators
{


    class PerimeterClipCalculator : ClipCalculator, ICalculate
    {

        public PerimeterClipCalculator(double startFinishDim, double horizontalZoneSize, double verticalZoneSize, StartFinish startFinish)
        {
            if (startFinish == StartFinish.Start)
            {
                base.StartFinishDim = startFinishDim;
            }
            else if (startFinish == StartFinish.Finish)
            {
                base.FinishFinishDim = startFinishDim;
            }
            base.HorizontalZoneSize = horizontalZoneSize;
            base.VerticalZoneSize = verticalZoneSize;
            base.StartFinish = startFinish;
        }



        public override int Calculate(int clipsPerPurlin, int counter)
        {
            base.TotalClips = clipsPerPurlin * counter;
            return base.TotalClips;
        }
    }
}

