CREATE DATABASE [Northwind]
GO
USE [Northwind]
GO
/****** Object:  Table [dbo].[Department] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[HeadID] [bigint] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[About] [nvarchar](200) NULL,
	[DepartmentID] [bigint] NOT NULL,
	[IsFullTimer] [bit] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Project]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[ProjectID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Stage] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectInvolement] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectInvolement](
	[ProjectInvolementID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectID] [bigint] NOT NULL,
	[EmployeeID] [bigint] NOT NULL,
	[Role] [int] NOT NULL,
	[IsMainForEmployee] [bit] NOT NULL,
 CONSTRAINT [PK_ProjectInvolement] PRIMARY KEY CLUSTERED 
(
	[ProjectInvolementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_Employee] FOREIGN KEY([HeadID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Department] ([DepartmentID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
ALTER TABLE [dbo].[ProjectInvolement]  WITH CHECK ADD  CONSTRAINT [FK_ProjectInvolement_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[ProjectInvolement] CHECK CONSTRAINT [FK_ProjectInvolement_Employee]
GO
ALTER TABLE [dbo].[ProjectInvolement]  WITH CHECK ADD  CONSTRAINT [FK_ProjectInvolement_Project] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Project] ([ProjectID])
GO
ALTER TABLE [dbo].[ProjectInvolement] CHECK CONSTRAINT [FK_ProjectInvolement_Project]
GO
