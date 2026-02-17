-- Create Database
CREATE DATABASE CollegeDB;
GO

-- Use Database
USE CollegeDB;
GO

-- Create Table
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Course VARCHAR(50),
    Marks INT
);
GO

-- Insert Data
INSERT INTO Students VALUES
(1, 'Chinni', 'CSE', 85),
(2, 'Rahul', 'ECE', 78),
(3, 'Anita', 'CSE', 92);
GO

-- Select Query
SELECT * FROM Students;
GO