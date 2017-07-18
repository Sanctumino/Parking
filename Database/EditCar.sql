USE [Parking]
GO
/****** Object:  StoredProcedure [dbo].[EditCar]    Script Date: 28.03.2017 18:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[EditCar]
@ID as int,
@Make as nvarchar(30),
@Model as nvarchar(30),
@CarNumber as nvarchar(15)
as
begin
	update Cars
	set 
		Make = @Make,
		Model = @Model,
		CarNumber = @CarNumber
	where ID = @ID
end
