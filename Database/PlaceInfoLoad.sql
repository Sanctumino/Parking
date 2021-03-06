USE [Parking]
GO
/****** Object:  StoredProcedure [dbo].[PlaceInfoLoad]    Script Date: 03.10.2016 17:39:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[PlaceInfoLoad]
@PersonID as int
as
begin
	create table #TempInfo
	(
		[Place] nvarchar(12),
		[Status] nvarchar(10),
		[DateFrom] date,
		[DateTo] date
	)

if (select PlaceID from Persons where ID = @PersonID) is null 
	begin
		insert into #TempInfo
			(
			[Place],
			[Status],
			[DateFrom],
			[DateTo]
			)
		values	('Отсутствует','',NULL,NULL)
	end

else
	begin
	insert into #TempInfo
			(
			[Place],
			[Status],
			[DateFrom],
			[DateTo]
			)
		select ps.PlaceID, pls.Description, pl.DateFrom, pl.DateTo from Places pl join Persons ps on ps.PlaceID = pl.ID join PlaceStatuses pls on pl.StatusID = pls.ID where ps.ID = @PersonID 
	end	
	select * from #TempInfo
end
