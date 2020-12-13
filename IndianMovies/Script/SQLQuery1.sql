SET IDENTITY_INSERT [dbo].[UpcomingMovies] ON
INSERT INTO [dbo].[UpcomingMovies] ([UpcomingMovies_Id], [Movie_Name], [Movie_Type], [Release_Date], [Movie_ID], [Movie_objMovie_Id]) VALUES (1, N'Torbazz', N'Action', N'2020-12-23 17:00:00', 10, NULL)
INSERT INTO [dbo].[UpcomingMovies] ([UpcomingMovies_Id], [Movie_Name], [Movie_Type], [Release_Date], [Movie_ID], [Movie_objMovie_Id]) VALUES (2, N'Shakeela', N'Action ', N'2021-06-16 17:01:00', 11, NULL)
INSERT INTO [dbo].[UpcomingMovies] ([UpcomingMovies_Id], [Movie_Name], [Movie_Type], [Release_Date], [Movie_ID], [Movie_objMovie_Id]) VALUES (3, N'Bellbottom', N'Romantic', N'2021-10-10 11:02:00', 12, NULL)
INSERT INTO [dbo].[UpcomingMovies] ([UpcomingMovies_Id], [Movie_Name], [Movie_Type], [Release_Date], [Movie_ID], [Movie_objMovie_Id]) VALUES (4, N'Maidaan', N'Action', N'2021-08-10 08:03:00', 13, NULL)
INSERT INTO [dbo].[UpcomingMovies] ([UpcomingMovies_Id], [Movie_Name], [Movie_Type], [Release_Date], [Movie_ID], [Movie_objMovie_Id]) VALUES (5, N'Golmaal5', N'Comedy', N'2021-09-10 10:04:00', 14, NULL)
INSERT INTO [dbo].[UpcomingMovies] ([UpcomingMovies_Id], [Movie_Name], [Movie_Type], [Release_Date], [Movie_ID], [Movie_objMovie_Id]) VALUES (6, N'Takht', N'Action', N'2021-09-10 02:05:00', 15, NULL)
SET IDENTITY_INSERT [dbo].[UpcomingMovies] OFF


SET IDENTITY_INSERT [dbo].[Ranking] ON
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (1, N'Kick', N'5/5', N'4.4/5', N'3.3/5', 1, NULL)
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (2, N'Boss', N'4/5', N'3/5', N'1/5', 2, NULL)
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (3, N'MS Dhoni', N'5/5', N'4.5/5', N'4/5', 3, NULL)
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (4, N'Kabir Singh', N'5/5', N'4.5/5', N'4.4/5', 4, NULL)
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (5, N'Manje Bistre', N'4/5', N'3/5', N'3.4/5', 5, NULL)
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (6, N'Baahubali', N'5/5', N'5/5', N'4.5/5', 6, NULL)
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (7, N'Carry on Jatta', N'4/5', N'3.2/5', N'2/5', 7, NULL)
SET IDENTITY_INSERT [dbo].[Ranking] OFF


SET IDENTITY_INSERT [dbo].[MoviesCollection] ON
INSERT INTO [dbo].[MoviesCollection] ([Moviescollection_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (1, N'Kick', N'100cr', N'80cr', N'70cr', 20, NULL)
INSERT INTO [dbo].[MoviesCollection] ([Moviescollection_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (2, N'Boss', N'111cr', N'85cr', N'90cr', 21, NULL)
INSERT INTO [dbo].[MoviesCollection] ([Moviescollection_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (3, N'MS Dhoni', N'200cr', N'115cr', N'125cr', 22, NULL)
INSERT INTO [dbo].[MoviesCollection] ([Moviescollection_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (4, N'Kabir Singh', N'350cr', N'200cr', N'175cr', 23, NULL)
INSERT INTO [dbo].[MoviesCollection] ([Moviescollection_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (5, N'Manje Bistre', N'25cr', N'15cr', N'20cr', 24, NULL)
INSERT INTO [dbo].[MoviesCollection] ([Moviescollection_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (6, N'Baahubali', N'1200cr', N'500cr', N'700cr', 25, NULL)
INSERT INTO [dbo].[MoviesCollection] ([Moviescollection_Id], [Movie_Name], [India], [Canada], [Australia], [Movie_ID], [Movie_objMovie_Id]) VALUES (7, N'Carry on Jatta', N'30cr', N'20cr', N'14cr', 26, NULL)
SET IDENTITY_INSERT [dbo].[MoviesCollection] OFF

SET IDENTITY_INSERT [dbo].[Movies] ON
INSERT INTO [dbo].[Movies] ([Movie_Id], [Movie_Name], [Director_Name], [Actor_Name], [Actress_Name], [Release_Date]) VALUES (1, N'Kick', N'Rohit Shetty', N'Salman Khan', N'Katrina Kaif', N'2016-02-09 16:37:00')
INSERT INTO [dbo].[Movies] ([Movie_Id], [Movie_Name], [Director_Name], [Actor_Name], [Actress_Name], [Release_Date]) VALUES (2, N'Boss', N'Rohit Shetty', N'Akshay Kumar', N'Sonakshi Senha', N'2017-05-10 17:39:00')
INSERT INTO [dbo].[Movies] ([Movie_Id], [Movie_Name], [Director_Name], [Actor_Name], [Actress_Name], [Release_Date]) VALUES (3, N'MS Dhoni', N'Neeraj Panday', N'Sushant Singh Rajput', N'Disha Patani', N'2018-03-10 19:41:00')
INSERT INTO [dbo].[Movies] ([Movie_Id], [Movie_Name], [Director_Name], [Actor_Name], [Actress_Name], [Release_Date]) VALUES (4, N'Kabir Singh', N'Sandeep Vanga', N'Shahid Kapoor', N'Kiara Advani', N'2019-01-10 21:46:00')
INSERT INTO [dbo].[Movies] ([Movie_Id], [Movie_Name], [Director_Name], [Actor_Name], [Actress_Name], [Release_Date]) VALUES (5, N'Manje Bistre', N'Gippy Grewal', N'Gippy Grewal', N'Sonam Bajwa', N'2019-07-10 16:48:00')
INSERT INTO [dbo].[Movies] ([Movie_Id], [Movie_Name], [Director_Name], [Actor_Name], [Actress_Name], [Release_Date]) VALUES (6, N'Baahubali', N'S.S Rajamouli', N'Prabhas', N'Anushka Shetty', N'2015-06-10 16:52:00')
INSERT INTO [dbo].[Movies] ([Movie_Id], [Movie_Name], [Director_Name], [Actor_Name], [Actress_Name], [Release_Date]) VALUES (7, N'Carry On jatta', N'Gippy Grewal', N'Gippy Grewal', N'Neeru Bajwa', N'2017-03-10 03:53:00')
SET IDENTITY_INSERT [dbo].[Movies] OFF
