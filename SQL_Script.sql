USE [Demo_CRUD]
GO
/****** Object:  Table [dbo].[StudentTb]    Script Date: 3/19/2021 5:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentTb](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[RollNumber] [varchar](50) NULL,
	[Adress] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
 CONSTRAINT [PK_StudentTb] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[StudentTb] ON 

INSERT [dbo].[StudentTb] ([StudentID], [Name], [FirstName], [RollNumber], [Adress], [Mobile]) VALUES (1, N'Nhan', N'Nguyen', N'0675', N'Binh Dinh', N'0955844')
INSERT [dbo].[StudentTb] ([StudentID], [Name], [FirstName], [RollNumber], [Adress], [Mobile]) VALUES (2, N'fgghh', N'fdgfd', N'87', N'fggffg', N'fh')
SET IDENTITY_INSERT [dbo].[StudentTb] OFF
GO
