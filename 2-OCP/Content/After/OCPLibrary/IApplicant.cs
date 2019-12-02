namespace OCPLibrary
{
    public interface IApplicant
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccountService Processor { get; set; }
}
}