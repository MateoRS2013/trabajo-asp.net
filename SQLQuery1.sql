CREATE DATABASE demodb;
USE demodb;
CREATE TABLE Users(
	UserID INT PRIMARY KEY IDENTITY(1,1),
	Username NVARCHAR(50) NOT NULL,
	Passwords NVARCHAR(50) NOT NULL
);
