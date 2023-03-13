CREATE DATABASE Hostel;
GO
USE Hostel
GO

--Таблица Кафедры
CREATE TABLE Departments
(
	DepartmentId INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(100) NOT NULL
	CONSTRAINT PK_Departments_DepartmentsId PRIMARY KEY(DepartmentId),
	CONSTRAINT CK_Departments_Name CHECK ([Name]<>''),
	CONSTRAINT UQ_Departments_Name UNIQUE ([Name])
);
GO

--Таблица групп
CREATE TABLE Groups
(
	GroupId INT NOT NULL IDENTITY(1,1),
	DepartmentId INT NOT NULL,
	[Name] VARCHAR(100) NOT NULL
	CONSTRAINT PK_Groups_GroupId PRIMARY KEY(GroupId),
	CONSTRAINT CK_Groups_Name CHECK ([Name]<>''),
);
GO

--Пользователи
CREATE TABLE Users
(
	UserId INT NOT NULL IDENTITY(1,1),
	[FullName] VARCHAR(100) NOT NULL,
	TelNumber VARCHAR(50) NOT NULL,
	[Password] VARCHAR(15) NOT NULL, 
	CONSTRAINT PK_Users_UserId PRIMARY KEY (UserId),
	CONSTRAINT CK_Users_FullName CHECK ([FullName]<>'')
);
GO

--ПользователиГруппа
CREATE TABLE UsersGroup
(
	UserId INT NOT NULL,
	GroupId INT NOT NULL
	CONSTRAINT PK_UsersGroup_UserId_GroupId PRIMARY KEY(UserId,GroupId)
);
GO

--Таблица студентов
CREATE TABLE Students
(
	StudentId INT NOT NULL IDENTITY(1,1),
	FullName VARCHAR(50) NOT NULL,
	DateOfBirth DATE NOT NULL,
	TelNumber VARCHAR(100) NOT NULL,
	Sex BIT NOT NULL,
	GroupId INT NOT NULL,
	Photo VARBINARY(MAX)
	CONSTRAINT PK_Student_StudentId PRIMARY KEY(StudentId),
	CONSTRAINT CK_Student_FullName CHECK ([FullName]<>'')
);
GO

--Типы комнат
CREATE TABLE TypeRooms
(
	TypeRoomId INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(50) NOT NULL,
	DateSettlement DATETIME NOT NULL,
	CONSTRAINT PK_TypeRooms_TypeRoomsId PRIMARY KEY (TypeRoomId),
	CONSTRAINT CK_TypeRooms_Name CHECK ([Name]<>''),
	CONSTRAINT UQ_TypeRooms_Name UNIQUE ([Name])
);
GO

--Таблица комнат
CREATE TABLE Rooms
(
	RoomId INT NOT NULL IDENTITY(1,1),
	TypeRoomId INT NOT NULL,
	Number VARCHAR(10) NOT NULL, --Номер комнаты
	FloorApartment INT NOT NULL, --Номер этажа
	NumberBeds INT NOT NULL, --Количество койко-мест
	CONSTRAINT PK_Rooms_RoomsId PRIMARY KEY (RoomId),
	CONSTRAINT CK_Rooms_FullName CHECK ([Number]<>''),
	CONSTRAINT CK_Rooms_FloorApartment CHECK (FloorApartment BETWEEN 1 AND 10),
	CONSTRAINT CK_Rooms_NumberBeds CHECK (NumberBeds BETWEEN 1 AND 16)
);
GO
--Комнаты студенты
CREATE TABLE RoomsStudents
(
	StudentId INT NOT NULL,
	RoomId INT NOT NULL,
	DateSettlement DATE NOT NULL
	CONSTRAINT PK_RoomsStudents_StudentId PRIMARY KEY(StudentId)
);
GO
--История выселения студентов
CREATE TABLE HistoryEvictionsStudent
(
	RecordId INT NOT NULL IDENTITY(1,1),
	FullName VARCHAR(50) NOT NULL,
	TelNumber VARCHAR(100) NOT NULL,
	NumberRoom VARCHAR(10) NOT NULL, --Номер комнаты
	DateEviction DATETIME NOT NULL
	CONSTRAINT PK_RecordId PRIMARY KEY(RecordId)
);
GO

--Связи между таблицами
ALTER TABLE Groups
ADD CONSTRAINT FK_GroupsDepartments FOREIGN KEY (DepartmentId) REFERENCES Departments(DepartmentId);
GO

ALTER TABLE UsersGroup
ADD CONSTRAINT FK_UsersGroup_UserId FOREIGN KEY (UserId) REFERENCES Users(UserId),
	CONSTRAINT FK_UsersGroup_GroupId FOREIGN KEY (GroupId) REFERENCES Groups(GroupId);
GO

ALTER TABLE Students
ADD CONSTRAINT FK_Students_GroupId FOREIGN KEY (GroupId) REFERENCES Groups(GroupId);
GO

ALTER TABLE Rooms
ADD CONSTRAINT FK_Rooms_RoomId FOREIGN KEY (TypeRoomId) REFERENCES TypeRooms (TypeRoomId);
GO

ALTER TABLE RoomsStudents
ADD CONSTRAINT FK_RoomsStudents_RoomId FOREIGN KEY (RoomId) REFERENCES Rooms (RoomId);
GO

ALTER TABLE RoomsStudents
ADD CONSTRAINT FK_RoomsStudents_StudentId FOREIGN KEY (StudentId) REFERENCES Students (StudentId);
GO


--Процедуры
--Просмотр информации о пользвателях
CREATE PROCEDURE up_sel_getUsers
AS
SELECT UserId, [FullName], TelNumber
FROM Users
ORDER BY 2;
GO
--Просмотр информации о кафедрах
CREATE PROCEDURE up_sel_getDepartments
AS
SELECT [Name] AS InfoName
FROM Departments
ORDER BY 1;
GO
--Просмотр информации о типах комнат
CREATE PROCEDURE up_sel_getTypeRooms
AS
SELECT [Name] AS InfoName
FROM TypeRooms
ORDER BY 1;
GO
--Просмотр информации о комнатах
CREATE PROCEDURE up_sel_getInfoRooms
AS
SELECT r.RoomId, tr.[Name] AS TypeRoomName, r.Number, r.FloorApartment, r.NumberBeds
FROM Rooms r
INNER JOIN TypeRooms tr ON r.TypeRoomId=tr.TypeRoomId;
GO
--Просморт информации о Группах
CREATE PROCEDURE up_sel_getInfoGroup
AS
SELECT g.GroupId, g.[Name] AS [Group name], d.[Name] AS [Department name], u.FullName AS [Curator group], u.TelNumber AS [Tel number] 
FROM Groups g
INNER JOIN Departments d ON g.DepartmentId=d.DepartmentId
LEFT JOIN UsersGroup ug ON g.GroupId=ug.GroupId
LEFT JOIN Users u ON ug.UserId=u.UserId;
GO
--Проверка логина и пароля
CREATE PROCEDURE [dbo].[up_sel_checkPasswordUser]
@UserName VARCHAR(50), @Password VARCHAR(15), @AuthenticationPassed BIT OUT, @LineAnswer VARCHAR(1000)='' OUT
AS
BEGIN
DECLARE @PasswordUser VARCHAR(15) = '';
IF NOT EXISTS(SELECT * FROM Users WHERE FullName=@UserName AND Password=@Password)
BEGIN
 SET @LineAnswer='Не корректное имя пользователя или пароль'
 SET @AuthenticationPassed = 0;
END
ELSE
BEGIN
 SET @LineAnswer='Аутентификация пройдена'
 SET @AuthenticationPassed = 1;
END
END;
GO
--Карточка студента
ALTER PROCEDURE up_sel_StudentCard
@StudentId INT
AS
BEGIN
 SELECT s.StudentId, s.FullName,s.TelNumber, CASE WHEN s.Sex=0 THEN 'ЖЕН.' ELSE 'МУЖ.' END AS Sex, s.DateOfBirth,
 g.[Name] AS [Group], r.Number AS NumberRoom, rs.DateSettlement, tr.[Name] AS TypeNameRoom, s.Photo
 FROM Students s
 INNER JOIN Groups g ON s.GroupId=g.GroupId
 INNER JOIN Departments d ON g.DepartmentId=d.DepartmentId
 LEFT JOIN RoomsStudents rs ON s.StudentId=rs.StudentId
 LEFT JOIN Rooms r ON rs.RoomId=r.RoomId
 LEFT JOIN TypeRooms tr ON r.TypeRoomId=tr.TypeRoomId
 WHERE s.StudentId=@StudentId
END;
GO

--Информация о студентах
ALTER PROCEDURE up_sel_InfoStudent
AS
BEGIN
 SELECT s.StudentId, s.FullName,s.TelNumber, CASE WHEN s.Sex=0 THEN 'ЖЕН.' ELSE 'МУЖ.' END AS Sex, s.DateOfBirth,
 d.[Name] AS Department, g.[Name] AS [Group], r.Number AS NumberRoom, rs.DateSettlement, tr.[Name] AS TypeNameRoom
 FROM Students s
 INNER JOIN Groups g ON s.GroupId=g.GroupId
 INNER JOIN Departments d ON g.DepartmentId=d.DepartmentId
 LEFT JOIN RoomsStudents rs ON s.StudentId=rs.StudentId
 LEFT JOIN Rooms r ON rs.RoomId=r.RoomId
 LEFT JOIN TypeRooms tr ON r.TypeRoomId=tr.TypeRoomId
END;
GO
--Просмотр информации о выселенных студентах
CREATE PROCEDURE up_sel_InfoEvictionStudent
AS
BEGIN
 SELECT *
 FROM HistoryEvictionsStudent
END;
GO
SELECT *
FROM TypeRooms
--Заселить, изменить данные, выселить студента
ALTER PROCEDURE up_upd_AddEditDeleteStudentRoom
@Action INT, @StudentId INT, @RoomId INT, @DateSettlement DATETIME, @LineAnswer VARCHAR(1000)='' OUT
AS
SET @LineAnswer=''
BEGIN
 IF @Action=0
 BEGIN
  IF EXISTS(SELECT * FROM RoomsStudents rs 
			INNER JOIN Students s ON rs.StudentId=s.StudentId
			WHERE s.StudentId=@StudentId AND rs.DateSettlement=@DateSettlement) SET @LineAnswer='Данный студент уже заселен в комнату.'
  IF EXISTS(SELECT * FROM Rooms r
			INNER JOIN TypeRooms tr ON r.TypeRoomId=tr.TypeRoomId
			WHERE r.RoomId=@RoomId AND tr.TypeRoomId=1) AND EXISTS(SELECT * 
																   FROM Students s 
																   WHERE StudentId=@StudentId AND s.Sex=0) SET @LineAnswer='Не возможно заседить девушку в мужскую комнату.'
  IF EXISTS(SELECT * FROM Rooms r
			INNER JOIN TypeRooms tr ON r.TypeRoomId=tr.TypeRoomId
			WHERE r.RoomId=@RoomId AND tr.TypeRoomId=2) AND EXISTS(SELECT * 
																   FROM Students s 
																   WHERE StudentId=@StudentId AND s.Sex=1) SET @LineAnswer='Не возможно мужчину в женскую комнату'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT RoomsStudents (StudentId, RoomId, DateSettlement)
   VALUES (@StudentId, @RoomId, @DateSettlement)
   IF @@ERROR=0 AND @@ROWCOUNT>0
   BEGIN
    COMMIT TRAN
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
   END
  END
 END
 ELSE
 IF @Action>0
 BEGIN
  IF EXISTS(SELECT * FROM RoomsStudents rs 
			WHERE rs.StudentId=@StudentId AND rs.RoomId=@RoomId AND rs.DateSettlement=@DateSettlement) SET @LineAnswer='Студент уже заселен в выбранную Вами комнату.'
  IF EXISTS(SELECT * FROM Rooms r
			INNER JOIN TypeRooms tr ON r.TypeRoomId=tr.TypeRoomId
			WHERE r.RoomId=@RoomId AND tr.TypeRoomId=1) AND EXISTS(SELECT * 
																   FROM Students s 
																   WHERE StudentId=@StudentId AND s.Sex=0) SET @LineAnswer='Не возможно заседить девушку в мужскую комнату.'
  IF EXISTS(SELECT * FROM Rooms r
			INNER JOIN TypeRooms tr ON r.TypeRoomId=tr.TypeRoomId
			WHERE r.RoomId=@RoomId AND tr.TypeRoomId=2) AND EXISTS(SELECT * 
																   FROM Students s 
																   WHERE StudentId=@StudentId AND s.Sex=1) SET @LineAnswer='Не возможно мужчину в женскую комнату'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE RoomsStudents SET RoomId=@RoomId, DateSettlement=@DateSettlement WHERE StudentId=@StudentId AND NOT(RoomId=@RoomId AND DateSettlement=@DateSettlement)
   IF @@ERROR=0 AND @@ROWCOUNT>0
   BEGIN
    COMMIT TRAN
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
   END
  END
 END
 ELSE
 IF @Action<0
 BEGIN
  DELETE FROM RoomsStudents WHERE StudentId=@StudentId
 END
END;
GO
--Триггеры
CREATE TRIGGER tg_RoomsStudentsDelete
ON RoomsStudents
AFTER DELETE
AS
BEGIN
 INSERT HistoryEvictionsStudent(FullName, TelNumber, NumberRoom, DateEviction)
 SELECT s.FullName, s.TelNumber, r.Number, GETDATE() AS DateEviction
 FROM deleted d
 INNER JOIN Rooms r ON d.RoomId=r.RoomId
 INNER JOIN Students s ON d.StudentId=s.StudentId
END

/*Заполнение таблиц тестовыми данными*/
INSERT Departments ([Name])
VALUES ('Разработка программного обеспечения');
GO
INSERT Groups (DepartmentId, [Name])
VALUES (1, 'БВ112');
GO
INSERT INTO TypeRooms ([Name])
VALUES ('Мужская'),
	   ('Женская');
GO
INSERT INTO Rooms (TypeRoomId, Number, FloorApartment, NumberBeds)
VALUES (1, '123A', 1, 3),
	   (1, '124A', 1, 5),
	   (1, '125A', 1, 2),
	   (1, '126A', 1, 10),
	   (1, '127A', 1, 7),
	   (1, '128A', 1, 2),
	   (2, '130A', 1, 4);
GO
INSERT Students (FullName, DateOfBirth, TelNumber, Sex, GroupId, Photo)
VALUES ('Тухтаров М.Р.', '19880703', '11-11-11', 1, 1, NULL),
	   ('Гулюгина Д.С.', '19990101', '22-22-22', 0, 1, NULL),
	   ('Пономаренко М.Б.', '19990101', '33-33-33', 1, 1, NULL),
	   ('Кубиковский Д.С.', '19990101', '44-44-44', 1, 1, NULL),
	   ('Зорин И.Ю.', '19990101', '55-55-55', 1, 1, NULL),
	   ('Рудяченко И.К.', '19990101', '66-66-66', 1, 1, NULL),
	   ('Гордей А.А.', '19990101', '77-77-77', 1, 1, NULL);
GO
/*Фото*/
UPDATE Students SET Photo=(SELECT * FROM OPENROWSET( Bulk 'C:\Photo\Pirat.jpg', Single_Blob) as EmployeePicture) WHERE StudentId=1;
GO
UPDATE Students SET Photo=(SELECT * FROM OPENROWSET( Bulk 'C:\Photo\Robot3.jpg', Single_Blob) as EmployeePicture) WHERE StudentId=3;
GO
UPDATE Students SET Photo=(SELECT * FROM OPENROWSET( Bulk 'C:\Photo\Robot4.jpg', Single_Blob) as EmployeePicture) WHERE StudentId=4;
GO
UPDATE Students SET Photo=(SELECT * FROM OPENROWSET( Bulk 'C:\Photo\Robot5.jpg', Single_Blob) as EmployeePicture) WHERE StudentId=5;
GO
UPDATE Students SET Photo=(SELECT * FROM OPENROWSET( Bulk 'C:\Photo\Robot6.jpg', Single_Blob) as EmployeePicture) WHERE StudentId=6;
GO
UPDATE Students SET Photo=(SELECT * FROM OPENROWSET( Bulk 'C:\Photo\Robot7.jpg', Single_Blob) as EmployeePicture) WHERE StudentId=7;
GO
UPDATE Students SET Photo=null WHERE StudentId=2;
GO

INSERT Users (FullName, TelNumber, Password)
VALUES ('Иванов И.И.','33-33-33', '12345678'),
	   ('Малышев Ю.А.','12-34-56', '12345678');
GO

INSERT INTO UsersGroup (UserId, GroupId)
VALUES (2, 1);
GO

INSERT INTO RoomsStudents (StudentId, RoomId, DateSettlement)
VALUES (1, 1, '20230101'),
	   (2, 7, '20230102'),
	   (3, 2, '20230103'),
	   (4, 3, '20230104'),
	   (5, 4, '20230105'),
	   (6, 5, '20230106'),
	   (7, 6, '20230107');
GO;


ALTER PROCEDURE [dbo].[up_sel_sendStudentCardEmail]
@StudentId INT, @IndexDocumentFormat INT=0, @Address VARCHAR(100), @MessageSubject VARCHAR(50), @MessageBoby VARCHAR(1000), @LineAnswer VARCHAR(1000)='' out
AS
SET @LineAnswer=''

DECLARE @URL NVARCHAR(MAX)='http://laptop-fo5qin3i:4863/ReportServer/Pages/ReportViewer.aspx?%2fInformation%2fCardStudent&StudentId='+CAST(@StudentId AS VARCHAR(10)),
@NameDocument nvarchar(100)='Card student',
@Path nvarchar(50)='C:\Export\',
@FileExtension VARCHAR(3)=CASE WHEN @IndexDocumentFormat=1 THEN 'docx'
						       WHEN @IndexDocumentFormat=2 THEN 'doc'
						       WHEN @IndexDocumentFormat=3 THEN 'xlsx'
						       WHEN @IndexDocumentFormat=4 THEN 'xls'
						       WHEN @IndexDocumentFormat=5 THEN 'pptx'
						       WHEN @IndexDocumentFormat=6 THEN 'pdf'
						       ELSE 'pdf'
						   END, @R BIT

SET @NameDocument = @Path + @NameDocument + '.' + @FileExtension
IF @LineAnswer=''
BEGIN
 SELECT @R=dbo.[CLR_DownloadFilePortal](@URL,@IndexDocumentFormat,@Path)
 IF @R=1
 BEGIN
  EXEC msdb.dbo.sp_send_dbmail
       -- Созданный нами профиль администратора почтовых рассылок
	   @profile_name = 'WorkMail',
       -- Адрес получателя
	   @recipients=@Address,
       -- Тема
	   @subject = @MessageSubject,
       -- Текст письма
	   @body = @MessageBoby,
       --Важность
	   @importance='HIGH',
       --Вложения
	   @file_attachments = @NameDocument
 END
 ELSE
 BEGIN
  RETURN -1
  SET @LineAnswer='Ошибка при формировании файла '+@NameDocument
 END
END
ELSE
BEGIN
 RETURN -1
 SET @LineAnswer='Ошибка при формировании файла '+@NameDocument
END

