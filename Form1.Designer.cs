namespace MovieRentals
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
            this.WizardMover = new System.Windows.Forms.Panel();
            this.availableFunds = new System.Windows.Forms.Label();
            this.Minimize_Application = new System.Windows.Forms.Button();
            this.ShutDown_Application = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Customers = new System.Windows.Forms.TabPage();
            this.customersList = new System.Windows.Forms.DataGridView();
            this.tab_Movies = new System.Windows.Forms.TabPage();
            this.moviesList = new System.Windows.Forms.DataGridView();
            this.tab_Rentals = new System.Windows.Forms.TabPage();
            this.rentalsList = new System.Windows.Forms.DataGridView();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.PhoneNumberField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.movieTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.movieYear = new System.Windows.Forms.TextBox();
            this.movieRatings = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.movieRentingPrice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.movieCopiesAvailable = new System.Windows.Forms.NumericUpDown();
            this.movieGenre = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddMovie = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.DeleteMovie = new System.Windows.Forms.Button();
            this.rentMovie = new System.Windows.Forms.Button();
            this.returnMovie = new System.Windows.Forms.Button();
            this.rentingDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.returningDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.rentingMovie = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rentingDays = new System.Windows.Forms.Label();
            this.WizardMover.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).BeginInit();
            this.tab_Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesList)).BeginInit();
            this.tab_Rentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieCopiesAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // WizardMover
            // 
            this.WizardMover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.WizardMover.Controls.Add(this.availableFunds);
            this.WizardMover.Controls.Add(this.Minimize_Application);
            this.WizardMover.Controls.Add(this.ShutDown_Application);
            this.WizardMover.Location = new System.Drawing.Point(0, 0);
            this.WizardMover.Name = "WizardMover";
            this.WizardMover.Size = new System.Drawing.Size(1280, 25);
            this.WizardMover.TabIndex = 0;
            this.WizardMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WizardMover_MouseDown);
            // 
            // availableFunds
            // 
            this.availableFunds.AutoSize = true;
            this.availableFunds.Dock = System.Windows.Forms.DockStyle.Left;
            this.availableFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableFunds.ForeColor = System.Drawing.Color.White;
            this.availableFunds.Location = new System.Drawing.Point(0, 0);
            this.availableFunds.Name = "availableFunds";
            this.availableFunds.Size = new System.Drawing.Size(109, 20);
            this.availableFunds.TabIndex = 2;
            this.availableFunds.Text = "Movie Rentals";
            // 
            // Minimize_Application
            // 
            this.Minimize_Application.BackgroundImage = global::MovieRentals.Properties.Resources.minimize_window_25px;
            this.Minimize_Application.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Minimize_Application.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_Application.FlatAppearance.BorderSize = 0;
            this.Minimize_Application.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Application.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Minimize_Application.Location = new System.Drawing.Point(1200, 0);
            this.Minimize_Application.Name = "Minimize_Application";
            this.Minimize_Application.Size = new System.Drawing.Size(40, 25);
            this.Minimize_Application.TabIndex = 1;
            this.Minimize_Application.UseVisualStyleBackColor = true;
            this.Minimize_Application.Click += new System.EventHandler(this.Minimize_Application_Click);
            // 
            // ShutDown_Application
            // 
            this.ShutDown_Application.BackgroundImage = global::MovieRentals.Properties.Resources.close_window_25px;
            this.ShutDown_Application.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShutDown_Application.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShutDown_Application.FlatAppearance.BorderSize = 0;
            this.ShutDown_Application.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDown_Application.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ShutDown_Application.Location = new System.Drawing.Point(1240, 0);
            this.ShutDown_Application.Name = "ShutDown_Application";
            this.ShutDown_Application.Size = new System.Drawing.Size(40, 25);
            this.ShutDown_Application.TabIndex = 0;
            this.ShutDown_Application.UseVisualStyleBackColor = true;
            this.ShutDown_Application.Click += new System.EventHandler(this.ShutDown_Application_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Customers);
            this.tabControl1.Controls.Add(this.tab_Movies);
            this.tabControl1.Controls.Add(this.tab_Rentals);
            this.tabControl1.ItemSize = new System.Drawing.Size(61, 18);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1256, 502);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tab_Customers
            // 
            this.tab_Customers.BackColor = System.Drawing.Color.White;
            this.tab_Customers.Controls.Add(this.customersList);
            this.tab_Customers.Location = new System.Drawing.Point(4, 22);
            this.tab_Customers.Name = "tab_Customers";
            this.tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customers.Size = new System.Drawing.Size(1248, 476);
            this.tab_Customers.TabIndex = 0;
            this.tab_Customers.Text = "Customers";
            // 
            // customersList
            // 
            this.customersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersList.Location = new System.Drawing.Point(3, 3);
            this.customersList.Name = "customersList";
            this.customersList.Size = new System.Drawing.Size(1242, 470);
            this.customersList.TabIndex = 0;
            this.customersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersList_CellClick);
            // 
            // tab_Movies
            // 
            this.tab_Movies.Controls.Add(this.moviesList);
            this.tab_Movies.Location = new System.Drawing.Point(4, 22);
            this.tab_Movies.Name = "tab_Movies";
            this.tab_Movies.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Movies.Size = new System.Drawing.Size(1248, 476);
            this.tab_Movies.TabIndex = 1;
            this.tab_Movies.Text = "Movies";
            this.tab_Movies.UseVisualStyleBackColor = true;
            // 
            // moviesList
            // 
            this.moviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesList.Location = new System.Drawing.Point(3, 3);
            this.moviesList.Name = "moviesList";
            this.moviesList.Size = new System.Drawing.Size(1242, 470);
            this.moviesList.TabIndex = 0;
            this.moviesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesList_CellClick);
            // 
            // tab_Rentals
            // 
            this.tab_Rentals.Controls.Add(this.rentalsList);
            this.tab_Rentals.Location = new System.Drawing.Point(4, 22);
            this.tab_Rentals.Name = "tab_Rentals";
            this.tab_Rentals.Size = new System.Drawing.Size(1248, 476);
            this.tab_Rentals.TabIndex = 2;
            this.tab_Rentals.Text = "Rentals";
            this.tab_Rentals.UseVisualStyleBackColor = true;
            // 
            // rentalsList
            // 
            this.rentalsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalsList.Location = new System.Drawing.Point(3, 3);
            this.rentalsList.Name = "rentalsList";
            this.rentalsList.Size = new System.Drawing.Size(1242, 470);
            this.rentalsList.TabIndex = 0;
            this.rentalsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalsList_CellClick);
            // 
            // firstNameField
            // 
            this.firstNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameField.Location = new System.Drawing.Point(12, 566);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(151, 20);
            this.firstNameField.TabIndex = 2;
            this.firstNameField.TextChanged += new System.EventHandler(this.FirstNameField_TextChanged);
            // 
            // lastNameField
            // 
            this.lastNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameField.Location = new System.Drawing.Point(169, 566);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(151, 20);
            this.lastNameField.TabIndex = 3;
            // 
            // PhoneNumberField
            // 
            this.PhoneNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberField.Location = new System.Drawing.Point(568, 566);
            this.PhoneNumberField.MaxLength = 10;
            this.PhoneNumberField.Name = "PhoneNumberField";
            this.PhoneNumberField.Size = new System.Drawing.Size(151, 20);
            this.PhoneNumberField.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(568, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddCustomer.Location = new System.Drawing.Point(726, 540);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(152, 45);
            this.AddCustomer.TabIndex = 9;
            this.AddCustomer.Text = "Add New Customer";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // movieTitle
            // 
            this.movieTitle.Location = new System.Drawing.Point(12, 612);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(151, 20);
            this.movieTitle.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Movie Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(165, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Year";
            // 
            // movieYear
            // 
            this.movieYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieYear.Location = new System.Drawing.Point(169, 612);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(82, 20);
            this.movieYear.TabIndex = 13;
            // 
            // movieRatings
            // 
            this.movieRatings.Location = new System.Drawing.Point(258, 612);
            this.movieRatings.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.movieRatings.Name = "movieRatings";
            this.movieRatings.Size = new System.Drawing.Size(62, 20);
            this.movieRatings.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(254, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ratings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(323, 589);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rental Cost";
            // 
            // movieRentingPrice
            // 
            this.movieRentingPrice.DecimalPlaces = 2;
            this.movieRentingPrice.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.movieRentingPrice.Location = new System.Drawing.Point(327, 612);
            this.movieRentingPrice.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.movieRentingPrice.Name = "movieRentingPrice";
            this.movieRentingPrice.Size = new System.Drawing.Size(111, 20);
            this.movieRentingPrice.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(440, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Available Copies";
            // 
            // movieCopiesAvailable
            // 
            this.movieCopiesAvailable.Location = new System.Drawing.Point(444, 612);
            this.movieCopiesAvailable.Name = "movieCopiesAvailable";
            this.movieCopiesAvailable.Size = new System.Drawing.Size(118, 20);
            this.movieCopiesAvailable.TabIndex = 18;
            // 
            // movieGenre
            // 
            this.movieGenre.FormattingEnabled = true;
            this.movieGenre.Location = new System.Drawing.Point(572, 612);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(111, 21);
            this.movieGenre.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(568, 589);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Genre";
            // 
            // AddMovie
            // 
            this.AddMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddMovie.Location = new System.Drawing.Point(726, 590);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(152, 41);
            this.AddMovie.TabIndex = 22;
            this.AddMovie.Text = "Add New Movie";
            this.AddMovie.UseVisualStyleBackColor = false;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UpdateCustomer.Enabled = false;
            this.UpdateCustomer.Location = new System.Drawing.Point(884, 541);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(152, 45);
            this.UpdateCustomer.TabIndex = 23;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = false;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DeleteCustomer.Enabled = false;
            this.DeleteCustomer.Location = new System.Drawing.Point(1042, 540);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(152, 45);
            this.DeleteCustomer.TabIndex = 24;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = false;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DeleteMovie.Enabled = false;
            this.DeleteMovie.Location = new System.Drawing.Point(884, 589);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(152, 43);
            this.DeleteMovie.TabIndex = 25;
            this.DeleteMovie.Text = "Delete Movie";
            this.DeleteMovie.UseVisualStyleBackColor = false;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // rentMovie
            // 
            this.rentMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rentMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentMovie.ForeColor = System.Drawing.Color.IndianRed;
            this.rentMovie.Location = new System.Drawing.Point(11, 638);
            this.rentMovie.Name = "rentMovie";
            this.rentMovie.Size = new System.Drawing.Size(240, 70);
            this.rentMovie.TabIndex = 26;
            this.rentMovie.Text = "Issue Movie";
            this.rentMovie.UseVisualStyleBackColor = false;
            this.rentMovie.Click += new System.EventHandler(this.RentMovie_Click);
            // 
            // returnMovie
            // 
            this.returnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.returnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMovie.ForeColor = System.Drawing.Color.LimeGreen;
            this.returnMovie.Location = new System.Drawing.Point(1028, 638);
            this.returnMovie.Name = "returnMovie";
            this.returnMovie.Size = new System.Drawing.Size(240, 70);
            this.returnMovie.TabIndex = 27;
            this.returnMovie.Text = "Return Movie";
            this.returnMovie.UseVisualStyleBackColor = false;
            this.returnMovie.Click += new System.EventHandler(this.ReturnMovie_Click);
            // 
            // rentingDate
            // 
            this.rentingDate.Location = new System.Drawing.Point(359, 692);
            this.rentingDate.MinDate = new System.DateTime(2019, 8, 6, 0, 0, 0, 0);
            this.rentingDate.Name = "rentingDate";
            this.rentingDate.Size = new System.Drawing.Size(200, 20);
            this.rentingDate.TabIndex = 28;
            this.rentingDate.Value = new System.DateTime(2019, 8, 6, 0, 0, 0, 0);
            this.rentingDate.ValueChanged += new System.EventHandler(this.RentingDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(307, 688);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "From";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(564, 689);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "To";
            // 
            // returningDate
            // 
            this.returningDate.Location = new System.Drawing.Point(597, 689);
            this.returningDate.Name = "returningDate";
            this.returningDate.Size = new System.Drawing.Size(195, 20);
            this.returningDate.TabIndex = 31;
            this.returningDate.Value = new System.DateTime(2019, 8, 7, 0, 0, 0, 0);
            this.returningDate.ValueChanged += new System.EventHandler(this.ReturningDate_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(589, 665);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Renting Period";
            // 
            // addressField
            // 
            this.addressField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressField.Location = new System.Drawing.Point(327, 566);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(235, 20);
            this.addressField.TabIndex = 35;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(323, 543);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(68, 20);
            this.address.TabIndex = 36;
            this.address.Text = "Address";
            // 
            // rentingMovie
            // 
            this.rentingMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rentingMovie.FormattingEnabled = true;
            this.rentingMovie.Location = new System.Drawing.Point(424, 665);
            this.rentingMovie.Name = "rentingMovie";
            this.rentingMovie.Size = new System.Drawing.Size(159, 21);
            this.rentingMovie.TabIndex = 37;
            this.rentingMovie.SelectedIndexChanged += new System.EventHandler(this.RentingMovie_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(307, 665);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "Movie to Issue";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // rentingDays
            // 
            this.rentingDays.AutoSize = true;
            this.rentingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentingDays.ForeColor = System.Drawing.Color.White;
            this.rentingDays.Location = new System.Drawing.Point(798, 688);
            this.rentingDays.Name = "rentingDays";
            this.rentingDays.Size = new System.Drawing.Size(58, 20);
            this.rentingDays.TabIndex = 39;
            this.rentingDays.Text = "0 Days";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.rentingDays);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.rentingMovie);
            this.Controls.Add(this.address);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.returningDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rentingDate);
            this.Controls.Add(this.returnMovie);
            this.Controls.Add(this.rentMovie);
            this.Controls.Add(this.DeleteMovie);
            this.Controls.Add(this.DeleteCustomer);
            this.Controls.Add(this.UpdateCustomer);
            this.Controls.Add(this.AddMovie);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.movieGenre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.movieCopiesAvailable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.movieRentingPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.movieRatings);
            this.Controls.Add(this.movieYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumberField);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.WizardMover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WizardMover.ResumeLayout(false);
            this.WizardMover.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).EndInit();
            this.tab_Movies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviesList)).EndInit();
            this.tab_Rentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentalsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieCopiesAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WizardMover;
        private System.Windows.Forms.Button ShutDown_Application;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Customers;
        private System.Windows.Forms.TabPage tab_Movies;
        private System.Windows.Forms.Button Minimize_Application;
        private System.Windows.Forms.TabPage tab_Rentals;
        private System.Windows.Forms.DataGridView customersList;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.TextBox PhoneNumberField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.TextBox movieTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox movieYear;
        private System.Windows.Forms.NumericUpDown movieRatings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown movieRentingPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown movieCopiesAvailable;
        private System.Windows.Forms.ComboBox movieGenre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button DeleteMovie;
        private System.Windows.Forms.Button rentMovie;
        private System.Windows.Forms.Button returnMovie;
        private System.Windows.Forms.DateTimePicker rentingDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker returningDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView moviesList;
        private System.Windows.Forms.DataGridView rentalsList;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.ComboBox rentingMovie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label availableFunds;
        private System.Windows.Forms.Label rentingDays;
    }
}

