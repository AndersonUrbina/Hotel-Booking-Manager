namespace Hotel_Booking_Manager;

partial class Form1
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
        IbWelcomeLabel = new Label();
        lblGuestName = new Label();
        lblRoomNumber = new Label();
        lblcheckin = new Label();
        lblcheckout = new Label();
        tbGuestName = new TextBox();
        tbRoomNumber = new TextBox();
        dtCheckIn = new DateTimePicker();
        dtCheckOut = new DateTimePicker();
        btnBookRoom = new Button();
        btnCancelBooking = new Button();
        btnViewAllBooking = new Button();
        btnExit = new Button();
        btnStatus = new Button();
        lvBookings = new ListView();
        SuspendLayout();
        // 
        // IbWelcomeLabel
        // 
        IbWelcomeLabel.AutoSize = true;
        IbWelcomeLabel.Font = new Font("Bodoni MT Condensed", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        IbWelcomeLabel.ForeColor = SystemColors.ControlLight;
        IbWelcomeLabel.Location = new Point(209, 9);
        IbWelcomeLabel.Name = "IbWelcomeLabel";
        IbWelcomeLabel.Size = new Size(370, 41);
        IbWelcomeLabel.TabIndex = 0;
        IbWelcomeLabel.Text = "Welcome To The Home2 Hotel";
        IbWelcomeLabel.Click += IbWelcomeLabel_Click;
        // 
        // lblGuestName
        // 
        lblGuestName.AutoSize = true;
        lblGuestName.ForeColor = SystemColors.ControlLight;
        lblGuestName.Location = new Point(70, 80);
        lblGuestName.Name = "lblGuestName";
        lblGuestName.RightToLeft = RightToLeft.No;
        lblGuestName.Size = new Size(75, 15);
        lblGuestName.TabIndex = 1;
        lblGuestName.Text = "Guest Name:";
        lblGuestName.UseMnemonic = false;
        lblGuestName.Click += label1_Click;
        // 
        // lblRoomNumber
        // 
        lblRoomNumber.AutoSize = true;
        lblRoomNumber.ForeColor = SystemColors.ControlLight;
        lblRoomNumber.Location = new Point(421, 80);
        lblRoomNumber.Name = "lblRoomNumber";
        lblRoomNumber.Size = new Size(89, 15);
        lblRoomNumber.TabIndex = 2;
        lblRoomNumber.Text = "Room Number:";
        lblRoomNumber.Click += label1_Click_1;
        // 
        // lblcheckin
        // 
        lblcheckin.AutoSize = true;
        lblcheckin.ForeColor = SystemColors.ControlLight;
        lblcheckin.Location = new Point(87, 144);
        lblcheckin.Name = "lblcheckin";
        lblcheckin.Size = new Size(58, 15);
        lblcheckin.TabIndex = 3;
        lblcheckin.Text = "Check-in:";
        lblcheckin.Click += lblcheckin_Click;
        // 
        // lblcheckout
        // 
        lblcheckout.AutoSize = true;
        lblcheckout.ForeColor = SystemColors.ControlLight;
        lblcheckout.Location = new Point(444, 144);
        lblcheckout.Name = "lblcheckout";
        lblcheckout.Size = new Size(66, 15);
        lblcheckout.TabIndex = 4;
        lblcheckout.Text = "Check-out:";
        // 
        // tbGuestName
        // 
        tbGuestName.Location = new Point(160, 77);
        tbGuestName.Name = "tbGuestName";
        tbGuestName.Size = new Size(240, 23);
        tbGuestName.TabIndex = 5;
        tbGuestName.Text = "Guest Name";
        // 
        // tbRoomNumber
        // 
        tbRoomNumber.Location = new Point(516, 77);
        tbRoomNumber.Name = "tbRoomNumber";
        tbRoomNumber.Size = new Size(100, 23);
        tbRoomNumber.TabIndex = 6;
        tbRoomNumber.Text = "Room (e,g., 101)";
        // 
        // dtCheckIn
        // 
        dtCheckIn.Location = new Point(160, 138);
        dtCheckIn.Name = "dtCheckIn";
        dtCheckIn.Size = new Size(240, 23);
        dtCheckIn.TabIndex = 8;
        // 
        // dtCheckOut
        // 
        dtCheckOut.Location = new Point(516, 138);
        dtCheckOut.Name = "dtCheckOut";
        dtCheckOut.Size = new Size(240, 23);
        dtCheckOut.TabIndex = 9;
        // 
        // btnBookRoom
        // 
        btnBookRoom.Location = new Point(98, 204);
        btnBookRoom.Name = "btnBookRoom";
        btnBookRoom.Size = new Size(87, 23);
        btnBookRoom.TabIndex = 10;
        btnBookRoom.Text = "Book Room";
        btnBookRoom.UseVisualStyleBackColor = true;
        btnBookRoom.Click += button1_Click;
        // 
        // btnCancelBooking
        // 
        btnCancelBooking.Location = new Point(265, 204);
        btnCancelBooking.Name = "btnCancelBooking";
        btnCancelBooking.Size = new Size(106, 23);
        btnCancelBooking.TabIndex = 11;
        btnCancelBooking.Text = "Cancel Booking";
        btnCancelBooking.UseVisualStyleBackColor = true;
        // 
        // btnViewAllBooking
        // 
        btnViewAllBooking.Location = new Point(391, 204);
        btnViewAllBooking.Name = "btnViewAllBooking";
        btnViewAllBooking.Size = new Size(106, 23);
        btnViewAllBooking.TabIndex = 12;
        btnViewAllBooking.Text = "View All Booking";
        btnViewAllBooking.UseVisualStyleBackColor = true;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(540, 204);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(106, 23);
        btnExit.TabIndex = 13;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        // 
        // btnStatus
        // 
        btnStatus.Location = new Point(98, 401);
        btnStatus.Name = "btnStatus";
        btnStatus.Size = new Size(87, 23);
        btnStatus.TabIndex = 14;
        btnStatus.Text = "Status";
        btnStatus.UseVisualStyleBackColor = true;
        btnStatus.Click += button1_Click_1;
        // 
        // lvBookings
        // 
        lvBookings.Location = new Point(98, 244);
        lvBookings.Name = "lvBookings";
        lvBookings.Size = new Size(576, 135);
        lvBookings.TabIndex = 15;
        lvBookings.UseCompatibleStateImageBehavior = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(800, 450);
        Controls.Add(lvBookings);
        Controls.Add(btnStatus);
        Controls.Add(btnExit);
        Controls.Add(btnViewAllBooking);
        Controls.Add(btnCancelBooking);
        Controls.Add(btnBookRoom);
        Controls.Add(dtCheckOut);
        Controls.Add(dtCheckIn);
        Controls.Add(tbRoomNumber);
        Controls.Add(tbGuestName);
        Controls.Add(lblcheckout);
        Controls.Add(lblcheckin);
        Controls.Add(lblRoomNumber);
        Controls.Add(lblGuestName);
        Controls.Add(IbWelcomeLabel);
        Name = "Form1";
        Text = "Hotel Booking Manager";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label IbWelcomeLabel;
    private Label lblGuestName;
    private Label lblRoomNumber;
    private Label lblcheckin;
    private Label lblcheckout;
    private TextBox tbGuestName;
    private TextBox tbRoomNumber;
    private DateTimePicker dtCheckIn;
    private DateTimePicker dtCheckOut;
    private Button btnBookRoom;
    private Button btnCancelBooking;
    private Button btnViewAllBooking;
    private Button btnExit;
    private Button btnStatus;
    private ListView lvBookings;
}
