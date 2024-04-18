using GraphQL.Domain.Entities;
 

namespace GraphQL.Infrastructure.GraphQl
{
    //public class AccountType : ObjectGraphType<Account>
    //{
    //    public AccountType()
    //    {
    //        Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the account object.");
    //        Field(x => x.Description).Description("Description property from the account object.");
    //        Field(x => x.OwnerId, type: typeof(IdGraphType)).Description("OwnerId property from the account object.");
    //        Field<AccountTypeEnumType>("Type", "Enumeration for the account type object.");
    //    }
    //}
    public class Query
    {
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Account> Accounts([Service] ApplicationContext context) => context.Accounts;

    }
}