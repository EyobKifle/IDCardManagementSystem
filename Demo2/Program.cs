using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Demo2
{
    // Student Class
    public class Student
    {
        public string StudentID { get; }
        public string FullName { get; }
        public DateTime DOB { get; }
        public string Email { get; }
        public string PhoneNumber { get; }
        public string EmergencyContactNumber { get; }
        public string EmergencyContactName { get; }
        public string Address { get; }
        public string ProfilePicturePath { get; }
        public string Status { get; }
        public DateTime CreatedAt { get; }

        public Student(string studentID, string fullName, DateTime dob, string email, string phoneNumber, string emergencyContactNumber, string emergencyContactName, string address, string profilePicturePath, string status, DateTime createdAt)
        {
            StudentID = studentID;
            FullName = fullName;
            DOB = dob;
            Email = email;
            PhoneNumber = phoneNumber;
            EmergencyContactNumber = emergencyContactNumber;
            EmergencyContactName = emergencyContactName;
            Address = address;
            ProfilePicturePath = profilePicturePath;
            Status = status;
            CreatedAt = createdAt;
        }
    }

    // Dean Class
    public class Dean
    {
        public int DeanID { get; }
        public string FullName { get; }
        public string Department { get; }
        public string OfficeLocation { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
        public string ProfilePicturePath { get; }
        public string Status { get; }
        public DateTime CreatedAt { get; }
        public DateTime DOB { get; }
        public string Address { get; }
        public string EmergencyContactName { get; }
        public string EmergencyContactPhone { get; }

        public Dean(int deanID, string fullName, string department, string officeLocation, string phoneNumber, string email, string profilePicturePath, string status, DateTime createdAt, DateTime dob, string address, string emergencyContactName, string emergencyContactPhone)
        {
            DeanID = deanID;
            FullName = fullName;
            Department = department;
            OfficeLocation = officeLocation;
            PhoneNumber = phoneNumber;
            Email = email;
            ProfilePicturePath = profilePicturePath;
            Status = status;
            CreatedAt = createdAt;
            DOB = dob;
            Address = address;
            EmergencyContactName = emergencyContactName;
            EmergencyContactPhone = emergencyContactPhone;
        }
    }

    // IDRequest Class
    public class IDRequest
    {
        public int RequestID { get; }
        public string StudentID { get; }
        public string StudentName { get; }
        public string StudentEmail { get; }
        public DateTime RequestDate { get; }
        public DateTime? ProcessedDate { get; }
        public string Status { get; }
        public string Remark { get; }
        public byte[] ProfilePictureData { get; }
        public string AdditionalInfo { get; }
        public string EvidencePath { get; }
        public string Reason { get; }

        public IDRequest(int requestID, string studentID, string studentName, string studentEmail, DateTime requestDate, DateTime? processedDate, string status, string remark, byte[] profilePictureData, string additionalInfo, string evidencePath, string reason)
        {
            RequestID = requestID;
            StudentID = studentID;
            StudentName = studentName;
            StudentEmail = studentEmail;
            RequestDate = requestDate;
            ProcessedDate = processedDate;
            Status = status;
            Remark = remark;
            ProfilePictureData = profilePictureData;
            AdditionalInfo = additionalInfo;
            EvidencePath = evidencePath;
            Reason = reason;
        }
    }

    // DatabaseHelper Class
    public class DatabaseHelper
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Demo2DB"].ConnectionString;

        // Hash a password using SHA256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        // Fetch all students using the GetStudents stored procedure
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetStudents", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                students.Add(new Student(
                                    reader["StudentID"].ToString(),
                                    reader["FullName"].ToString(),
                                    Convert.ToDateTime(reader["DOB"]),
                                    reader["Email"].ToString(),
                                    reader["PhoneNumber"].ToString(),
                                    reader["EmergencyContactNumber"].ToString(),
                                    reader["EmergencyContactName"].ToString(),
                                    reader["Address"].ToString(),
                                    reader["ProfilePicturePath"].ToString(),
                                    reader["Status"].ToString(),
                                    Convert.ToDateTime(reader["CreatedAt"])
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching students: {ex.Message}");
            }

            return students;
        }

        // Fetch all deans using the GetDeans stored procedure
        public List<Dean> GetDeans()
        {
            List<Dean> deans = new List<Dean>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetDeans", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                deans.Add(new Dean(
                                    Convert.ToInt32(reader["DeanID"]),
                                    reader["FullName"].ToString(),
                                    reader["Department"].ToString(),
                                    reader["OfficeLocation"].ToString(),
                                    reader["PhoneNumber"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["ProfilePicturePath"].ToString(),
                                    reader["Status"].ToString(),
                                    Convert.ToDateTime(reader["CreatedAt"]),
                                    Convert.ToDateTime(reader["DOB"]),
                                    reader["Address"].ToString(),
                                    reader["EmergencyContactName"].ToString(),
                                    reader["EmergencyContactPhone"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching deans: {ex.Message}");
            }

            return deans;
        }

        // Validate login credentials using the ValidateLogin stored procedure
        public string ValidateLogin(string email, string password)
        {
            string userType = "";
            string hashedPassword = HashPassword(password);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("ValidateLogin", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                userType = reader["Role"].ToString();
                                int userId = Convert.ToInt32(reader["UserID"]);
                                return $"{userType}|{userId}"; // Return user type and ID
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error validating login: {ex.Message}");
            }

            return userType;
        }

        // Fetch all ID requests using the GetAllStudentRequests stored procedure
        public List<IDRequest> GetIDRequests()
        {
            List<IDRequest> requests = new List<IDRequest>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetAllStudentRequests", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                requests.Add(new IDRequest(
                                    Convert.ToInt32(reader["RequestID"]),
                                    reader["StudentID"].ToString(),
                                    reader["StudentName"].ToString(),
                                    reader["StudentEmail"].ToString(),
                                    Convert.ToDateTime(reader["RequestDate"]),
                                    reader["ProcessedDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ProcessedDate"]),
                                    reader["Status"].ToString(),
                                    reader["Remark"].ToString(),
                                    reader["ProfilePictureData"] as byte[],
                                    reader["AdditionalInfo"].ToString(),
                                    reader["EvidencePath"].ToString(),
                                    reader["Reason"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching ID requests: {ex.Message}");
            }

            return requests;
        }
    }

    // Program Class
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
        }
    }
}