using System;
using System.Collections.Generic;
using System.Text;
using Test.Model;

namespace Test.Logic
{
    public class SubtractionLogic
    {
        public double Subtract(SubtractionModel model)
        {
            return model.NumA - model.NumB;
        }
            
    }
}
