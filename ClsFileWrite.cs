//Class containing methods to write to a file

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Get software for working w/file IO and win32 controls
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    class ClsFileWrite
    {
        //Method for writing to a file
        public void writeTextFile(TextBox txtMain)
        {
            //Get and store filename from ClsHoldValues
            string strFileName;
            strFileName = ClsHoldValues.strFileName;

            //Variable to hold text to be written
            string strHoldText;
            strHoldText = txtMain.Text;

            try
            {
                using (StreamWriter streamWrite = new StreamWriter(strFileName))
                {
                    streamWrite.Write(strHoldText);
                }
            }

            catch (Exception ex)
            {
                //An error has occured, inform the user
                MessageBox.Show("Error writing to the file: " + ex.Message);
            }
        }

        //Method for creating a file
        public void newTextFile(TextBox txtMain, Label lblFileName)
        {
            //Variable for the new file name
            string strNewFileName;
            strNewFileName = ClsHoldValues.strNewFileName;

            //Variable for holding the text to be saved
            string strHoldText;
            strHoldText = txtMain.Text;

            //Create and write to a new text file
            try
            {
                using (StreamWriter fileCreate = File.CreateText(strNewFileName))
                {
                    fileCreate.Write(strHoldText);
                    ClsHoldValues.strFileName = strNewFileName;
                    lblFileName.Text = strNewFileName;
                    ClsHoldValues.blnFileOpen = true;
                }
            }

            catch (Exception ex)
            {
                //An error has occured, inform the user
                MessageBox.Show("Error creating a new file: " + ex.Message);
            }
        }
    }
}
