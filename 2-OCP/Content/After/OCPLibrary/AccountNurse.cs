namespace OCPLibrary
{
    public class AccountNurse : IAccountService
    {
        public Staff Create(IApplicant person)
        {
            Staff newStaff = new Staff();
            newStaff.FirstName = person.FirstName;
            newStaff.LastName = person.LastName;
            newStaff.Email = $"{person.FirstName}.{person.LastName}@nurse.com";

            return newStaff;
        }
    }
}
