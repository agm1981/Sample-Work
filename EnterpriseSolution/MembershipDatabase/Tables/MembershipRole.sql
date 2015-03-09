CREATE TABLE [dbo].[MembershipRole]
(
	[Id] INT NOT NULL IDENTITY , 
    [Name] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_MembershipRole] PRIMARY KEY ([Id])
)
