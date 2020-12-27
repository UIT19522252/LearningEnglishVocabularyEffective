﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenu
{
    public partial class FOptionLearns : Form
    {
        public FOptionLearns()
        {
            InitializeComponent();
        }

        private void btnMultipleChoices_Click(object sender, EventArgs e)
        {
            FPreviewNewWord tabPreviewNewWord = new FPreviewNewWord();
            tabPreviewNewWord.AutoScroll = true;
            tabPreviewNewWord.TopLevel = false;
            pnlLoad.Controls.Clear();
            pnlLoad.Controls.Add(tabPreviewNewWord);

            tabPreviewNewWord.FormBorderStyle = FormBorderStyle.None;
            tabPreviewNewWord.Show();
            pnlLoad.Dock = DockStyle.Fill;
            pnlLoad.Visible = true;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            G_RPG game = new G_RPG();
            game.AutoScroll = true;
            game.TopLevel = false;
            pnlLoad.Controls.Clear();
            pnlLoad.Controls.Add(game);
            pnlLoad.Dock = DockStyle.Fill;
            game.FormBorderStyle = FormBorderStyle.None;
            game.Show();
            pnlLoad.Visible = true;
        }
    }
}