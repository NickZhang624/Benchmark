namespace Benchmark_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picScreen = new System.Windows.Forms.PictureBox();
            this.btnShowStatus = new System.Windows.Forms.Button();
            this.btnLoadInitialData = new System.Windows.Forms.Button();
            this.btnLoadPreviousSaving = new System.Windows.Forms.Button();
            this.btnRemoveSelectedObj = new System.Windows.Forms.Button();
            this.btnSortZA = new System.Windows.Forms.Button();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSaveCurrentList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbxDisplay = new System.Windows.Forms.ListBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.picEarth = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picMercury = new System.Windows.Forms.PictureBox();
            this.picVenus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMercury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVenus)).BeginInit();
            this.SuspendLayout();
            // 
            // picScreen
            // 
            this.picScreen.BackColor = System.Drawing.Color.LawnGreen;
            this.picScreen.Location = new System.Drawing.Point(0, 0);
            this.picScreen.Name = "picScreen";
            this.picScreen.Size = new System.Drawing.Size(980, 560);
            this.picScreen.TabIndex = 0;
            this.picScreen.TabStop = false;
            this.picScreen.Click += new System.EventHandler(this.picScreen_Click);
            // 
            // btnShowStatus
            // 
            this.btnShowStatus.Location = new System.Drawing.Point(602, 298);
            this.btnShowStatus.Name = "btnShowStatus";
            this.btnShowStatus.Size = new System.Drawing.Size(95, 47);
            this.btnShowStatus.TabIndex = 1;
            this.btnShowStatus.Text = "Show status";
            this.btnShowStatus.UseVisualStyleBackColor = true;
            this.btnShowStatus.Click += new System.EventHandler(this.btnShowStatus_Click);
            // 
            // btnLoadInitialData
            // 
            this.btnLoadInitialData.Location = new System.Drawing.Point(602, 355);
            this.btnLoadInitialData.Name = "btnLoadInitialData";
            this.btnLoadInitialData.Size = new System.Drawing.Size(95, 38);
            this.btnLoadInitialData.TabIndex = 2;
            this.btnLoadInitialData.Text = "Load initial Data";
            this.btnLoadInitialData.UseVisualStyleBackColor = true;
            this.btnLoadInitialData.Click += new System.EventHandler(this.btnLoadInitialData_Click);
            // 
            // btnLoadPreviousSaving
            // 
            this.btnLoadPreviousSaving.Location = new System.Drawing.Point(602, 410);
            this.btnLoadPreviousSaving.Name = "btnLoadPreviousSaving";
            this.btnLoadPreviousSaving.Size = new System.Drawing.Size(95, 42);
            this.btnLoadPreviousSaving.TabIndex = 3;
            this.btnLoadPreviousSaving.Text = "Load Previous Saving";
            this.btnLoadPreviousSaving.UseVisualStyleBackColor = true;
            this.btnLoadPreviousSaving.Click += new System.EventHandler(this.btnLoadPreviousSaving_Click);
            // 
            // btnRemoveSelectedObj
            // 
            this.btnRemoveSelectedObj.Location = new System.Drawing.Point(714, 298);
            this.btnRemoveSelectedObj.Name = "btnRemoveSelectedObj";
            this.btnRemoveSelectedObj.Size = new System.Drawing.Size(95, 47);
            this.btnRemoveSelectedObj.TabIndex = 4;
            this.btnRemoveSelectedObj.Text = "Remove Selected Obj";
            this.btnRemoveSelectedObj.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedObj.Click += new System.EventHandler(this.btnRemoveSelectedObj_Click);
            // 
            // btnSortZA
            // 
            this.btnSortZA.Location = new System.Drawing.Point(714, 355);
            this.btnSortZA.Name = "btnSortZA";
            this.btnSortZA.Size = new System.Drawing.Size(95, 38);
            this.btnSortZA.TabIndex = 5;
            this.btnSortZA.Text = "Sort by Type ZA";
            this.btnSortZA.UseVisualStyleBackColor = true;
            this.btnSortZA.Click += new System.EventHandler(this.btnSortZA_Click);
            // 
            // btnSortAZ
            // 
            this.btnSortAZ.Location = new System.Drawing.Point(714, 410);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(95, 42);
            this.btnSortAZ.TabIndex = 6;
            this.btnSortAZ.Text = "Sort by Type AZ";
            this.btnSortAZ.UseVisualStyleBackColor = true;
            this.btnSortAZ.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(827, 298);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 47);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search by Type";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSaveCurrentList
            // 
            this.btnSaveCurrentList.Location = new System.Drawing.Point(827, 355);
            this.btnSaveCurrentList.Name = "btnSaveCurrentList";
            this.btnSaveCurrentList.Size = new System.Drawing.Size(95, 38);
            this.btnSaveCurrentList.TabIndex = 8;
            this.btnSaveCurrentList.Text = "Save Current List";
            this.btnSaveCurrentList.UseVisualStyleBackColor = true;
            this.btnSaveCurrentList.Click += new System.EventHandler(this.btnSaveCurrentList_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(827, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 42);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbxDisplay
            // 
            this.lbxDisplay.FormattingEnabled = true;
            this.lbxDisplay.Location = new System.Drawing.Point(602, 22);
            this.lbxDisplay.Name = "lbxDisplay";
            this.lbxDisplay.Size = new System.Drawing.Size(319, 199);
            this.lbxDisplay.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Yellow;
            this.lblSearch.Location = new System.Drawing.Point(600, 252);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(152, 13);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Enter Planets Type for Search:";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(797, 238);
            this.txbSearch.Multiline = true;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(124, 27);
            this.txbSearch.TabIndex = 12;
            // 
            // picEarth
            // 
            this.picEarth.Image = ((System.Drawing.Image)(resources.GetObject("picEarth.Image")));
            this.picEarth.Location = new System.Drawing.Point(180, 160);
            this.picEarth.Name = "picEarth";
            this.picEarth.Size = new System.Drawing.Size(141, 150);
            this.picEarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEarth.TabIndex = 13;
            this.picEarth.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picMercury
            // 
            this.picMercury.Image = ((System.Drawing.Image)(resources.GetObject("picMercury.Image")));
            this.picMercury.Location = new System.Drawing.Point(422, 205);
            this.picMercury.Name = "picMercury";
            this.picMercury.Size = new System.Drawing.Size(141, 150);
            this.picMercury.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMercury.TabIndex = 14;
            this.picMercury.TabStop = false;
            // 
            // picVenus
            // 
            this.picVenus.Image = ((System.Drawing.Image)(resources.GetObject("picVenus.Image")));
            this.picVenus.Location = new System.Drawing.Point(340, 35);
            this.picVenus.Name = "picVenus";
            this.picVenus.Size = new System.Drawing.Size(141, 150);
            this.picVenus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVenus.TabIndex = 15;
            this.picVenus.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lbxDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveCurrentList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSortAZ);
            this.Controls.Add(this.btnSortZA);
            this.Controls.Add(this.btnRemoveSelectedObj);
            this.Controls.Add(this.btnLoadPreviousSaving);
            this.Controls.Add(this.btnLoadInitialData);
            this.Controls.Add(this.btnShowStatus);
            this.Controls.Add(this.picScreen);
            this.Controls.Add(this.picEarth);
            this.Controls.Add(this.picVenus);
            this.Controls.Add(this.picMercury);
            this.Name = "Form1";
            this.Text = "Clik Me";
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMercury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVenus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picScreen;
        private System.Windows.Forms.Button btnShowStatus;
        private System.Windows.Forms.Button btnLoadInitialData;
        private System.Windows.Forms.Button btnLoadPreviousSaving;
        private System.Windows.Forms.Button btnRemoveSelectedObj;
        private System.Windows.Forms.Button btnSortZA;
        private System.Windows.Forms.Button btnSortAZ;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSaveCurrentList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbxDisplay;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.PictureBox picEarth;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picMercury;
        private System.Windows.Forms.PictureBox picVenus;
    }
}

