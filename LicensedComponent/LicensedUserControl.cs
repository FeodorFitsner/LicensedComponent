using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LicensedComponent
{
    [LicenseProvider(typeof(MyLicFileLicenseProvider))]
    public class LicensedUserControl : UserControl
    {
        private License _license;
        private Label _lblText;

        public LicensedUserControl()
        {
            InitializeComponent();
            _license = LicenseManager.Validate(typeof(LicensedUserControl), this);
            _lblText.Text = _license.LicenseKey;
        }

        private void InitializeComponent()
        {
            _lblText = new Label();
            SuspendLayout();

            _lblText.Dock = DockStyle.Fill;
            _lblText.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(_lblText);
            Size = new Size(400, 250);

            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (_license != null)
            {
                _license.Dispose();
                _license = null;
            }
            base.Dispose(disposing);
        }
    }
}
