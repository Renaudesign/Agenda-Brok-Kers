/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: brokers
------------------------------------------------------------*/
CREATE TABLE brokers(
	idBroker      INT IDENTITY (1,1) NOT NULL ,
	lastname      NVARCHAR (50)  NOT NULL ,
	firstname     NVARCHAR (25)  NOT NULL ,
	mail          NVARCHAR (100) NOT NULL ,
	phoneNumber   CHAR (10)  NOT NULL  ,
	CONSTRAINT brokers_PK PRIMARY KEY (idBroker)
);


/*------------------------------------------------------------
-- Table: customers
------------------------------------------------------------*/
CREATE TABLE customers(
	idCustomers   INT IDENTITY (1,1) NOT NULL ,
	lastname      NVARCHAR (50) NOT NULL ,
	firstname     NVARCHAR (25) NOT NULL ,
	mail          NVARCHAR (100) NOT NULL ,
	phoneNumber   CHAR (10)  NOT NULL ,
	budget        INT  NOT NULL  ,
	CONSTRAINT customers_PK PRIMARY KEY (idCustomers)
);


/*------------------------------------------------------------
-- Table: appointments
------------------------------------------------------------*/
CREATE TABLE appointments(
	idAppointments   INT IDENTITY (1,1) NOT NULL ,
	dateHour         DATETIME  NOT NULL ,
	subject          TEXT  NOT NULL ,
	idCustomers      INT  NOT NULL ,
	idBroker         INT  NOT NULL  ,
	CONSTRAINT appointments_PK PRIMARY KEY (idAppointments)

	,CONSTRAINT appointments_customers_FK FOREIGN KEY (idCustomers) REFERENCES customers(idCustomers)
	,CONSTRAINT appointments_brokers0_FK FOREIGN KEY (idBroker) REFERENCES brokers(idBroker)
);

Use agendaEntities
ALTER TABLE dbo.brokers
ALTER COLUMN lastname NVARCHAR(50)
ALTER TABLE dbo.brokers
ALTER COLUMN firstname NVARCHAR(25)
GO

