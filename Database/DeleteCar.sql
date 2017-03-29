USE [Parking]
GO

CREATE Procedure [dbo].[DeleteCar]
@ID as int
as
begin
	delete from [Cars]
	where ID = @ID
end

GO
