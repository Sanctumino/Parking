USE [Parking]
GO
/****** Object:  StoredProcedure [dbo].[CarInfoLoad]    Script Date: 04.10.2016 10:12:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CarInfoLoad]
@PersonID as int
as
begin
	create table #CarInfo
	(
		[Make] nvarchar(20),
		[Model] nvarchar(20),
		[CarNumber] nvarchar(15),
	)

	insert into #CarInfo
			(
			[Make],
			[Model],
			[CarNumber]
			)
		select Make as [Марка], Model as [Модель], CarNumber as [Регистрацонный номер] from Cars where PersonID = @PersonID
	select * from #CarInfo
end
