USE [Parking]
GO

Create Procedure [dbo].[FreeParkingPlace]
@PersonID as int,
@DateFrom as date,
@DateTo as date
as
begin
	update Persons
	set LeaveDateFrom = @DateFrom, LeaveDateTo = @DateTo
	where ID = @PersonID
end

go
