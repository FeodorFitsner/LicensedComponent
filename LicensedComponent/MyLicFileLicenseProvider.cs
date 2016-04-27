using System.ComponentModel;

namespace LicensedComponent
{
    public class MyLicFileLicenseProvider : LicFileLicenseProvider
    {
        private const string LicenseKeyFormat = "{0} license key: {1}";

        // this key makes you a billionaire, so keep it safe...
        private const string LicenseKey = "{2EDE0218-0996-41D8-9E32-6066F248A215}";

        protected override string GetKey(System.Type type)
        {
            string formattedLicenseKey = string.Format(LicenseKeyFormat, type.FullName, LicenseKey);
            return formattedLicenseKey;
        }
    }
}