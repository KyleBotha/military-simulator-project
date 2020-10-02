USE [military-simulator]

CREATE TABLE Users(
	UserID int IDENTITY(1,1) PRIMARY KEY,
	FirstName varchar(40),
	LastName varchar(40),
	Rank varchar(40),
	DodIdentification varchar(40),
	Affiliation varchar(40),
	Username varchar(40),
	Hash varchar(255),
	Salt varchar(255)
);