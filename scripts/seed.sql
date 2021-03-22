use LMS

declare @index int = 0

while (@index < 100000)
begin
	insert into Courses(Id, Name, Description, StartDate, EndDate)
	values (NEWID(), 'Course' + CONVERT(varchar, @index), 'Descrition of course'  + CONVERT(varchar, @index), '2021-09-01', '2021-12-31')

	set @index = @index + 1
end
