using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using System.Diagnostics;

namespace Pitangueiros.GuardioesDasQuentinhas.App.Services.IoC
{
    public class IntercptorValidacao : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Debug.WriteLine($"{invocation.MethodInvocationTarget.Name}({string.Join(",", invocation.Arguments)})");
            invocation.Proceed();
        }
    }
}
