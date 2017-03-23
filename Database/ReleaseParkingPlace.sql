USE [Parking]
GO

/****** Object:  StoredProcedure [dbo].[ReleaseParkingPlace]    Script Date: 06.02.2017 21:23:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ReleaseParkingPlace]
@PersonID as int
as
begin
	update Persons
	set ReleaseFlag = 1 where ID = @PersonID
end


GO

