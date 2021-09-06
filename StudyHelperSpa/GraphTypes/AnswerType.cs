using System;
using StudyHelperSpa.Models;
using GraphQL.Types;
namespace StudyHelperSpa.GraphTypes
{
    public class AnswerType : ObjectGraphType<Answer>
    {
        public AnswerType()
        {
            Name = nameof(Answer);
            Field(_ => _.Id).Description("Answer Id");
            Field(_ => _.Text).Description("Text of the answer");
        }
    }
}
