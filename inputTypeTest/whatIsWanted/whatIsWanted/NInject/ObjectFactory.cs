/*
 * Created by SharpDevelop.
 * User: APetrovsky
 * Date: 12/18/2013
 * Time: 5:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace whatIsWanted
{
    using Ninject;
    using Ninject.Parameters;
    using Ninject.Extensions.Conventions;
    
    /// <summary>
    /// Description of ObjectFactory.
    /// </summary>
    public class ObjectFactory
    {
        internal static readonly IKernel Kernel;
        
        static ObjectFactory()
        {
            Kernel = new StandardKernel(new ObjectModule());
            
            Kernel.Bind(x => x
                        .FromThisAssembly()
                        .SelectAllClasses()
                        .BindAllInterfaces());
        }
        
        public static T GetObject<T>()
        {
            return Kernel.Get<T>(new Parameter[] {});
        }
    }
}
