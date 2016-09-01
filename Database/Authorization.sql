USE [Parking]
GO

/****** Object:  StoredProcedure [dbo].[Authorization]    Script Date: 01.09.2016 17:46:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[Authorization]
@Username as nvarchar(30),
@Password as nvarchar(30)
as
begin
declare @PersonID int, @RoleID int
	create table #UserParameters
	(
		[ID] nvarchar(3),
		[Role] tinyint,
		[Error] nvarchar(50)
	)
set @PersonID = (select PersonID from Users where Login = @Username and Password = @Password)
if @PersonID is null
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
		set @RoleID = (select RoleID from Users where PersonID = @PersonID)
		insert into #UserParameters
			(
			[ID],
			[Role],
			[Error]
			)
		values (@PersonID,@RoleID,NULL)
	end 
	select * from #UserParameters
end


GO

