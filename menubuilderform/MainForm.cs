using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Catering_system
{
    public partial class MainForm : Form
    {
        public class UserAccount
        {
            public string Username { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public string Gmail { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }

        private static string filePath = "users.json";

        private static List<UserAccount> localUserStorage =
            new List<UserAccount>();

        private bool storageReady = true;

        public MainForm()
        {
            InitializeComponent();

            // Login Button Event Binding
            if (this.btnLogin != null)
            {
                this.btnLogin.Click -= btnLogin_Click;
                this.btnLogin.Click += btnLogin_Click;
            }

            LoadUsersFromFile();

            // Display All Users In Console
            DisplayAllUsersInTerminal();
        }

        // ==========================================
        // DESIGNER EVENT STUBS
        // ==========================================

        private void MainForm_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblPassword_Click(object sender, EventArgs e) { }
        private void lblUserName_Click(object sender, EventArgs e) { }
        private void txtUserName_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void txtGmail_TextChanged(object sender, EventArgs e) { }
        private void txtPhone_TextChanged(object sender, EventArgs e) { }


        // ==========================================
        // LOAD USERS FROM JSON
        // ==========================================

        private void LoadUsersFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);

                    if (string.IsNullOrWhiteSpace(json))
                    {
                        localUserStorage = new List<UserAccount>();
                    }
                    else
                    {
                        localUserStorage =
                            JsonSerializer.Deserialize<List<UserAccount>>(json)
                            ?? new List<UserAccount>();
                    }
                }
                else
                {
                    localUserStorage = new List<UserAccount>();
                }

                // Remove invalid null entries
                localUserStorage.RemoveAll(u => u == null);

                storageReady = true;

                // Create default admin if storage is empty
                if (!localUserStorage.Any())
                {
                    UserAccount admin = new UserAccount
                    {
                        Username = "admin",
                        Phone = "01000000000",
                        Gmail = "admin@gmail.com",
                        Password = "12345678"
                    };

                    localUserStorage.Add(admin);

                    SaveUsersToFile();
                }
            }
            catch (Exception ex)
            {
                storageReady = false;

                localUserStorage = new List<UserAccount>();

                MessageBox.Show(
                    "Unable to load user data.\n" +
                    "Please check the users.json file.\n\n" +
                    ex.Message,
                    "Storage Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ==========================================
        // SAVE USERS TO JSON
        // ==========================================

        private bool SaveUsersToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(
                    localUserStorage,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    }
                );

                File.WriteAllText(filePath, json);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to save user data: {ex.Message}",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }


        // ==========================================
        // DISPLAY ALL USERS IN CONSOLE
        // ==========================================

        private void DisplayAllUsersInTerminal()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("       REGISTERED USERS DATA");
            Console.WriteLine("==================================");

            if (!localUserStorage.Any())
            {
                Console.WriteLine("No users found.");
                return;
            }

            foreach (UserAccount user in localUserStorage)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Username : {user.Username}");
                Console.WriteLine($"Phone    : {user.Phone}");
                Console.WriteLine($"Gmail    : {user.Gmail}");
                Console.WriteLine($"Password : {user.Password}");
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("==================================");
            Console.WriteLine($"Total Users: {localUserStorage.Count}");
            Console.WriteLine("==================================");
        }


        // ==========================================
        // VALIDATION METHODS
        // ==========================================

        // Username Validation

        private bool IsValidUsername(string username)
        {
            return !string.IsNullOrWhiteSpace(username)
                   && username.Length >= 3;
        }


        // Phone Validation

        private bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^[0-9]{11}$");
        }


        // Gmail Validation

        private bool IsValidGmail(string gmail)
        {
            return Regex.IsMatch(
                gmail,
                @"^[a-zA-Z0-9][a-zA-Z0-9._%+-]*@gmail\.com$",
                RegexOptions.IgnoreCase
            );
        }


        // Password Validation

        private bool IsValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password)
                   && password.Length >= 8;
        }


        // ==========================================
        // LOGIN AND REGISTRATION
        // ==========================================

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!storageReady)
            {
                MessageBox.Show(
                    "User storage is unavailable. Please restart the application after fixing the storage file.",
                    "Storage Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Get all entered data

            string username = txtUserName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string gmail = txtGmail.Text.Trim();
            string password = txtPassword.Text;


            // ==========================================
            // 1. CHECK EMPTY FIELDS
            // ==========================================

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(gmail) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // ==========================================
            // 2. USERNAME VALIDATION
            // ==========================================

            if (!IsValidUsername(username))
            {
                MessageBox.Show(
                    "Username must contain at least 3 characters.",
                    "Invalid Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // ==========================================
            // 3. PHONE VALIDATION
            // ==========================================

            if (!IsValidPhone(phone))
            {
                MessageBox.Show(
                    "Phone number must contain exactly 11 digits and numbers only.",
                    "Invalid Phone Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            // ==========================================
            // 4. GMAIL VALIDATION
            // ==========================================

            if (!IsValidGmail(gmail))
            {
                MessageBox.Show(
                    "Invalid Gmail address.\n" +
                    "Please enter a valid Gmail such as name@gmail.com.",
                    "Invalid Gmail",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            // ==========================================
            // 5. PASSWORD VALIDATION
            // ==========================================

            if (!IsValidPassword(password))
            {
                MessageBox.Show(
                    "Password must contain at least 8 characters.",
                    "Weak Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            // ==========================================
            // 6. CHECK EXISTING ACCOUNT
            // ==========================================

            UserAccount existingUser = localUserStorage.FirstOrDefault(u =>

                string.Equals(
                    u.Username,
                    username,
                    StringComparison.OrdinalIgnoreCase
                )
                ||
                string.Equals(
                    u.Gmail,
                    gmail,
                    StringComparison.OrdinalIgnoreCase
                )
                ||
                string.Equals(
                    u.Phone,
                    phone,
                    StringComparison.Ordinal
                )
            );


            // ==========================================
            // CASE A: EXISTING USER
            // ==========================================

            if (existingUser != null)
            {
                bool allDataMatch =

                    string.Equals(
                        existingUser.Username,
                        username,
                        StringComparison.Ordinal
                    )

                    && string.Equals(
                        existingUser.Phone,
                        phone,
                        StringComparison.Ordinal
                    )

                    && string.Equals(
                        existingUser.Gmail,
                        gmail,
                        StringComparison.OrdinalIgnoreCase
                    )

                    && string.Equals(
                        existingUser.Password,
                        password,
                        StringComparison.Ordinal
                    );


                if (allDataMatch)
                {
                    MessageBox.Show(
                        $"Welcome Back, {existingUser.Username}!",
                        "Welcome Back",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Open Dashboard After Successful Login
                    ProceedToMainDashboard();

                    return;
                }
                else
                {
                    MessageBox.Show(
                        "The entered information is incorrect.\n" +
                        "One or more fields do not match the saved account.\n\n" +
                        "Please enter your correct saved information.",
                        "Authentication Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }
            }


            // ==========================================
            // CASE B: NEW USER REGISTRATION
            // ==========================================

            // Check duplicate Username

            bool usernameExists = localUserStorage.Any(u =>
                string.Equals(
                    u.Username,
                    username,
                    StringComparison.OrdinalIgnoreCase
                )
            );

            // Check duplicate Phone

            bool phoneExists = localUserStorage.Any(u =>
                string.Equals(
                    u.Phone,
                    phone,
                    StringComparison.Ordinal
                )
            );

            // Check duplicate Gmail

            bool gmailExists = localUserStorage.Any(u =>
                string.Equals(
                    u.Gmail,
                    gmail,
                    StringComparison.OrdinalIgnoreCase
                )
            );


            if (usernameExists || phoneExists || gmailExists)
            {
                MessageBox.Show(
                    "This Username, Phone Number, or Gmail is already registered.",
                    "Duplicate Account",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // ==========================================
            // CREATE NEW USER
            // ==========================================

            UserAccount newUser = new UserAccount
            {
                Username = username,
                Phone = phone,
                Gmail = gmail,
                Password = password
            };


            // Save new user

            localUserStorage.Add(newUser);

            bool savedSuccessfully = SaveUsersToFile();

            if (!savedSuccessfully)
            {
                localUserStorage.Remove(newUser);

                return;
            }


            // ==========================================
            // REGISTRATION SUCCESS
            // ==========================================

            MessageBox.Show(
                $"Welcome, {newUser.Username}!",
                "Registration Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Open Dashboard After Successful Registration
            ProceedToMainDashboard();
        }


        // ==========================================
        // NAVIGATE TO MAIN DASHBOARD
        // ==========================================

        private void ProceedToMainDashboard()
        {
            this.Hide();

            MainDashboardForm mainDashboard = new MainDashboardForm();

            mainDashboard.FormClosed += (s, args) =>
            {
                this.Close();
            };

            mainDashboard.Show();
        }
    }
}