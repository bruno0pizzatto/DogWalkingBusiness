CREATE DATABASE DogWalkingBusinessDb;
GO

USE DogWalkingBusinessDb;
GO

CREATE TABLE Clients (
    Id INT IDENTITY PRIMARY KEY, -- No change here, assuming you want it clustered (default).
    Name NVARCHAR(100) NOT NULL,
    PhoneNumber NVARCHAR(20) NOT NULL
);

CREATE TABLE Dogs (
    Id INT IDENTITY NOT NULL,
    ClientId INT FOREIGN KEY REFERENCES Clients(Id),
    Name NVARCHAR(100) NOT NULL,
    Breed NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    CONSTRAINT PK_Dogs_Id PRIMARY KEY NONCLUSTERED (Id) -- Make PK non-clustered
);
-- Add clustered index
CREATE CLUSTERED INDEX IX_Dogs_ClientId_Id ON Dogs (ClientId, Id);

CREATE TABLE Walks (
    Id INT IDENTITY NOT NULL,
    DogId INT FOREIGN KEY REFERENCES Dogs(Id),
    WalkDate DATETIME NOT NULL,
    Duration TIME NOT NULL,
    CONSTRAINT PK_Walks_Id PRIMARY KEY NONCLUSTERED (Id) -- Make PK non-clustered
);
-- Add clustered index
CREATE CLUSTERED INDEX IX_Walks_DogId_WalkDate ON Walks (DogId, WalkDate);

CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL
);