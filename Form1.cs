using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFromName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        string folderName = @"H:\Students_Folder\Charlie Hatch\Semesters\Multi-Semester\App Dev\Projects\App Dev 2\ReadFromName\";
        string fileName = "file";
        string fileExtension = ".txt";
        const string errorMessage = "I'm sorry dave, I'm afraid I can't do that";


        private void error(string message, Exception ex = null, bool revealException = false)
        {
            string msg = message;
            if (revealException) {
              msg = msg + ": " + ex.Message;
            }
            MessageBox.Show(msg);
        } //this is for error messages. the text is mandatory, but the
          //rest isn't necessary. if you don't provide an exception, it won't display one. If you provide an error, it will default to "hide error".
          //If you provide a boolean, you can controll if it's hidden. If you provide a boolean but no error, well, it won't work right

        private string fullPath()
        {
            string fullPath = folderName + fileName + fileExtension;
            return fullPath;
        }
        private bool fullPath(bool confirm)
        {
            if(confirm)
            {
                bool status = File.Exists(fullPath());
                if (status)
                {
                    return true;
                } else
                {
                    error(errorMessage); //displays the error message about haveing no file
                    // probally would be best if I told them the reason, but where's the fun in that?
                    return false;
                }
            } else
            {
                return false;
            }
        }

        private void btn_readAllText_Click(object sender, EventArgs e)
        {
            if (fullPath(true))
            {
                try
                {
                    string text = File.ReadAllText(fullPath());
                    lst_readAllText.Items.Clear();
                    lst_readAllText.Items.Add(text);
                }
                catch (Exception ex)
                {
                    error(errorMessage, ex); //displays the eror message, but due to the optional value, never displays the error the computer threw (however it
                                             //is still acessable, as it's acessible, since it's a higher level variable
                }
            }
        }

        private void btn_readAllLine_Click(object sender, EventArgs e)
        {
            if (fullPath(true))
            {
                try
                {
                    string[] contentArray = File.ReadAllLines(fullPath());
                    foreach (string item in contentArray)
                    {
                        
                    }

                    lst_readAllLine.Items.Add(contentText);
                } catch (Exception ex)
                {
                    error(errorMessage, ex); //display error if it somehow manages to not work even if the file is there
                }
            }
        }

        private void btn_triggerAll_Click(object sender, EventArgs e)
        {
            btn_readAllLine_Click(sender, e);
            btn_readAllText_Click(sender, e);
        }
    }
}
