set xact_abort on


declare @coursesIndex int = 1,
		@courseId uniqueidentifier,
		@chapterId uniqueidentifier,
		@chapterNumber int,
		@pageId  uniqueidentifier,
		@pageNumber int,
		@sectionId  uniqueidentifier	

while (@coursesIndex <= 50)
begin
	set @courseId = NEWID()
	insert into Courses(Id, Name, Description, StartDate, EndDate)
	values (@courseId, 'Course' + CONVERT(varchar, @coursesIndex), 'Descrition of course'  + CONVERT(varchar, @coursesIndex), '2021-09-01', '2021-12-31')

	set @chapterNumber = 1
	while (@chapterNumber <= 10)
	begin
		
		set @chapterId = NEWID()
		insert into Chapters(Id, CourseId, Number, Title)
		values (@chapterId, @courseId, @chapterNumber, 'Chapter' +  CONVERT(varchar, @chapterNumber))

		set @pageNumber = 1

		while (@pageNumber <= 10)
		begin

			set @pageId = NEWID()

			insert into Pages(Id, ChapterId, Title)
			values (@pageId, @chapterId, 'Page' +  CONVERT(varchar, @pageNumber))

			set @pageNumber = @pageNumber + 1
		end

		set @chapterNumber = @chapterNumber + 1
	end

	set @coursesIndex = @coursesIndex + 1
end
