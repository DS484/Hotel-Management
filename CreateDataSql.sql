
use HOTEL_MANAGEMENT;

-- Them du lieu vao bang Hotels
insert into Hotels(hotel_name, address, city, picture) 
values('SaiGonGateWay', N'Thủ Đức', N'TP Hồ Chí Minh', 'Image\img1_1.png')

insert into Hotels(hotel_name, address, city, picture) 
values('MoonLight', N'Quận 1', N'TP Hồ Chí Minh', 'Image\img2_1.png')

insert into Hotels(hotel_name, address, city, picture) 
values('UI', N'Đống Đa', N'Hà Nội', 'Image\img3_1.png')

insert into Hotels(hotel_name, address, city, picture) 
values('Vista', N'Ba Đình', N'Hà Nội', 'Image\img4_1.png')

insert into Hotels(hotel_name, address, city, picture) 
values('Lotte', N'Hải Châu', N'Đà Nẵng', 'Image\img5_1.png')

insert into Hotels(hotel_name, address, city, picture) 
values('Stella', N'Phước Mỹ', N'Đà Nẵng', 'Image\img6_1.png')

select * from Hotels
-- Them du lieu vao bang Rooms

insert into Rooms(room_number, room_picture, pre_price, curr_price, room_status, hotel_id)
values ('202', 'Image\img1_3.png', 3499999, 1499999, 1, 13);

insert into Rooms(room_number, room_picture, pre_price, curr_price, room_status, hotel_id)
values ('301', 'Image\img1_3.png', 2999999, 1299999, 1, 13);

insert into Rooms(room_number, room_picture, pre_price, curr_price, room_status, hotel_id)
values ('107', 'Image\img2_2.png', 3499999, 1499999, 1, 14);

insert into Rooms(room_number, room_picture, pre_price, curr_price, room_status, hotel_id)
values ('204', 'Image\img2_2.png', 2999999, 1299999, 1, 14);

insert into Rooms(room_number, room_picture, pre_price, curr_price, room_status, hotel_id)
values ('404', 'Image\img3_4.png', 2999999, 1299999, 1, 15);

insert into Rooms(room_number, room_picture, pre_price, curr_price, room_status, hotel_id)
values ('209', 'Image\img3_4.png', 3499999, 1499999, 1, 15);

insert into Rooms(room_number, room_picture, pre_price, curr_price, room_status, hotel_id)
values ('102', 'Image\img4_4.png', 3499999, 1499999, 1, 16);

insert into Rooms(room_number, room_picture, pre_price, curr_price, room_status, hotel_id)
values ('104', 'Image\img4_4.png', 2999999, 1299999, 1, 16);

insert into Rooms(room_number, room_picture, pre_price, curr_price, room_status, hotel_id)
values ('304', 'Image\img5_2.png', 2999999, 1299999, 1, 17);

insert into Rooms(room_number, room_picture, pre_price, curr_price, room_status, hotel_id)
values ('502', 'Image\img5_2.png', 3499999, 1499999, 1, 17);

select * from Rooms
select * from Rooms_Detail

-- Them du lieu vao bang Rooms_Detail
insert into Rooms_Detail values(21, 'Image\img1_1.png', 'Image\img1_2.png',
'Image\img1_3.png', 'Image\img1_4.png', 'Image\img1_5.png', 2, 1, '03-15-2024')

insert into Rooms_Detail values(22, 'Image\img1_1.png', 'Image\img1_2.png',
'Image\img1_3.png', 'Image\img1_4.png', 'Image\img1_5.png', 1, 1, '03-16-2024')

insert into Rooms_Detail values(23, 'Image\img2_1.png', 'Image\img2_2.png',
'Image\img2_3.png', 'Image\img2_4.png', 'Image\img2_5.png', 2, 1, '03-17-2024')

insert into Rooms_Detail values(24, 'Image\img2_1.png', 'Image\img2_2.png',
'Image\img2_3.png', 'Image\img2_4.png', 'Image\img2_5.png', 1, 1, '03-15-2024')

insert into Rooms_Detail values(25, 'Image\img3_1.png', 'Image\img3_2.png',
'Image\img3_3.png', 'Image\img3_4.png', 'Image\img3_5.png', 1, 1, '03-18-2024')

insert into Rooms_Detail values(26, 'Image\img3_1.png', 'Image\img3_2.png',
'Image\img3_3.png', 'Image\img3_4.png', 'Image\img3_5.png', 2, 1, '03-16-2024')

insert into Rooms_Detail values(27, 'Image\img4_1.png', 'Image\img4_2.png',
'Image\img4_3.png', 'Image\img4_4.png', 'Image\img4_5.png', 2, 1, '03-15-2024')

insert into Rooms_Detail values(28, 'Image\img4_1.png', 'Image\img4_2.png',
'Image\img4_3.png', 'Image\img4_4.png', 'Image\img4_5.png', 1, 1, '03-19-2024')

insert into Rooms_Detail values(29, 'Image\img5_1.png', 'Image\img5_2.png',
'Image\img5_3.png', 'Image\img5_4.png', 'Image\img5_5.png', 1, 1, '03-17-2024')

insert into Rooms_Detail values(30, 'Image\img5_1.png', 'Image\img5_2.png',
'Image\img5_3.png', 'Image\img5_4.png', 'Image\img5_5.png', 2, 1, '03-18-2024')

select * from Hotels

SELECT r.id as 'Room Id', h.id as 'Hotel Id' FROM Hotels h
JOIN Rooms r ON h.id = r.hotel_id
JOIN Rooms_Detail rd ON r.id = rd.room_id
WHERE rd.adult = 1 and rd.children = 1 and rd.start_day >= '03-16-2024' and h.city LIKE N'Hà Nội'
GROUP BY r.id, h.id
HAVING COUNT(r.id) = 1

<<<<<<< HEAD
insert into Rooms_Detail values(10, 'Image\img5_1.png', 'Image\img5_2.png',
'Image\img5_3.png', 'Image\img5_4.png', 'Image\img5_5.png', 2, 1)
=======
<<<<<<< HEAD
insert into Rooms_Detail values(10, 'Image\img5_1.png', 'Image\img5_2.png',
'Image\img5_3.png', 'Image\img5_4.png', 'Image\img5_5.png', 2, 1)
=======
>>>>>>> bea3105526d50005886e62e75a65a595fff4d841
>>>>>>> Login_Register
