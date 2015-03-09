CREATE TABLE [dbo].[MembershipUserQuestionAnswerLink]
(
	[Id] INT NOT NULL IDENTITY , 
    [UserId] INT NOT NULL, 
    [QuestionAnswerId] INT NOT NULL, 
    CONSTRAINT [PK_MembershipQuestionsAndAnswers] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_MembershipQuestionsAndAnswers_ToUser] FOREIGN KEY ([UserId]) REFERENCES MembershipUser(Id), 
    CONSTRAINT [FK_MembershipQuestionsAndAnswers_ToQuestions] FOREIGN KEY ([QuestionAnswerId]) REFERENCES MembershipQuestionAnswer(Id)
)
