USE [Parking]
GO

/****** Object:  StoredProcedure [dbo].[AddNewCar]    Script Date: 28.03.2017 13:10:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[AddNewCar]
@PersonID as int,
@Make as nvarchar(30),
@Model as nvarchar(30),
@CarNumber as nvarchar(15)
as
begin
	insert into Cars(PersonID,Make,Model,CarNumber) values (@PersonID,@Make,@Model,@CarNumber)
end


GO

