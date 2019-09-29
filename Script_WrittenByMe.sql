-- CREATE DATABASE
--create database Store

--use Master
--use Store

-- CREATE TABLES
create table Signin(
	signinID int identity(1, 1) primary key,
	userName nvarchar(max),
	userPassword nvarchar(max),
	userType int
)

create table Employees(
	employeeID int identity(1, 1) primary key,
	eUserName nvarchar(max),
	eUserPassword nvarchar(max),
	eFirstName nvarchar(max),
	eLastName nvarchar(max),
	email nvarchar(max),
	officeCode int,
	jobTitle nvarchar(max),
	signinID int Foreign key references Signin(signinID)
)

create table Customers(
	customerID int identity(1, 1) primary key,
	cUserName nvarchar(max),
	cUserPassword nvarchar(max),
	cFirstName nvarchar(max),
	cLastName nvarchar(max),
	phone nvarchar(max),
	creditLimit float,
	addressLine nvarchar(max),
	region nvarchar(max),
	city nvarchar(max),
	country nvarchar(max),
	postalCode nvarchar(max),
	signinID int Foreign key references Signin(signinID)
)

create table Cate(
	cateID int identity(1, 1) primary key,
	cateName nvarchar(max)
)

create table SubCate(
	subCateID int identity(1, 1) primary key,
	subCateName nvarchar(max),
	cateID int Foreign key references Cate(cateID)
)

create table Products(
	productID int identity(1, 1) primary key,
	proName nvarchar(max),
	proPrice float,
	quantity int,
	subCateID int Foreign key references SubCate(SubCateID),
	cateID int Foreign key references Cate(cateID)
)

create table Orders(
	orderID int identity(1, 1) primary key,
	orderDate date,
	orderStatus nvarchar(max),
	amount float,
	customerID int Foreign key references Customers(customerID)
)

create table OrderDetails(
	orderDetailID int identity(1, 1) primary key,
	productID int Foreign key references Products(productID),
	priceEach float,
	quantityOrdered int,
	orderID int Foreign key references Orders(orderID),
	employeeID int Foreign key references Employees(employeeID)
)

create table Payment(
	paymentID int identity(1, 1) primary key,
	paymentDate date,
	amountPayed float,
	customerID int Foreign key references Customers(customerID),
	orderID int Foreign key references Orders(orderID)
)

create table City(
	cityID int identity(1, 1) primary key,
	cityName nvarchar(max)
)

create table Region(
	regionID int identity(1, 1) primary key,
	regionName nvarchar(max),
	postalCode nvarchar(max),
	cityID int Foreign key references City(cityID)
)


-- INSERTS
insert into Signin (userName, userPassword, userType) values ('1', '1', '1')
insert into Signin (userName, userPassword, userType) values ('2', '2', '1')
insert into Signin (userName, userPassword, userType) values ('3', '3', '1')
insert into Signin (userName, userPassword, userType) values ('4', '4', '1')
insert into Signin (userName, userPassword, userType) values ('5', '5', '2')
insert into Signin (userName, userPassword, userType) values ('6', '6', '2')
insert into Signin (userName, userPassword, userType) values ('7', '7', '2')
insert into Signin (userName, userPassword, userType) values ('8', '8', '2')

insert into Employees (eUserName, eUserPassword, eFirstName, eLastName, email, officeCode, jobTitle, signinID) values ('1', '1', 'Jose', 'Sosa', 'jsosa@store.com', 101, 'Satış Müdürü', 1)
insert into Employees (eUserName, eUserPassword, eFirstName, eLastName, email, officeCode, jobTitle, signinID) values ('2', '2', 'Tony', 'Nwakaeme', 'tnwakaeme@store.com', 102, 'Satış Personeli', 2)
insert into Employees (eUserName, eUserPassword, eFirstName, eLastName, email, officeCode, jobTitle, signinID) values ('3', '3', 'Caleb', 'Ekuban', 'cekuban@store.com', 103, 'Satış Elemanı', 3)
insert into Employees (eUserName, eUserPassword, eFirstName, eLastName, email, officeCode, jobTitle, signinID) values ('4', '4', 'Philip', 'Novak', 'pnovak@store.com', 104, 'Satış Temsilcisi', 4)

insert into Customers (cUserName, cUserPassword, cFirstName, cLastName, phone, creditLimit, addressLine, region, city, country, postalCode, signinID) values ('5', '5', 'Yusuf', 'Yazıcı', '5341524895', 125000, 'İstiklal Caddesi No:78/4', 'Bayrampaşa', 'İstanbul', 'Türkiye', '34030', 5)
insert into Customers (cUserName, cUserPassword, cFirstName, cLastName, phone, creditLimit, addressLine, region, city, country, postalCode, signinID) values ('6', '6', 'Abdulkadir', 'Ömür', '5302645284', 62400, 'Kunduracılar Caddesi No:128/1', 'Beşikdüzü', 'Trabzon', 'Türkiye', '61827', 6)
insert into Customers (cUserName, cUserPassword, cFirstName, cLastName, phone, creditLimit, addressLine, region, city, country, postalCode, signinID) values ('7', '7', 'Uğurcan', 'Çakır', '5326329878', 25600, 'Atatürk Caddesi No:74/10', 'Darıca', 'Kocaeli', 'Türkiye', '41700', 7)
insert into Customers (cUserName, cUserPassword, cFirstName, cLastName, phone, creditLimit, addressLine, region, city, country, postalCode, signinID) values ('8', '8', 'Hüseyin', 'Türkmen', '5380214556', 45200, 'Hürriyet Caddesi No:146/8', 'Hendek', 'Adapazari', 'Türkiye', '54300', 8)


insert into City(cityName) values ('İstanbul');
insert into City(cityName) values ('Ankara');
insert into City(cityName) values ('Kocaeli');
insert into City(cityName) values ('Trabzon');
insert into City(cityName) values ('Sakarya');

insert into Region (regionName, postalCode, cityID) values ('Ataşehir', '34758', 1)
insert into Region (regionName, postalCode, cityID) values ('Avcılar', '34310', 1)
insert into Region (regionName, postalCode, cityID) values ('Bakırköy', '34140', 1)
insert into Region (regionName, postalCode, cityID) values ('Bayrampaşa', '34030', 1)
insert into Region (regionName, postalCode, cityID) values ('Beşiktaş', '34330', 1)
insert into Region (regionName, postalCode, cityID) values ('Beyoğlu', '34220', 1)
insert into Region (regionName, postalCode, cityID) values ('Eyüp', '34050', 1)
insert into Region (regionName, postalCode, cityID) values ('Fatih', '34080', 1)
insert into Region (regionName, postalCode, cityID) values ('Gaziosmanpaşa', '34240', 1)
insert into Region (regionName, postalCode, cityID) values ('Kadıköy', '34710', 1)
insert into Region (regionName, postalCode, cityID) values ('Kağıthane', '34400', 1)
insert into Region (regionName, postalCode, cityID) values ('Kartal', '34860', 1)
insert into Region (regionName, postalCode, cityID) values ('Küçükçekmece', '34290', 1)
insert into Region (regionName, postalCode, cityID) values ('Maltepe', '34840', 1)
insert into Region (regionName, postalCode, cityID) values ('Pendik', '34890', 1)
insert into Region (regionName, postalCode, cityID) values ('Sarıyer', '34450', 1)
insert into Region (regionName, postalCode, cityID) values ('Şişli', '34360', 1)
insert into Region (regionName, postalCode, cityID) values ('Tuzla', '34940', 1)
insert into Region (regionName, postalCode, cityID) values ('Üsküdar', '34660', 1)
insert into Region (regionName, postalCode, cityID) values ('Zeytinburnu', '34010', 1)

insert into Region (regionName, postalCode, cityID) values ('Altındağ', '06030', 2)
insert into Region (regionName, postalCode, cityID) values ('Beypazarı', '06730', 2)
insert into Region (regionName, postalCode, cityID) values ('Çankaya', '06410', 2)
insert into Region (regionName, postalCode, cityID) values ('Çubuk', '06760', 2)
insert into Region (regionName, postalCode, cityID) values ('Elmadağ', '06780', 2)
insert into Region (regionName, postalCode, cityID) values ('Etimesgut', '06790', 2)
insert into Region (regionName, postalCode, cityID) values ('Keçiören', '06010', 2)
insert into Region (regionName, postalCode, cityID) values ('Mamak', '06260', 2)
insert into Region (regionName, postalCode, cityID) values ('Polatlı', '06900', 2)
insert into Region (regionName, postalCode, cityID) values ('Pursaklar', '06415', 2)
insert into Region (regionName, postalCode, cityID) values ('Sincan', '06930', 2)

insert into Region (regionName, postalCode, cityID) values ('Başiskele', '41190', 3)
insert into Region (regionName, postalCode, cityID) values ('Darıca', '41700', 3)
insert into Region (regionName, postalCode, cityID) values ('Derince', '41900', 3)
insert into Region (regionName, postalCode, cityID) values ('Dilovası', '41455', 3)
insert into Region (regionName, postalCode, cityID) values ('Gebze', '41400', 3)
insert into Region (regionName, postalCode, cityID) values ('Gölcük', '41650', 3)
insert into Region (regionName, postalCode, cityID) values ('Kandıra', '41600', 3)
insert into Region (regionName, postalCode, cityID) values ('Karamürsel', '41500', 3)
insert into Region (regionName, postalCode, cityID) values ('Kartepe', '41255', 3)
insert into Region (regionName, postalCode, cityID) values ('Körfez', '41780', 3)
insert into Region (regionName, postalCode, cityID) values ('Çayırova', '41420', 3)

insert into Region (regionName, postalCode, cityID) values ('Akçaabat', '61310', 4)
insert into Region (regionName, postalCode, cityID) values ('Araklı', '61700', 4)
insert into Region (regionName, postalCode, cityID) values ('Arsin', '61930', 4)
insert into Region (regionName, postalCode, cityID) values ('Beşikdüzü', '61827', 4)
insert into Region (regionName, postalCode, cityID) values ('Dernekpazarı', '61950', 4)
insert into Region (regionName, postalCode, cityID) values ('Düzköy', '61390', 4)
insert into Region (regionName, postalCode, cityID) values ('Hayrat', '61450', 4)
insert into Region (regionName, postalCode, cityID) values ('Köprübaşı', '61630', 4)
insert into Region (regionName, postalCode, cityID) values ('Maçka', '61750', 4)
insert into Region (regionName, postalCode, cityID) values ('Of', '61585', 4)
insert into Region (regionName, postalCode, cityID) values ('Ortahisar', '61220', 4)
insert into Region (regionName, postalCode, cityID) values ('Sürmene', '61600', 4)
insert into Region (regionName, postalCode, cityID) values ('Tonya', '61500', 4)
insert into Region (regionName, postalCode, cityID) values ('Vakfıkebir', '61410', 4)
insert into Region (regionName, postalCode, cityID) values ('Yomra', '61250', 4)
insert into Region (regionName, postalCode, cityID) values ('Çarşıbaşı', '61420', 4)
insert into Region (regionName, postalCode, cityID) values ('Çaykara', '61940', 4)
insert into Region (regionName, postalCode, cityID) values ('Şalpazarı', '61670', 4)

insert into Region (regionName, postalCode, cityID) values ('Adapazarı', '54100', 5)
insert into Region (regionName, postalCode, cityID) values ('Akyazı', '54405', 5)
insert into Region (regionName, postalCode, cityID) values ('Arifiye', '54580', 5)
insert into Region (regionName, postalCode, cityID) values ('Erenler', '54200', 5)
insert into Region (regionName, postalCode, cityID) values ('Ferizli', '54150', 5)
insert into Region (regionName, postalCode, cityID) values ('Geyve', '54700', 5)
insert into Region (regionName, postalCode, cityID) values ('Hendek', '54300', 5)
insert into Region (regionName, postalCode, cityID) values ('Karapürçek', '54430', 5)
insert into Region (regionName, postalCode, cityID) values ('Karasu', '54500', 5)
insert into Region (regionName, postalCode, cityID) values ('Kaynarca', '54680', 5)
insert into Region (regionName, postalCode, cityID) values ('Kocaali', '54800', 5)
insert into Region (regionName, postalCode, cityID) values ('Pamukova', '54900', 5)
insert into Region (regionName, postalCode, cityID) values ('Sapanca', '54600', 5)
insert into Region (regionName, postalCode, cityID) values ('Serdivan', '54130', 5)
insert into Region (regionName, postalCode, cityID) values ('Söğütlü', '54160', 5)
insert into Region (regionName, postalCode, cityID) values ('Taraklı', '54750', 5)


--****************************************

insert into Cate (cateName) values ('Bilgisayar/Tablet')
insert into Cate (cateName) values ('Telefon & Telefon Aksesuarları')
insert into Cate (cateName) values ('TV, Görüntü & Ses Sistemleri')
insert into Cate (cateName) values ('Beyaz Eşya')

insert into SubCate (subCateName, cateID) values ('Dizüstü Bilgisayar', 1)
insert into SubCate (subCateName, cateID) values ('Tablet', 1)
insert into SubCate (subCateName, cateID) values ('Masaüstü Bilgisayar', 1)
insert into SubCate (subCateName, cateID) values ('Veri Depolama', 1)

insert into SubCate (subCateName, cateID) values ('Cep Telefonu', 2)
insert into SubCate (subCateName, cateID) values ('Akıllı Saat ve Bileklikler', 2)
insert into SubCate (subCateName, cateID) values ('Powerbank & Bluetooth Kulaklık', 2)
insert into SubCate (subCateName, cateID) values ('Kılıf ve Ekran Koruyucular', 2)

insert into SubCate (subCateName, cateID) values ('Televizyon', 3)
insert into SubCate (subCateName, cateID) values ('Müzik Sistemleri', 3)
insert into SubCate (subCateName, cateID) values ('Blu-Ray ve DVD Oynatıcılar', 3)
insert into SubCate (subCateName, cateID) values ('Kablo & Soketler', 3)

insert into SubCate (subCateName, cateID) values ('Çamaşır Makineleri', 4)
insert into SubCate (subCateName, cateID) values ('Buzdolapları', 4)
insert into SubCate (subCateName, cateID) values ('Bulaşık Makineleri', 4)
insert into SubCate (subCateName, cateID) values ('Derin Dondurucular', 4)


insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Lenovo Ideapad S145-14IWL', 3500, 40, 1, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Dell Gaming G315', 2500, 40, 1, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('HP 15-RA012NT', 1750, 40, 1, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Acer Nitro AN515-52', 2000, 40, 1, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Asus ROG FX504GE-E4777', 3750, 40, 1, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Casper Nirvana F650.8550-8E55X-G-F', 1500, 40, 1, 1)
									
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Lenovo Tab E10 TB-X104F 32GB 10.1', 750, 40, 2, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Samsung Galaxy Tab 3 Lite T113 8GB 7', 800, 40, 2, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Apple iPad 6.Nesil 32GB 9.7 Wi-Fi IPS', 1400, 40, 2, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Alcatel Pixi 4 8GB 7', 1450, 40, 2, 1)
									
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('TURBOX ATM900012 Intel i5m 4GB Ram 320GB Hdd', 2250, 40, 3, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('HP 460-P202NT Intel Core i3 7100T 4GB 1TB Windows 10 Home', 1750, 40, 3, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Izoly N13PF i5-3470 16GB 1TB GTX1050Tİ 4GB 21.5', 2400, 40, 3, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('HP Omen 875-0008NT Intel Core i5 8400 8GB 1TB + 128GB SSD GTX1050Ti', 2000, 40, 3, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Casper N1H.7400-4T05X Intel Core i5 7400 4GB 1TB Freedos', 1800, 40, 3, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('MSI TRIDENT 3 7RB-252XTR Intel Core i7 7700 4GB 1TB + 128GB SSD GTX1050Ti', 3700, 40, 3, 1)
									
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('SanDisk Cruzer Blade 32GB', 45, 40, 4, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Samsung 860 Evo 250GB 560MB-520MB/s Sata3 2.5', 150, 40, 4, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Toshiba Canvio Basic 1TB 2.5', 295, 40, 4, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Seagate Expansion 1TB 2.5 USB 3.0', 245, 40, 4, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('HP S700 250GB 555/515MB/s Sata 3 2.5', 400, 40, 4, 1)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('WD My Passport 2TB 2.5 USB 3.0', 450, 40, 4, 1)
										
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Samsung Galaxy Note 10 Plus 256 GB', 11400, 40, 5, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Sony Xperia XA1 Ultra', 1200, 40, 5, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Xiaomi Redmi Note 7 64 GB', 1758, 40, 5, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Huawei Mate 20 Lite 64 GB', 2080, 40, 5, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Alcatel 2003G', 270, 40, 5, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Asus Zenfone Max Pro', 1490, 40, 5, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('LG V30 Plus 128 GB', 2570, 40, 5, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('General Mobile GM8 32 GB', 100, 40, 5, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Apple iPhone XS Max 512 GB', 13800, 40, 5, 2)
										
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Xiaomi Mi Band 4 Akıllı Bileklik', 210, 40, 6, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Owwotech M3 Akıllı Bileklik', 43, 40, 6, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('A1 Smart Watch Universal', 110, 40, 6, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Huawei Honor Band 4 Akıllı Bileklik', 240, 40, 6, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Samsung Galaxy Watch Active', 1090, 40, 6, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Apple Watch Seri 4 44mm GPS', 3700, 40, 6, 2)
										
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Samsung Galaxy Buds (Beyaz)-SM-R170NZWATUR Sound By AKG', 890, 40, 7, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Spigen Legato R53E Kablosuz Bluetooth Suya Dayanıklı Spor Kulaklık Black', 150, 40, 7, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Apple AirPods 2. Nesil Bluetooth Kulaklık MV7N2TU/A', 900, 40, 7, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Sennheiser Momentum True Wireless Kablosuz Kulak İçi Kulaklık', 1950, 40, 7, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Anker SoundBuds Mono BT Bluetooth Kulaklık-A3701-OFP', 200, 40, 7, 2)
										
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Case 4U Apple iPhone 7 Plus-8 Plus Kılıf Ultra İnce Silikon Füme', 12, 40, 8, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Spigen Samsung Galaxy A50 Kılıf Rugged Armor Matte Black', 70, 40, 8, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('KNY Samsung Galaxy A70 Kılıf 4 Köşe', 35, 40, 8, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Deer Case Apple iPhone 7 Plus Silikon Kılıf Kauçuk', 56, 40, 8, 2)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Blueway Apple İphone 6-6S Ekran Koruyucu + Şeffaf Silikon', 27, 40, 8, 2)
										
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Vestel 65UD9000 65 164 Ekran Uydu Alıcılı 4K Ultra HD Smart LED TV', 4350, 40, 9, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Samsung UE-40N5300 Full HD Uydu Alıcılı Smart LED', 2230, 40, 9, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Awox U3200STR 32 82 Ekran Uydu Alıcılı HD LED TV', 720, 40, 9, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Philips 50PUS7303/62 50 126 Ekran Uydu Alıcılı 4K Ultra HD Smart LED TV', 3960, 40, 9, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Awox AWX-10943ST 43 109 Ekran Uydu Alıcılı Full HD LED TV', 1195, 40, 9, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('LG 70UM7450 70 177 Ekran Uydu Alıcılı 4K Ultra HD Smart LED TV', 7300, 40, 9, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Regal 32R4020H 32 81 Ekran Uydu Alıcılı LED TV', 940, 40, 9, 3)
									
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Harman Kardon Soundstick Bluetooth Bağlantılı 2.1 Hoparlör Sistemi', 1650, 40, 10, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Bowers&Wilkins Zeppelin Wireless", "Philips BTM2660W/12 Bluetooth Micro', 3000, 40, 10, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Philips BTM2660W/12 Bluetooth Micro', 700, 40, 10, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Marshall Stockwell Blueooth Hoparlör Siyah ZD.4091451', 1700, 40, 10, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Bose Soundtouch 10 Kablosuz Müzik Sistemi', 1765, 40, 10, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Sony Shake-33 2200W Bluetooth Yüksek Güçlü Ev Ses Sistemi', 4060, 40, 10, 3)
									
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Sony DVP-SR760 USBli DVD Oynatıcı', 310, 40, 11, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Kamosonic Ks-Dx-3802 Dvd Player Usb+Sd Hoparlörlü', 150, 40, 11, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Premier PRD-990 DVD Oynatıcı', 170, 40, 11, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Denon DVD 2500 BT Blu-ray Oynatıcı', 4060, 40, 11, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Goldmaster D-726 DVD Oynatıcı', 300, 40, 11, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Cambridge Audio AZUR 851C CD Oynatıcı Gümüş', 11000, 40, 11, 3)
										
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Philips SWV5401H 4K Destekli 1,8m Ethernet HDMI Kablo (ULTRA HD-3D)', 35, 40, 12, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Paugge Hdmi 2.0b 4K 60Hz 18Gbps Bandwith HDR Dolby Vision', 90, 40, 12, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Case 4U Premium 4K HDMI 2.0 Kablo - 60 HZ', 70, 40, 12, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Spigen Essential C20CH USB-C / Type-C 3.1 to Hdmi USB Kablosu', 100, 40, 12, 3)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Qed Qe-0004 Supremus Hoparlör Kablosu 2X3 Metre', 7650, 40, 12, 3)
									
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Vestfrost VF ÇM 5800 A++ 5 kg 800 Devir', 1250, 40, 13, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Samsung WW90J5475FW/AH A+++ 1400 Devir 9 kg', 2250, 40, 13, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Profilo CMG120DTR A+++ 9 Kg 1200 Devir', 2070, 40, 13, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Bosch WAT24480TR A+++ 9 kg 1200 Devir', 2470, 40, 13, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Hoover HL 14102D3R-S A+++ 10 Kg 1400', 2100, 40, 13, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Grundig GWM 9701 A+++ 7 kg 1000 Devir', 1540, 40, 13, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Siemens WM12T480TR A+++ 9 kg 1200', 2540, 40, 13, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Vestel CM 7610 A+++ 7 kg 1000 Devir', 1550, 40, 13, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Altus AL 7100 ML A+++ 7 kg 1000 Devir', 1480, 40, 13, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('LG FH0C9CDHK7.ASSPLTK A++ 17 kg Yıkama / 10 kg Kurutma 1100 Devir', 8150, 40, 13, 4)
									
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Vestfrost VF 1268 A+ 300 lt Statik', 1600, 40, 14, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Vestel SC470 A+ 470 lt Statik', 1900, 40, 14, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Grundig GKNE 4800 A+ 475 lt No-Frost', 2600, 40, 14, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Samsung RT43K6000WW A+ 440 Lt Beyaz NoFrost', 2500, 40, 14, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Altus AL-306 E A+ 140 lt Statik Büro Tipi Mini Buzdolabı', 940, 40, 14, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('LG GR-X31FTKHL.ASBPLTK A+ 889 lt No-Frost', 17350, 40, 14, 4)
								
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Vestfrost VF BM 2003 A++ 3 Programlı', 1140, 40, 15, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Altus AL 434 C A+ 4 Programlı', 1230, 40, 15, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Bosch SMS44DI00T A+ 4 Programlı', 2000, 40, 15, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Siemens SN234I00DT iQ300 4 Programlı', 1870, 40, 15, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Profi̇lo BM4320EG 4 Programlı', 1570, 40, 15, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Regal Pratik BM 310 A++ 3 Programlı', 1120, 40, 15, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Electrolux ESF7506ROX A+++ 9 Programlı', 7500, 40, 15, 4)
									
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Grundig GFSE 6140 A+ 200 Lt.', 2000, 40, 16, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Vestel Cde-M1102W A+ 6 Çekmeçeli', 1300, 40, 16, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Profilo DF1133W3VV A++ Çekmeceli', 2470, 40, 16, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Delta DCF 466 D/S A+ Soğutucu/Dondurucu Tipi', 1870, 40, 16, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Simfer (+) FS5210 A+ 210 lt 5 Çekmeceli', 1200, 40, 16, 4)
insert into Products (proName, proPrice, quantity, subCateID, cateID) values ('Miele KF 37122 iD A++ 224 lt', 7800, 40, 16, 4)

--************************************************


--update Employees set email = 'cekuban@store.com' where eUserName = 3

--select * from Employees
--drop table Employees