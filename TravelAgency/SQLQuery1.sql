create table customer
(
SSN integer primary key not null ,
F_Name text not null,
L_Name text not null,
cus_address text not null,
email text not null,
passport_ID integer not null,
birthdate date not null,
sex text not null,
job text not null,

);

Create table Customer_phone
(
	phone int not null,
	SSN int not null,
	foreign key (SSN)
	references Customer (SSN)
);

Create table Hotel
(
	Id_hotel int primary key not null,
	type_room text not null,
	cost float not null,
	numberDays int not null,
	name_hotel text not null,
);

Create table Employee
(
	Emp_id int primary key not null,
	sex text not null,
	Job text not null,
	EMP_address text not null,
	EMP_name text not null
);

create table Invoice
(
	Invoice_ID int primary key not null,
	amount float not null,
	Idate date not null,
	payment_method text not null
);

Create table Trip
(
	ID_trip int primary key not null,
	trip_name text not null,
	cost float not null,
	transportation_method text not null,
	Tlocation text not null,
	Tstart_date date not null,
	Tend_date date not null,
);

Create table book
(
	EMP_id int not null,
	Foreign key (EMP_id)
	references Employee (Emp_id),

	Id_hotel int not null,
	Foreign key (Id_hotel)
	references Hotel (Id_hotel), 

	primary key(EMP_id, Id_hotel)
);