Use IdCardManagement
Go
-- Dean Table
CREATE TABLE Dean (
    DeanID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID), -- Links to the Users table
    FullName VARCHAR(100) NOT NULL,
    Department VARCHAR(100) NOT NULL,
    OfficeLocation VARCHAR(255),
    PhoneNumber VARCHAR(15) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    ProfilePicturePath VARCHAR(255), -- Path to the dean's profile picture
    Status VARCHAR(50) DEFAULT 'Active', -- Active, Inactive, etc.
    CreatedAt DATETIME DEFAULT GETDATE(),
    DOB DATE, -- Added from C# form
    Address VARCHAR(255), -- Added from C# form
    EmergencyContactName VARCHAR(100), -- Added from C# form
    EmergencyContactPhone VARCHAR(15) -- Added from C# form
);
GO

-- IDCardDetails Table
CREATE TABLE IDCardDetails (
    IdCardNumber VARCHAR(50) PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID), -- Links to the Users table
    StudentID VARCHAR(20) FOREIGN KEY REFERENCES Students(StudentID), -- Links to the Students table
    IssueDate DATE NOT NULL,
    ExpirationDate DATE NOT NULL,
    Status VARCHAR(50) NOT NULL, -- Active, Expired, etc.
    Remarks VARCHAR(255),
    Reason VARCHAR(50) -- Reason for the request (Stolen or Damaged)
);
GO

-- IDRequests Table
CREATE TABLE IDRequests (
    RequestID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID VARCHAR(20) FOREIGN KEY REFERENCES Students(StudentID),
    StudentName VARCHAR(100) NOT NULL,
    StudentEmail VARCHAR(100) NOT NULL,
    RequestDate DATETIME DEFAULT GETDATE(),
	ProcessedDate DATETIME NULL,
    Status VARCHAR(50) DEFAULT 'Pending', -- Pending, Approved, Rejected
    Remark VARCHAR(255), -- Reason for rejection (if applicable)
    ProfilePictureData VARBINARY(MAX), -- Optional: Store profile picture as binary data
    AdditionalInfo VARCHAR(MAX), -- Additional information provided by the student
    EvidencePath VARCHAR(255), -- Path to evidence (e.g., damaged ID photo)
    Reason VARCHAR(50) -- Reason for the request (Stolen or Damaged)
);
GO

-- Students Table
CREATE TABLE Students (
    StudentID VARCHAR(20) PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID), -- Links to the Users table
    FullName VARCHAR(100) NOT NULL,
    DOB DATE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    EmergencyContactNumber VARCHAR(15) NOT NULL,
    EmergencyContactName VARCHAR(100) NOT NULL,
    Address VARCHAR(255) NOT NULL,
    ProfilePicturePath VARCHAR(255), -- Path to the student's profile picture
    Status VARCHAR(50) DEFAULT 'Active', -- Active, Deleted, etc.
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- TransactionLogs Table (for auditing)
CREATE TABLE TransactionLogs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    TableName VARCHAR(100) NOT NULL, -- Name of the table being modified
    Action VARCHAR(50) NOT NULL, -- Action performed (Insert, Update, Delete)
    RecordID VARCHAR(100) NOT NULL, -- ID of the record being modified
    UserID INT FOREIGN KEY REFERENCES Users(UserID), -- User who performed the action
    LogDate DATETIME DEFAULT GETDATE() -- Timestamp of the action
);
GO

-- Users Table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL, -- Store hashed passwords for security
    Role VARCHAR(50) NOT NULL CHECK (Role IN ('Student', 'Dean')), -- Role can be 'Student' or 'Dean'
    ResetToken VARCHAR(255), -- For password reset
    TokenExpiry DATETIME, -- Expiry time for reset token
    ProfilePicturePath VARCHAR(255), -- Path to profile picture
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- CheckPendingRequests: Checks for pending ID requests
CREATE PROCEDURE CheckPendingRequests
    @UserID INT
AS
BEGIN
    SELECT 
        ir.RequestID,
        ir.StudentName,
        ir.StudentEmail,
        ir.RequestDate,
        ir.Status,
        ir.Remark,
        ir.ProfilePictureData,
        ir.AdditionalInfo,
        ir.EvidencePath,
        ir.Reason
    FROM 
        IDRequests ir
    INNER JOIN 
        Students s ON ir.StudentID = s.StudentID
    WHERE 
        s.UserID = @UserID 
        AND ir.Status = 'Pending';  -- Ensure only pending requests are returned
END;
GO
-- CreateDean: Creates a new dean record
CREATE PROCEDURE CreateDean
    @UserID INT,
    @FullName VARCHAR(100),
    @Department VARCHAR(100),
    @OfficeLocation VARCHAR(255),
    @PhoneNumber VARCHAR(15),
    @Email VARCHAR(100),
    @ProfilePicturePath VARCHAR(255),
    @Status VARCHAR(50)
AS
BEGIN
    DECLARE @FirstName VARCHAR(50);
    DECLARE @LastName VARCHAR(50);

    -- Extract FirstName and LastName from @FullName
    SET @FullName = LTRIM(RTRIM(@FullName)); -- Trim leading and trailing spaces
    SET @FirstName = LEFT(@FullName, ISNULL(NULLIF(CHARINDEX(' ', @FullName), 0), LEN(@FullName))); -- FirstName is everything before the first space
    SET @LastName = CASE 
                        WHEN CHARINDEX(' ', @FullName) > 0 THEN LTRIM(SUBSTRING(@FullName, CHARINDEX(' ', @FullName), LEN(@FullName))) -- LastName is everything after the first space
                        ELSE '' -- If no space exists, set LastName to an empty string
                    END;

    -- Insert the dean record
    INSERT INTO Dean (UserID, FullName, Department, OfficeLocation, PhoneNumber, Email, ProfilePicturePath, Status)
    VALUES (@UserID, @FullName, @Department, @OfficeLocation, @PhoneNumber, @Email, @ProfilePicturePath, @Status);
END;
GO

-- CreateStudent: Creates a new student record
CREATE PROCEDURE CreateStudent
    @FullName VARCHAR(100),
    @DOB DATE,
    @Email VARCHAR(100),
    @PhoneNumber VARCHAR(15),
    @EmergencyContactNumber VARCHAR(15),
    @EmergencyContactName VARCHAR(100),
    @Address VARCHAR(255),
    @ProfilePicturePath VARCHAR(255),
    @Status VARCHAR(50),
    @Password VARCHAR(255),
    @StudentID VARCHAR(20) OUTPUT -- Output parameter for the generated student ID
AS
BEGIN
    DECLARE @UserID INT;
    DECLARE @FirstName VARCHAR(50);
    DECLARE @LastName VARCHAR(50);

    -- Extract FirstName and LastName from @FullName
    SET @FullName = LTRIM(RTRIM(@FullName)); -- Trim leading and trailing spaces
    SET @FirstName = LEFT(@FullName, ISNULL(NULLIF(CHARINDEX(' ', @FullName), 0), LEN(@FullName))); -- FirstName is everything before the first space
    SET @LastName = CASE 
                        WHEN CHARINDEX(' ', @FullName) > 0 THEN LTRIM(SUBSTRING(@FullName, CHARINDEX(' ', @FullName), LEN(@FullName))) -- LastName is everything after the first space
                        ELSE '' -- If no space exists, set LastName to an empty string
                    END;

    -- Generate a unique student ID
    EXEC GenerateUniqueStudentID @FullName, @PhoneNumber, @StudentID OUTPUT;

    -- Check if the user already exists
    SELECT @UserID = UserID FROM Users WHERE Email = @Email;

    -- If the user does not exist, create a new user
    IF @UserID IS NULL
    BEGIN
        INSERT INTO Users (FirstName, LastName, Email, Password, Role, ProfilePicturePath, CreatedAt)
        VALUES (
            @FirstName, -- FirstName
            @LastName, -- LastName
            @Email,
            @Password,
            'Student', -- Role is set to 'Student'
            @ProfilePicturePath,
            GETDATE() -- CreatedAt
        );

        SET @UserID = SCOPE_IDENTITY(); -- Get the newly created UserID
    END

    -- Create the student record
    INSERT INTO Students (StudentID, UserID, FullName, DOB, Email, PhoneNumber, EmergencyContactNumber, EmergencyContactName, Address, ProfilePicturePath, Status, CreatedAt)
    VALUES (@StudentID, @UserID, @FullName, @DOB, @Email, @PhoneNumber, @EmergencyContactNumber, @EmergencyContactName, @Address, @ProfilePicturePath, @Status, GETDATE());
END;
GO

-- fetchDeanProfile: Fetches dean profile details
CREATE PROCEDURE FetchDeanProfile
    @UserID INT
AS
BEGIN
    SELECT 
        FullName,
        dbo.CalculateAge(DOB) AS Age, -- Calculate age instead of returning DOB
        PhoneNumber,
        Email,
        Address,
        EmergencyContactName,
        EmergencyContactPhone,
        ProfilePicturePath
    FROM 
        Dean
    WHERE 
        UserID = @UserID;
END;
GO

-- FetchIDRequestDetails: Fetches details of a specific ID request
CREATE PROCEDURE FetchLatestIDRequestDetails
    @UserID INT
AS
BEGIN
    SELECT TOP 1 
        ir.StudentID, 
        ir.StudentName, 
        ir.RequestDate, 
        DATEADD(DAY, 4, ir.RequestDate) AS ExpirationDate, -- Expiration date is 4 days after the request date
        ir.Status, 
        CASE 
            WHEN ir.Status = 'Approved' THEN 'Approved. Come on the next day of the expiration date to the registrar to pick up your new ID.'
            WHEN ir.Status = 'Rejected' THEN ir.Remark
            ELSE '' -- If status is pending, return an empty string
        END AS Remarks
    FROM 
        IDRequests ir
    INNER JOIN 
        Students s ON ir.StudentID = s.StudentID
    WHERE 
        s.UserID = @UserID
    ORDER BY 
        ir.RequestDate DESC;
END;
GO
-- FetchStudentDetails: Fetches student details
CREATE PROCEDURE FetchStudentDetails
    @UserID INT
AS
BEGIN
    SELECT 
        s.FullName,
        dbo.CalculateAge(s.DOB) AS Age, -- Calculate age instead of returning DOB
        s.PhoneNumber,
        s.Email,
        s.Address,
        s.EmergencyContactName,
        s.EmergencyContactNumber,
        s.StudentID,
        s.ProfilePicturePath
    FROM 
        Students s
    WHERE 
        s.UserID = @UserID;
END;
GO

--For Updating student data
CREATE PROCEDURE FetchStudentDetail
    @UserID INT
AS
BEGIN
    SELECT 
        FullName,
        DOB, -- Return DOB instead of Age
        PhoneNumber,
        Email,
        Address,
        EmergencyContactName,
        EmergencyContactNumber,
        StudentID,
        ProfilePicturePath
    FROM 
        Students
    WHERE 
        UserID = @UserID;
END;
GO
-- FetchUserDetails: Fetches user details based on their role
CREATE PROCEDURE FetchUserDetails
    @UserID INT
AS
BEGIN
    DECLARE @Role VARCHAR(50);
    SELECT @Role = Role FROM Users WHERE UserID = @UserID;

    IF @Role = 'Student'
    BEGIN
        SELECT s.*, u.FirstName, u.LastName, u.ProfilePicturePath
        FROM Students s
        INNER JOIN Users u ON s.UserID = u.UserID
        WHERE s.UserID = @UserID;
    END
    ELSE IF @Role = 'Dean'
    BEGIN
        SELECT d.*, u.FirstName, u.LastName, u.Email, u.Role, u.ProfilePicturePath
        FROM Dean d
        INNER JOIN Users u ON d.UserID = u.UserID
        WHERE d.UserID = @UserID;
    END
END;
GO

-- GenerateUniqueStudentID: Generates a unique student ID
CREATE PROCEDURE GenerateUniqueStudentID
    @FullName VARCHAR(100),
    @PhoneNumber VARCHAR(15),
    @StudentID VARCHAR(20) OUTPUT
AS
BEGIN
    DECLARE @FirstName VARCHAR(50);
    DECLARE @LastName VARCHAR(50);
    DECLARE @Initials VARCHAR(2);
    DECLARE @PhoneSuffix VARCHAR(2);
    DECLARE @BaseID VARCHAR(4);
    DECLARE @Counter INT = 0;
    DECLARE @NewStudentID VARCHAR(20);

    -- Trim leading and trailing spaces from the full name
    SET @FullName = LTRIM(RTRIM(@FullName));

    -- Extract the first name (everything before the first space)
    SET @FirstName = LEFT(@FullName, ISNULL(NULLIF(CHARINDEX(' ', @FullName), 0), LEN(@FullName)));

    -- Extract the last name (everything after the first space)
    SET @LastName = LTRIM(SUBSTRING(@FullName, CHARINDEX(' ', @FullName + ' '), LEN(@FullName)));

    -- Get the first letter of the first name and last name
    SET @Initials = UPPER(LEFT(@FirstName, 1) + LEFT(@LastName, 1));

    -- Get the last two digits of the phone number
    SET @PhoneSuffix = RIGHT(@PhoneNumber, 2);

    -- Create the base ID (e.g., ZS56)
    SET @BaseID = @Initials + @PhoneSuffix;

    -- Check if the base ID already exists
    WHILE EXISTS (SELECT 1 FROM Students WHERE StudentID = @BaseID + CASE WHEN @Counter > 0 THEN CAST(@Counter AS VARCHAR) ELSE '' END)
    BEGIN
        SET @Counter = @Counter + 1;
    END

    -- Generate the final student ID
    SET @NewStudentID = @BaseID + CASE WHEN @Counter > 0 THEN CAST(@Counter AS VARCHAR) ELSE '' END;

    -- Return the generated student ID
    SET @StudentID = @NewStudentID;
END;
GO

-- GetAllStudentRequests: Fetches all student requests
CREATE PROCEDURE GetAllStudentRequests
AS
BEGIN
    SELECT 
        RequestID,
        StudentName,
        StudentEmail,
        RequestDate,
        Status,
        Reason,
        EvidencePath
    FROM 
        IDRequests
    ORDER BY 
        RequestDate DESC;
END;
GO

-- GetDeans: Fetches all deans from the Dean table
CREATE PROCEDURE GetDeans
AS
BEGIN
    SELECT 
        FullName,
        Department,
        OfficeLocation,
        PhoneNumber,
        Email,
        ProfilePicturePath,
        Status,
        DOB,
        Address,
        EmergencyContactName,
        EmergencyContactPhone
    FROM Dean;
END;
GO

-- GetProfilePicturePath: Fetches the profile picture path for a user
CREATE PROCEDURE GetProfilePicturePath
    @UserID INT
AS
BEGIN
    SELECT ProfilePicturePath
    FROM Users
    WHERE UserID = @UserID;
END;
GO

-- GetRequestHistory: Fetches all ID request history
CREATE PROCEDURE GetRequestHistory
AS
BEGIN
    -- Fetch only the necessary columns from the IDRequests table
    SELECT 
        RequestID,          -- Unique identifier for the request
        StudentName, 
		StudentID,
		ProcessedDate,
		Remark,-- Name of the student who made the request
        RequestDate,        -- Date when the request was made
        Status,             -- Current status of the request (e.g., Pending, Approved, Rejected)
        Reason             -- Additional remarks about the request
    FROM 
        IDRequests
    ORDER BY 
        RequestDate DESC;   -- Order by most recent requests first
END;
GO

ALTER PROCEDURE ExportIDRequestsToFile  
AS  
BEGIN  
    Select * from IDRequests
END;

exec ExportIDRequestsToFile


-- GetStudents: Fetches all students from the Students table
CREATE PROCEDURE GetStudents
AS
BEGIN
    SELECT 
        StudentID,
        FullName,
        DOB,
        Email,
        PhoneNumber,
        EmergencyContactNumber,
        EmergencyContactName,
        Address,
        ProfilePicturePath,
        Status
    FROM Students;
END;
GO


CREATE OR ALTER PROCEDURE GetStudentProfilePicturePath
    @StudentID VARCHAR(20)
AS
BEGIN
    SELECT ProfilePicturePath
    FROM Students
    WHERE StudentID = @StudentID;
END;
GO

-- GetStudentRequestDetails: Fetches details of a specific student request
CREATE OR ALTER PROCEDURE GetStudentRequestDetails
    @RequestID INT
AS
BEGIN
    SELECT 
        StudentID, -- Ensure this is included
        StudentName, 
        StudentEmail, 
        RequestDate, 
        Status AS RequestStatus, 
        Remark AS RequestRemark, 
        Reason AS RequestReason, 
        ProfilePictureData AS RequestProfilePictureData, 
        EvidencePath AS RequestEvidencePath
    FROM 
        IDRequests
    WHERE 
        RequestID = @RequestID;

    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR('Request ID not found or invalid.', 16, 1);
        RETURN;
    END
END;
GO

CREATE PROCEDURE GetStudentIdByUserId
    @UserId INT
AS
BEGIN
    SELECT studentId
    FROM Students
    WHERE userId = @UserId;
END

CREATE OR ALTER PROCEDURE GetSpecificStudentRequestHistory
    @StudentID NVARCHAR(50)
AS
BEGIN
    SELECT 
        RequestID,
        StudentName,
        StudentEmail,
        RequestDate,
        Status,
        Reason,
        EvidencePath
    FROM 
        IDRequests
    WHERE 
        StudentID = @StudentID
		 ORDER BY 
        RequestDate DESC;
END

-- GetStudentInfo: Fetches student information
CREATE PROCEDURE GetStudentInfo
    @UserID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        s.FullName, 
        s.Email
    FROM 
        Students s
    INNER JOIN 
        Users u ON s.UserID = u.UserID
    WHERE 
        u.UserID = @UserID;
END;
GO

CREATE OR ALTER PROCEDURE GetStudentRequestHistory
    @StudentID VARCHAR(20)
AS
BEGIN
    SELECT 
      RequestID,
        StudentName,
        StudentEmail,
        RequestDate,
        Status,
        Reason,
        EvidencePath
    FROM 
        IDRequests
    WHERE 
        StudentID = @StudentID
    ORDER BY 
        RequestDate DESC; -- Show the most recent requests first
END;
GO

-- GetUserIdByName: Gets UserID by full name
CREATE PROCEDURE GetUserIdByName
    @FullName VARCHAR(100)
AS
BEGIN
    SELECT 
        UserID 
    FROM 
        Users 
    WHERE 
        FirstName + ' ' + LastName = @FullName;
END;
GO

-- SaveIDRequest: Saves a new ID request
CREATE PROCEDURE SaveIDRequest
    @StudentID VARCHAR(20), -- Changed to VARCHAR to match the Students table
    @StudentName NVARCHAR(255),
    @StudentEmail NVARCHAR(255),
    @Reason NVARCHAR(255),
    @EvidencePath NVARCHAR(255)
AS
BEGIN
    -- Insert your logic here
    INSERT INTO IDRequests (StudentID, StudentName, StudentEmail, Reason, EvidencePath)
    VALUES (@StudentID, @StudentName, @StudentEmail, @Reason, @EvidencePath)
END
GO

-- SearchStudent: Searches for active students by name or ID
CREATE PROCEDURE SearchStudent
    @SearchTerm VARCHAR(100)
AS
BEGIN
    -- Search for students by name or student ID, and ensure they are active
    SELECT 
        StudentID,
        FullName,
        dbo.CalculateAge(DOB) AS Age, -- Calculate age instead of returning DOB
        Email,
        PhoneNumber,
        EmergencyContactNumber,
        EmergencyContactName,
        Address,
        ProfilePicturePath,
        Status
    FROM 
        Students
    WHERE 
        (FullName LIKE @SearchTerm 
        OR StudentID LIKE @SearchTerm)
        AND Status = 'active'; -- Only return active students
END;
GO

-- SoftDeleteStudent: Marks a student as deleted
CREATE PROCEDURE SoftDeleteStudent
    @StudentID VARCHAR(20) -- Input parameter: StudentID to be soft deleted
AS
BEGIN
    -- Update the student's status to 'Deleted'
    UPDATE Students
    SET Status = 'Deleted'
    WHERE StudentID = @StudentID;

    -- Check if the update was successful
    IF @@ROWCOUNT > 0
    BEGIN
        -- Return a success message or status
        SELECT 'Student marked as deleted.' AS Message;
    END
    ELSE
    BEGIN
        -- Return an error message if no rows were affected
        SELECT 'Student not found or already deleted.' AS Message;
    END
END
GO

-- UpdateRequestStatus: Updates the status of an ID request
CREATE PROCEDURE UpdateRequestStatus
    @RequestID INT,
    @Status VARCHAR(50),
    @RejectReason VARCHAR(255) = NULL
AS
BEGIN
    UPDATE IDRequests
    SET 
        Status = @Status,
        Remark = CASE 
                    WHEN @Status = 'Rejected' THEN @RejectReason 
                    ELSE Remark 
                 END
    WHERE 
        RequestID = @RequestID;
END;
GO

CREATE PROCEDURE UpdateUserProfile
    @UserID INT, 
    @FullName NVARCHAR(100),  
    @DOB DATE,
    @Email NVARCHAR(100),
    @PhoneNumber NVARCHAR(15),
    @EmergencyContactNumber NVARCHAR(15),
    @EmergencyContactName NVARCHAR(100),
    @Address NVARCHAR(255),
    @ProfilePicturePath NVARCHAR(255) = NULL  
AS
BEGIN
    SET NOCOUNT ON;

    -- Split FullName into FirstName and LastName
    DECLARE @FirstName NVARCHAR(50), @LastName NVARCHAR(50);
    
    IF CHARINDEX(' ', @FullName) > 0
    BEGIN
        SET @FirstName = LEFT(@FullName, CHARINDEX(' ', @FullName) - 1);
        SET @LastName = RIGHT(@FullName, LEN(@FullName) - CHARINDEX(' ', @FullName));
    END
    ELSE
    BEGIN
        SET @FirstName = @FullName;
        SET @LastName = '';
    END

    -- Update Users table
    UPDATE Users
    SET 
        FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        ProfilePicturePath = ISNULL(@ProfilePicturePath, ProfilePicturePath)
    WHERE UserID = @UserID;

    -- Update Students table
    UPDATE Students
    SET 
        FullName = @FullName,
        DOB = @DOB,
        Email = @Email,
        PhoneNumber = @PhoneNumber,
        EmergencyContactNumber = @EmergencyContactNumber,
        EmergencyContactName = @EmergencyContactName,
        Address = @Address,
        ProfilePicturePath = ISNULL(@ProfilePicturePath, ProfilePicturePath)
    WHERE UserID = @UserID;

    -- Return the total number of rows affected
    SELECT @@ROWCOUNT AS RowsAffected;
END;



-- ValidateLogin: Validates user login credentials
CREATE PROCEDURE ValidateLogin
    @Email VARCHAR(100),
    @Password VARCHAR(255)
AS
BEGIN
    SELECT 
        UserID, 
        Role, 
        FirstName, 
        LastName
    FROM 
        Users
    WHERE 
        Email = @Email 
        AND Password = @Password;
END;
GO

-- LogIDRequestStatusChange: Logs when the status of an ID request changes
CREATE TRIGGER LogIDRequestStatusChange
ON IDRequests
AFTER UPDATE
AS
BEGIN
    IF UPDATE(Status)
    BEGIN
        INSERT INTO TransactionLogs (TableName, Action, RecordID, UserID)
        SELECT 'IDRequests', 'StatusChange', inserted.RequestID, inserted.StudentID
        FROM inserted;
    END
END;
GO

-- LogStudentDeletion: Logs when a student is marked as deleted
CREATE TRIGGER LogStudentDeletion
ON Students
AFTER UPDATE
AS
BEGIN
    IF UPDATE(Status)
    BEGIN
        INSERT INTO TransactionLogs (TableName, Action, RecordID, UserID)
        SELECT 'Students', 'Delete', deleted.StudentID, deleted.UserID
        FROM deleted
        WHERE deleted.Status = 'Deleted';
    END
END;
GO
-- Create the trigger to set ProcessedDate 4 days after RequestDate
CREATE TRIGGER SetProcessedDate
ON IDRequests
AFTER INSERT
AS
BEGIN
    UPDATE i
    SET i.ProcessedDate = DATEADD(DAY, 4, ins.RequestDate)
    FROM IDRequests i
    INNER JOIN inserted ins ON i.RequestID = ins.RequestID;
END;
GO


-- Insert the dean account with the plaintext password 'dean123'
INSERT INTO Users (FirstName, LastName, Email, Password, Role, ProfilePicturePath, CreatedAt)
VALUES (
    'Primary', -- FirstName
    'Dean', -- LastName
    'dean@gmail.com', -- Email
    'dean123', -- Plaintext Password
    'Dean', -- Role
    'C:\Users\eyobk\OneDrive\Desktop\download.png', -- ProfilePicturePath (optional)
    GETDATE() -- CreatedAt
);
GO

-- Retrieve the UserID of the newly inserted dean account
DECLARE @DeanUserID INT;
SET @DeanUserID = SCOPE_IDENTITY(); -- Get the UserID of the newly inserted dean account

-- Insert the dean profile using the retrieved UserID
INSERT INTO Dean (UserID, FullName, Department, OfficeLocation, PhoneNumber, Email, ProfilePicturePath, Status, DOB, Address, EmergencyContactName, EmergencyContactPhone)
VALUES (
    1, -- UserID (retrieved from the Users table)
    'Primary Dean', -- FullName
    'Computer Science', -- Department
    'Room 101', -- OfficeLocation
    '0923456789', -- PhoneNumber
    'dean@gmail.com', -- Email
    'C:\Users\eyobk\OneDrive\Desktop\download.png', -- ProfilePicturePath
    'Active', -- Status
    '1989-01-01', -- DOB
    '654 Addis Ababa, Ethiopia', -- Address
    'Primary Wife', -- EmergencyContactName
    '0987654321' -- EmergencyContactPhone
);
GO
