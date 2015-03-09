CREATE TABLE [dbo].[MembershipUserRoleLink]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [RoleId] INT NOT NULL, 
    CONSTRAINT [PK_MembershipUserRoleLink] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_MembershipUserRoleLink_ToUser] FOREIGN KEY ([UserId]) REFERENCES MembershipUser(Id) ,
	CONSTRAINT [FK_MembershipUserRoleLink_ToRole] FOREIGN KEY ([RoleId]) REFERENCES MembershipRole(Id) 
)

GO

CREATE INDEX [IX_MembershipUserRoleLink_UserId] ON [dbo].[MembershipUserRoleLink] ([UserId])

GO

CREATE UNIQUE INDEX [IX_MembershipUserRoleLink_RoleUserId] ON [dbo].[MembershipUserRoleLink] ([UserId],[RoleId])
