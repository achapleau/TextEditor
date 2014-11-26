//Class that contains methods to read files

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Get software for working w/file IO and controls
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    class ClsFileRead
    {
        //Method for reading all the text in a file and displaying in a textbox
        public void readTextFile(TextBox txtMain, Label lblFileName)
        {
            //Get and store filename
            string strFileName;
            strFileName = ClsHoldValues.strFileName;

            //String to hold contents of file
            string strHoldText;

            try
            {
                using (StreamReader streamRead = new StreamReader(strFileName))
                {
                    strHoldText = streamRead.ReadToEnd();
                    txtMain.Text = strHoldText;                    
                }
            }

            catch (Exception ex)
            {
                lblFileName.Text = "Could not open the file: " + ex.Message;
            }
        }
    }
}
