USE [Item_db]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/26/2016 9:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 12/26/2016 9:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,10) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Designation]    Script Date: 12/26/2016 9:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Designation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/26/2016 9:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[DepartmentId] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[DesignationId] [int] NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Requistion]    Script Date: 12/26/2016 9:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Requistion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReqSl] [int] NULL,
	[ReqBy] [varchar](50) NULL,
	[DepartmentId] [int] NULL,
	[EmployeeId] [int] NULL,
	[ReqDate] [date] NULL,
	[CategoryId] [int] NULL,
	[Quantity] [int] NULL,
	[SupplierId] [int] NULL,
 CONSTRAINT [PK_Requistion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 12/26/2016 9:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Company] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[EmployeeView]    Script Date: 12/26/2016 9:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[EmployeeView]
as
SELECT        e.Name AS EmployeeName, d.Name AS Department, ds.Name AS Designation, e.Email, e.Password
FROM            Employee AS e JOIN
                         Department AS d ON e.Id = d.Id JOIN
                         Designation AS ds ON e.Id = ds.Id
GO
/****** Object:  View [dbo].[RequistionView]    Script Date: 12/26/2016 9:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create view [dbo].[RequistionView]
as
SELECT r.ReqSl,r.ReqBy,d.Name as Department,e.Name as Employee,ReqDate,c.Name as Category,Quantity,s.Name as Supplier from Requistion as r join Department as d on r.Id=d.Id join 
Employee as e on r.id=e.Id join Category as c on r.id=c.id join Supplier as s on r.id=s.id
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (1, N'HDD', N'Hard-Disk')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([Id], [Name]) VALUES (1, N'HR')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (2, N'Finance')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (3, N'Production')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (4, N'Commercial')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (5, N'QA')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (6, N'QC')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (7, N'Tent-I')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (8, N'Tent-II')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (9, N'Jacket')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (10, N'Sample')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (11, N'CAD')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (12, N'RuckSuck')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (22, N'SleepingBag')
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[Designation] ON 

INSERT [dbo].[Designation] ([Id], [Name]) VALUES (1, N'Manager')
INSERT [dbo].[Designation] ([Id], [Name]) VALUES (2, N'Asst.Manager')
INSERT [dbo].[Designation] ([Id], [Name]) VALUES (3, N'Officer')
INSERT [dbo].[Designation] ([Id], [Name]) VALUES (4, N'WorkStudy')
SET IDENTITY_INSERT [dbo].[Designation] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id], [Name], [DepartmentId], [Email], [DesignationId], [Password]) VALUES (1, N'Anower', 5, N'a@mail', 1, N'123')
INSERT [dbo].[Employee] ([Id], [Name], [DepartmentId], [Email], [DesignationId], [Password]) VALUES (2, N'Jamal', 2, N'j@mail.com', 1, N'231')
INSERT [dbo].[Employee] ([Id], [Name], [DepartmentId], [Email], [DesignationId], [Password]) VALUES (3, N'Kamal', 3, N'k@Mail', 2, N'256')
INSERT [dbo].[Employee] ([Id], [Name], [DepartmentId], [Email], [DesignationId], [Password]) VALUES (4, N'Jamrul', 1, N'ja@mail.com', 2, N'546')
INSERT [dbo].[Employee] ([Id], [Name], [DepartmentId], [Email], [DesignationId], [Password]) VALUES (6, N'hanan', 4, N'h@mail.com', 2, N'789')
SET IDENTITY_INSERT [dbo].[Employee] OFF
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([Id], [Name], [Company], [Email], [Contact], [Address]) VALUES (1, N'Jashim Uddin', N'Computer World', N'anower@mail.com', N'01823636933', N'CEPZ')
SET IDENTITY_INSERT [dbo].[Supplier] OFF
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Designation] FOREIGN KEY([DesignationId])
REFERENCES [dbo].[Designation] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Designation]
GO
ALTER TABLE [dbo].[Requistion]  WITH CHECK ADD  CONSTRAINT [FK_Requistion_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Requistion] CHECK CONSTRAINT [FK_Requistion_Category]
GO
ALTER TABLE [dbo].[Requistion]  WITH CHECK ADD  CONSTRAINT [FK_Requistion_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Requistion] CHECK CONSTRAINT [FK_Requistion_Department]
GO
ALTER TABLE [dbo].[Requistion]  WITH CHECK ADD  CONSTRAINT [FK_Requistion_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[Requistion] CHECK CONSTRAINT [FK_Requistion_Employee]
GO
ALTER TABLE [dbo].[Requistion]  WITH CHECK ADD  CONSTRAINT [FK_Requistion_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([Id])
GO
ALTER TABLE [dbo].[Requistion] CHECK CONSTRAINT [FK_Requistion_Supplier]
GO
