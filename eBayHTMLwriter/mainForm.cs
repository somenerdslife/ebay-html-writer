using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*******************************************************************************
 * Program: eBayHTMLwriter
 * Description: Creates an HTML file for an eBay listing based on input info
 * Programmer: Wesley Kendall
 * Date: 05/01/2019
 * ****************************************************************************/
namespace eBayHTMLwriter
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        string titleString;
        List<string> propTitlesList = new List<string>();
        List<string> propertiesList = new List<string>();
        List<string> imagesList = new List<string>();
        string photoLink;
        int i = 0;

        // Assigns listing title
        private void addTitleButton_Click(object sender, EventArgs e)
        {
            titleString = titleTB.Text;
            titleTB.Text = "";
            writeButton.Visible = true; // Ensures the listing has a title before the HTML file is written
        }

        // Adds listing property
        private void addPropertyButton_Click(object sender, EventArgs e)
        {
            propTitlesList.Add(propTitleTB.Text);
            propertiesList.Add(propInfoTB.Text);
            propTitleTB.Text = "";
            propInfoTB.Text = "";
        }

        // Adds photo for listing
        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            imagesList.Add(photoLinkTB.Text);
            photoLinkTB.Text = "";
        }

        // Assigns main listing photo
        private void mainPhotoButton_Click(object sender, EventArgs e)
        {
            photoLink = mainPhotoTB.Text;
            mainPhotoTB.Text = "";
        }

        // Writes the HTML 
        private void writeButton_Click(object sender, EventArgs e)
        {
            string[] propertiesArray = propertiesList.ToArray(); // For writing HTML for properties later
            StreamWriter fileWriter;
            fileWriter = File.CreateText(@"D:\eBay\listing.html"); // File location path
            fileWriter.WriteLine("<table style='width: 90%;' summary='' border='10' cellspacing='1' cellpadding='3'>");
            fileWriter.WriteLine("<tbody>");
            fileWriter.WriteLine("<tr>");
            fileWriter.WriteLine("<td>");
            fileWriter.WriteLine("<p align='center'><br /> <strong><span style='font-family: Trebuchet MS; font-size: xx-large;'>" + titleString + "</span></strong></p>"); // Writes HTML for the title
            fileWriter.WriteLine("<div align='center'><center>");
            fileWriter.WriteLine("<table id='AutoNumber6' style='width: 100%;' border='1' cellspacing='1' cellpadding='5'>");
            fileWriter.WriteLine("<tbody>");
            fileWriter.WriteLine("<tr>");
            fileWriter.WriteLine("<td width='42%'>");
            fileWriter.WriteLine("<table id='AutoNumber7' style='width: 100%;' border='1' cellspacing='1'>");
            fileWriter.WriteLine("<tbody>");
            foreach (string image in imagesList) // Writes HTML for each image
            {
                fileWriter.WriteLine("<tr>");
                fileWriter.WriteLine("<td align='center' width='100%'>&nbsp;");
                fileWriter.WriteLine("<p><img src='" + image + "' alt='' width='281' border='0' /></p>");
                fileWriter.WriteLine("<p>&nbsp;</p>");
                fileWriter.WriteLine("</td>");
                fileWriter.WriteLine("</tr>");
            }
            fileWriter.WriteLine("</tbody>");
            fileWriter.WriteLine("</table>");
            fileWriter.WriteLine("</td>");
            fileWriter.WriteLine("<td style='vertical-align: top;' width='58%'>");
            fileWriter.WriteLine("<p style='text-align: center;' align='center'><span style='font-family: Arial; font-size: large;'>PRODUCT DETAILS</span><strong><span style='font-family: Arial;'><br /></span></strong></p>");
            fileWriter.WriteLine("<hr />");
            fileWriter.WriteLine("<ul>");
            foreach (string title in propTitlesList) // Writes HTML for each property
            {
                fileWriter.WriteLine("<li style='text-align: left;'><span style='font-size: large;'><strong><span style='color: #111111; font-family: Arial;'>" + title + ": " + propertiesArray[i] + "<br /><br /></span></strong></span></li>");
                i++;
            }
            i = 0; // Ensures property titles and property info match if another property is added later and this file is overwritten
            fileWriter.WriteLine("</ul>");
            fileWriter.WriteLine("<p style='text-align: center;'><strong><span style='color: #111111; font-family: Arial; font-size: small;'><span style='font-size: x-large;'><span style='font-size: large;'><img src='" + photoLink + "' alt='' width='281' /></span></span></span></strong></p>"); // Writes HTML for the main photo
            fileWriter.WriteLine("<p><strong><span style='color: #111111; font-family: Arial; font-size: small;'><span style='font-size: x-large;'><span style='font-size: large;'><br /></span></span></span></strong></p>");
            fileWriter.WriteLine("<p style='text-align: center;'><em><span style='color: #111111; font-family: Arial; font-size: medium;'>Returns accepted within 14 days. If you have any questions or concerns, please message me and I'll be happy to help!</span></em><strong><span style='color: #111111; font-family: Arial; font-size: small;'><span style='font-size: x-large;'><span style='font-size: large;'><br /></span></span></span></strong></p>");
            fileWriter.WriteLine("<p style='text-align: center;'><strong><span style='color: #111111; font-family: Arial; font-size: small;'><span style='font-size: x-large;'><span style='font-size: large;'><br /></span></span></span></strong></p>");
            fileWriter.WriteLine("<p style='text-align: center;'><em><span style='color: #111111; font-family: Arial; font-size: medium;'><strong>Honest reviews are appreciated!</strong><br /></span></em></p>");
            fileWriter.WriteLine("</td>");
            fileWriter.WriteLine("</tr>");
            fileWriter.WriteLine("</tbody>");
            fileWriter.WriteLine("</table>");
            fileWriter.WriteLine("</center></div>");
            fileWriter.WriteLine("</td>");
            fileWriter.WriteLine("</tr>");
            fileWriter.WriteLine("</tbody>");
            fileWriter.WriteLine("</table>");
            fileWriter.WriteLine("</center></div>");
            fileWriter.Close();
            newListingButton.Visible = true;
        }

        // Ensures new listings don't get old info
        private void newListingButton_Click(object sender, EventArgs e)
        {
            propTitlesList.Clear();
            propertiesList.Clear();
            imagesList.Clear();
            writeButton.Visible = false;
            newListingButton.Visible = false;
        }
    }
}
