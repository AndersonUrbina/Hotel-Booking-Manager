using HotelBookingManager;

namespace Hotel_Booking_Manager;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    //Declare a BookingManager object
    private readonly HotelBookingManager.BookingManager manager = new();

    //Event sender method
    private void btnBookRoom_Click(object sender, EventArgs e) => BookRoom();
    private void btnCancelBooking_Click(object sender, EventArgs e) => CancelBooking();
    private void btnViewAllBooking_Click(object sender, EventArgs e) => RefreshList();
    private void btnExit_Click(object sender, EventArgs e) => Close();

    //Void to Book a Hotel Room
    private void BookRoom()
    {
        try
        {
            var room = tbRoomNumber.Text.Trim();
            var guest = tbGuestName.Text.Trim();
            var c_in = dtCheckIn.Value;
            var c_out = dtCheckOut.Value;

            //Validate that Guest and Room are not empty
            if (string.IsNullOrWhiteSpace(room) || string.IsNullOrWhiteSpace(guest))
                throw new ArgumentException("Guest Name and Room Number are required.");
            //Validate that Check-out is after Check-in
            if (c_out <= c_in)
                throw new ArgumentException("Check-out must be after Check-in.");
            //Create a booking and add it
            var b = new Booking(room, guest, c_in, c_out);
            manager.Add(b);

            //Call helpers
            RefreshList();
            clearInputs();
            SetStatus($"Booked room {room} for {guest} from {c_in:MM/dd/yyyy} to {c_out:MM/dd/yyyy}.", success: true);

            //If successful, refresh the list, clear the inputs, and update the status label. Otherwise, show a message box.
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SetStatus(ex.Message, success: false);
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SetStatus(ex.Message, success: false);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Unexpected error. See detyails.\n " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            SetStatus("Unexpected error occurred.", success: false);
        }
    }

    //Void to Cancel a Booking
    private void CancelBooking()
    { 
        //Get information from the text boxes
        var room = tbRoomNumber.Text;
        var guest = tbGuestName.Text;

        //Reject empty textboxes
        if (string.IsNullOrWhiteSpace(room) || string.IsNullOrWhiteSpace(guest))
        {
            MessageBox.Show("Enter both Room and Guest to cancel.", "Cancel Booking",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        
        //Attemp to Cancel the reservation. If successful, refresh the list and clear the inputs. Otherwise, show a message box.
        var ok = manager.Cancel(room, guest);
        if (ok)
        {
            RefreshList();
            clearInputs();
            SetStatus($"Canceled booking for {guest} in room {room}.", success: true);
        }
        else
        {
            MessageBox.Show("No matching booking found to cancel.", "Cancel Booking",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetStatus("No matching booking found.", success: false);
        }
    }

    //Method to refresh the Bookng List View
    private void RefreshList()
    {
        lvBookings.BeginUpdate();
        lvBookings.Items.Clear();

        foreach (var b in manager.All())
        {
            var item = new ListViewItem(new[]
            { 
                b.RoomNumber,
                b.CheckIn.ToString("yyyy-MM-dd HH:mm"),
                b.CheckOut.ToString("yyyy-MM-dd HH:mm"),
                b.GuestName
            });
            lvBookings.Items.Add(item);
        }
        lvBookings.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        lvBookings.EndUpdate();
        SetStatus($"Loaded {lvBookings.Items.Count} booking(s).", success: true);
    }

    //Void to load selected booking into the form inputs
    private void LoadBookingToForm()
    {
        if (lvBookings.SelectedItems.Count == 0) return;
        var sel = lvBookings.SelectedItems[0];
        tbRoomNumber.Text = sel.SubItems[0].Text;
        dtCheckIn.Value = DateTime.Parse(sel.SubItems[1].Text);
        dtCheckOut.Value = DateTime.Parse(sel.SubItems[2].Text);
        tbGuestName.Text = sel.SubItems[3].Text;
        SetStatus("Loaded selection intro inputs.", success: true);
    }

    //Void to update Status label
    private void SetStatus(string message, bool success)
    {
        lblStatus.Text = message;
        lblStatus.ForeColor = success ? Color.FromArgb(24, 128, 28) : Color.FromArgb(176, 32, 32);
    }

    //Void to clear the form inputs
    private void clearInputs()
    {
        tbGuestName.Clear();
        tbRoomNumber.Clear();
        tbGuestName.Focus();
    }

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
        lvBookings = new ListView();
        Room = new ColumnHeader();
        Check_In = new ColumnHeader();
        Check_Out = new ColumnHeader();
        Guest = new ColumnHeader();
        lblStatus = new Label();
        SuspendLayout();
        // 
        // IbWelcomeLabel
        // 
        IbWelcomeLabel.AutoSize = true;
        IbWelcomeLabel.Font = new Font("Bodoni MT Condensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        IbWelcomeLabel.ForeColor = SystemColors.ControlLight;
        IbWelcomeLabel.Location = new Point(209, 9);
        IbWelcomeLabel.Name = "IbWelcomeLabel";
        IbWelcomeLabel.Size = new Size(383, 44);
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
        tbRoomNumber.TextChanged += tbRoomNumber_TextChanged;
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
        btnBookRoom.Click += btnBookRoom_Click;
        // 
        // btnCancelBooking
        // 
        btnCancelBooking.Location = new Point(265, 204);
        btnCancelBooking.Name = "btnCancelBooking";
        btnCancelBooking.Size = new Size(106, 23);
        btnCancelBooking.TabIndex = 11;
        btnCancelBooking.Text = "Cancel Booking";
        btnCancelBooking.UseVisualStyleBackColor = true;
        btnCancelBooking.Click += btnCancelBooking_Click;
        // 
        // btnViewAllBooking
        // 
        btnViewAllBooking.Location = new Point(391, 204);
        btnViewAllBooking.Name = "btnViewAllBooking";
        btnViewAllBooking.Size = new Size(106, 23);
        btnViewAllBooking.TabIndex = 12;
        btnViewAllBooking.Text = "View All Booking";
        btnViewAllBooking.UseVisualStyleBackColor = true;
        btnViewAllBooking.Click += btnViewAllBooking_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(540, 204);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(106, 23);
        btnExit.TabIndex = 13;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // lvBookings
        // 
        lvBookings.Columns.AddRange(new ColumnHeader[] { Room, Check_In, Check_Out, Guest });
        lvBookings.LabelEdit = true;
        lvBookings.Location = new Point(98, 244);
        lvBookings.Name = "lvBookings";
        lvBookings.Size = new Size(576, 135);
        lvBookings.TabIndex = 15;
        lvBookings.UseCompatibleStateImageBehavior = false;
        lvBookings.View = View.Details;
        lvBookings.SelectedIndexChanged += lvBookings_SelectedIndexChanged;
        // 
        // Room
        // 
        Room.Text = "Room";
        Room.Width = 80;
        // 
        // Check_In
        // 
        Check_In.Text = "Check-In";
        Check_In.Width = 140;
        // 
        // Check_Out
        // 
        Check_Out.Text = "Check-Out";
        Check_Out.Width = 140;
        // 
        // Guest
        // 
        Guest.Text = "Guest";
        Guest.Width = 250;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblStatus.ForeColor = SystemColors.ControlLight;
        lblStatus.Location = new Point(98, 392);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(53, 20);
        lblStatus.TabIndex = 16;
        lblStatus.Text = "Ready.";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(800, 450);
        Controls.Add(lblStatus);
        Controls.Add(lvBookings);
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
    private ListView lvBookings;
    private Label lblStatus;
    private ColumnHeader Room;
    private ColumnHeader Check_In;
    private ColumnHeader Check_Out;
    private ColumnHeader Guest;
}
