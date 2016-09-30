using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Validation
    {
        private static Validation instance = null;

        private Validation() { }

        public static Validation getInstance()
        {
            if(instance == null)
            {
                instance = new Validation();
                return instance;
            }
            return instance;
        }

        public string validateOperation(String operationString)
        {
            if(operationString.Equals("") || operationString == null)
            {
                return Operations.noValueMessageError;
            }

            operationString = operationString.ToUpper();

            if(!operationString.Equals(Operations.display) && !operationString.Equals(Operations.enlist))
            {
                return Operations.nonExistingOperationError;
            }

            return Operations.validationOK;
        }

        public string validateStrings(String name)
        {

            if(name.Equals("") || name == null )
            {
                return Operations.noValueMessageError;
            }

            return Operations.validationOK;
        }

        public string validateGpa(String gpa)
        {
            float number;

            if(gpa.Equals("") || gpa == null)
            {
                return Operations.noValueMessageError;
            }

            bool isNumber = float.TryParse(gpa, out number);

            if (!isNumber)
            {
                return Operations.gpaIsStringError;
            }

            if(number < 1 || number > 5)
            {
                return Operations.gpaNotInRangeError;
            }

            return Operations.validationOK;
        }

    }
}
