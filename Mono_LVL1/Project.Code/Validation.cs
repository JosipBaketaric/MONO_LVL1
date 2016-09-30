using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    class Validation
    {
        private bool isValid;

        public Validation()
        {
            isValid = false;
        }

        public bool validateOperation(String operationString)
        {
            isValid = true;
            operationString = operationString.ToUpper();

            if(!operationString.Equals(Operations.display) && !operationString.Equals(Operations.enlist))
            {
                isValid = false;
            }

            return isValid;
        }

        public bool validateStrings(String firstName, String lastName)
        {
            isValid = true;

            if(firstName.Equals("") || firstName == null || lastName.Equals("") || lastName == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public bool validateGpa(String gpa)
        {
            isValid = true;
            float number;

            isValid = float.TryParse(gpa, out number);

            if (!isValid)
            {
                return isValid;
            }

            if(number < 1 || number > 5)
            {
                isValid = false;
                return isValid;
            }

            return isValid;
        }

    }
}
