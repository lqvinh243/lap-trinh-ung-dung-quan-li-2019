using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Validatior
{
    public abstract class BaseValidator
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public string ErrMess { get; set; }
        public Icon ErrIcon { get => errorProvider.Icon; set => errorProvider.Icon = value; }

        Control Control2Tovalidator;
        [TypeConverter(typeof(ReferenceConverter))]
        public Control Controltovalidate
        {
            get => Control2Tovalidator;
            set
            {
                if (Control2Tovalidator != null && !DesignMode)
                {
                    Control2Tovalidator.Validating -= Control2Tovalidator_Validating;
                }
                Control2Tovalidator = value;
                if (Control2Tovalidator != null && !DesignMode)
                {
                    Control2Tovalidator.Validating += Control2Tovalidator_Validating;
                }
            }
        }

        private void Control2Tovalidator_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate())
            {
                errorProvider.SetError(Control2Tovalidator, ErrMess);
            }
            else
            {
                errorProvider.SetError(Control2Tovalidator, "");
            }
        }

        public bool DesignMode { get; private set; }
        public abstract bool Validate();
    }
}
