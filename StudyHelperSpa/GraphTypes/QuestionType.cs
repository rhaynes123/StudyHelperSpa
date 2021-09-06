using System;
using StudyHelperSpa.Models;
using GraphQL.Types;

namespace StudyHelperSpa.GraphTypes
{
    public class QuestionType : ObjectGraphType<Question>
    {
        public QuestionType()
        {
            Name = nameof(Question);
            Field(_ => _.Id).Description("Question Id");
            Field(_ => _.Text).Description("Text of the question");
        }
    }
}
