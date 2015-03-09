CREATE TABLE [dbo].[MembershipUser]
(
	[Id] INT NOT NULL IDENTITY , 
    [UserName] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [LastLoggedDate] DATETIME NULL, 
    CONSTRAINT [PK_MembershipUser] PRIMARY KEY ([Id])
)

GO

CREATE UNIQUE INDEX [IX_MembershipUser_Column] ON [dbo].[MembershipUser] ([UserName])
