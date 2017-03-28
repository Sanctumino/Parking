use Parking 
go

Create Procedure [dbo].[EditCar]
@PersonID as int,
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
	where PersonID = @PersonID
end
