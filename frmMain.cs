//Main form of the text editor program

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Form load

            //Disable save and close file buttons
            btnSave.Enabled = false;
            btnClose.Enabled = false;

            //Set bool to false- no file is open
            ClsHoldValues.blnFileOpen = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Open file button

            //Variable referring to the class
            ClsFileRead fileRead = new ClsFileRead();

            //Launch file chooser dialog and save value to ClsHoldValues
            if (openTextDialog.ShowDialog() == DialogResult.OK)
            {
                //Hold the filename in ClsHoldValues
                ClsHoldValues.strFileName = openTextDialog.FileName;

                //Display the filename in the label
                lblFileName.Text = ClsHoldValues.strFileName;

                //Read and display the contents of the file
                fileRead.readTextFile(txtMain, lblFileName);
                
                //Enable the save and close buttons now that a file has been opened
                btnSave.Enabled = true;
                btnClose.Enabled = true;

                //Set the bool to true- a file is open
                ClsHoldValues.blnFileOpen = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save button

            //Variable referring to the class
            ClsFileWrite fileWrite = new ClsFileWrite();

            //Save file
            fileWrite.writeTextFile(txtMain);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit button

            if (ClsHoldValues.blnFileOpen == true)
            {
                //Variable referring to the class to save file
                ClsFileWrite fileWrite = new ClsFileWrite();

                //Variables for the messagebox
                string strMessage = "Save before exiting?";
                string strCaption = "Save?";
                MessageBoxButtons msgButtons = MessageBoxButtons.YesNoCancel;
                MessageBoxIcon msgIcon = MessageBoxIcon.Warning;
                DialogResult saveResult;

                //Display messagebox and save result
                saveResult = MessageBox.Show(strMessage, strCaption, msgButtons, msgIcon);

                switch (saveResult)
                {
                    case DialogResult.Yes:
                        //Save and exit program
                        fileWrite.writeTextFile(txtMain);
                        this.Close();
                        break;

                    case DialogResult.No:
                        //Exit program w/o saving
                        this.Close();
                        break;

                    case DialogResult.Cancel:
                        //Cancel- do nothing
                        break;
                }
            }

            else
            {
                //Exit progam as no file is open
                this.Close();
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            //Save As button
            
            //Variable referring to the class to create a new file
            ClsFileWrite fileCreate = new ClsFileWrite();

            //Show the file save dialog and save the file name to the class
            if (saveTextDialog.ShowDialog() == DialogResult.OK)
            {
                ClsHoldValues.strNewFileName = saveTextDialog.FileName;
                fileCreate.newTextFile(txtMain, lblFileName);
                
                //Enable Save and Close File buttons
                btnSave.Enabled = true;
                btnClose.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close file button

            //Variable referring to the class to save file
            ClsFileWrite fileWrite = new ClsFileWrite();

            //Variables for the messagebox
            string strMessage = "Save before closing the file?";
            string strCaption = "Save?";
            MessageBoxButtons msgButtons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon msgIcon = MessageBoxIcon.Warning;
            DialogResult saveResult;

            //Display messagebox and save result
            saveResult = MessageBox.Show(strMessage, strCaption, msgButtons, msgIcon);

            switch (saveResult)
            {
                case DialogResult.Yes:
                    //Save and close file
                    fileWrite.writeTextFile(txtMain);
                    txtMain.Text = "";
                    ClsHoldValues.strFileName = "";
                    lblFileName.Text = "";
                    btnSave.Enabled = false;
                    btnClose.Enabled = false;
                    ClsHoldValues.blnFileOpen = false;
                    break;

                case DialogResult.No:
                    //Close file w/o saving
                    txtMain.Text = "";
                    ClsHoldValues.strFileName = "";
                    lblFileName.Text = "";
                    btnSave.Enabled = false;
                    btnClose.Enabled = false;
                    ClsHoldValues.blnFileOpen = false;
                    break;

                case DialogResult.Cancel:
                    //Cancel
                    break;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //Choose font button

            //Set the font picker's font to the font of the textbox
            chooseFontDialog.Font = txtMain.Font;

            //Change the font of the textbox
            if (chooseFontDialog.ShowDialog() == DialogResult.OK)
            {
                txtMain.Font = chooseFontDialog.Font;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //Help & About button

            frmAboutBox frm = new frmAboutBox();
            frm.ShowDialog();
        }
    }
}
