﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            String input = TxtInput.Text.ToLower();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' ||
                    input[i] == 'i' || input[i] == 'o' ||
                    input[i] == 'u')
                {
                    sum++;
                }
            }

            LblResult.Text = Convert.ToString(sum);

        }
    }
}
