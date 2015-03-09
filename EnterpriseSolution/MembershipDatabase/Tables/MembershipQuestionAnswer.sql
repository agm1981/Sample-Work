CREATE TABLE [dbo].[MembershipQuestionAnswer]
(
	[Id] INT NOT NULL IDENTITY , 
    [Question] NVARCHAR(50) NOT NULL, 
    [Answer] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_MembershipQuestionAnswer] PRIMARY KEY ([Id]) 
)
