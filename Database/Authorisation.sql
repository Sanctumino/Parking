USE [Parking]
GO

/****** Object:  StoredProcedure [dbo].[Authorization]    Script Date: 25.08.2016 18:05:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[Authorization]
@Username as nvarchar(30),
@Password as nvarchar(30)

as
begin
declare @errorMessage nvarchar(50)	
	create table #UserParameters
	(
		[ID] nvarchar(3),
		[Role] tinyint,
		[Error] nvarchar(50)
	)
if (select PersonID from Users where Login = @Username and Password = @Password) is null
begin
		insert into #UserParameters
			(
			[ID],
			[Role],
			[Error]
			)
		values (NULL,NULL,'Неверный логин или пароль')
	end

else
	begin
	insert into #UserParameters
			(
			[Place],
			[Status],
			[DateFrom],
			[DateTo]
			)
		select * from Persons

end end

GO

