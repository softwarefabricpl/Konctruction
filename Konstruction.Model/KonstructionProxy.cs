using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model
{
    public class KonstructionProxy : IDisposable
    {

        // Define the object context to be provided. 
        private KonstructionEntities contextProxy = new KonstructionEntities();

        public KonstructionProxy()
        {
        }

        // Method that provides an object context. 
        public KonstructionEntities Context
        {
            get
            {
                return contextProxy;
            }
            set { }
        }

        public void Dispose()
        {
            if (this.Context != null)
            {
                Context.Dispose();
                Context = null;
            }
        }
    }
}
