using System;

namespace OCPLibrary
{
    public class Doctor : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IAccountService Processor { get; set; } = new AccountDoctor();

    }
}
