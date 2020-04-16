namespace ScanStoreService.Features.Profiles
{
    public class ProfileEnvelope
    {
        public ProfileEnvelope(Profile profile)
        {
            Profile = profile;
        }

        public Profile Profile { get; set; }
    }
}