using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace EnvironmentVariable
{
    public class GetEnvironmentVariable : CodeActivity
    {

        [Category("Input")]
        public InArgument<string> Variable { get; set; }
        [Category("Output")]
        public OutArgument<string> ResultVariable { get; set; }


        protected override void Execute(CodeActivityContext context)
        {
            string name = Environment.GetEnvironmentVariable(Variable.Get(context));

            string result = name;

            ResultVariable.Set(context, result);

        }


    }

    public class SetEnvironmentVariable : CodeActivity
    {
        [Category("Input")]
        public InArgument<string> Variable { get; set; }
        [Category("Input")]
        public InArgument<string> ResultVariable { get; set; }
        


        protected override void Execute(CodeActivityContext context)
        {
            Environment.SetEnvironmentVariable(Variable.Get(context), ResultVariable.Get(context));

            string result = Environment.GetEnvironmentVariable(Variable.Get(context));


        }


    }

}

    
