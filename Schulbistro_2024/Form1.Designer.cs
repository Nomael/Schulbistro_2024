﻿namespace Schulbistro_2024
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tLPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_HeadName = new System.Windows.Forms.Label();
            this.tControl_Content = new System.Windows.Forms.TabControl();
            this.tPage_Produktsortiment = new System.Windows.Forms.TabPage();
            this.tLPanel_Produkte = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.tBox_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.dGView_Produkte = new System.Windows.Forms.DataGridView();
            this.tPage_Login = new System.Windows.Forms.TabPage();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.tBox_Account = new System.Windows.Forms.TextBox();
            this.tBox_Passwort = new System.Windows.Forms.TextBox();
            this.tPage_PVerwaltung = new System.Windows.Forms.TabPage();
            this.tLPanel_PVerwaltung = new System.Windows.Forms.TableLayoutPanel();
            this.panel_PVerwaltung = new System.Windows.Forms.Panel();
            this.btn_PNew = new System.Windows.Forms.Button();
            this.tBox_PVSuche = new System.Windows.Forms.TextBox();
            this.lbl_PVSuche = new System.Windows.Forms.Label();
            this.dGView_PVerwaltung = new System.Windows.Forms.DataGridView();
            this.tPage_Stats = new System.Windows.Forms.TabPage();
            this.tLPanel_Stats = new System.Windows.Forms.TableLayoutPanel();
            this.panel_SChart = new System.Windows.Forms.Panel();
            this.chart_Stats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_SProdukt = new System.Windows.Forms.Panel();
            this.cBox_SProdukte = new System.Windows.Forms.ComboBox();
            this.lbl_SProdukt = new System.Windows.Forms.Label();
            this.tLPanel_Main.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.tControl_Content.SuspendLayout();
            this.tPage_Produktsortiment.SuspendLayout();
            this.tLPanel_Produkte.SuspendLayout();
            this.panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Produkte)).BeginInit();
            this.tPage_Login.SuspendLayout();
            this.tPage_PVerwaltung.SuspendLayout();
            this.tLPanel_PVerwaltung.SuspendLayout();
            this.panel_PVerwaltung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_PVerwaltung)).BeginInit();
            this.tPage_Stats.SuspendLayout();
            this.tLPanel_Stats.SuspendLayout();
            this.panel_SChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Stats)).BeginInit();
            this.panel_SProdukt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPanel_Main
            // 
            this.tLPanel_Main.ColumnCount = 1;
            this.tLPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanel_Main.Controls.Add(this.panel_Header, 0, 0);
            this.tLPanel_Main.Controls.Add(this.tControl_Content, 0, 1);
            this.tLPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tLPanel_Main.Margin = new System.Windows.Forms.Padding(4);
            this.tLPanel_Main.Name = "tLPanel_Main";
            this.tLPanel_Main.RowCount = 2;
            this.tLPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Main.Size = new System.Drawing.Size(1132, 527);
            this.tLPanel_Main.TabIndex = 0;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_Header.Controls.Add(this.lbl_HeadName);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Header.Location = new System.Drawing.Point(4, 4);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1124, 60);
            this.panel_Header.TabIndex = 0;
            // 
            // lbl_HeadName
            // 
            this.lbl_HeadName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_HeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadName.ForeColor = System.Drawing.Color.White;
            this.lbl_HeadName.Location = new System.Drawing.Point(0, 0);
            this.lbl_HeadName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeadName.Name = "lbl_HeadName";
            this.lbl_HeadName.Size = new System.Drawing.Size(1124, 60);
            this.lbl_HeadName.TabIndex = 0;
            this.lbl_HeadName.Text = "Schulbistro Manna";
            this.lbl_HeadName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tControl_Content
            // 
            this.tControl_Content.Controls.Add(this.tPage_Produktsortiment);
            this.tControl_Content.Controls.Add(this.tPage_Login);
            this.tControl_Content.Controls.Add(this.tPage_PVerwaltung);
            this.tControl_Content.Controls.Add(this.tPage_Stats);
            this.tControl_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tControl_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tControl_Content.Location = new System.Drawing.Point(3, 71);
            this.tControl_Content.Name = "tControl_Content";
            this.tControl_Content.SelectedIndex = 0;
            this.tControl_Content.Size = new System.Drawing.Size(1126, 453);
            this.tControl_Content.TabIndex = 1;
            this.tControl_Content.TabStop = false;
            // 
            // tPage_Produktsortiment
            // 
            this.tPage_Produktsortiment.Controls.Add(this.tLPanel_Produkte);
            this.tPage_Produktsortiment.Location = new System.Drawing.Point(4, 27);
            this.tPage_Produktsortiment.Name = "tPage_Produktsortiment";
            this.tPage_Produktsortiment.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_Produktsortiment.Size = new System.Drawing.Size(1118, 422);
            this.tPage_Produktsortiment.TabIndex = 0;
            this.tPage_Produktsortiment.Text = "Produktsortiment";
            this.tPage_Produktsortiment.UseVisualStyleBackColor = true;
            // 
            // tLPanel_Produkte
            // 
            this.tLPanel_Produkte.ColumnCount = 1;
            this.tLPanel_Produkte.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanel_Produkte.Controls.Add(this.panel_Search, 0, 0);
            this.tLPanel_Produkte.Controls.Add(this.dGView_Produkte, 0, 1);
            this.tLPanel_Produkte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanel_Produkte.Location = new System.Drawing.Point(3, 3);
            this.tLPanel_Produkte.Name = "tLPanel_Produkte";
            this.tLPanel_Produkte.RowCount = 2;
            this.tLPanel_Produkte.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Produkte.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Produkte.Size = new System.Drawing.Size(1112, 416);
            this.tLPanel_Produkte.TabIndex = 0;
            // 
            // panel_Search
            // 
            this.panel_Search.Controls.Add(this.tBox_Search);
            this.panel_Search.Controls.Add(this.lbl_Search);
            this.panel_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Search.Location = new System.Drawing.Point(3, 3);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(1106, 48);
            this.panel_Search.TabIndex = 0;
            // 
            // tBox_Search
            // 
            this.tBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Search.Location = new System.Drawing.Point(184, 7);
            this.tBox_Search.Name = "tBox_Search";
            this.tBox_Search.Size = new System.Drawing.Size(216, 36);
            this.tBox_Search.TabIndex = 1;
            this.tBox_Search.TabStop = false;
            this.tBox_Search.TextChanged += new System.EventHandler(this.tBox_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(3, 10);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(175, 29);
            this.lbl_Search.TabIndex = 0;
            this.lbl_Search.Text = "Produktsuche:";
            // 
            // dGView_Produkte
            // 
            this.dGView_Produkte.AllowUserToAddRows = false;
            this.dGView_Produkte.AllowUserToDeleteRows = false;
            this.dGView_Produkte.BackgroundColor = System.Drawing.Color.White;
            this.dGView_Produkte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView_Produkte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGView_Produkte.Location = new System.Drawing.Point(3, 57);
            this.dGView_Produkte.Name = "dGView_Produkte";
            this.dGView_Produkte.ReadOnly = true;
            this.dGView_Produkte.RowHeadersWidth = 51;
            this.dGView_Produkte.RowTemplate.Height = 24;
            this.dGView_Produkte.Size = new System.Drawing.Size(1106, 356);
            this.dGView_Produkte.TabIndex = 1;
            this.dGView_Produkte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_Produkte_CellContentClick);
            // 
            // tPage_Login
            // 
            this.tPage_Login.Controls.Add(this.lbl_Error);
            this.tPage_Login.Controls.Add(this.lbl_Passwort);
            this.tPage_Login.Controls.Add(this.btn_Login);
            this.tPage_Login.Controls.Add(this.lbl_Account);
            this.tPage_Login.Controls.Add(this.tBox_Account);
            this.tPage_Login.Controls.Add(this.tBox_Passwort);
            this.tPage_Login.Location = new System.Drawing.Point(4, 27);
            this.tPage_Login.Name = "tPage_Login";
            this.tPage_Login.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_Login.Size = new System.Drawing.Size(1118, 422);
            this.tPage_Login.TabIndex = 1;
            this.tPage_Login.Text = "Login";
            this.tPage_Login.UseVisualStyleBackColor = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(505, 257);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(75, 29);
            this.lbl_Error.TabIndex = 5;
            this.lbl_Error.Text = "Error:";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passwort.Location = new System.Drawing.Point(356, 115);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(124, 29);
            this.lbl_Passwort.TabIndex = 1;
            this.lbl_Passwort.Text = "Passwort:";
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(454, 203);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(175, 41);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Account
            // 
            this.lbl_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account.Location = new System.Drawing.Point(356, 48);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(187, 29);
            this.lbl_Account.TabIndex = 0;
            this.lbl_Account.Text = "Account Name:";
            // 
            // tBox_Account
            // 
            this.tBox_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBox_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Account.Location = new System.Drawing.Point(562, 45);
            this.tBox_Account.Name = "tBox_Account";
            this.tBox_Account.Size = new System.Drawing.Size(228, 36);
            this.tBox_Account.TabIndex = 0;
            // 
            // tBox_Passwort
            // 
            this.tBox_Passwort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBox_Passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Passwort.Location = new System.Drawing.Point(562, 112);
            this.tBox_Passwort.Name = "tBox_Passwort";
            this.tBox_Passwort.PasswordChar = '*';
            this.tBox_Passwort.Size = new System.Drawing.Size(228, 36);
            this.tBox_Passwort.TabIndex = 1;
            // 
            // tPage_PVerwaltung
            // 
            this.tPage_PVerwaltung.Controls.Add(this.tLPanel_PVerwaltung);
            this.tPage_PVerwaltung.Location = new System.Drawing.Point(4, 27);
            this.tPage_PVerwaltung.Name = "tPage_PVerwaltung";
            this.tPage_PVerwaltung.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_PVerwaltung.Size = new System.Drawing.Size(1118, 422);
            this.tPage_PVerwaltung.TabIndex = 3;
            this.tPage_PVerwaltung.Text = "Produkt Verwaltung";
            this.tPage_PVerwaltung.UseVisualStyleBackColor = true;
            // 
            // tLPanel_PVerwaltung
            // 
            this.tLPanel_PVerwaltung.ColumnCount = 1;
            this.tLPanel_PVerwaltung.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanel_PVerwaltung.Controls.Add(this.panel_PVerwaltung, 0, 0);
            this.tLPanel_PVerwaltung.Controls.Add(this.dGView_PVerwaltung, 0, 1);
            this.tLPanel_PVerwaltung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanel_PVerwaltung.Location = new System.Drawing.Point(3, 3);
            this.tLPanel_PVerwaltung.Name = "tLPanel_PVerwaltung";
            this.tLPanel_PVerwaltung.RowCount = 2;
            this.tLPanel_PVerwaltung.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_PVerwaltung.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_PVerwaltung.Size = new System.Drawing.Size(1112, 416);
            this.tLPanel_PVerwaltung.TabIndex = 1;
            // 
            // panel_PVerwaltung
            // 
            this.panel_PVerwaltung.Controls.Add(this.btn_PNew);
            this.panel_PVerwaltung.Controls.Add(this.tBox_PVSuche);
            this.panel_PVerwaltung.Controls.Add(this.lbl_PVSuche);
            this.panel_PVerwaltung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PVerwaltung.Location = new System.Drawing.Point(3, 3);
            this.panel_PVerwaltung.Name = "panel_PVerwaltung";
            this.panel_PVerwaltung.Size = new System.Drawing.Size(1106, 48);
            this.panel_PVerwaltung.TabIndex = 0;
            // 
            // btn_PNew
            // 
            this.btn_PNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_PNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PNew.Location = new System.Drawing.Point(846, 7);
            this.btn_PNew.Name = "btn_PNew";
            this.btn_PNew.Size = new System.Drawing.Size(257, 35);
            this.btn_PNew.TabIndex = 5;
            this.btn_PNew.TabStop = false;
            this.btn_PNew.Text = "Produkt Erstellen";
            this.btn_PNew.UseVisualStyleBackColor = true;
            this.btn_PNew.Click += new System.EventHandler(this.btn_PNew_Click);
            // 
            // tBox_PVSuche
            // 
            this.tBox_PVSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_PVSuche.Location = new System.Drawing.Point(184, 7);
            this.tBox_PVSuche.Name = "tBox_PVSuche";
            this.tBox_PVSuche.Size = new System.Drawing.Size(216, 36);
            this.tBox_PVSuche.TabIndex = 1;
            this.tBox_PVSuche.TabStop = false;
            this.tBox_PVSuche.TextChanged += new System.EventHandler(this.tBox_PVSuche_TextChanged);
            // 
            // lbl_PVSuche
            // 
            this.lbl_PVSuche.AutoSize = true;
            this.lbl_PVSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PVSuche.Location = new System.Drawing.Point(3, 10);
            this.lbl_PVSuche.Name = "lbl_PVSuche";
            this.lbl_PVSuche.Size = new System.Drawing.Size(175, 29);
            this.lbl_PVSuche.TabIndex = 0;
            this.lbl_PVSuche.Text = "Produktsuche:";
            // 
            // dGView_PVerwaltung
            // 
            this.dGView_PVerwaltung.AllowUserToAddRows = false;
            this.dGView_PVerwaltung.AllowUserToDeleteRows = false;
            this.dGView_PVerwaltung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGView_PVerwaltung.BackgroundColor = System.Drawing.Color.White;
            this.dGView_PVerwaltung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView_PVerwaltung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGView_PVerwaltung.Location = new System.Drawing.Point(3, 57);
            this.dGView_PVerwaltung.Name = "dGView_PVerwaltung";
            this.dGView_PVerwaltung.ReadOnly = true;
            this.dGView_PVerwaltung.RowHeadersWidth = 51;
            this.dGView_PVerwaltung.RowTemplate.Height = 24;
            this.dGView_PVerwaltung.Size = new System.Drawing.Size(1106, 356);
            this.dGView_PVerwaltung.TabIndex = 1;
            this.dGView_PVerwaltung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_PVerwaltung_CellContentClick);
            // 
            // tPage_Stats
            // 
            this.tPage_Stats.Controls.Add(this.tLPanel_Stats);
            this.tPage_Stats.Location = new System.Drawing.Point(4, 27);
            this.tPage_Stats.Name = "tPage_Stats";
            this.tPage_Stats.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_Stats.Size = new System.Drawing.Size(1118, 422);
            this.tPage_Stats.TabIndex = 4;
            this.tPage_Stats.Text = "Statistik";
            this.tPage_Stats.UseVisualStyleBackColor = true;
            // 
            // tLPanel_Stats
            // 
            this.tLPanel_Stats.ColumnCount = 1;
            this.tLPanel_Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanel_Stats.Controls.Add(this.panel_SChart, 0, 1);
            this.tLPanel_Stats.Controls.Add(this.panel_SProdukt, 0, 0);
            this.tLPanel_Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanel_Stats.Location = new System.Drawing.Point(3, 3);
            this.tLPanel_Stats.Name = "tLPanel_Stats";
            this.tLPanel_Stats.RowCount = 2;
            this.tLPanel_Stats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Stats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Stats.Size = new System.Drawing.Size(1112, 416);
            this.tLPanel_Stats.TabIndex = 1;
            // 
            // panel_SChart
            // 
            this.panel_SChart.Controls.Add(this.chart_Stats);
            this.panel_SChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SChart.Location = new System.Drawing.Point(3, 57);
            this.panel_SChart.Name = "panel_SChart";
            this.panel_SChart.Size = new System.Drawing.Size(1106, 356);
            this.panel_SChart.TabIndex = 1;
            // 
            // chart_Stats
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Stats.ChartAreas.Add(chartArea1);
            this.chart_Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_Stats.Legends.Add(legend1);
            this.chart_Stats.Location = new System.Drawing.Point(0, 0);
            this.chart_Stats.Name = "chart_Stats";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Stats.Series.Add(series1);
            this.chart_Stats.Size = new System.Drawing.Size(1106, 356);
            this.chart_Stats.TabIndex = 0;
            this.chart_Stats.Text = "chart1";
            // 
            // panel_SProdukt
            // 
            this.panel_SProdukt.Controls.Add(this.cBox_SProdukte);
            this.panel_SProdukt.Controls.Add(this.lbl_SProdukt);
            this.panel_SProdukt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SProdukt.Location = new System.Drawing.Point(3, 3);
            this.panel_SProdukt.Name = "panel_SProdukt";
            this.panel_SProdukt.Size = new System.Drawing.Size(1106, 48);
            this.panel_SProdukt.TabIndex = 0;
            // 
            // cBox_SProdukte
            // 
            this.cBox_SProdukte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_SProdukte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cBox_SProdukte.FormattingEnabled = true;
            this.cBox_SProdukte.Location = new System.Drawing.Point(109, 7);
            this.cBox_SProdukte.Name = "cBox_SProdukte";
            this.cBox_SProdukte.Size = new System.Drawing.Size(270, 37);
            this.cBox_SProdukte.TabIndex = 0;
            this.cBox_SProdukte.SelectedIndexChanged += new System.EventHandler(this.cBox_SProdukte_SelectedIndexChanged);
            // 
            // lbl_SProdukt
            // 
            this.lbl_SProdukt.AutoSize = true;
            this.lbl_SProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SProdukt.Location = new System.Drawing.Point(3, 10);
            this.lbl_SProdukt.Name = "lbl_SProdukt";
            this.lbl_SProdukt.Size = new System.Drawing.Size(100, 29);
            this.lbl_SProdukt.TabIndex = 0;
            this.lbl_SProdukt.Text = "Produk:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 527);
            this.Controls.Add(this.tLPanel_Main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Schulbistro";
            this.tLPanel_Main.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.tControl_Content.ResumeLayout(false);
            this.tPage_Produktsortiment.ResumeLayout(false);
            this.tLPanel_Produkte.ResumeLayout(false);
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Produkte)).EndInit();
            this.tPage_Login.ResumeLayout(false);
            this.tPage_Login.PerformLayout();
            this.tPage_PVerwaltung.ResumeLayout(false);
            this.tLPanel_PVerwaltung.ResumeLayout(false);
            this.panel_PVerwaltung.ResumeLayout(false);
            this.panel_PVerwaltung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_PVerwaltung)).EndInit();
            this.tPage_Stats.ResumeLayout(false);
            this.tLPanel_Stats.ResumeLayout(false);
            this.panel_SChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Stats)).EndInit();
            this.panel_SProdukt.ResumeLayout(false);
            this.panel_SProdukt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPanel_Main;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lbl_HeadName;
        private System.Windows.Forms.TabControl tControl_Content;
        private System.Windows.Forms.TabPage tPage_Produktsortiment;
        private System.Windows.Forms.TabPage tPage_Login;
        private System.Windows.Forms.TabPage tPage_PVerwaltung;
        private System.Windows.Forms.TabPage tPage_Stats;
        private System.Windows.Forms.TableLayoutPanel tLPanel_Produkte;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.TextBox tBox_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.DataGridView dGView_Produkte;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tBox_Passwort;
        private System.Windows.Forms.TextBox tBox_Account;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.TableLayoutPanel tLPanel_PVerwaltung;
        private System.Windows.Forms.Panel panel_PVerwaltung;
        private System.Windows.Forms.TextBox tBox_PVSuche;
        private System.Windows.Forms.Label lbl_PVSuche;
        private System.Windows.Forms.DataGridView dGView_PVerwaltung;
        private System.Windows.Forms.Button btn_PNew;
        private System.Windows.Forms.TableLayoutPanel tLPanel_Stats;
        private System.Windows.Forms.Panel panel_SProdukt;
        private System.Windows.Forms.ComboBox cBox_SProdukte;
        private System.Windows.Forms.Label lbl_SProdukt;
        private System.Windows.Forms.Panel panel_SChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Stats;
    }
}

