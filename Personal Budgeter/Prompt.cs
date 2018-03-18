using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Personal_Budgeter
{
    public static class Prompt
    {
        public static string getUserInput(string title, string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 500,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label promptLabel = new Label()
            {
                Left = 50,
                Top = 30,
                Text = prompt,
                Width = 400
            };

            TextBox promptTextBox = new TextBox()
            {
                Left = 50,
                Top = 60,
                Width = 400
            };

            Button confirmation = new Button()
            {
                Text = "Ok",
                Left = 350,
                Top = 80,
                Width = 100,
                DialogResult = DialogResult.OK
            };

            confirmation.Click += (sender, e) => { promptForm.Close();  };
            promptForm.Controls.Add(promptTextBox);
            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(promptLabel);
            promptForm.AcceptButton = confirmation;

            if (promptForm.ShowDialog() == DialogResult.OK)
                return promptTextBox.Text;
            else
                return "";

        }
    }
}
