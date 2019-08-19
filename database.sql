CREATE TABLE `customers`
(
	`customerID` int(11) UNIQUE AUTO_INCREMENT NOT NULL,
	`customerName` VARCHAR(32) NULL,
	`firstName` VARCHAR(32) NOT NULL,
	`lastName` VARCHAR(32) NOT NULL,
	`Address` TEXT NOT NULL,
	`phone` VARCHAR(11) NOT NULL,
	`availableFunds` int(11) NULL DEFAULT(500),
	PRIMARY KEY(customerID)
);

CREATE TABLE `movies`
(
	`movieID` int(11) UNIQUE NOT NULL AUTO_INCREMENT,
	`ratings` int(1) NOT NULL,
	`title` VARCHAR(255) UNIQUE NOT NULL,
	`year` VARCHAR(4) NOT NULL,
	`rentalCost` VARCHAR(15) NOT NULL,
	`copies` int(11) NOT NULL,
	`genre` VARCHAR(50) NOT NULL,
	PRIMARY KEY(movieID)
);

CREATE TABLE `rentedmovies`
(
	`rentalID` int(11) UNIQUE AUTO_INCREMENT NOT NULL,
	`movieID` int(11) NOT NULL,
	`customerID` int(11) NOT NULL,
	`dateRented` DATETIME NOT NULL,
	`dateReturned` DATETIME NOT NULL,
	PRIMARY KEY(rentalID),
	FOREIGN KEY(movieID) REFERENCES movies(movieID),
	FOREIGN KEY(customerID) REFERENCES customers(customerID)
);