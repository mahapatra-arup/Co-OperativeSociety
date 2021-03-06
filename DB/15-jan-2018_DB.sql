USE [master]
GO
/****** Object:  Database [CoOperative]    Script Date: 15-01-2019 10:45:38 PM ******/
CREATE DATABASE [CoOperative] ON  PRIMARY 
( NAME = N'CoOperative', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\CoOperative.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CoOperative_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\CoOperative_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CoOperative] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoOperative].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoOperative] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoOperative] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoOperative] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoOperative] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoOperative] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoOperative] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CoOperative] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoOperative] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoOperative] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoOperative] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoOperative] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoOperative] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoOperative] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoOperative] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoOperative] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CoOperative] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoOperative] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoOperative] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoOperative] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoOperative] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoOperative] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoOperative] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoOperative] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CoOperative] SET  MULTI_USER 
GO
ALTER DATABASE [CoOperative] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoOperative] SET DB_CHAINING OFF 
GO
USE [CoOperative]
GO
/****** Object:  User [sb]    Script Date: 15-01-2019 10:45:38 PM ******/
CREATE USER [sb] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Bank]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [varchar](200) NOT NULL,
	[Code] [varchar](50) NULL,
 CONSTRAINT [PK_Bank] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerAddressDetails]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerAddressDetails](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[PrVill] [varchar](max) NOT NULL,
	[PrPS] [varchar](max) NOT NULL,
	[PrPIN] [varchar](6) NOT NULL,
	[prDist] [varchar](max) NOT NULL,
	[pmVill] [varchar](max) NOT NULL,
	[pmPS] [varchar](max) NOT NULL,
	[pmPIN] [varchar](6) NOT NULL,
	[pmDist] [varchar](max) NOT NULL,
	[mNo] [varchar](13) NOT NULL,
	[lNo] [varchar](13) NOT NULL,
	[emailID] [varchar](max) NOT NULL,
 CONSTRAINT [PK_CustomerPersonalDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerBankDetails]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerBankDetails](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[BankID] [int] NOT NULL,
	[BranchName] [varchar](max) NOT NULL,
	[BankIFC] [varchar](50) NOT NULL,
	[MICRCode] [varchar](50) NOT NULL,
	[AccountNo] [varchar](50) NOT NULL,
	[BranchCode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CustomerBankDetails_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerDetails]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerDetails](
	[CustomerId] [uniqueidentifier] NOT NULL,
	[Customername] [varchar](200) NULL,
	[PanNo] [varchar](200) NULL,
	[AadhaarNo] [varchar](200) NULL,
	[DOB] [datetime] NULL,
	[LedgerId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerLoanDetails]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerLoanDetails](
	[LoanId] [uniqueidentifier] NOT NULL,
	[SocietyLoanSlNo] [varchar](200) NOT NULL,
	[Date] [datetime] NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[SanctionedAmount] [float] NOT NULL,
	[RateOfInterest] [float] NOT NULL,
	[EMIPrincipalAmount] [float] NOT NULL,
	[EMIInterestAmount] [float] NOT NULL,
	[ShareAmount] [float] NULL,
	[ROIShare] [float] NULL,
	[InsuranceAmount] [float] NULL,
	[PaidInsuranceFromSociety] [float] NULL,
	[PayableAmount] [float] NULL,
	[NoOfEMI] [bigint] NOT NULL,
	[LoanTypeName] [varchar](100) NOT NULL,
	[LoanSubTypeName] [varchar](100) NOT NULL,
	[EMIPeriodFormate] [varchar](50) NOT NULL,
	[EMIPeriod] [int] NULL,
	[EMIPaidDay] [int] NOT NULL,
	[Remarks] [nvarchar](max) NULL,
	[IsCompoundInterest] [bit] NULL,
	[Transection_Ref_No] [varchar](500) NOT NULL,
 CONSTRAINT [PK_LoanAc] PRIMARY KEY CLUSTERED 
(
	[LoanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerLoanEMI]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerLoanEMI](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LoanId] [uniqueidentifier] NOT NULL,
	[NoOfEMI] [bigint] NOT NULL,
	[EMIDate] [datetime] NOT NULL,
	[PrincipalAmount] [float] NOT NULL,
	[InterestAmount] [float] NOT NULL,
	[IsPaid] [bit] NULL,
	[VoucherNo] [bigint] NULL,
	[PaidDate] [datetime] NULL,
	[Remarks] [varchar](max) NULL,
	[Transection_Ref_No] [varchar](500) NULL,
 CONSTRAINT [PK_LoanAcSub] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DecimalPointTools]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DecimalPointTools](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DecimalPointNo] [int] NOT NULL,
 CONSTRAINT [PK_DecimalPointTools] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Districts]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Districts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DistName] [varchar](50) NOT NULL,
	[StateID] [int] NULL,
 CONSTRAINT [PK_Districts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinancialYear]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinancialYear](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FinancialYearName] [varchar](90) NOT NULL,
	[StartingDate] [datetime] NOT NULL,
	[EndingDate] [datetime] NOT NULL,
	[IsCurentyear] [bit] NOT NULL,
 CONSTRAINT [PK_FinancialYear] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LedgerBankDetails]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LedgerBankDetails](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LedgerID] [uniqueidentifier] NOT NULL,
	[BankID] [int] NOT NULL,
	[ACNo] [varchar](50) NOT NULL,
	[IFSC] [varchar](50) NULL,
	[MICR] [varchar](50) NULL,
	[BranchName] [varchar](50) NULL,
	[BranchCode] [varchar](50) NULL,
	[Address] [varchar](200) NULL,
	[ACType] [varchar](20) NULL,
 CONSTRAINT [PK_AccountHeadBankDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ledgers]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ledgers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[LedgerId] [uniqueidentifier] NOT NULL,
	[LedgerName] [varchar](100) NULL,
	[TemplateName] [varchar](200) NULL,
	[Category] [varchar](50) NULL,
	[SubAccount] [varchar](50) NULL,
	[ParentLedgerId] [uniqueidentifier] NULL,
	[Type] [varchar](50) NULL,
	[IsFixed] [bit] NULL,
 CONSTRAINT [PK_LedgerMain] PRIMARY KEY CLUSTERED 
(
	[LedgerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LedgersStatus]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LedgersStatus](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[LedgerID] [uniqueidentifier] NOT NULL,
	[FinYearID] [bigint] NOT NULL,
	[OpeningBalance] [float] NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_LedgerStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LedgerSubAccount]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LedgerSubAccount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountName] [varchar](50) NOT NULL,
	[ParentAccount] [varchar](50) NOT NULL,
	[Nature] [varchar](50) NULL,
	[IsFixed] [bit] NULL,
 CONSTRAINT [PK_SubAccount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanSubType]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanSubType](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SubTypeName] [varchar](100) NULL,
	[LoanTypeId] [bigint] NULL,
	[MaxLoanAmount] [float] NULL,
	[MinLoanAmount] [float] NULL,
	[EMIPeriodFormate] [varchar](50) NULL,
	[EMIPeriod] [int] NULL,
	[IsCompoundInterest] [bit] NULL,
 CONSTRAINT [PK_LoanSubType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanType]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanType](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[LoanTypeName] [varchar](100) NULL,
 CONSTRAINT [PK_LoanType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROIofBank]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROIofBank](
	[Id] [bigint] NOT NULL,
	[RateOfLoan] [bigint] NULL,
	[RateOfShareDeposit] [bigint] NULL,
 CONSTRAINT [PK_RateofInterestOfBank] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROIofSociety]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROIofSociety](
	[Id] [bigint] NULL,
	[RateOfLoan] [bigint] NULL,
	[RateOfShareDeposit] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocietyDetails]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocietyDetails](
	[SocietyName] [varchar](500) NOT NULL,
	[At] [varchar](50) NOT NULL,
	[PO] [varchar](50) NOT NULL,
	[Block] [varchar](50) NULL,
	[SubDivission] [varchar](50) NULL,
	[PS] [varchar](50) NULL,
	[DIST] [varchar](50) NOT NULL,
	[PIN] [varchar](50) NULL,
	[ESTD] [varchar](50) NULL,
	[Category] [varchar](50) NULL,
	[Ph] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Website] [varchar](50) NULL,
	[Logo] [image] NULL,
	[GP] [varchar](50) NULL,
	[CentreCode] [varchar](50) NULL,
	[Area] [varchar](100) NULL,
	[DistrictCode] [varchar](50) NULL,
	[RegistrationNo] [varchar](200) NULL,
	[GSTNo] [varchar](200) NULL,
	[PanNo] [varchar](200) NULL,
 CONSTRAINT [PK_SchoolProfile] PRIMARY KEY CLUSTERED 
(
	[SocietyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocietyLoanDetails]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocietyLoanDetails](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[SocietyLoanSlNo] [varchar](200) NOT NULL,
	[SanctionedAmount] [float] NOT NULL,
	[Date] [datetime] NOT NULL,
	[RateOfInterest] [float] NOT NULL,
	[EMIPrincipalAmount] [float] NOT NULL,
	[EMIInterestAmount] [float] NOT NULL,
	[PayableAmount] [float] NOT NULL,
	[NoOfEMI] [bigint] NOT NULL,
	[LoanTypeName] [varchar](100) NOT NULL,
	[LoanSubTypeName] [varchar](100) NOT NULL,
	[EMIPeriodFormate] [varchar](50) NULL,
	[EMIPeriod] [int] NOT NULL,
	[EMIPaidDay] [int] NOT NULL,
	[Remarks] [nvarchar](max) NULL,
	[IsCompoundInterest] [bit] NULL,
	[LedgerFrom] [uniqueidentifier] NOT NULL,
	[LedgerTo] [uniqueidentifier] NOT NULL,
	[Transection_Ref_No] [varchar](500) NOT NULL,
 CONSTRAINT [PK_SocietyLoanDetails_1] PRIMARY KEY CLUSTERED 
(
	[SocietyLoanSlNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocietyLoanEMI]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocietyLoanEMI](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[SocietyLoanSlNo] [varchar](200) NOT NULL,
	[NoOfEMI] [bigint] NOT NULL,
	[EMIDate] [datetime] NOT NULL,
	[PrincipalAmount] [float] NOT NULL,
	[InterestAmount] [float] NOT NULL,
	[IsPaid] [bit] NULL,
	[VoucherNo] [varchar](500) NULL,
	[PaidDate] [datetime] NULL,
	[Remarks] [varchar](max) NULL,
	[Transection_Ref_No] [varchar](500) NULL,
 CONSTRAINT [PK_SocietyLoanEMI_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[State]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](50) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transection]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transection](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[TransectionID] [uniqueidentifier] NOT NULL,
	[Date] [datetime] NOT NULL,
	[No] [varchar](max) NULL,
	[TransectionType] [varchar](200) NOT NULL,
	[LedgerIdFrom] [uniqueidentifier] NOT NULL,
	[LedgerIdTo] [uniqueidentifier] NOT NULL,
	[Amount_Dr] [float] NULL,
	[Amount_Cr] [float] NULL,
	[Mode] [varchar](200) NULL,
	[BankName] [varchar](200) NULL,
	[ChequeNo] [varchar](200) NULL,
	[ChequeDate] [date] NULL,
	[Narration] [varchar](max) NULL,
	[Status] [varchar](200) NULL,
	[Transection_Ref_No] [varchar](500) NULL,
 CONSTRAINT [PK_Transection] PRIMARY KEY CLUSTERED 
(
	[TransectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[CustomerList]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CustomerList]
AS
SELECT     dbo.CustomerDetails.Customername, dbo.CustomerDetails.PanNo, dbo.CustomerDetails.AadhaarNo, dbo.CustomerDetails.DOB, dbo.CustomerBankDetails.BankID, 
                      dbo.CustomerBankDetails.BranchName, dbo.CustomerBankDetails.BankIFC, dbo.CustomerBankDetails.MICRCode, dbo.CustomerBankDetails.AccountNo, dbo.CustomerBankDetails.BranchCode, 
                      dbo.CustomerAddressDetails.PrVill, dbo.CustomerAddressDetails.PrPS, dbo.CustomerAddressDetails.PrPIN, dbo.CustomerAddressDetails.prDist, dbo.CustomerAddressDetails.pmVill, 
                      dbo.CustomerAddressDetails.pmPS, dbo.CustomerAddressDetails.pmPIN, dbo.CustomerAddressDetails.pmDist, dbo.CustomerAddressDetails.mNo, dbo.CustomerAddressDetails.lNo, 
                      dbo.CustomerAddressDetails.emailID, dbo.Bank.BankName, dbo.Bank.Code, dbo.CustomerDetails.CustomerId, dbo.CustomerDetails.LedgerId, dbo.Ledgers.LedgerName
FROM         dbo.CustomerDetails INNER JOIN
                      dbo.CustomerBankDetails ON dbo.CustomerDetails.CustomerId = dbo.CustomerBankDetails.CustomerId INNER JOIN
                      dbo.CustomerAddressDetails ON dbo.CustomerDetails.CustomerId = dbo.CustomerAddressDetails.CustomerId INNER JOIN
                      dbo.Bank ON dbo.CustomerBankDetails.BankID = dbo.Bank.ID INNER JOIN
                      dbo.Ledgers ON dbo.Ledgers.LedgerId = dbo.CustomerDetails.LedgerId
GO
/****** Object:  View [dbo].[TransectionView]    Script Date: 15-01-2019 10:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*---============================Transection Details=============================
-------------===================================(End)===============================================*/
CREATE VIEW [dbo].[TransectionView]
AS
SELECT     TOP (100) PERCENT dbo.Transection.id, dbo.Transection.TransectionID, dbo.Transection.Date, dbo.Transection.No, dbo.Transection.TransectionType, dbo.Transection.Amount_Dr, 
                      dbo.Transection.Amount_Cr, dbo.Transection.Mode, dbo.Transection.BankName, dbo.Transection.ChequeNo, dbo.Transection.ChequeDate, dbo.Transection.Narration, dbo.Transection.Status, 
                      dbo.Transection.Transection_Ref_No, dbo.Transection.LedgerIdFrom, Ledgers_From.LedgerName AS LedgerName_From, dbo.Transection.LedgerIdTo, 
                      Ledgers_To.LedgerName AS LedgerName_To
FROM         dbo.Transection INNER JOIN
                      dbo.Ledgers AS Ledgers_From ON Ledgers_From.LedgerId = dbo.Transection.LedgerIdFrom INNER JOIN
                      dbo.Ledgers AS Ledgers_To ON Ledgers_To.LedgerId = dbo.Transection.LedgerIdTo
GROUP BY dbo.Transection.id, dbo.Transection.TransectionID, dbo.Transection.Date, dbo.Transection.No, dbo.Transection.TransectionType, dbo.Transection.Amount_Dr, dbo.Transection.Amount_Cr, 
                      dbo.Transection.Mode, dbo.Transection.BankName, dbo.Transection.ChequeNo, dbo.Transection.ChequeDate, dbo.Transection.Narration, dbo.Transection.Status, 
                      dbo.Transection.Transection_Ref_No, Ledgers_From.LedgerName, dbo.Transection.LedgerIdFrom, Ledgers_To.LedgerName, dbo.Transection.LedgerIdTo
ORDER BY dbo.Transection.id, dbo.Transection.Date, dbo.Transection.Transection_Ref_No
GO
SET IDENTITY_INSERT [dbo].[Bank] ON 

INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (1, N'Allahabad Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (2, N'Axis Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (3, N'IDBI Bank Ltd.', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (4, N'Punjub National Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (5, N'State Bank of India', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (6, N'UCO Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (7, N'United Bank of India', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (8, N'Co-operative Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (9, N'Andhra Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (10, N'Bank of Baroda', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (11, N'Bank of India', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (12, N'Bank Maharashtra', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (13, N'Canara Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (14, N'Central Bank of India', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (15, N'Corporation Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (16, N'Dena Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (17, N'Indian Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (18, N'Indian Overseas Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (19, N'Oriental Bank of Commerce', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (20, N'Syndicate Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (21, N'Union Bank of India', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (22, N'HDFC Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (23, N'ICICI Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (24, N'IndusInd Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (25, N'Yes Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (26, N'Karanataka Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (27, N'Karur Vysya Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (28, N'Kotak Mahindra Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (29, N'Citi Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (30, N'FEDRAL BANK LTD', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (31, N'Bangiya Gramin Vikash Bank', NULL)
INSERT [dbo].[Bank] ([ID], [BankName], [Code]) VALUES (32, N'Gramin Bank', NULL)
SET IDENTITY_INSERT [dbo].[Bank] OFF
SET IDENTITY_INSERT [dbo].[CustomerAddressDetails] ON 

INSERT [dbo].[CustomerAddressDetails] ([Id], [CustomerId], [PrVill], [PrPS], [PrPIN], [prDist], [pmVill], [pmPS], [pmPIN], [pmDist], [mNo], [lNo], [emailID]) VALUES (5, N'4b557e15-c7a9-4746-8091-f24ac758ca32', N'Kamalapur', N'TUFURIA KAMALAPUR', N'721102', N'Kamalapur', N'Kamalapur', N'TUFURIA KAMALAPUR', N'721102', N'Paschim Medinipur', N'9563273765', N'', N'ARUP@GMAIL.COM')
INSERT [dbo].[CustomerAddressDetails] ([Id], [CustomerId], [PrVill], [PrPS], [PrPIN], [prDist], [pmVill], [pmPS], [pmPIN], [pmDist], [mNo], [lNo], [emailID]) VALUES (8, N'ac722565-6c3f-4e6b-8f6e-67544a4978ae', N'Nayagram', N'Nayagram', N'721155', N'Nayagram', N'Nayagram', N'Nayagram', N'721155', N'Jhargram', N'9933000000', N'', N'anamica0123@gmail.com')
SET IDENTITY_INSERT [dbo].[CustomerAddressDetails] OFF
SET IDENTITY_INSERT [dbo].[CustomerBankDetails] ON 

INSERT [dbo].[CustomerBankDetails] ([ID], [CustomerId], [BankID], [BranchName], [BankIFC], [MICRCode], [AccountNo], [BranchCode]) VALUES (4, N'4b557e15-c7a9-4746-8091-f24ac758ca32', 1, N'', N'', N'', N'', N'')
INSERT [dbo].[CustomerBankDetails] ([ID], [CustomerId], [BankID], [BranchName], [BankIFC], [MICRCode], [AccountNo], [BranchCode]) VALUES (7, N'ac722565-6c3f-4e6b-8f6e-67544a4978ae', 1, N'', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[CustomerBankDetails] OFF
INSERT [dbo].[CustomerDetails] ([CustomerId], [Customername], [PanNo], [AadhaarNo], [DOB], [LedgerId]) VALUES (N'ac722565-6c3f-4e6b-8f6e-67544a4978ae', N'Anamica Mishra', N'', N'', CAST(N'2000-10-12T15:26:11.000' AS DateTime), N'ac722565-6c3f-4e6b-8f6e-67544a4978ae')
INSERT [dbo].[CustomerDetails] ([CustomerId], [Customername], [PanNo], [AadhaarNo], [DOB], [LedgerId]) VALUES (N'4b557e15-c7a9-4746-8091-f24ac758ca32', N'Arup Mahapatre', N'123456789', N'123456789', CAST(N'1995-09-10T12:20:11.000' AS DateTime), N'4b557e15-c7a9-4746-8091-f24ac758ca32')
INSERT [dbo].[CustomerLoanDetails] ([LoanId], [SocietyLoanSlNo], [Date], [CustomerId], [SanctionedAmount], [RateOfInterest], [EMIPrincipalAmount], [EMIInterestAmount], [ShareAmount], [ROIShare], [InsuranceAmount], [PaidInsuranceFromSociety], [PayableAmount], [NoOfEMI], [LoanTypeName], [LoanSubTypeName], [EMIPeriodFormate], [EMIPeriod], [EMIPaidDay], [Remarks], [IsCompoundInterest], [Transection_Ref_No]) VALUES (N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', N'SL002', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'4b557e15-c7a9-4746-8091-f24ac758ca32', 1000, 8, 1000, 43.8611490250524, 20, 10, 10, 10, 970, 12, N'MTE', N'Monthly_MTE', N'MONTH', 1, 6, N'', 0, N'TRN2')
SET IDENTITY_INSERT [dbo].[CustomerLoanEMI] ON 

INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (98, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 1, CAST(N'2018-12-06T00:00:00.000' AS DateTime), 80.321762418755327, 6.6666666666666661, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (99, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 2, CAST(N'2019-01-06T00:00:00.000' AS DateTime), 80.857240834880372, 6.1311882505416309, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (100, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 3, CAST(N'2019-02-06T00:00:00.000' AS DateTime), 81.3962891071129, 5.5921399783090955, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (101, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 4, CAST(N'2019-03-06T00:00:00.000' AS DateTime), 81.938931034493663, 5.0494980509283423, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (102, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 5, CAST(N'2019-04-06T00:00:00.000' AS DateTime), 82.485190574723617, 4.5032385106983854, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (103, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 6, CAST(N'2019-05-06T00:00:00.000' AS DateTime), 83.035091845221771, 3.9533372402002271, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (104, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 7, CAST(N'2019-06-06T00:00:00.000' AS DateTime), 83.588659124189917, 3.3997699612320824, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (105, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 8, CAST(N'2019-07-06T00:00:00.000' AS DateTime), 84.145916851684518, 2.8425122337374829, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (106, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 9, CAST(N'2019-08-06T00:00:00.000' AS DateTime), 84.706889630695741, 2.2815394547262531, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (107, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 10, CAST(N'2019-09-06T00:00:00.000' AS DateTime), 85.271602228233718, 1.7168268571882814, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (108, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 11, CAST(N'2019-10-06T00:00:00.000' AS DateTime), 85.840079576421942, 1.1483495090000566, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CustomerLoanEMI] ([ID], [LoanId], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (109, N'5ba2642c-104f-4dd9-9a0f-96eccc1264a5', 12, CAST(N'2019-11-06T00:00:00.000' AS DateTime), 86.412346773598088, 0.57608231182391034, 0, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[CustomerLoanEMI] OFF
SET IDENTITY_INSERT [dbo].[DecimalPointTools] ON 

INSERT [dbo].[DecimalPointTools] ([Id], [DecimalPointNo]) VALUES (1, 12)
SET IDENTITY_INSERT [dbo].[DecimalPointTools] OFF
SET IDENTITY_INSERT [dbo].[Districts] ON 

INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (1, N'Bankura', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (2, N'Bardhaman', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (3, N'Birbhum', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (4, N'Purba Medinipur', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (5, N'Hooghly', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (6, N'Purulia', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (7, N'Paschim Medinipur', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (8, N'Cooch Behar', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (9, N'Darjeeling', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (10, N'Jalpaiguri', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (11, N'Malda', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (12, N'North Dinajpur', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (13, N'South Dinajpur', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (14, N'Howrah', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (15, N'Kolkata', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (16, N'Murshidabad', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (17, N'Nadia', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (18, N'North 24 Parganas', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (19, N'South 24 Parganas', 1)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (20, N'East Singbhum', 2)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (21, N'West Singbhum', 2)
INSERT [dbo].[Districts] ([Id], [DistName], [StateID]) VALUES (22, N'Jhargram', 1)
SET IDENTITY_INSERT [dbo].[Districts] OFF
SET IDENTITY_INSERT [dbo].[FinancialYear] ON 

INSERT [dbo].[FinancialYear] ([ID], [FinancialYearName], [StartingDate], [EndingDate], [IsCurentyear]) VALUES (1, N'2025', CAST(N'2018-08-22T11:47:13.953' AS DateTime), CAST(N'2018-08-22T11:47:13.953' AS DateTime), 0)
INSERT [dbo].[FinancialYear] ([ID], [FinancialYearName], [StartingDate], [EndingDate], [IsCurentyear]) VALUES (3, N'2017', CAST(N'2018-08-22T11:53:17.073' AS DateTime), CAST(N'2017-06-22T11:53:17.000' AS DateTime), 0)
INSERT [dbo].[FinancialYear] ([ID], [FinancialYearName], [StartingDate], [EndingDate], [IsCurentyear]) VALUES (4, N'2018', CAST(N'2018-08-22T11:54:46.680' AS DateTime), CAST(N'2018-08-22T11:54:46.680' AS DateTime), 0)
INSERT [dbo].[FinancialYear] ([ID], [FinancialYearName], [StartingDate], [EndingDate], [IsCurentyear]) VALUES (5, N'2019', CAST(N'2018-08-22T12:01:04.007' AS DateTime), CAST(N'2018-08-22T12:01:04.007' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[FinancialYear] OFF
SET IDENTITY_INSERT [dbo].[LedgerBankDetails] ON 

INSERT [dbo].[LedgerBankDetails] ([ID], [LedgerID], [BankID], [ACNo], [IFSC], [MICR], [BranchName], [BranchCode], [Address], [ACType]) VALUES (3, N'08bf634a-7666-4d7d-9de2-4ae15c7bb833', 5, N'123456789', N'123', N'123', N'123', N'123', NULL, N'Society_Saving_AC')
INSERT [dbo].[LedgerBankDetails] ([ID], [LedgerID], [BankID], [ACNo], [IFSC], [MICR], [BranchName], [BranchCode], [Address], [ACType]) VALUES (4, N'08bf634a-7666-4d7d-9de2-4ae15c7bb833', 5, N'5475755', NULL, NULL, NULL, NULL, NULL, N'Society_Loan_AC')
INSERT [dbo].[LedgerBankDetails] ([ID], [LedgerID], [BankID], [ACNo], [IFSC], [MICR], [BranchName], [BranchCode], [Address], [ACType]) VALUES (6, N'39fba701-0ddb-48f2-a38b-3604dc8af7fd', 4, N'123545588788', NULL, NULL, NULL, NULL, NULL, N'Society_Saving_AC')
INSERT [dbo].[LedgerBankDetails] ([ID], [LedgerID], [BankID], [ACNo], [IFSC], [MICR], [BranchName], [BranchCode], [Address], [ACType]) VALUES (7, N'39fba701-0ddb-48f2-a38b-3604dc8af7fd', 4, N'123545588788', NULL, NULL, NULL, NULL, NULL, N'Society_Loan_AC')
SET IDENTITY_INSERT [dbo].[LedgerBankDetails] OFF
SET IDENTITY_INSERT [dbo].[Ledgers] ON 

INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (58, N'94746353-15a0-4da7-b27d-00dc4ba1d857', N'Loan Against Principal Deposit From Socity', N'Loan Against Principal Deposit From Socity', N'Loan_Deposit', NULL, NULL, NULL, 1)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (59, N'e41d7e6a-0a11-4f29-8541-00deaa647e76', N'Loan Against Interest Deposit From Socity', N'Loan Against Interest Deposit From Socity', N'Loan_Deposit', NULL, NULL, NULL, 1)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (3, N'69c53e69-725f-4ad2-8690-01376bb462fa', N'Insurance From Customer', N'Insurance From Customer', N'Insurance', NULL, NULL, NULL, 1)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (4, N'5db49d38-7168-4252-9585-0163ec5f22e5', N'Share Deposit from Customer', N'Share Deposit from Customer', N'ShareDeposit', NULL, NULL, NULL, 1)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (5, N'698ccbbd-debe-42d7-84c7-016a4fefc636', N'Insurance From Socity', N'Insurance From Socity', N'Insurance', NULL, NULL, NULL, 1)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (61, N'177711ce-850d-46cd-b0b2-02d347cd2309', N'Loan Against Deposit From Socity', N'Loan Against Deposit From Socity', N'Loan_Deposit', NULL, NULL, NULL, 1)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (1, N'944b37ca-eef5-4a4a-a2a2-17c7a6307da1', N'CASH A/C', N'CASH A/C', N'Cash', N'Current Assets', NULL, NULL, 1)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (33, N'4877a8ee-92b6-43f2-a6d0-2668e7976aeb', N'Loan Against Deposit From Customer', N'Loan Against Deposit From Customer', N'Loan_Deposit', NULL, NULL, NULL, 1)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (63, N'39fba701-0ddb-48f2-a38b-3604dc8af7fd', N'Punjub National Bank', N'Punjub National Bank', N'Bank', NULL, NULL, NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (65, N'c6a5fcd2-0495-41b6-8068-3b9453d9c646', N'Punjub National Bank(Society_Loan_AC)', N'Punjub National Bank(Society_Loan_AC)', N'Society_Loan_AC', N'Loans(Liability)', N'39fba701-0ddb-48f2-a38b-3604dc8af7fd', NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (56, N'27f3b96d-ca31-41a2-8850-3d28cbc025b6', N'Anamica Mishra_9933000000_Saving_AC', N'Anamica Mishra_Saving_AC', N'Customer_Saving_AC', N'XX', N'ac722565-6c3f-4e6b-8f6e-67544a4978ae', NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (44, N'08bf634a-7666-4d7d-9de2-4ae15c7bb833', N'State Bank of India', N'State Bank of India', N'Bank', NULL, NULL, NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (57, N'e81fc4b9-c434-480e-b79d-50b2e3445e60', N'Anamica Mishra_9933000000_Loan_AC', N'Anamica Mishra_Loan_AC', N'Customer_Loan_AC', N'Sundry Debtors', N'ac722565-6c3f-4e6b-8f6e-67544a4978ae', NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (15, N'13cf4d17-54ba-4597-b773-572d6abed331', N'Arup Mahapatre_9563273765_Loan_AC', N'Arup Mahapatre(Loan A/C)', N'Customer_Loan_AC', N'Current Assets', N'4b557e15-c7a9-4746-8091-f24ac758ca32', NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (62, N'97a55ea3-5c38-4734-888f-59e5677d0d5e', N'Abcd Expence', N'Abcd Expence', N'Others_Expence', N'Indirect Expense', NULL, N'Expense', NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (27, N'41d7169d-49d9-41cf-8805-5d6a9cd2c6c1', N'Interest Of Share Deposit A/C', N'Interest Of Share Deposit A/C', N'Interest', NULL, N'5db49d38-7168-4252-9585-0163ec5f22e5', NULL, 1)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (14, N'7901e540-65da-4b83-a42a-647bff45461a', N'Arup Mahapatre_9563273765_Saving_AC', N'Arup Mahapatre(Saving A/C)', N'Customer_Saving_AC', N'Loans(Liability)', N'4b557e15-c7a9-4746-8091-f24ac758ca32', NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (55, N'ac722565-6c3f-4e6b-8f6e-67544a4978ae', N'Anamica Mishra_9933000000', N'Anamica Mishra', N'Customer', N'Current Assets', NULL, NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (64, N'dea1c2ef-f2f4-4e7c-937e-9020e172bfdf', N'Punjub National Bank(Society_Saving_AC)', N'Punjub National Bank(Society_Saving_AC)', N'Society_Saving_AC', N'Current Assets', N'39fba701-0ddb-48f2-a38b-3604dc8af7fd', NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (46, N'5aff2686-f379-4f6b-857a-97ac47508237', N'State Bank of India(Society_Loan_AC)', N'State Bank of India(Society_Loan_AC)', N'Society_Loan_AC', N'Loans(Liability)', N'08bf634a-7666-4d7d-9de2-4ae15c7bb833', NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (31, N'e7bfc52f-5ca3-4490-8365-cfb9a26b679c', N'Loan Against Interest Collection From Customer', N'Loan Against Interest Collection From Customer', N'Loan_Collection', NULL, NULL, NULL, 1)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (45, N'9decd1dc-c9ac-4144-aed5-f23641d317da', N'State Bank of India(Society_Saving_AC)', N'State Bank of India(Society_Saving_AC)', N'Society_Saving_AC', N'Current Assets', N'08bf634a-7666-4d7d-9de2-4ae15c7bb833', NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (13, N'4b557e15-c7a9-4746-8091-f24ac758ca32', N'Arup Mahapatre_9563273765', N'Arup Mahapatre', N'Customer', N'Current Assets', NULL, NULL, NULL)
INSERT [dbo].[Ledgers] ([Id], [LedgerId], [LedgerName], [TemplateName], [Category], [SubAccount], [ParentLedgerId], [Type], [IsFixed]) VALUES (32, N'a8d4294d-903e-4061-b65d-f5da75266c03', N'Loan Against Principal Collection From Customer', N'Loan Against Principal Collection From Customer', N'Loan_Collection', NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Ledgers] OFF
SET IDENTITY_INSERT [dbo].[LedgersStatus] ON 

INSERT [dbo].[LedgersStatus] ([Id], [LedgerID], [FinYearID], [OpeningBalance], [Date]) VALUES (5, N'08bf634a-7666-4d7d-9de2-4ae15c7bb833', 1, 0, CAST(N'2018-09-28' AS Date))
INSERT [dbo].[LedgersStatus] ([Id], [LedgerID], [FinYearID], [OpeningBalance], [Date]) VALUES (6, N'08bf634a-7666-4d7d-9de2-4ae15c7bb833', 1, 0, CAST(N'2018-09-28' AS Date))
INSERT [dbo].[LedgersStatus] ([Id], [LedgerID], [FinYearID], [OpeningBalance], [Date]) VALUES (11, N'97a55ea3-5c38-4734-888f-59e5677d0d5e', 1, 0, CAST(N'2018-11-02' AS Date))
INSERT [dbo].[LedgersStatus] ([Id], [LedgerID], [FinYearID], [OpeningBalance], [Date]) VALUES (12, N'39fba701-0ddb-48f2-a38b-3604dc8af7fd', 1, 0, CAST(N'2018-11-05' AS Date))
INSERT [dbo].[LedgersStatus] ([Id], [LedgerID], [FinYearID], [OpeningBalance], [Date]) VALUES (13, N'39fba701-0ddb-48f2-a38b-3604dc8af7fd', 1, 0, CAST(N'2018-11-05' AS Date))
SET IDENTITY_INSERT [dbo].[LedgersStatus] OFF
SET IDENTITY_INSERT [dbo].[LedgerSubAccount] ON 

INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (1, N'Current Assets', N'Parent', N'Assets', 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (2, N'Current Liability', N'Parent', N'Assets', 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (3, N'Capital A/C', N'Parent', N'Liabilities', 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (4, N'Direct Expense', N'Parent', N'Expense', 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (5, N'Indirect Expense', N'Parent', N'Expense', 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (6, N'Direct Income', N'Parent', N'Income', 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (7, N'Indirect Income', N'Parent', N'Income', 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (8, N'Investment', N'Parent', N'Assets', 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (9, N'Loans(Liability)', N'Parent', N'Liabilities', 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (12, N'Fixed Assets', N'Parent', N'Assets', 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (13, N'Duties & Tax', N'Current Liability', NULL, 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (14, N'Bank A/C', N'Current Assets', NULL, 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (16, N'Cash A/C', N'Current Assets', NULL, 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (17, N'Load & Advances', N'Current Assets', NULL, 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (18, N'Stock in Hand', N'Current Assets', NULL, 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (19, N'Sundry Creditors', N'Current Liability', NULL, 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (20, N'Sundry Debtors', N'Current Assets', NULL, 1)
INSERT [dbo].[LedgerSubAccount] ([ID], [AccountName], [ParentAccount], [Nature], [IsFixed]) VALUES (25, N'Check in Hand', N'Current Assets', NULL, 1)
SET IDENTITY_INSERT [dbo].[LedgerSubAccount] OFF
SET IDENTITY_INSERT [dbo].[LoanSubType] ON 

INSERT [dbo].[LoanSubType] ([Id], [SubTypeName], [LoanTypeId], [MaxLoanAmount], [MinLoanAmount], [EMIPeriodFormate], [EMIPeriod], [IsCompoundInterest]) VALUES (1, N'Monthly_MTE', 1, 50000, 10000, N'MONTH', 1, NULL)
INSERT [dbo].[LoanSubType] ([Id], [SubTypeName], [LoanTypeId], [MaxLoanAmount], [MinLoanAmount], [EMIPeriodFormate], [EMIPeriod], [IsCompoundInterest]) VALUES (2, N'Yearly_MTE', 1, 50000, 10000, N'MONTH', 12, NULL)
INSERT [dbo].[LoanSubType] ([Id], [SubTypeName], [LoanTypeId], [MaxLoanAmount], [MinLoanAmount], [EMIPeriodFormate], [EMIPeriod], [IsCompoundInterest]) VALUES (3, N'Quarterly_MTE', 1, 50000, 10000, N'MONTH', 6, NULL)
INSERT [dbo].[LoanSubType] ([Id], [SubTypeName], [LoanTypeId], [MaxLoanAmount], [MinLoanAmount], [EMIPeriodFormate], [EMIPeriod], [IsCompoundInterest]) VALUES (6, N'MONTH_LT', 2, 50000, 0, N'MONTH', 1, 0)
SET IDENTITY_INSERT [dbo].[LoanSubType] OFF
SET IDENTITY_INSERT [dbo].[LoanType] ON 

INSERT [dbo].[LoanType] ([Id], [LoanTypeName]) VALUES (28, N'ABC')
INSERT [dbo].[LoanType] ([Id], [LoanTypeName]) VALUES (2, N'LT')
INSERT [dbo].[LoanType] ([Id], [LoanTypeName]) VALUES (1, N'MTE')
SET IDENTITY_INSERT [dbo].[LoanType] OFF
INSERT [dbo].[SocietyDetails] ([SocietyName], [At], [PO], [Block], [SubDivission], [PS], [DIST], [PIN], [ESTD], [Category], [Ph], [Email], [Website], [Logo], [GP], [CentreCode], [Area], [DistrictCode], [RegistrationNo], [GSTNo], [PanNo]) VALUES (N'DEMO', N'DEMO', N'DEMO', N'DEMO', N'', N'', N'Purulia', N'', N'', N'Primary', N'', N'', N'', 0x47494638396178007800F700000000000000330000660000990000CC0000FF002B00002B33002B66002B99002BCC002BFF0055000055330055660055990055CC0055FF0080000080330080660080990080CC0080FF00AA0000AA3300AA6600AA9900AACC00AAFF00D50000D53300D56600D59900D5CC00D5FF00FF0000FF3300FF6600FF9900FFCC00FFFF3300003300333300663300993300CC3300FF332B00332B33332B66332B99332BCC332BFF3355003355333355663355993355CC3355FF3380003380333380663380993380CC3380FF33AA0033AA3333AA6633AA9933AACC33AAFF33D50033D53333D56633D59933D5CC33D5FF33FF0033FF3333FF6633FF9933FFCC33FFFF6600006600336600666600996600CC6600FF662B00662B33662B66662B99662BCC662BFF6655006655336655666655996655CC6655FF6680006680336680666680996680CC6680FF66AA0066AA3366AA6666AA9966AACC66AAFF66D50066D53366D56666D59966D5CC66D5FF66FF0066FF3366FF6666FF9966FFCC66FFFF9900009900339900669900999900CC9900FF992B00992B33992B66992B99992BCC992BFF9955009955339955669955999955CC9955FF9980009980339980669980999980CC9980FF99AA0099AA3399AA6699AA9999AACC99AAFF99D50099D53399D56699D59999D5CC99D5FF99FF0099FF3399FF6699FF9999FFCC99FFFFCC0000CC0033CC0066CC0099CC00CCCC00FFCC2B00CC2B33CC2B66CC2B99CC2BCCCC2BFFCC5500CC5533CC5566CC5599CC55CCCC55FFCC8000CC8033CC8066CC8099CC80CCCC80FFCCAA00CCAA33CCAA66CCAA99CCAACCCCAAFFCCD500CCD533CCD566CCD599CCD5CCCCD5FFCCFF00CCFF33CCFF66CCFF99CCFFCCCCFFFFFF0000FF0033FF0066FF0099FF00CCFF00FFFF2B00FF2B33FF2B66FF2B99FF2BCCFF2BFFFF5500FF5533FF5566FF5599FF55CCFF55FFFF8000FF8033FF8066FF8099FF80CCFF80FFFFAA00FFAA33FFAA66FFAA99FFAACCFFAAFFFFD500FFD533FFD566FFD599FFD5CCFFD5FFFFFF00FFFF33FFFF66FFFF99FFFFCCFFFFFF00000000000000000000000021F904010000FC002C00000000780078000008FF00F7091C48B0A0C18308A3450B152ADAB26877EE446BD270D9885011EF34E9C0B123C7234DEE1C69285122C68618339E42C8B2A5CB97300F2E6488D2E19D50CB8C4434D28143CF9F1C46F8140114E891233743317978D2CECD9B31A34A9D4A7061C486A02A463BC2A4A34FA4371F46DB37962C5987A72236F1C91624435077E24474BA6C25D5BB78ABDE5916CA0EC3BA7D8FB0EDE0B72C5EAB6B7F86F49B315A9C53CBF24A8EAA30149C532731F3EC49D130424D9A102E232613234F0E6EEDC4899695E6E4D7A26936E16BE7C866260D0B2A031D7AA0B21933941DCC9480B4A63491AB6EFD891462DD889E61BF4E8BF3541C53773872906890528E19096424FF1833905802046A0EA699B1EF778E81A30B9E3A1DC70EE6BE0CA34BA78A7359E1DA8275905B79E9EDA389009A2CB34C1A095022501A399091033D06E590C33233BC37500E082447D029477004C7537C41B5DF5D204203114601DE71D081A12993406FFBE420C3583368F25B8103D593C31816D633D07AC511E4A1521C3985596BFA9DC89243183D74C7692EFAF66364F53C405E3D339027902609D4635E1A9A58A8DB78390E04269034128300690385F255567740B6979330A164C73277F8D444743E26900369EB4566E69709EC960070392048902639FE28D06FE4C9E0A0406324C0E3407D7640114E762C84E79361A9E55328BE11B45E0E339A179A261DEEFFE3630EB32AA3E07704A9712398C265AA4699058289401A98D2B8156AA1EEF5E7A806F1955F6DA8194689A6BE693A89A066429A861A1C12B38C0C346A32867002A9C11E97BF0A8A4302E3611AE17B32120BE73E9DCA158D110C313BD0427061D613AAAACE808097FB00B90F31E005B7CFA25792452E4BFA7C39C60CC4D653E67B606A32C97B99CAFAC0A56471C62764008F1A4A6B209E6A10A4E65E68E08C648D81DEC1F3DEE561C1EC4D6C608E0DEEF3EDA6FB6C64C448D098E8E44C0DF1744459E256AB8C793928C325C19A08F9A4430A8965164BC4C0410902A14D6B2185BCEEB32D85F4FA44722876EDB71743A684C844AE8EFA6C291CE2E508E1932C06FF58D4603AEDD5E48291C9284381DE11C3EA1847F6941428374F160D07330956A5AA45D6B8A8268A5F68F5BEA124861A1337450399426831D44480A8717710D4567F2768CD02C929E0E9254BB6D00875F154A5E29490FB9D701692FBF940F3F53452DB021143617CCBD073BC556C0D48500E9762E800C83BF7168DE3A038D6E45437516EF9406A20C030256B16AC6141D1C0F111F3C1B35FF026ED4536066F32C5A1FCF8C35393C01290893875005F107188648EE0174FA1A6200C4A83CC32A4A9A655C50E492A8B87C6E02DF2A8815CFA5B86C608420FCF240F5F058151F35825C119DCEC141CB983261632BE97F4E9266B39C241BEE390328987769DCA1D3DFFC6C034351023348C939570D440098219680C64A0DD7298E019E390417D0E3A144140F12F28D59025201A41441E7810F7C0A766B6FB1D7C2C580C62958B34FAD0DF3E8C38904C75C930CB10CEB12E87A98F59C85C3422487628720AC87DB1595312A34FCAF29D0FAA490040238BFF5C448FD1948934A3A1841B6935294AE4D167E322468196313104704F5CD1A3574F3C231C5222C06507C1A01168C8479744033742EB808738049EFD454685FBEA895D2CB88CF794B060F58B5C4B8891063204725C731C48886A49962E95912C218A43D272D79250084804D37C548E20B52832D5EC8602B994333125424C7E08237160421C9A30CFABD450136478903BB9B8FFB447816D653310D2E404B415C8BC04231CC04807E65610330169629BC2E0E53EA90C2FA9A192716A024F86E61486DC212B76D0A8609072B38A262789FB0BD92CE1C3C98264885C30A4DC2CB9699085C0D076CD73E3C1040533CF8408554D0C0D9C9828B5DAE55022FA8918FC407154812C2378F568E6130912A22F66AA66BE5B1A079867108970B12B0003D3061330098308A62CBB6922130D441AD31DD075FBD0875207A20FB4D155A9A1E3C06ABE141A1FA59318D0D8876068FAA5BA118433DFBBD341A2B40CA1F98662D5E2DE3E164910721D3139533AC229E62A907ACCA320F4F82C09ED4A961BA2755007C39840D6A24C6544A83D9072993767B91D6AFF96367C53EAC058E263AECFAD87AABA35D0C3886198AD685620A415483B40BB5C82349720FA704C075C643105156C191623CD5AA2932909B22B076940DB3405E4178378B4B1DB7950835CFB2328A25620182C4B1383B78F62F406837620C83C92CB0ED2CEE3B971650768457BAF7E1EB160708A4F55D5C4B01C704E20C5D0235BD4625E65D489271ACC547BB9E5604E09685FF685A21E0FA81F00EFA31D00463109875190FD0A32A1B2D2841ACA320947DAA63C64F25054DBA5CAA4E084206C6388FF0046AE32510B7EDBD1476FE881C9D09C02C6C9DD477F49280CE7B278202A2688396A9ADE5C918718CA482C4228F100F4906B7247804B284CB12FBFF4A5FF275F5298ACD28080340D848CF1F119B9BC0930179370CB03A1C7379C0B68819823C526DEC73CB66204A78E619442921337CB34B0040BA44F14992EC044B217A100CC4CCB286B6A0916A249D56337070B8D9C3CC30ECEEEA3169CAD855DDBC10B82C89A20BC70753BD0B6BAF648F6D2C1C5D4E61C3D83B67204142300496955F3E4E082895009488E619E7C8A7A40B1998FAE5DB0035D68E5761B1CCF6DC7A0913B6E72B718C04CD0214B6E9C4E378A527D87C234617C9C92E90A7B7F69FA8D873A1087B8E6D967FB80E1C39C0B607ADCDAD0B536B42DB05C0B827CA3E0DD160803BF34F0806F3BB5E5B458A27CD6812388E02419819687280D3320A1AD4FC5FFF5964026B79276B8FAD5000647A1CD516E9A0F041CE5A6C72B0AC20BD14237BD5273A43439C0E01C4C2239FA984181BA4291ABD064A1E9ECAC77C603B390D1541314FA705C775D107794FBC43B57EE2BD0C68B72D7A2D0DFE8B63922BE8FD02E4397A6AE8AD67FE65237CAE926746208587DF64AE35DEB7D288F2AFB88A1F229FD39B9E668F840B021E0B663A3B9E0C88640F4218DE6EAE315CF357872B30C43FD50421F7D429F0B070287BA7D6F791881C859E39C399FC1E97B6195B1543B0FDA834F3E1BCFB585E4E39A0A40DBC21BCA4D05DA70AE547DE0BE20EDA8F24074F2A831A4A11E628E6B8640338601E8741FBEC3086EC938295605F2D2442F8FFF40029BE683083AC5A840DB3C50D1DC6F28FE1B63DF072FB041217D6063E1020187E207B27683387B0C1CB40F0E127A2B94376E041A16B714D011225C553009707DFB606F67141953420F51D676984757EE3710D9F07ED34021DF900D11037F02C10BD3205AEDE00AEE806BE07010A18780C5906DB0B72F84275F02E02068961612B17A65028064002103D052726220F47530C2D1012B310F53D662AE9079D2306EE65079FB600EECB70FDF207CF4900D92677C8A470FAEA076DFF072A1351234B87C4D8010DD951C961311CBE013EE622116F25065D16B154506FB530CF4D2689DC50E09E75CD27065F22785F4800A83D60EA8B065B5300DFAE00E87B80FE7FFD08856980D68A30FB6F00D518662FA100A239042E3E24D06E15A55076C7700074E21812F016393B220A1715CCEF570C8870D2D1857D9E00A149288C3300FD36089DF907EECD088DF407F81987094088CFAC50BCF854251F5682A878AD130758B726D6DC501213146A8A23846D424DE3416F5301A70120A7A587BE0C059BC200D09770EAE3068E6008B3A870DEE9088F3000EEC67882DD80ED8306E82468C93670EE0405A1A6120554310BD261019C23E930004DFF11EA717120BA638E1311E46E421E9E63E12444721C112E6F0855AF68420788859D884D9F00A34370DECF00AB87785FD7585CB6570D9008827960D7D184C07431084F76465F172712471B5FFC513462263DF313003616FB6A27264C101CAE073069182AE2810B5D08116380DAE300CB6F0844BB994E7F891232989B5200D5B968552885CB5F00D2C49552B612B641932C9F154B6E28202B21173534C812442DE43393B490FA1A043F4D00EEC90686D570BD87070596989FA588224990DD83098AE900D2198761F195AAF800DCAA70F48798171F506EAE62191D165BFF14ACA7824D2E84D2E9274E3413BDA161DC2111181260CDFB0845A569802A60F57F80DBC90097A047F1FA98586F90AEE270D79D99880D60E59C9766D8797EDF03D6D6749761834EAE63360D29316421A3024175D6631ACF25E9CD268C639060E82423CE77EAA7962BB887B82F60AAFFF8009CA1066EE7098D8308B8439981F99768DD982F4000E87696290690EBBF05C94434A69103CA431840461293B03493E238D1B3169DF014D127786E24209C4F5101D6091DFE00AE0A654E1797FEC8098C95089C3100DB54992B4E90D8DD9815A086B89578FFE9578DFB08200892AFA530C17457B1B025E8242238E838AB0252EF0B67C97539E2BC7502C216EA8E00DB6D05C23999EDF200C4B290D0BD70B85E90D1F999E24899BED296ED900896DC70EF067898BA54315A5099980831CE0210C390392956C0B4624E09103BF322F5A0761AAD6682F877CBF788EE0266EE21982B8590BD1408FB599A57D49987C097F7D9992C310A1D9B00B92B90F4A612037FFF33DC3041E4767109B219776C83951363993462F4C209C79E96706E10EE5D09879FA8B1D08A507F3A4B308A5E939951DF870EF18A1D8600E893A7E0FBA8D41491AA8A80CC881101BC111871432630180A2D408FB2017C8A50CECA07FDF009B79490F73450F34B7AAA5DAAAD1E0851D080EBCD00BBCC00BEA598FF55889A26A0E715A57FF9597C3A043E2726D0E32776A3009CDF40340322141C316BFFA3DD10066CB4047414358FFB5ACAE800DE7787679899AB829AD1D58AD20692B68A50CBDB094B859B069375775859734F795C6482193A340EDB1B112F81B3C9521AC1219BDFAA02FD186D1E0A293C03EABD880CC8573877998ADFAA786BA70EDD00BD1FF103152432ED0300C817A8EC6F85F28DA983ECB7505C1A5A06187E9D104F9E55471647407A3307140AF2F61AFBB011A94E020B81113138BA2201A82B480984D58ADCA5049521358B6726ADCBA94CB2AA887F90DE540B432115C9A746A02C16F06C12699529A1D211AFBE954725959C56A5B74D57675658128E67E88E9A17D292461462E39EB6FEDD1B3D9400BDF006ECE0A1344477805413A06611E8B0207AB25B546B21E336375044109490B0AFF8597ECB076E5F095B5E00D4BF9B5FF1AA811FA8BF0C762D1509E8CBB0C71642B714489ADFA702E175730419C0A22941128B83A3210236B1815C530F33239C951260C4A2F7040AEEE8062C2B9766B57B9E5FFB0B6BFD898B6F0063F00BA465842C2B1BEED510FD0500FF337B92118A85FB9AC6BC70E79C90EF3B05FF4A00CC99956474864BF021ADE42B782258D7219BD0EC620058184FB6087F3D20769063798B1244BB26659010AA0000799900699F0C116000468D34AFA40B7650B7DEA3B099900076FD0C22CFC062C1CC3300C07344CC37660047373B4BE345900430C023040E0F14A42B211D911195FF3804F35038175672E221CDE523593438A460007533CC54C40C5576C045A8CC35CE18D1660013F902AADF4BE615642666C2BD0A00653CC1543C30446A0516E7CC56E7CC376203F2EA2491E62AFFBA20C1166B5BD31346B812AD1202E02E37D9F434FBA514207FF54C78C6C07754C8A90CCC8904CC346F000A0001FBF4BB6391B3D64590F9930C593FCC8923C25524CC75D5610260B1323D071A628318DF23EF1944E814418914CC5927CC5747C047070C5540C0415902AB262B6ED41C66311319A500116600475ECC6BBACCBCCACCC46501F56ECC0E645B244982075441E39481808214AE4921D06D2B700D727B5CCC8CA5CCEA4A809165001C81C0A25EC6F1113191422241143977080CC3F60049A3025B5B1CC543C8AB81CCD754C3906CC29E157307556678F065E1C3746C9591E3296524379B2BE26416923C9180DC9B8BCCBBB6C1960AC097EA109A0B009A0409627A3C1A1A009349CCC204DC937CCD1FDCCD1018D415CFFAABC93355122A449AC023372D204AB43B2CAD044AC32030F300034DA1000387821438A19DDD4900C0A9A6004C80C3961B60CD0C0171A0C39CB00391B2CD5F802071A75C3D2FCD2742CD0E79C5E79A40941158184D53C6FD26377D015C12A28FBC32181F4C6053D10738CCE187DCE76B00970F0C515000470509EBEEBBB81B6BB51EDCB1030D81B5CD62372CEBC4CD6BBFC7FA8AB23300A1A03A738439C50D4E87AE9D4334066CD052127914CC77C7DDA345C045FACC57020D29B20D22A6D04821DC253DCD5A4CCCCF2B4CBF154CA43D3BE37637898220082F22B37831A213149B9F24FEDBB725BF5282BB750A19CDA924C8A232DD5169003C80C04F9FC0339FFB0CE2D2DC95C61CB300DCDE63C8AF2B31249DDBCCB2B93DE5167E3111AA7171130F48DD39206C4E01D902571FD3610509536AAEDC8305DCEA27C1C69D00BBD00AFBD9003BEB0E09340CA3AA1C5BACDDBCAACCB1C7DCEBB7CD0833C065DF0107F4B1040C24C1DE64D4E2111186620EA13C46A3A2F04982B21E3CF528CCE1B0D0745C008EE8AE0EE400CC380E0C390E3BD300993D00B6360CBD12C4FD02CD3BCEDCF123547F32235E0FC25C4550FA118BA1AB11A82B112E6B23FFF083F6D5A10E48CD14ECDC869700B93800EBD700BB7400CEEE00B8C700BBDA0E36EDEE0BCE0AE72FCCF452ECD311ED0B52A419EE4DC25A361AC22593F051DD9D16FD125137AFF9D9C0BB23FD027DDA85DDE190D07418EE0BDD0E692200C982E0CBCD0086D4EE96960E4377CC545E0066F30C54D00D3CEFC61ADC4E78A1A5C8C2B2ECC99443DCD27128141E177449C1394EBF17AD48C9DB6AAA81C70CBA98DCB6F80E6684E78BD200CF2800FC2D00BEE300C68DEE0921D0746E0066E30046DA0046E60C570D0DB37CCA50EA272A1F1C643F40039921CBB7155AAC418B2E1C09A10848BF200CF6818BF8D6AA978C0C23ED3913CC592300968DEE33A1E098C407884E7E69350EA1C0D074440074340074470ED75E0CC172EB71AD49FBA053C997238F3921C3E5112342127FDFD3415753815C772DBE8DF23B6C6BC3C8AE75C04529C09FEDE0B8DFFF0E604FFEF39EE0E938EE052EC064AD0060FDFF3DA4EE4A4985EE24206188BABB5A40CDC321E794C183471078C0167A4776466C5A54F936DC2E14D012DC771F00644E0F330DC08317F0B8CD00BE7400CE730F33A4EE9414EE6437EED6E900470FFF54410F1BC2D8D6D371697046C864123F5F0060F387449C1EEA55825693000A2D659550163A2D41B97921D380C070C64046FD0F044300744F0D26FD008B6100B8D80E69C7E0B8600FA687EF0CBDCC2D63E046E70F93D6FDE3A2980209452A7FC3564F030EF2E61054AE8A12327EAA67493A22B3FF230D951431874E17010F773FF06FE9C069CDFFCB6F0F99C7F0B6240C530EDF50F4FF7ABDF06A67EE24FFF6435C2516ABE612E484C71AA14072270132B21127E11C81BDB1E69BAD3F3F2DBC09C9642134F6F20F73FDF06E46D074C300900318C58AF4970D2302236CCD71B3B701ADA3172E70D913944E80C7193C48D113B1C3A44DB4749D33E4D39C668AA778A03C87D2D5B2ACB8160064A974738DCE9D0C408C868119735E970C4E5BE1C3388BD9C91C3E5A90EA15A521A432CDA184A2D8D746062C40D91365C29728403360D9C37701C36243B160E138766D9C221E266C8453745E07038025299A693FBEA2DDB17AD431C97C4686A9AA1660C821C80437168124AC4913B2E439D0A75C7E6A996CB10A819AA29C1C8967756EE9B146D19D5A1388D1469A364ABDC3771FF38DA86E8F02DDB876D213E3C6267E2EC8E1FF7113B5A6F0CE896478C0C5523204749A524C7B4ECD03454E4A1D1422DB3C354E8F104475D6A1260BE79877DCB88E5506FB98311AE1AB7AEFDBDD6A191B3FB1BF28EE3378E220ACB8E23721A6A19C0F661CD3496F65186A41C069869A87D1EBBC38E504279B0253BEE88231A9B9C522681EB5C4A2381055DC28BA4A3A231ECA57D4EB1A988E1DE608B3FDE086C08ACDEFE73280EFDF4E3E0A69634D124C208DBDBC78E0E383B72860533C9C1C425F7F168993B36EC30B0234089C634F6F649510D659649638034646C49B02642AB2A24F370E2C008E7E260024F38822BD047B078734BBFDF0E6C42AFE3C8506CFF8C31220CA5A9A19451831E97D04C6086D2728A0614EE2C9CF10E0581AA8C41192A35B1253566B8329A163BDB47D268928C301AA08CC88A561D0585A309DF82CCCFCF0E3870EAB81C8A81B09EF6466AD48E478DE574AFC03C02338E3BBAEC6C5A507E358E2435D2304F0D044E948F094E5DA2244E1A7F3542CF23D6C24DBF3BFEDC9589033B089598AA88395119F31A0DB5BD2A1188CFC2033D8D060E28C7F52E94111E1BD3426F415B86925483A2763524CD0B13DBAC72EC15ADDEB2CA8E89603B1B03244A407BF5C20E94356F9299481BD7B423985806B37187D210D8268C1C6A8C04243E158138DBC4ABCBBE8C15C9B2260EF4C84E23680DAB569BB28B8CFF2562A021F744D6F631AD32C440CAA13ABE606E333B1AC3A4D642EF9A5ABA8305A732718C19C6087B992E473C0F5C069394D825EFEE68828911E61D3CA73BEE38B83D658A19033062201D69197A447494A40122148D6E5299B36AE59FCEBC596D60E5F5E829041E98218D3373A88A6E0B4D238CC1159521A3A5C6D8ECCE6F4E9184F0A99172A84799131BDDC9257AC27E2AA9915C7609A7234EF9A9DFD097D26C04999F4A634197E14E83D9A53C1AD9D4913499E4A5DAA77749787DCA3D8E64EB00FB09B2DD4BEDBD9E926600A9510E30030F7D4E25A3D7CEA4E72FA820806CDD314D1316F41E638D8158F65B93858891862459481364C0179BFAD212E2252E7F346A425102E0D31EF02D034C69435F1C46A0A1810D250D49190DFA42619369F56E19D589D018BCE797A2B4E08021D144F648D212620086293C0B5DE658B224C1DC241AFCF3DFB854B22526FC0A4ACB9801EA02769C1FEA2F44AD920A2500D3B8D0E4A005A9B3D06AF6A18691149183BFAAA185FA36144A548A8C5E82CC776AFF16C59B8549618D7214DC02A6094ABC902F9C52495082B5A40D922B6C5B1409725A720A3AC5B167254943D20AB32DF3D0301A76F00E1F4367C28F5C8B038051C695D237834AF9F06634F2C8F356C4A92D5AE81471F815659278C619A0AA8F345490254529C58F6CC8231E24A2DC7AA9BCD079A78AB1D490DD468919CD642722287C4A5164D04B0C724A4479E450EC8619BA956C884EE1EB0C62B6290335D4129187C3964762991D7962CB084D38053687428C53550A079AE8D237B7140A6848739CD34B1834003940082DB342859963339F68CE0C65864BFA3C12195449896DF632604D1CE8860E1AC50D6DC894C2D4C432F8A25217562A8223E5A326646092FFD058CC3D436198024DC12598FA6F439881655ED2A8CAC09447A5CB20C3A27ACAA9D544C83025992584A2EA24600D144C4BF51F284AFACDCA858E129FC9611AC8C03AD6B9737A8631CF21B3E6CB3E668732CBA019F4B01AC54F722833B9C4660ED4D008A58C614D49F29949C216D14715324A3978C051E8D6C835EAAD354DFBE44FD039D7E92DE332A1D0D0CEBA1A1A16AC0831CC611D514E4253A6FA2C42A14DC3754C72AA338D96737EB30965C21926CA0E137A99518D988C105598D0B471253ACA08A7E397D12CA37C16126EF714130D2931A8648B555B25071A2650D4769C990A9196B6E3914259C8593920032594F2B57D18C5769AE027A7868BC598FCFF6EB43F2C4DD33C85D9EF4CD6BAFEF3635DC364939B44B53D743B4A1A945222C0E8E3A1647A68688F04BCFFEA356653DBD29628C9A1FBC234B7F53DDCD414183A35DCCB80D491916198E5D7AC21544C37098556EFA0500A57D8C2985D461FE0E01D9DE4B2C5E3A2DD62010395DD9DEF3828BC25B614382D73DED8C53D4DD84023AC59BCE4338ACB202A494F4C993B80694B2A3EB2754FB113FADA2D334C9B0FC1284B63791E81CA1FF294868C9C65CA5254AB1CFA1B98F172B868D419BFAAC9CC55CA1C992D7D283344C6289B61CA620E69F54C9F44DC11988C2DE72CAD094D009CA2ED54CF5852D9AE683EDC1D662C6841D7994BF9942C5CED4AAF0355319E11A71E5C44E80CCAED40D9A2150D34560302003B, N'', N'', N'', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[SocietyLoanDetails] ON 

INSERT [dbo].[SocietyLoanDetails] ([id], [SocietyLoanSlNo], [SanctionedAmount], [Date], [RateOfInterest], [EMIPrincipalAmount], [EMIInterestAmount], [PayableAmount], [NoOfEMI], [LoanTypeName], [LoanSubTypeName], [EMIPeriodFormate], [EMIPeriod], [EMIPaidDay], [Remarks], [IsCompoundInterest], [LedgerFrom], [LedgerTo], [Transection_Ref_No]) VALUES (15, N'SL002', 5000, CAST(N'2018-11-07T12:58:11.497' AS DateTime), 5, 5000, 136.448907308026, 5000, 12, N'MTE', N'Monthly_MTE', N'MONTH', 1, 5, NULL, 0, N'dea1c2ef-f2f4-4e7c-937e-9020e172bfdf', N'c6a5fcd2-0495-41b6-8068-3b9453d9c646', N'TRN1')
SET IDENTITY_INSERT [dbo].[SocietyLoanDetails] OFF
SET IDENTITY_INSERT [dbo].[SocietyLoanEMI] ON 

INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (115, N'SL002', 1, CAST(N'2018-12-05T00:00:00.000' AS DateTime), 407.20407560900395, 20.833333333333332, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (116, N'SL002', 2, CAST(N'2019-01-05T00:00:00.000' AS DateTime), 408.90075925737477, 19.136649684962485, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (117, N'SL002', 3, CAST(N'2019-02-05T00:00:00.000' AS DateTime), 410.60451242094717, 17.432896521390091, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (118, N'SL002', 4, CAST(N'2019-03-05T00:00:00.000' AS DateTime), 412.31536455603447, 15.722044386302811, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (119, N'SL002', 5, CAST(N'2019-04-05T00:00:00.000' AS DateTime), 414.03334524168457, 14.004063700652667, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (120, N'SL002', 6, CAST(N'2019-05-05T00:00:00.000' AS DateTime), 415.7584841801916, 12.278924762145648, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (121, N'SL002', 7, CAST(N'2019-06-05T00:00:00.000' AS DateTime), 417.4908111976091, 10.546597744728183, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (122, N'SL002', 8, CAST(N'2019-07-05T00:00:00.000' AS DateTime), 419.23035624426581, 8.8070526980714785, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (123, N'SL002', 9, CAST(N'2019-08-05T00:00:00.000' AS DateTime), 420.97714939528356, 7.060259547053704, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (124, N'SL002', 10, CAST(N'2019-09-05T00:00:00.000' AS DateTime), 422.73122085109725, 5.3061880912400223, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (125, N'SL002', 11, CAST(N'2019-10-05T00:00:00.000' AS DateTime), 424.49260093797682, 3.5448080043604504, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[SocietyLoanEMI] ([ID], [SocietyLoanSlNo], [NoOfEMI], [EMIDate], [PrincipalAmount], [InterestAmount], [IsPaid], [VoucherNo], [PaidDate], [Remarks], [Transection_Ref_No]) VALUES (126, N'SL002', 12, CAST(N'2019-11-05T00:00:00.000' AS DateTime), 426.26132010855173, 1.7760888337855472, 0, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[SocietyLoanEMI] OFF
SET IDENTITY_INSERT [dbo].[State] ON 

INSERT [dbo].[State] ([ID], [State]) VALUES (1, N'ANDHRA PRADESH')
INSERT [dbo].[State] ([ID], [State]) VALUES (2, N'ARUNACHAL PRADESH')
INSERT [dbo].[State] ([ID], [State]) VALUES (3, N'ASSAM')
INSERT [dbo].[State] ([ID], [State]) VALUES (31, N'Bangla')
INSERT [dbo].[State] ([ID], [State]) VALUES (4, N'BHIAR')
INSERT [dbo].[State] ([ID], [State]) VALUES (5, N'CHANDIGARH')
INSERT [dbo].[State] ([ID], [State]) VALUES (6, N'CHHATTISGARH')
INSERT [dbo].[State] ([ID], [State]) VALUES (7, N'DELHI')
INSERT [dbo].[State] ([ID], [State]) VALUES (8, N'GOA')
INSERT [dbo].[State] ([ID], [State]) VALUES (9, N'GUJRAT')
INSERT [dbo].[State] ([ID], [State]) VALUES (10, N'HARYANA')
INSERT [dbo].[State] ([ID], [State]) VALUES (11, N'HIMACHAL PRADESH')
INSERT [dbo].[State] ([ID], [State]) VALUES (12, N'JAMMU AND KASHMIR')
INSERT [dbo].[State] ([ID], [State]) VALUES (13, N'Jharkhand')
INSERT [dbo].[State] ([ID], [State]) VALUES (14, N'KARNATAKA')
INSERT [dbo].[State] ([ID], [State]) VALUES (15, N'KERALA')
INSERT [dbo].[State] ([ID], [State]) VALUES (16, N'MADHYA PRADESH')
INSERT [dbo].[State] ([ID], [State]) VALUES (17, N'MAHARASTRA')
INSERT [dbo].[State] ([ID], [State]) VALUES (18, N'MANIPUR')
INSERT [dbo].[State] ([ID], [State]) VALUES (19, N'MEGHALAYA')
INSERT [dbo].[State] ([ID], [State]) VALUES (20, N'MIZORAM')
INSERT [dbo].[State] ([ID], [State]) VALUES (21, N'NAGALAND')
INSERT [dbo].[State] ([ID], [State]) VALUES (22, N'ODISHA')
INSERT [dbo].[State] ([ID], [State]) VALUES (23, N'PUNJAB')
INSERT [dbo].[State] ([ID], [State]) VALUES (24, N'RAJASTAN')
INSERT [dbo].[State] ([ID], [State]) VALUES (25, N'SIKKIM')
INSERT [dbo].[State] ([ID], [State]) VALUES (26, N'TAMIL NADU')
INSERT [dbo].[State] ([ID], [State]) VALUES (27, N'TELANGANA')
INSERT [dbo].[State] ([ID], [State]) VALUES (28, N'TRIPURA')
INSERT [dbo].[State] ([ID], [State]) VALUES (29, N'UTTAR PRADESH')
INSERT [dbo].[State] ([ID], [State]) VALUES (30, N'UTTARAKHAND')
SET IDENTITY_INSERT [dbo].[State] OFF
SET IDENTITY_INSERT [dbo].[Transection] ON 

INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (153, N'd1c583ba-89d9-45e2-bfef-0e0f80d0b6b3', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'SL002', N'Customer_Loan', N'698ccbbd-debe-42d7-84c7-016a4fefc636', N'dea1c2ef-f2f4-4e7c-937e-9020e172bfdf', 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'TRN2')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (144, N'52125b58-6093-4ab3-a28c-25ab9bb32848', CAST(N'2018-11-07T12:58:11.497' AS DateTime), N'SL002', N'Society_Loan', N'c6a5fcd2-0495-41b6-8068-3b9453d9c646', N'dea1c2ef-f2f4-4e7c-937e-9020e172bfdf', NULL, 5000, N'Bank', NULL, NULL, NULL, NULL, NULL, N'TRN1')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (148, N'450ca73d-fdff-47e6-8c88-2df667e03d8e', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'SL002', N'Customer_Loan', N'13cf4d17-54ba-4597-b773-572d6abed331', N'7901e540-65da-4b83-a42a-647bff45461a', NULL, 1000, NULL, NULL, NULL, NULL, NULL, NULL, N'TRN2')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (150, N'91456366-14b2-4596-9315-3401f7085e5b', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'SL002', N'Customer_Loan', N'7901e540-65da-4b83-a42a-647bff45461a', N'5db49d38-7168-4252-9585-0163ec5f22e5', NULL, 20, NULL, NULL, NULL, NULL, NULL, NULL, N'TRN2')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (143, N'92e7a188-2314-47cf-ac44-37ff4b873dc5', CAST(N'2018-11-07T12:58:11.497' AS DateTime), N'SL002', N'Society_Loan', N'dea1c2ef-f2f4-4e7c-937e-9020e172bfdf', N'c6a5fcd2-0495-41b6-8068-3b9453d9c646', 5000, NULL, N'Bank', NULL, NULL, NULL, NULL, NULL, N'TRN1')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (152, N'8f4ad6d7-d3c3-4aae-8d36-3e1c6d3570b9', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'SL002', N'Customer_Loan', N'7901e540-65da-4b83-a42a-647bff45461a', N'69c53e69-725f-4ad2-8690-01376bb462fa', NULL, 10, NULL, NULL, NULL, NULL, NULL, NULL, N'TRN2')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (145, N'e863ad92-162d-47a4-afb4-7295432dae1b', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'SL002', N'Customer_Loan', N'13cf4d17-54ba-4597-b773-572d6abed331', N'dea1c2ef-f2f4-4e7c-937e-9020e172bfdf', 1000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'TRN2')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (146, N'8daf658a-4764-4154-badd-77e3be2b69c5', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'SL002', N'Customer_Loan', N'dea1c2ef-f2f4-4e7c-937e-9020e172bfdf', N'13cf4d17-54ba-4597-b773-572d6abed331', NULL, 1000, NULL, NULL, NULL, NULL, NULL, NULL, N'TRN2')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (154, N'34d2780f-d39a-4184-bf1b-a1e79b49c738', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'SL002', N'Customer_Loan', N'dea1c2ef-f2f4-4e7c-937e-9020e172bfdf', N'698ccbbd-debe-42d7-84c7-016a4fefc636', NULL, 10, NULL, NULL, NULL, NULL, NULL, NULL, N'TRN2')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (149, N'45c21250-c1fc-445d-b334-c901ef676b5e', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'SL002', N'Customer_Loan', N'5db49d38-7168-4252-9585-0163ec5f22e5', N'7901e540-65da-4b83-a42a-647bff45461a', 20, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'TRN2')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (151, N'0bad0950-c008-4d11-90f2-dc73737cad4f', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'SL002', N'Customer_Loan', N'69c53e69-725f-4ad2-8690-01376bb462fa', N'7901e540-65da-4b83-a42a-647bff45461a', 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'TRN2')
INSERT [dbo].[Transection] ([id], [TransectionID], [Date], [No], [TransectionType], [LedgerIdFrom], [LedgerIdTo], [Amount_Dr], [Amount_Cr], [Mode], [BankName], [ChequeNo], [ChequeDate], [Narration], [Status], [Transection_Ref_No]) VALUES (147, N'49bb4eb4-130c-4d8d-958a-f5e2577ce1f6', CAST(N'2018-11-07T12:59:08.773' AS DateTime), N'SL002', N'Customer_Loan', N'7901e540-65da-4b83-a42a-647bff45461a', N'13cf4d17-54ba-4597-b773-572d6abed331', 1000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'TRN2')
SET IDENTITY_INSERT [dbo].[Transection] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Bank_2]    Script Date: 15-01-2019 10:45:38 PM ******/
ALTER TABLE [dbo].[Bank] ADD  CONSTRAINT [IX_Bank_2] UNIQUE NONCLUSTERED 
(
	[BankName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CustomerLoanDetails]    Script Date: 15-01-2019 10:45:38 PM ******/
ALTER TABLE [dbo].[CustomerLoanDetails] ADD  CONSTRAINT [IX_CustomerLoanDetails] UNIQUE NONCLUSTERED 
(
	[Transection_Ref_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Districts]    Script Date: 15-01-2019 10:45:38 PM ******/
ALTER TABLE [dbo].[Districts] ADD  CONSTRAINT [IX_Districts] UNIQUE NONCLUSTERED 
(
	[DistName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FinancialYear]    Script Date: 15-01-2019 10:45:38 PM ******/
ALTER TABLE [dbo].[FinancialYear] ADD  CONSTRAINT [IX_FinancialYear] UNIQUE NONCLUSTERED 
(
	[FinancialYearName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LedgerMain]    Script Date: 15-01-2019 10:45:38 PM ******/
ALTER TABLE [dbo].[Ledgers] ADD  CONSTRAINT [IX_LedgerMain] UNIQUE NONCLUSTERED 
(
	[LedgerName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SubAccount]    Script Date: 15-01-2019 10:45:38 PM ******/
ALTER TABLE [dbo].[LedgerSubAccount] ADD  CONSTRAINT [IX_SubAccount] UNIQUE NONCLUSTERED 
(
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_LoanType]    Script Date: 15-01-2019 10:45:38 PM ******/
ALTER TABLE [dbo].[LoanType] ADD  CONSTRAINT [IX_LoanType] UNIQUE NONCLUSTERED 
(
	[LoanTypeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SocietyLoanDetails]    Script Date: 15-01-2019 10:45:38 PM ******/
ALTER TABLE [dbo].[SocietyLoanDetails] ADD  CONSTRAINT [IX_SocietyLoanDetails] UNIQUE NONCLUSTERED 
(
	[Transection_Ref_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_State]    Script Date: 15-01-2019 10:45:38 PM ******/
ALTER TABLE [dbo].[State] ADD  CONSTRAINT [IX_State] UNIQUE NONCLUSTERED 
(
	[State] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CustomerBankDetails] ADD  CONSTRAINT [DF__CustomerDetailsA__Branc__4D6A6A69]  DEFAULT (' ') FOR [BranchCode]
GO
ALTER TABLE [dbo].[CustomerAddressDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPersonalDetails_CustomerDetails] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[CustomerDetails] ([CustomerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerAddressDetails] CHECK CONSTRAINT [FK_CustomerPersonalDetails_CustomerDetails]
GO
ALTER TABLE [dbo].[CustomerBankDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerBankDetails_Bank] FOREIGN KEY([BankID])
REFERENCES [dbo].[Bank] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerBankDetails] CHECK CONSTRAINT [FK_CustomerBankDetails_Bank]
GO
ALTER TABLE [dbo].[CustomerBankDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerBankDetails_CustomerDetails] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[CustomerDetails] ([CustomerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerBankDetails] CHECK CONSTRAINT [FK_CustomerBankDetails_CustomerDetails]
GO
ALTER TABLE [dbo].[CustomerDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerDetails_LedgerMain] FOREIGN KEY([LedgerId])
REFERENCES [dbo].[Ledgers] ([LedgerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerDetails] CHECK CONSTRAINT [FK_CustomerDetails_LedgerMain]
GO
ALTER TABLE [dbo].[CustomerLoanDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerLoanDetails_CustomerDetails] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[CustomerDetails] ([CustomerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerLoanDetails] CHECK CONSTRAINT [FK_CustomerLoanDetails_CustomerDetails]
GO
ALTER TABLE [dbo].[CustomerLoanDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerLoanDetails_SocietyLoanDetails] FOREIGN KEY([SocietyLoanSlNo])
REFERENCES [dbo].[SocietyLoanDetails] ([SocietyLoanSlNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerLoanDetails] CHECK CONSTRAINT [FK_CustomerLoanDetails_SocietyLoanDetails]
GO
ALTER TABLE [dbo].[CustomerLoanEMI]  WITH CHECK ADD  CONSTRAINT [FK_CustomerLoanEMI_CustomerLoanDetails] FOREIGN KEY([LoanId])
REFERENCES [dbo].[CustomerLoanDetails] ([LoanId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerLoanEMI] CHECK CONSTRAINT [FK_CustomerLoanEMI_CustomerLoanDetails]
GO
ALTER TABLE [dbo].[Districts]  WITH CHECK ADD  CONSTRAINT [FK_Districts_State] FOREIGN KEY([StateID])
REFERENCES [dbo].[State] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Districts] CHECK CONSTRAINT [FK_Districts_State]
GO
ALTER TABLE [dbo].[LedgerBankDetails]  WITH CHECK ADD  CONSTRAINT [FK_LedgerBankDetails_Bank] FOREIGN KEY([BankID])
REFERENCES [dbo].[Bank] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LedgerBankDetails] CHECK CONSTRAINT [FK_LedgerBankDetails_Bank]
GO
ALTER TABLE [dbo].[LedgerBankDetails]  WITH CHECK ADD  CONSTRAINT [FK_LedgerBankDetails_Ledgers] FOREIGN KEY([LedgerID])
REFERENCES [dbo].[Ledgers] ([LedgerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LedgerBankDetails] CHECK CONSTRAINT [FK_LedgerBankDetails_Ledgers]
GO
ALTER TABLE [dbo].[LedgersStatus]  WITH CHECK ADD  CONSTRAINT [FK_LedgerStatus_FinancialYear] FOREIGN KEY([FinYearID])
REFERENCES [dbo].[FinancialYear] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LedgersStatus] CHECK CONSTRAINT [FK_LedgerStatus_FinancialYear]
GO
ALTER TABLE [dbo].[LedgersStatus]  WITH CHECK ADD  CONSTRAINT [FK_LedgerStatus_Ledgers] FOREIGN KEY([LedgerID])
REFERENCES [dbo].[Ledgers] ([LedgerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LedgersStatus] CHECK CONSTRAINT [FK_LedgerStatus_Ledgers]
GO
ALTER TABLE [dbo].[LoanSubType]  WITH CHECK ADD  CONSTRAINT [FK_LoanSubType_LoanType] FOREIGN KEY([LoanTypeId])
REFERENCES [dbo].[LoanType] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LoanSubType] CHECK CONSTRAINT [FK_LoanSubType_LoanType]
GO
ALTER TABLE [dbo].[SocietyLoanEMI]  WITH CHECK ADD  CONSTRAINT [FK_SocietyLoanEMI_SocietyLoanEMI] FOREIGN KEY([SocietyLoanSlNo])
REFERENCES [dbo].[SocietyLoanDetails] ([SocietyLoanSlNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SocietyLoanEMI] CHECK CONSTRAINT [FK_SocietyLoanEMI_SocietyLoanEMI]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[39] 4[4] 2[22] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CustomerDetails"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 199
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CustomerBankDetails"
            Begin Extent = 
               Top = 8
               Left = 319
               Bottom = 128
               Right = 479
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CustomerAddressDetails"
            Begin Extent = 
               Top = 6
               Left = 742
               Bottom = 126
               Right = 902
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "Bank"
            Begin Extent = 
               Top = 36
               Left = 536
               Bottom = 141
               Right = 696
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ledgers"
            Begin Extent = 
               Top = 6
               Left = 940
               Bottom = 126
               Right = 1104
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 27
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CustomerList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CustomerList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CustomerList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[13] 4[8] 2[31] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -1001
      End
      Begin Tables = 
         Begin Table = "Transection"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 225
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ledgers_From"
            Begin Extent = 
               Top = 6
               Left = 263
               Bottom = 126
               Right = 427
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ledgers_To"
            Begin Extent = 
               Top = 6
               Left = 465
               Bottom = 126
               Right = 629
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TransectionView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TransectionView'
GO
USE [master]
GO
ALTER DATABASE [CoOperative] SET  READ_WRITE 
GO
