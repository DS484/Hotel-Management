--Table Userh
CREATE DATABASE HOTEL_MANAGEMENT;

USE HOTEL_MANAGEMENT;

CREATE TABLE Users(
	id bigint NOT NULL IDENTITY(1,1),
	password nvarchar(255),
	first_name nvarchar(100),
	last_name nvarchar(100),
	gender int,
	username nvarchar(100) unique,
	identify_card nvarchar(20) unique,
	phone_number nvarchar(15) unique,
	role int,
	created_at datetime default getdate(),
	modified_at datetime default getdate(),
	is_admin bit,
	primary key(id)
);

-- Table Hotel
CREATE TABLE Hotels(
	id bigint not null identity(1,1),
	hotel_name nvarchar(100),
	address nvarchar(255),
	city nvarchar(100),
	star_avg float,
	picture nvarchar(500),
	primary key(id)
);

-- Table Rooms
CREATE TABLE Rooms(
	id bigint not null identity (1,1),
	room_number nvarchar(10),
	room_picture nvarchar(255),
	pre_price bigint,
	curr_price bigint,
	room_status int,
	description nvarchar(1000),
	hotel_id bigint,
	primary key(id)
);

--Table Room Details
CREATE TABLE Rooms_Detail(
	room_id bigint not null,
	picture_1 nvarchar(255),
	picture_2 nvarchar(255),
	picture_3 nvarchar(255),
	picture_4 nvarchar(255),
	picture_5 nvarchar(255),
	adult int,
	children int,
	start_day date,
	primary key(room_id)
);

CREATE TABLE Room_Services(
	room_id bigint,
	service_id bigint,
	primary key(room_id, service_id)
);


-- Table Services
CREATE TABLE Services(
	id bigint not null identity(1,1),
	service_name nvarchar(100),
	price bigint,
	service_type int,
	primary key(id)
);

-- TABLE Booking
CREATE TABLE Booking(
	id bigint identity(1,1),
	checkin datetime,
	checkout datetime,
	room_id bigint,
	user_id bigint,
	created_at datetime default getdate(),
	modified_at datetime default getdate(),
	primary key(id)
);

CREATE TABLE Booking_Details(
	booking_id bigint,
	service_id bigint,
	primary key(booking_id, service_id),
);

-- ADD Constraints
ALTER TABLE Booking ADD CONSTRAINT FK_Booking_User FOREIGN KEY (user_id) REFERENCES Users(id) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE Booking ADD CONSTRAINT FK_Booking_Room FOREIGN KEY (room_id) REFERENCES Rooms(id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE Rooms ADD CONSTRAINT FK_Room_Hotel FOREIGN KEY (hotel_id) REFERENCES Hotels(id) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE Rooms_detail ADD CONSTRAINT FK_Rooms_detail FOREIGN KEY (room_id) REFERENCES Rooms(id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE Booking_details ADD CONSTRAINT FK_BookingDetail_Booking FOREIGN KEY (booking_id) REFERENCES Booking(id) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE Booking_details ADD CONSTRAINT FK_BookingDetail_Service FOREIGN KEY (service_id) REFERENCES Services(id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE Room_services ADD CONSTRAINT FK_RoomService_Service FOREIGN KEY (service_id) REFERENCES Services(id) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE Room_services ADD CONSTRAINT FK_RoomService_Room FOREIGN KEY (room_id) REFERENCES Rooms(id) ON DELETE CASCADE ON UPDATE CASCADE;
