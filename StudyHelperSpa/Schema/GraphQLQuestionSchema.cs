using System;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace StudyHelperSpa.Schema
{
    public class GraphQLQuestionSchema : GraphQL.Types.Schema, ISchema
    {
        public GraphQLQuestionSchema(IServiceProvider
        provider) : base(provider)
        {
            Query = provider.GetRequiredService<QuestionQuery>();
        }
    }
}
