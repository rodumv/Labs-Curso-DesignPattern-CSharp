namespace OCPLibrary
{
    public class AccountService : IAccountService
    {
        public Staff Create(IApplicant person)
        {
            Staff newStaff = new Staff();
            newStaff.FirstName = person.FirstName;
            newStaff.LastName = person.LastName;
            newStaff.Email = $"{person.FirstName}.{person.LastName}@staff.com";

            return newStaff;
        }
    }
}
