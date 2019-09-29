--CREATE DATABASE [Store]
USE [Store]
GO
/****** Object:  Table [dbo].[Cate]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cate](
	[cateID] [int] IDENTITY(1,1) NOT NULL,
	[cateName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[cateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[cityID] [int] IDENTITY(1,1) NOT NULL,
	[cityName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[cityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customerID] [int] IDENTITY(1,1) NOT NULL,
	[cUserName] [nvarchar](max) NULL,
	[cUserPassword] [nvarchar](max) NULL,
	[cFirstName] [nvarchar](max) NULL,
	[cLastName] [nvarchar](max) NULL,
	[phone] [nvarchar](max) NULL,
	[creditLimit] [float] NULL,
	[addressLine] [nvarchar](max) NULL,
	[region] [nvarchar](max) NULL,
	[city] [nvarchar](max) NULL,
	[country] [nvarchar](max) NULL,
	[postalCode] [nvarchar](max) NULL,
	[signinID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[employeeID] [int] IDENTITY(1,1) NOT NULL,
	[eUserName] [nvarchar](max) NULL,
	[eUserPassword] [nvarchar](max) NULL,
	[eFirstName] [nvarchar](max) NULL,
	[eLastName] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[officeCode] [int] NULL,
	[jobTitle] [nvarchar](max) NULL,
	[signinID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[orderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[productID] [int] NULL,
	[priceEach] [float] NULL,
	[quantityOrdered] [int] NULL,
	[orderID] [int] NULL,
	[employeeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[orderID] [int] IDENTITY(1,1) NOT NULL,
	[orderDate] [date] NULL,
	[orderStatus] [nvarchar](max) NULL,
	[amount] [float] NULL,
	[customerID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[paymentID] [int] IDENTITY(1,1) NOT NULL,
	[paymentDate] [date] NULL,
	[amountPayed] [float] NULL,
	[customerID] [int] NULL,
	[orderID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[paymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[productID] [int] IDENTITY(1,1) NOT NULL,
	[proName] [nvarchar](max) NULL,
	[proPrice] [float] NULL,
	[quantity] [int] NULL,
	[subCateID] [int] NULL,
	[cateID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Region]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Region](
	[regionID] [int] IDENTITY(1,1) NOT NULL,
	[regionName] [nvarchar](max) NULL,
	[postalCode] [nvarchar](max) NULL,
	[cityID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[regionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Signin]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Signin](
	[signinID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](max) NULL,
	[userPassword] [nvarchar](max) NULL,
	[userType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[signinID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubCate]    Script Date: 18-Sep-19 3:26:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCate](
	[subCateID] [int] IDENTITY(1,1) NOT NULL,
	[subCateName] [nvarchar](max) NULL,
	[cateID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[subCateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cate] ON 

INSERT [dbo].[Cate] ([cateID], [cateName]) VALUES (1, N'Bilgisayar/Tablet')
INSERT [dbo].[Cate] ([cateID], [cateName]) VALUES (2, N'Telefon & Telefon Aksesuarlari')
INSERT [dbo].[Cate] ([cateID], [cateName]) VALUES (3, N'TV, Görüntü & Ses Sistemleri')
INSERT [dbo].[Cate] ([cateID], [cateName]) VALUES (4, N'Beyaz Esya')
SET IDENTITY_INSERT [dbo].[Cate] OFF
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([cityID], [cityName]) VALUES (1, N'Istanbul')
INSERT [dbo].[City] ([cityID], [cityName]) VALUES (2, N'Ankara')
INSERT [dbo].[City] ([cityID], [cityName]) VALUES (3, N'Kocaeli')
INSERT [dbo].[City] ([cityID], [cityName]) VALUES (4, N'Trabzon')
INSERT [dbo].[City] ([cityID], [cityName]) VALUES (5, N'Sakarya')
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([customerID], [cUserName], [cUserPassword], [cFirstName], [cLastName], [phone], [creditLimit], [addressLine], [region], [city], [country], [postalCode], [signinID]) VALUES (1, N'5', N'5', N'Yusuf', N'Yazici', N'5341524895', 113000, N'Istiklal Caddesi No:78/4', N'Bayrampasa', N'Istanbul', N'Türkiye', N'34030', 5)
INSERT [dbo].[Customers] ([customerID], [cUserName], [cUserPassword], [cFirstName], [cLastName], [phone], [creditLimit], [addressLine], [region], [city], [country], [postalCode], [signinID]) VALUES (2, N'6', N'6', N'Abdulkadir', N'Ömür', N'5302645284', 62400, N'Kunduracilar Caddesi No:128/1', N'Besikdüzü', N'Trabzon', N'Türkiye', N'61827', 6)
INSERT [dbo].[Customers] ([customerID], [cUserName], [cUserPassword], [cFirstName], [cLastName], [phone], [creditLimit], [addressLine], [region], [city], [country], [postalCode], [signinID]) VALUES (3, N'7', N'7', N'Ugurcan', N'Çakir', N'5326329878', 25600, N'Atatürk Caddesi No:74/10', N'Darica', N'Kocaeli', N'Türkiye', N'41700', 7)
INSERT [dbo].[Customers] ([customerID], [cUserName], [cUserPassword], [cFirstName], [cLastName], [phone], [creditLimit], [addressLine], [region], [city], [country], [postalCode], [signinID]) VALUES (4, N'8', N'8', N'Hüseyin', N'Türkmen', N'5380214556', 45200, N'Hürriyet Caddesi No:146/8', N'Hendek', N'Adapazari', N'Türkiye', N'54300', 8)
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([employeeID], [eUserName], [eUserPassword], [eFirstName], [eLastName], [email], [officeCode], [jobTitle], [signinID]) VALUES (1, N'1', N'1', N'Jose', N'Sosa', N'jsosa@store.com', 101, N'Satis Müdürü', 1)
INSERT [dbo].[Employees] ([employeeID], [eUserName], [eUserPassword], [eFirstName], [eLastName], [email], [officeCode], [jobTitle], [signinID]) VALUES (2, N'2', N'2', N'Tony', N'Nwakaeme', N'tnwakaeme@store.com', 102, N'Satis Personeli', 2)
INSERT [dbo].[Employees] ([employeeID], [eUserName], [eUserPassword], [eFirstName], [eLastName], [email], [officeCode], [jobTitle], [signinID]) VALUES (3, N'3', N'3', N'Caleb', N'Ekuban', N'cekuban@store.com', 103, N'Satis Elemani', 3)
INSERT [dbo].[Employees] ([employeeID], [eUserName], [eUserPassword], [eFirstName], [eLastName], [email], [officeCode], [jobTitle], [signinID]) VALUES (4, N'4', N'4', N'Philip', N'Novak', N'pnovak@store.com', 104, N'Satis Temsilcisi', 4)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([orderDetailID], [productID], [priceEach], [quantityOrdered], [orderID], [employeeID]) VALUES (1, 1, 3500, 1, 1, 1)
INSERT [dbo].[OrderDetails] ([orderDetailID], [productID], [priceEach], [quantityOrdered], [orderID], [employeeID]) VALUES (2, 19, 295, 2, 1, 1)
INSERT [dbo].[OrderDetails] ([orderDetailID], [productID], [priceEach], [quantityOrdered], [orderID], [employeeID]) VALUES (3, 41, 1950, 2, 1, 1)
INSERT [dbo].[OrderDetails] ([orderDetailID], [productID], [priceEach], [quantityOrdered], [orderID], [employeeID]) VALUES (4, 63, 170, 1, 2, 2)
INSERT [dbo].[OrderDetails] ([orderDetailID], [productID], [priceEach], [quantityOrdered], [orderID], [employeeID]) VALUES (5, 68, 90, 2, 2, 2)
INSERT [dbo].[OrderDetails] ([orderDetailID], [productID], [priceEach], [quantityOrdered], [orderID], [employeeID]) VALUES (6, 84, 2600, 2, 2, 3)
INSERT [dbo].[OrderDetails] ([orderDetailID], [productID], [priceEach], [quantityOrdered], [orderID], [employeeID]) VALUES (7, 93, 1120, 1, 3, 4)
INSERT [dbo].[OrderDetails] ([orderDetailID], [productID], [priceEach], [quantityOrdered], [orderID], [employeeID]) VALUES (8, 56, 3000, 2, 3, 2)
INSERT [dbo].[OrderDetails] ([orderDetailID], [productID], [priceEach], [quantityOrdered], [orderID], [employeeID]) VALUES (9, 53, 7300, 1, 3, 3)
INSERT [dbo].[OrderDetails] ([orderDetailID], [productID], [priceEach], [quantityOrdered], [orderID], [employeeID]) VALUES (10, 9, 1400, 1, 3, 4)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([orderID], [orderDate], [orderStatus], [amount], [customerID]) VALUES (1, CAST(N'2019-09-18' AS Date), N'Tamamlanmış', 7990, 1)
INSERT [dbo].[Orders] ([orderID], [orderDate], [orderStatus], [amount], [customerID]) VALUES (2, CAST(N'2019-09-18' AS Date), N'Tamamlanmış', 5550, 1)
INSERT [dbo].[Orders] ([orderID], [orderDate], [orderStatus], [amount], [customerID]) VALUES (3, CAST(N'2019-09-18' AS Date), N'Tamamlanmış', 15820, 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Payment] ON 

INSERT [dbo].[Payment] ([paymentID], [paymentDate], [amountPayed], [customerID], [orderID]) VALUES (1, CAST(N'2019-09-18' AS Date), 5000, 1, 1)
INSERT [dbo].[Payment] ([paymentID], [paymentDate], [amountPayed], [customerID], [orderID]) VALUES (2, CAST(N'2019-09-18' AS Date), 3000, 1, 2)
INSERT [dbo].[Payment] ([paymentID], [paymentDate], [amountPayed], [customerID], [orderID]) VALUES (3, CAST(N'2019-09-18' AS Date), 2000, 1, 2)
INSERT [dbo].[Payment] ([paymentID], [paymentDate], [amountPayed], [customerID], [orderID]) VALUES (4, CAST(N'2019-09-18' AS Date), 550, 1, 2)
INSERT [dbo].[Payment] ([paymentID], [paymentDate], [amountPayed], [customerID], [orderID]) VALUES (5, CAST(N'2019-09-18' AS Date), 1450, 1, 3)
SET IDENTITY_INSERT [dbo].[Payment] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (1, N'Lenovo Ideapad S145-14IWL', 3500, 39, 1, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (2, N'Dell Gaming G315', 2500, 40, 1, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (3, N'HP 15-RA012NT', 1750, 40, 1, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (4, N'Acer Nitro AN515-52', 2000, 40, 1, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (5, N'Asus ROG FX504GE-E4777', 3750, 40, 1, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (6, N'Casper Nirvana F650.8550-8E55X-G-F', 1500, 40, 1, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (7, N'Lenovo Tab E10 TB-X104F 32GB 10.1', 750, 40, 2, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (8, N'Samsung Galaxy Tab 3 Lite T113 8GB 7', 800, 40, 2, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (9, N'Apple iPad 6.Nesil 32GB 9.7 Wi-Fi IPS', 1400, 39, 2, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (10, N'Alcatel Pixi 4 8GB 7', 1450, 40, 2, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (11, N'TURBOX ATM900012 Intel i5m 4GB Ram 320GB Hdd', 2250, 40, 3, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (12, N'HP 460-P202NT Intel Core i3 7100T 4GB 1TB Windows 10 Home', 1750, 40, 3, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (13, N'Izoly N13PF i5-3470 16GB 1TB GTX1050TI 4GB 21.5', 2400, 40, 3, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (14, N'HP Omen 875-0008NT Intel Core i5 8400 8GB 1TB + 128GB SSD GTX1050Ti', 2000, 40, 3, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (15, N'Casper N1H.7400-4T05X Intel Core i5 7400 4GB 1TB Freedos', 1800, 40, 3, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (16, N'MSI TRIDENT 3 7RB-252XTR Intel Core i7 7700 4GB 1TB + 128GB SSD GTX1050Ti', 3700, 40, 3, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (17, N'SanDisk Cruzer Blade 32GB', 45, 40, 4, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (18, N'Samsung 860 Evo 250GB 560MB-520MB/s Sata3 2.5', 150, 40, 4, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (19, N'Toshiba Canvio Basic 1TB 2.5', 295, 38, 4, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (20, N'Seagate Expansion 1TB 2.5 USB 3.0', 245, 40, 4, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (21, N'HP S700 250GB 555/515MB/s Sata 3 2.5', 400, 40, 4, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (22, N'WD My Passport 2TB 2.5 USB 3.0', 450, 40, 4, 1)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (23, N'Samsung Galaxy Note 10 Plus 256 GB', 11400, 40, 5, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (24, N'Sony Xperia XA1 Ultra', 1200, 40, 5, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (25, N'Xiaomi Redmi Note 7 64 GB', 1758, 40, 5, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (26, N'Huawei Mate 20 Lite 64 GB', 2080, 40, 5, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (27, N'Alcatel 2003G', 270, 40, 5, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (28, N'Asus Zenfone Max Pro', 1490, 40, 5, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (29, N'LG V30 Plus 128 GB', 2570, 40, 5, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (30, N'General Mobile GM8 32 GB', 100, 40, 5, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (31, N'Apple iPhone XS Max 512 GB', 13800, 40, 5, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (32, N'Xiaomi Mi Band 4 Akilli Bileklik', 210, 40, 6, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (33, N'Owwotech M3 Akilli Bileklik', 43, 40, 6, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (34, N'A1 Smart Watch Universal', 110, 40, 6, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (35, N'Huawei Honor Band 4 Akilli Bileklik', 240, 40, 6, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (36, N'Samsung Galaxy Watch Active', 1090, 40, 6, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (37, N'Apple Watch Seri 4 44mm GPS', 3700, 40, 6, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (38, N'Samsung Galaxy Buds (Beyaz)-SM-R170NZWATUR Sound By AKG', 890, 40, 7, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (39, N'Spigen Legato R53E Kablosuz Bluetooth Suya Dayanikli Spor Kulaklik Black', 150, 40, 7, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (40, N'Apple AirPods 2. Nesil Bluetooth Kulaklik MV7N2TU/A', 900, 40, 7, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (41, N'Sennheiser Momentum True Wireless Kablosuz Kulak Içi Kulaklik', 1950, 38, 7, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (42, N'Anker SoundBuds Mono BT Bluetooth Kulaklik-A3701-OFP', 200, 40, 7, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (43, N'Case 4U Apple iPhone 7 Plus-8 Plus Kilif Ultra Ince Silikon Füme', 12, 40, 8, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (44, N'Spigen Samsung Galaxy A50 Kilif Rugged Armor Matte Black', 70, 40, 8, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (45, N'KNY Samsung Galaxy A70 Kilif 4 Köse', 35, 40, 8, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (46, N'Deer Case Apple iPhone 7 Plus Silikon Kilif Kauçuk', 56, 40, 8, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (47, N'Blueway Apple Iphone 6-6S Ekran Koruyucu + Seffaf Silikon', 27, 40, 8, 2)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (48, N'Vestel 65UD9000 65 164 Ekran Uydu Alicili 4K Ultra HD Smart LED TV', 4350, 40, 9, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (49, N'Samsung UE-40N5300 Full HD Uydu Alicili Smart LED', 2230, 40, 9, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (50, N'Awox U3200STR 32 82 Ekran Uydu Alicili HD LED TV', 720, 40, 9, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (51, N'Philips 50PUS7303/62 50 126 Ekran Uydu Alicili 4K Ultra HD Smart LED TV', 3960, 40, 9, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (52, N'Awox AWX-10943ST 43 109 Ekran Uydu Alicili Full HD LED TV', 1195, 40, 9, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (53, N'LG 70UM7450 70 177 Ekran Uydu Alicili 4K Ultra HD Smart LED TV', 7300, 39, 9, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (54, N'Regal 32R4020H 32 81 Ekran Uydu Alicili LED TV', 940, 40, 9, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (55, N'Harman Kardon Soundstick Bluetooth Baglantili 2.1 Hoparlör Sistemi', 1650, 40, 10, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (56, N'Bowers&Wilkins Zeppelin Wireless", "Philips BTM2660W/12 Bluetooth Micro', 3000, 38, 10, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (57, N'Philips BTM2660W/12 Bluetooth Micro', 700, 40, 10, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (58, N'Marshall Stockwell Blueooth Hoparlör Siyah ZD.4091451', 1700, 40, 10, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (59, N'Bose Soundtouch 10 Kablosuz Müzik Sistemi', 1765, 40, 10, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (60, N'Sony Shake-33 2200W Bluetooth Yüksek Güçlü Ev Ses Sistemi', 4060, 40, 10, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (61, N'Sony DVP-SR760 USBli DVD Oynatici', 310, 40, 11, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (62, N'Kamosonic Ks-Dx-3802 Dvd Player Usb+Sd Hoparlörlü', 150, 40, 11, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (63, N'Premier PRD-990 DVD Oynatici', 170, 39, 11, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (64, N'Denon DVD 2500 BT Blu-ray Oynatici', 4060, 40, 11, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (65, N'Goldmaster D-726 DVD Oynatici', 300, 40, 11, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (66, N'Cambridge Audio AZUR 851C CD Oynatici Gümüs', 11000, 40, 11, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (67, N'Philips SWV5401H 4K Destekli 1,8m Ethernet HDMI Kablo (ULTRA HD-3D)', 35, 40, 12, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (68, N'Paugge Hdmi 2.0b 4K 60Hz 18Gbps Bandwith HDR Dolby Vision', 90, 38, 12, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (69, N'Case 4U Premium 4K HDMI 2.0 Kablo - 60 HZ', 70, 40, 12, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (70, N'Spigen Essential C20CH USB-C / Type-C 3.1 to Hdmi USB Kablosu', 100, 40, 12, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (71, N'Qed Qe-0004 Supremus Hoparlör Kablosu 2X3 Metre', 7650, 40, 12, 3)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (72, N'Vestfrost VF ÇM 5800 A++ 5 kg 800 Devir', 1250, 40, 13, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (73, N'Samsung WW90J5475FW/AH A+++ 1400 Devir 9 kg', 2250, 40, 13, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (74, N'Profilo CMG120DTR A+++ 9 Kg 1200 Devir', 2070, 40, 13, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (75, N'Bosch WAT24480TR A+++ 9 kg 1200 Devir', 2470, 40, 13, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (76, N'Hoover HL 14102D3R-S A+++ 10 Kg 1400', 2100, 40, 13, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (77, N'Grundig GWM 9701 A+++ 7 kg 1000 Devir', 1540, 40, 13, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (78, N'Siemens WM12T480TR A+++ 9 kg 1200', 2540, 40, 13, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (79, N'Vestel CM 7610 A+++ 7 kg 1000 Devir', 1550, 40, 13, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (80, N'Altus AL 7100 ML A+++ 7 kg 1000 Devir', 1480, 40, 13, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (81, N'LG FH0C9CDHK7.ASSPLTK A++ 17 kg Yikama / 10 kg Kurutma 1100 Devir', 8150, 40, 13, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (82, N'Vestfrost VF 1268 A+ 300 lt Statik', 1600, 40, 14, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (83, N'Vestel SC470 A+ 470 lt Statik', 1900, 40, 14, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (84, N'Grundig GKNE 4800 A+ 475 lt No-Frost', 2600, 38, 14, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (85, N'Samsung RT43K6000WW A+ 440 Lt Beyaz NoFrost', 2500, 40, 14, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (86, N'Altus AL-306 E A+ 140 lt Statik Büro Tipi Mini Buzdolabi', 940, 40, 14, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (87, N'LG GR-X31FTKHL.ASBPLTK A+ 889 lt No-Frost', 17350, 40, 14, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (88, N'Vestfrost VF BM 2003 A++ 3 Programli', 1140, 40, 15, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (89, N'Altus AL 434 C A+ 4 Programli', 1230, 40, 15, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (90, N'Bosch SMS44DI00T A+ 4 Programli', 2000, 40, 15, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (91, N'Siemens SN234I00DT iQ300 4 Programli', 1870, 40, 15, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (92, N'Profi?lo BM4320EG 4 Programli', 1570, 40, 15, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (93, N'Regal Pratik BM 310 A++ 3 Programli', 1120, 39, 15, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (94, N'Electrolux ESF7506ROX A+++ 9 Programli', 7500, 40, 15, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (95, N'Grundig GFSE 6140 A+ 200 Lt.', 2000, 40, 16, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (96, N'Vestel Cde-M1102W A+ 6 Çekmeçeli', 1300, 40, 16, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (97, N'Profilo DF1133W3VV A++ Çekmeceli', 2470, 40, 16, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (98, N'Delta DCF 466 D/S A+ Sogutucu/Dondurucu Tipi', 1870, 40, 16, 4)
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (99, N'Simfer (+) FS5210 A+ 210 lt 5 Çekmeceli', 1200, 40, 16, 4)
GO
INSERT [dbo].[Products] ([productID], [proName], [proPrice], [quantity], [subCateID], [cateID]) VALUES (100, N'Miele KF 37122 iD A++ 224 lt', 7800, 40, 16, 4)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Region] ON 

INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (1, N'Atasehir', N'34758', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (2, N'Avcilar', N'34310', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (3, N'Bakirköy', N'34140', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (4, N'Bayrampasa', N'34030', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (5, N'Besiktas', N'34330', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (6, N'Beyoglu', N'34220', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (7, N'Eyüp', N'34050', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (8, N'Fatih', N'34080', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (9, N'Gaziosmanpasa', N'34240', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (10, N'Kadiköy', N'34710', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (11, N'Kagithane', N'34400', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (12, N'Kartal', N'34860', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (13, N'Küçükçekmece', N'34290', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (14, N'Maltepe', N'34840', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (15, N'Pendik', N'34890', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (16, N'Sariyer', N'34450', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (17, N'Sisli', N'34360', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (18, N'Tuzla', N'34940', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (19, N'Üsküdar', N'34660', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (20, N'Zeytinburnu', N'34010', 1)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (21, N'Altindag', N'06030', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (22, N'Beypazari', N'06730', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (23, N'Çankaya', N'06410', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (24, N'Çubuk', N'06760', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (25, N'Elmadag', N'06780', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (26, N'Etimesgut', N'06790', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (27, N'Keçiören', N'06010', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (28, N'Mamak', N'06260', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (29, N'Polatli', N'06900', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (30, N'Pursaklar', N'06415', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (31, N'Sincan', N'06930', 2)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (32, N'Basiskele', N'41190', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (33, N'Darica', N'41700', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (34, N'Derince', N'41900', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (35, N'Dilovasi', N'41455', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (36, N'Gebze', N'41400', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (37, N'Gölcük', N'41650', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (38, N'Kandira', N'41600', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (39, N'Karamürsel', N'41500', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (40, N'Kartepe', N'41255', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (41, N'Körfez', N'41780', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (42, N'Çayirova', N'41420', 3)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (43, N'Akçaabat', N'61310', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (44, N'Arakli', N'61700', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (45, N'Arsin', N'61930', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (46, N'Besikdüzü', N'61827', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (47, N'Dernekpazari', N'61950', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (48, N'Düzköy', N'61390', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (49, N'Hayrat', N'61450', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (50, N'Köprübasi', N'61630', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (51, N'Maçka', N'61750', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (52, N'Of', N'61585', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (53, N'Ortahisar', N'61220', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (54, N'Sürmene', N'61600', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (55, N'Tonya', N'61500', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (56, N'Vakfikebir', N'61410', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (57, N'Yomra', N'61250', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (58, N'Çarsibasi', N'61420', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (59, N'Çaykara', N'61940', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (60, N'Salpazari', N'61670', 4)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (61, N'Adapazari', N'54100', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (62, N'Akyazi', N'54405', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (63, N'Arifiye', N'54580', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (64, N'Erenler', N'54200', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (65, N'Ferizli', N'54150', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (66, N'Geyve', N'54700', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (67, N'Hendek', N'54300', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (68, N'Karapürçek', N'54430', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (69, N'Karasu', N'54500', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (70, N'Kaynarca', N'54680', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (71, N'Kocaali', N'54800', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (72, N'Pamukova', N'54900', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (73, N'Sapanca', N'54600', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (74, N'Serdivan', N'54130', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (75, N'Sögütlü', N'54160', 5)
INSERT [dbo].[Region] ([regionID], [regionName], [postalCode], [cityID]) VALUES (76, N'Tarakli', N'54750', 5)
SET IDENTITY_INSERT [dbo].[Region] OFF
SET IDENTITY_INSERT [dbo].[Signin] ON 

INSERT [dbo].[Signin] ([signinID], [userName], [userPassword], [userType]) VALUES (1, N'1', N'1', 1)
INSERT [dbo].[Signin] ([signinID], [userName], [userPassword], [userType]) VALUES (2, N'2', N'2', 1)
INSERT [dbo].[Signin] ([signinID], [userName], [userPassword], [userType]) VALUES (3, N'3', N'3', 1)
INSERT [dbo].[Signin] ([signinID], [userName], [userPassword], [userType]) VALUES (4, N'4', N'4', 1)
INSERT [dbo].[Signin] ([signinID], [userName], [userPassword], [userType]) VALUES (5, N'5', N'5', 2)
INSERT [dbo].[Signin] ([signinID], [userName], [userPassword], [userType]) VALUES (6, N'6', N'6', 2)
INSERT [dbo].[Signin] ([signinID], [userName], [userPassword], [userType]) VALUES (7, N'7', N'7', 2)
INSERT [dbo].[Signin] ([signinID], [userName], [userPassword], [userType]) VALUES (8, N'8', N'8', 2)
SET IDENTITY_INSERT [dbo].[Signin] OFF
SET IDENTITY_INSERT [dbo].[SubCate] ON 

INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (1, N'Dizüstü Bilgisayar', 1)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (2, N'Tablet', 1)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (3, N'Masaüstü Bilgisayar', 1)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (4, N'Veri Depolama', 1)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (5, N'Cep Telefonu', 2)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (6, N'Akilli Saat ve Bileklikler', 2)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (7, N'Powerbank & Bluetooth Kulaklik', 2)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (8, N'Kilif ve Ekran Koruyucular', 2)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (9, N'Televizyon', 3)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (10, N'Müzik Sistemleri', 3)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (11, N'Blu-Ray ve DVD Oynaticilar', 3)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (12, N'Kablo & Soketler', 3)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (13, N'Çamasir Makineleri', 4)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (14, N'Buzdolaplari', 4)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (15, N'Bulasik Makineleri', 4)
INSERT [dbo].[SubCate] ([subCateID], [subCateName], [cateID]) VALUES (16, N'Derin Dondurucular', 4)
SET IDENTITY_INSERT [dbo].[SubCate] OFF
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD FOREIGN KEY([signinID])
REFERENCES [dbo].[Signin] ([signinID])
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([signinID])
REFERENCES [dbo].[Signin] ([signinID])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([employeeID])
REFERENCES [dbo].[Employees] ([employeeID])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([orderID])
REFERENCES [dbo].[Orders] ([orderID])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([productID])
REFERENCES [dbo].[Products] ([productID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([customerID])
REFERENCES [dbo].[Customers] ([customerID])
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([customerID])
REFERENCES [dbo].[Customers] ([customerID])
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([orderID])
REFERENCES [dbo].[Orders] ([orderID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([cateID])
REFERENCES [dbo].[Cate] ([cateID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([subCateID])
REFERENCES [dbo].[SubCate] ([subCateID])
GO
ALTER TABLE [dbo].[Region]  WITH CHECK ADD FOREIGN KEY([cityID])
REFERENCES [dbo].[City] ([cityID])
GO
ALTER TABLE [dbo].[SubCate]  WITH CHECK ADD FOREIGN KEY([cateID])
REFERENCES [dbo].[Cate] ([cateID])
GO
