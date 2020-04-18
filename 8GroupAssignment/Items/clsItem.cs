using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8GroupAssignment.Items
{
    class clsItem : INotifyPropertyChanged
    {
        /// <summary>
        /// string to hold the Code of the item
        /// </summary>
        private string sCode;
        /// <summary>
        /// float to hold the Cost of the item
        /// </summary>
        private float sCost;
        /// <summary>
        /// string to hold the description of the item
        /// </summary>
        private string sDescription;

        /// <summary>
        /// public property to access the sCode variable
        /// </summary>
        public string Code
        {
            get
            {
                return sCode;
            }
            set
            {
                if (sCode != null) {
                    return;
                }

                sCode = value;
                
            }
        }

        /// <summary>
        /// public property toa access the fCost variable
        /// </summary>
        public float Cost
        {
            get
            {
                return sCost;
            }
            set
            {
                //check input for format

                bool wasNull = sCost == 0;
                sCost = value;

                if (Code == null)
                {
                    return;
                }
                if (!wasNull && PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Cost"));
                }
            }
        }

        /// <summary>
        /// public variable to access the sDescription variable
        /// </summary>
        public string Description
        {
            get
            {
                return sDescription;
            }
            set
            {
                bool wasNull = sDescription == null;
                sDescription = value;

                if (Code == null)
                {
                    return;
                }

                if (!wasNull && PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Code"));
                }
            }
        }

        /// <summary>
        /// event handler for when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
