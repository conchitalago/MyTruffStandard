USE [MyTruffDB]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 06/11/2021 8:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[IdClient] [int] NOT NULL,
	[Company] [nchar](100) NULL,
	[Cif] [nchar](12) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendors]    Script Date: 06/11/2021 8:58:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendors](
	[Id] [int] NOT NULL,
	[FulName] [nchar](100) NOT NULL,
	[Cif] [nchar](13) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (1, N'Bardudollantor Holdings                                                                             ', N'KE 13 42 70 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (2, N'Parsapadan                                                                                          ', N'NJ 72 00 37 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (3, N'Ciprobin Direct Inc                                                                                 ', N'VQ 06 91 38 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (4, N'Tuperax                                                                                             ', N'TR 02 49 04 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (5, N'Sursipplover Direct                                                                                 ', N'MQ 08 40 02 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (6, N'Kliglibantor Holdings                                                                               ', N'WJ 07 91 59 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (7, N'Rapniponistor Holdings Corp.                                                                        ', N'QB 08 37 56 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (8, N'Parzapeficator WorldWide                                                                            ', N'HX 49 26 41 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (9, N'Dopzapover Holdings                                                                                 ', N'SK 60 88 04 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (10, N'Frotinor WorldWide Company                                                                          ', N'UJ 67 42 47 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (11, N'Emkililantor                                                                                        ', N'SN 73 11 83 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (12, N'Parbanar Holdings                                                                                   ', N'PS 87 32 36 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (13, N'Trukilonentor WorldWide Group                                                                       ', N'NP 89 12 29 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (14, N'Thrudimazz International                                                                            ', N'BB 39 98 80 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (15, N'Supwerpantor Direct Inc                                                                             ', N'TQ 01 43 72 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (16, N'Indudistor  Corp.                                                                                   ', N'KH 06 72 27 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (17, N'Supweramar WorldWide Group                                                                          ', N'EZ 23 57 81 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (18, N'Qwifropaquax International Company                                                                  ', N'JE 08 63 89 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (19, N'Suphupegar  Inc                                                                                     ', N'ZY 90 25 78 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (20, N'Unsipewower WorldWide                                                                               ', N'FE 11 25 96 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (21, N'Tupkilover Direct Inc                                                                               ', N'ZS 25 83 62 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (22, N'Varcadazz WorldWide                                                                                 ', N'OQ 76 45 98 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (23, N'Rapmunegan  Inc                                                                                     ', N'PO 35 40 69 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (24, N'Suptumplan Direct Corp.                                                                             ', N'JZ 48 15 55 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (25, N'Haptumedover Direct Corp.                                                                           ', N'WM 54 19 66 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (26, N'Thrududegover Holdings Corp.                                                                        ', N'GP 51 18 33 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (27, N'Winkilicator Direct                                                                                 ', N'QA 88 70 64 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (28, N'Tupjubefower Direct Company                                                                         ', N'OY 25 56 91 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (29, N'Rapfropax International                                                                             ', N'RO 73 85 29 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (30, N'Monjubor                                                                                            ', N'KI 48 06 70 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (31, N'Thrubananar Holdings Group                                                                          ', N'QX 77 36 31 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (32, N'Partinefor Holdings                                                                                 ', N'ZB 37 93 18 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (33, N'Thrusapor WorldWide                                                                                 ', N'WA 69 19 11 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (34, N'Emdudepentor WorldWide                                                                              ', N'ID 48 50 75 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (35, N'Haperover  Corp.                                                                                    ', N'ZS 27 15 18 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (36, N'Dopsapupin WorldWide Company                                                                        ', N'XS 32 78 19 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (37, N'Klikilentor                                                                                         ', N'CM 85 00 96 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (38, N'Endnipar Direct Corp.                                                                               ', N'TX 89 31 05 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (39, N'Grosipanex                                                                                          ', N'LH 90 87 11 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (40, N'Hapkilicator WorldWide Group                                                                        ', N'GI 31 29 55 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (41, N'Winrobilicator                                                                                      ', N'CW 38 30 23 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (42, N'Lomfropefex Holdings Inc                                                                            ', N'XD 90 45 86 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (43, N'Cipwerinin                                                                                          ', N'QZ 58 19 58 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (44, N'Bardimazz WorldWide Company                                                                         ', N'SO 98 39 74 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (45, N'Monnipower WorldWide                                                                                ', N'TI 00 62 37 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (46, N'Klivenazz  Corp.                                                                                    ', N'SV 20 53 82 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (47, N'Dopfropupor  Group                                                                                  ', N'YN 64 68 07 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (48, N'Raprobplower                                                                                        ', N'UC 79 93 12 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (49, N'Tiprobor International                                                                              ', N'VB 42 79 31 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (50, N'Hapfropadistor WorldWide Company                                                                    ', N'GZ 66 36 75 ')
INSERT [dbo].[Clients] ([IdClient], [Company], [Cif]) VALUES (51, N'Paquito el Chocolatero                                                                              ', N'BG 43 10 65 ')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (1, N'Nicole Franco                                                                                       ', N'WY 41 19 14 Y')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (2, N'Pablo Terry                                                                                         ', N'DU 14 15 42 L')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (3, N'Desiree Lambert                                                                                     ', N'KY 97 78 95 B')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (4, N'Chadwick Stephenson                                                                                 ', N'ET 38 45 86 D')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (5, N'Daphne Gilbert                                                                                      ', N'NQ 44 91 25 Q')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (6, N'Sonya Mosley                                                                                        ', N'PG 98 09 34 A')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (7, N'Katina Browning                                                                                     ', N'XA 01 84 07 T')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (8, N'Kari Boyd                                                                                           ', N'HB 95 73 11 L')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (9, N'Seth Mc Bride                                                                                       ', N'BB 02 48 96 E')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (10, N'Bernard Knight                                                                                      ', N'TV 21 14 05 M')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (11, N'Devon Fleming                                                                                       ', N'VH 18 51 70 H')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (12, N'Janet Ramos                                                                                         ', N'ZH 90 74 93 M')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (13, N'Jose Velazquez                                                                                      ', N'OH 80 64 16 E')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (14, N'Joshua Conrad                                                                                       ', N'GP 00 93 88 I')
INSERT [dbo].[Vendors] ([Id], [FulName], [Cif]) VALUES (15, N'Cassandra Randall                                                                                   ', N'TS 93 78 26 X')
