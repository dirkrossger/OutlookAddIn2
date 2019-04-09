﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace OutlookAddIn2
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm();
        }

            
        

        private Form1 form1 = null;

        private void ShowForm()
        {
            if (form1 == null)
            {                
                form1 = new Form1(Globals.ThisAddIn.Application);                
            }
            form1.ShowDialog();
        }
        
    }
}
