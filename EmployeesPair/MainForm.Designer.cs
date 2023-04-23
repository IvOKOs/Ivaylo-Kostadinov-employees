namespace EmployeesPair
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.empPairDatagridView = new System.Windows.Forms.DataGridView();
            this.allEmpDatagridView = new System.Windows.Forms.DataGridView();
            this.headingLabel = new System.Windows.Forms.Label();
            this.browseLabel = new System.Windows.Forms.Label();
            this.allEmployeesLabel = new System.Windows.Forms.Label();
            this.empPairLabel = new System.Windows.Forms.Label();
            this.browseDateFormatsLabel = new System.Windows.Forms.Label();
            this.dateFormatsCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.empPairDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmpDatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(429, 98);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(105, 38);
            this.chooseFileBtn.TabIndex = 0;
            this.chooseFileBtn.Text = "Browse";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileBtn_Click);
            // 
            // empPairDatagridView
            // 
            this.empPairDatagridView.AllowUserToDeleteRows = false;
            this.empPairDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empPairDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empPairDatagridView.Location = new System.Drawing.Point(180, 481);
            this.empPairDatagridView.Name = "empPairDatagridView";
            this.empPairDatagridView.RowHeadersWidth = 51;
            this.empPairDatagridView.RowTemplate.Height = 29;
            this.empPairDatagridView.Size = new System.Drawing.Size(591, 80);
            this.empPairDatagridView.TabIndex = 1;
            this.empPairDatagridView.Visible = false;
            // 
            // allEmpDatagridView
            // 
            this.allEmpDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allEmpDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allEmpDatagridView.Location = new System.Drawing.Point(180, 208);
            this.allEmpDatagridView.Name = "allEmpDatagridView";
            this.allEmpDatagridView.RowHeadersWidth = 51;
            this.allEmpDatagridView.RowTemplate.Height = 29;
            this.allEmpDatagridView.Size = new System.Drawing.Size(591, 145);
            this.allEmpDatagridView.TabIndex = 2;
            this.allEmpDatagridView.Visible = false;
            // 
            // headingLabel
            // 
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(321, 23);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(317, 56);
            this.headingLabel.TabIndex = 3;
            this.headingLabel.Text = "Pair Of Employees";
            // 
            // browseLabel
            // 
            this.browseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browseLabel.Location = new System.Drawing.Point(13, 100);
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.Size = new System.Drawing.Size(410, 36);
            this.browseLabel.TabIndex = 4;
            this.browseLabel.Text = "Choose a file with employees to be displayed:";
            // 
            // allEmployeesLabel
            // 
            this.allEmployeesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allEmployeesLabel.Location = new System.Drawing.Point(406, 163);
            this.allEmployeesLabel.Name = "allEmployeesLabel";
            this.allEmployeesLabel.Size = new System.Drawing.Size(156, 42);
            this.allEmployeesLabel.TabIndex = 5;
            this.allEmployeesLabel.Text = "All Employees";
            this.allEmployeesLabel.Visible = false;
            // 
            // empPairLabel
            // 
            this.empPairLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empPairLabel.Location = new System.Drawing.Point(406, 444);
            this.empPairLabel.Name = "empPairLabel";
            this.empPairLabel.Size = new System.Drawing.Size(153, 34);
            this.empPairLabel.TabIndex = 6;
            this.empPairLabel.Text = "Employee Pair";
            this.empPairLabel.Visible = false;
            // 
            // browseDateFormatsLabel
            // 
            this.browseDateFormatsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browseDateFormatsLabel.Location = new System.Drawing.Point(563, 100);
            this.browseDateFormatsLabel.Name = "browseDateFormatsLabel";
            this.browseDateFormatsLabel.Size = new System.Drawing.Size(208, 36);
            this.browseDateFormatsLabel.TabIndex = 7;
            this.browseDateFormatsLabel.Text = "Choose a date format:";
            // 
            // dateFormatsCombobox
            // 
            this.dateFormatsCombobox.FormattingEnabled = true;
            this.dateFormatsCombobox.Location = new System.Drawing.Point(767, 104);
            this.dateFormatsCombobox.Name = "dateFormatsCombobox";
            this.dateFormatsCombobox.Size = new System.Drawing.Size(151, 28);
            this.dateFormatsCombobox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(942, 623);
            this.Controls.Add(this.dateFormatsCombobox);
            this.Controls.Add(this.browseDateFormatsLabel);
            this.Controls.Add(this.empPairLabel);
            this.Controls.Add(this.allEmployeesLabel);
            this.Controls.Add(this.browseLabel);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.allEmpDatagridView);
            this.Controls.Add(this.empPairDatagridView);
            this.Controls.Add(this.chooseFileBtn);
            this.Name = "MainForm";
            this.Text = "Employees Demo";
            ((System.ComponentModel.ISupportInitialize)(this.empPairDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmpDatagridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Label label1;
        private Button chooseFileBtn;
        private DataGridView empPairDatagridView;
        private DataGridView allEmpDatagridView;
        private Label headingLabel;
        private Label browseLabel;
        private Label allEmployeesLabel;
        private Label empPairLabel;
        private Label browseDateFormatsLabel;
        private ComboBox dateFormatsCombobox;
    }
}