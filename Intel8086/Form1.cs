﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel8086
{
    public partial class Form1 : Form
    {
        string ax;
        string bx;
        string cx;
        string dx;

        string pierwszy;
        string drugi;
        string zamiana;

        /*  */
        public Form1()
        {
            InitializeComponent();
            ax = "0000";
            bx = "0000";
            cx = "0000";
            dx = "0000";
            axView.Text = ax;
            axText.Text = ax;
            bxView.Text = bx;
            bxText.Text = bx;
            cxView.Text = cx;
            cxText.Text = cx;
            dxView.Text = dx;
            dxText.Text = dx;
        }

        /* Po kliknięciu klawisza PRZYPISZ */
        private void buttonMOV_Click(object sender, EventArgs e)
        {
            // ZLE TO JESZCZE DZIALA if (axText.Text.Length == 4 || bxText.Text.Length == 4 || cxText.Text.Length == 4 || dxText.Text.Length == 4)
            if (comboBoxFROM.Text.Length > 0 && comboBoxTO.Text.Length > 0)
            {
                if (axText.Text.Length == 4 || bxText.Text.Length == 4 || cxText.Text.Length == 4 || dxText.Text.Length == 4)
                    movLabel.Text = $"MOV {pierwszy}, {drugi}";
            }
            else if (comboBoxFROM.Text.Length > 0)
                movLabel.Text = $"MOV {pierwszy}";
            else
                movLabel.Text = "";

            switch (comboBoxFROM.Text)
            {
                case "AX":
                    {
                        switch (comboBoxTO.Text)
                        {
                            case "AX":
                                {
                                    if (axText.Text.Length == 4) axView.Text = axText.Text.ToUpper();
                                    break;
                                }
                            case "BX":
                                {
                                    if (axText.Text.Length == 4) bxView.Text = axText.Text.ToUpper();
                                    break;
                                }
                            case "CX":
                                {
                                    if (axText.Text.Length == 4) cxView.Text = axText.Text.ToUpper();
                                    break;
                                }
                            case "DX":
                                {
                                    if (axText.Text.Length == 4) dxView.Text = axText.Text.ToUpper();
                                    break;
                                }
                        }
                        break;
                    }
                case "BX":
                    {
                        switch (comboBoxTO.Text)
                        {
                            case "AX":
                                {
                                    if (bxText.Text.Length == 4) axView.Text = bxText.Text.ToUpper();
                                    break;
                                }
                            case "BX":
                                {
                                    if (bxText.Text.Length == 4) bxView.Text = bxText.Text.ToUpper();
                                    break;
                                }
                            case "CX":
                                {
                                    if (bxText.Text.Length == 4) cxView.Text = bxText.Text.ToUpper();
                                    break;
                                }
                            case "DX":
                                {
                                    if (bxText.Text.Length == 4) dxView.Text = bxText.Text.ToUpper();
                                    break;
                                }
                        }
                        break;
                    }
                case "CX":
                    {
                        switch (comboBoxTO.Text)
                        {
                            case "AX":
                                {
                                    if (cxText.Text.Length == 4) axView.Text = cxText.Text.ToUpper();
                                    break;
                                }
                            case "BX":
                                {
                                    if (cxText.Text.Length == 4) bxView.Text = cxText.Text.ToUpper();
                                    break;
                                }
                            case "CX":
                                {
                                    if (cxText.Text.Length == 4) cxView.Text = cxText.Text.ToUpper();
                                    break;
                                }
                            case "DX":
                                {
                                    if (cxText.Text.Length == 4) dxView.Text = cxText.Text.ToUpper();
                                    break;
                                }
                        }
                        break;
                    }
                case "DX":
                    {
                        switch (comboBoxTO.Text)
                        {
                            case "AX":
                                {
                                    if (dxText.Text.Length == 4) axView.Text = dxText.Text.ToUpper();
                                    break;
                                }
                            case "BX":
                                {
                                    if (dxText.Text.Length == 4) bxView.Text = dxText.Text.ToUpper();
                                    break;
                                }
                            case "CX":
                                {
                                    if (dxText.Text.Length == 4) cxView.Text = dxText.Text.ToUpper();
                                    break;
                                }
                            case "DX":
                                {
                                    if (dxText.Text.Length == 4) dxView.Text = dxText.Text.ToUpper();
                                    break;
                                }
                        }
                        break;
                    }
            }

        }

        /*Przypisanie do zmiennej wartości labelu po wybraniu opcji w combo boxie */
        private void comboBoxFROM_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxFROM.Text)
            {
                case "AX":
                    pierwszy = "AX";
                    break;
                case "BX":
                    pierwszy = "BX";
                    break;
                case "CX":
                    pierwszy = "CX";
                    break;
                case "DX":
                    pierwszy = "DX";
                    break;
            }
        }
        /* Przypisanie do zmiennej wartości labelu po wybraniu opcji w combo boxie */
        private void comboBoxTO_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTO.Text)
            {
                case "AX":
                    drugi = "AX";
                    break;
                case "BX":
                    drugi = "BX";
                    break;
                case "CX":
                    drugi = "CX";
                    break;
                case "DX":
                    drugi = "DX";
                    break;
            }
        }

        /* Wyczyszczenie pól po naciśnięciu klawisza WYCZYŚĆ */
        private void buttonCLEAR_Click(object sender, EventArgs e)
        {
            comboBoxFROM.SelectedIndex = -1;
            comboBoxTO.SelectedIndex = -1;
            movLabel.Text = "";
            axText.Text = "";
            bxText.Text = "";
            cxText.Text = "";
            dxText.Text = "";
        }

        private void buttonXCHG_Click(object sender, EventArgs e)
        {
            switch (comboBoxFROM.Text)
            {
                case "AX":
                    {
                        switch (comboBoxTO.Text)
                        {
                            case "AX":
                                {
                                    break;
                                }
                            case "BX":
                                {
                                    zamiana = axView.Text;
                                    axView.Text = bxView.Text;
                                    bxView.Text = zamiana;
                                    break;
                                }
                            case "CX":
                                {
                                    zamiana = axView.Text;
                                    axView.Text = cxView.Text;
                                    cxView.Text = zamiana;
                                    break;
                                }
                            case "DX":
                                {
                                    zamiana = axView.Text;
                                    axView.Text = dxView.Text;
                                    dxView.Text = zamiana;
                                    break;
                                }
                        }
                        break;
                    }
                case "BX":
                    {
                        switch (comboBoxTO.Text)
                        {
                            case "AX":
                                {
                                    zamiana = bxView.Text;
                                    bxView.Text = axView.Text;
                                    axView.Text = zamiana;
                                    break;
                                }
                            case "BX":
                                {
                                    break;
                                }
                            case "CX":
                                {
                                    zamiana = bxView.Text;
                                    bxView.Text = cxView.Text;
                                    cxView.Text = zamiana;
                                    break;
                                }
                            case "DX":
                                {
                                    zamiana = bxView.Text;
                                    bxView.Text = dxView.Text;
                                    dxView.Text = zamiana;
                                    break;
                                }
                        }
                        break;
                    }
                case "CX":
                    {
                        switch (comboBoxTO.Text)
                        {
                            case "AX":
                                {
                                    zamiana = cxView.Text;
                                    cxView.Text = axView.Text;
                                    axView.Text = zamiana;
                                    break;
                                }
                            case "BX":
                                {
                                    zamiana = cxView.Text;
                                    cxView.Text = bxView.Text;
                                    bxView.Text = zamiana;
                                    break;
                                }
                            case "CX":
                                {
                                    break;
                                }
                            case "DX":
                                {
                                    zamiana = cxView.Text;
                                    cxView.Text = dxView.Text;
                                    dxView.Text = zamiana;
                                    break;
                                }
                        }
                        break;
                    }
                case "DX":
                    {
                        switch (comboBoxTO.Text)
                        {
                            case "AX":
                                {
                                    zamiana = dxView.Text;
                                    dxView.Text = axView.Text;
                                    axView.Text = zamiana;
                                    break;
                                }
                            case "BX":
                                {
                                    zamiana = dxView.Text;
                                    dxView.Text = bxView.Text;
                                    bxView.Text = zamiana;
                                    break;
                                }
                            case "CX":
                                {
                                    zamiana = dxView.Text;
                                    dxView.Text = cxView.Text;
                                    cxView.Text = zamiana;
                                    break;
                                }
                            case "DX":
                                {
                                    break;
                                }
                        }
                        break;
                    }
            }

            if (comboBoxFROM.Text.Length > 0 && comboBoxTO.Text.Length > 0)
                movLabel.Text = $"XCHG {pierwszy}, {drugi}";
            else if (comboBoxFROM.Text.Length > 0)
                movLabel.Text = $"XCHG {pierwszy}";
            else
                movLabel.Text = "";
        }
    }
}
