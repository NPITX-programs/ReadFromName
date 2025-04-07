﻿using System;
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

        #region messages
        private void error(string message, Exception ex = null, bool revealException = false)
        {
            string msg = message; //what message to display
            if (revealException) //put the toggle
            {
                msg = msg + ": " + ex.Message; //the message
            }//a bool to toggle if the exception code should be included in the error message
            MessageBox.Show(msg); //show the message
        } //this is for error messages. the text is mandatory, but the
          //rest isn't necessary. if you don't provide an exception, it won't display one. If you provide an error, it will default to "hide error".
          // WARNING: If you provide a boolean, you can controll if it's hidden. If you provide a boolean but no error, well, it won't work righ
        #endregion messages

        #region fileAcess
        private string fullPath()
        {
            string fullPath = folderName + fileName + fileExtension; //the path is in 3 parts for modularity. this combines them
            return fullPath; //this part outputs them
        } //full path (requires no input, it just combines the 3 pre-set variables). Due to method overloading, this is the "same" method as the one
        // that checks for the files existance. if you mathch this ones paramaters (meaning no input), it will do this one. Input a boolean, and it will match the other, and therefore check
        //for it's existance

        private bool fullPath(bool confirm)
        {
            if(confirm) //checks if confirm has an input, then checks if it's true
            {
                bool status = File.Exists(fullPath()); //if it is true, it will proceed to check if the file defined by fullPath exists
                if (status)
                {
                    return true; //if it exists, it outputs trye
                } //a boolean representing wether or not the file exists
                else
                {
                    error(errorMessage); //displays the error message about haveing no file
                    // probally would be best if I told them the reason, but where's the fun in that?
                    //this allows the message to be trigered as part of the check, so the if that's within the button doesn't need it
                    return false; //outputs the false, as it doesn't exist
                } //no file
            }// wether to confirm or not. if it should, it does this code
            else
            {
                return false; //if the input is false, it doesn't check, and outputs a false
            } //don't check
        } //confirming the file
          // I used the same method as the one to make the path, and a feature I found called "method overloading". basicaly, by making a method with different paramaters
          //it will run the method that I put the paramaters in. So, if I don't put in anything (the first method), it will output that string. But, if I put in a boolean (like this one)
          //then it will preform the check
        #endregion


        #region UI
        private void btn_readAllText_Click(object sender, EventArgs e)
        {
            if (fullPath(true))
            {
                try //double check
                {
                    string text = File.ReadAllText(fullPath());  //read the file
                    lst_readAllText.Items.Clear(); //clear the list
                    lst_readAllText.Items.Add(text); //add the contents to the list box
                }
                catch (Exception ex) //if there's an error
                {
                    error(errorMessage, ex); //displays the eror message, but due to the optional value, never displays the error the computer threw (however it
                                             //is still acessable, as it's acessible, since it's a higher level variable
                } //double check
            } //check for files
        } //read all the text in the file

        private void btn_readAllLine_Click(object sender, EventArgs e)
        {
            if (fullPath(true)) //check if file exists
            {
                try //double check
                {
                    string[] contentArray = File.ReadAllLines(fullPath()); //get the full lines output
                    foreach (string item in contentArray) //repeat with each
                    {
                        lst_readAllLine.Items.Add(item); //add item to list box
                    } //repeat each individual line to add it
                } catch (Exception ex) //check for error
                {
                    error(errorMessage, ex); //display error if it somehow manages to not work even if the file is there
                } //double check
            } //check if file exists
        } //read all the lines in the file

        private void btn_stringReader_Click(object sender, EventArgs e)
        {

        }

        private void btn_triggerAll_Click(object sender, EventArgs e)
        {
            btn_readAllLine_Click(sender, e); //triger read all lines
            btn_readAllText_Click(sender, e); //triger read all text
            btn_stringReader_Click(sender, e); //trigger the string reader
        } //triger all the buttons

        #endregion UI
    }
}
