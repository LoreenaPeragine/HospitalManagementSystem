CREATE TABLE Patients (
    TransactionID int IDENTITY (1,1) NOT NULL,
    LastName varchar(50),
    FirstName varchar(50),
    Address varchar(50),
    City varchar(50),
    Doctor varchar(50),
    Complaint varchar(50),
    DOB Date,
    Sex varchar(50),
    Marital varchar(50)
);

INSERT INTO Patients (LastName, FirstName, Address, City, Doctor, Complaint, DOB, Sex, Marital)
VALUES ('Smith', 'John', '123 Ambrose Rd', 'Davenport', 'Jones', 'Fall', '10/31/1950', 'Male', 'M');
INSERT INTO Patients (LastName, FirstName, Address, City, Doctor, Complaint, DOB, Sex, Marital)
VALUES ('Miller', 'Emma', '456 C Sharp Dr', 'Rock Island', 'Daniels', 'Sore throat', '2/23/1980', 'Female', 'S');
INSERT INTO Patients (LastName, FirstName, Address, City, Doctor, Complaint, DOB, Sex, Marital)
VALUES ('Johnson', 'James', '123 Programming Ln', 'Bettendorf', 'Garcia', 'Covid exposure', '6/19/2001', 'Male', 'S');