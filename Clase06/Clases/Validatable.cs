using Clase06.Objetos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Clases
{
    public class Validatable : IValidatable
    {
        public bool HasErrors => throw new NotImplementedException();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public void ClearErrors()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<ValidationResult> GetAllErrors()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<ValidationResult> GetErrors()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<ValidationResult> GetErrors(string propertyName)
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
