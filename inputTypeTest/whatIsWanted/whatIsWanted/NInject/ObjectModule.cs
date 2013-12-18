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
    using Ninject.Modules;
    using Ninject.Extensions.Conventions;
    using Ninject.Extensions.NamedScope;
    
    /// <summary>
    /// Description of ObjectModule.
    /// </summary>
    public class ObjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ObjectFactory>()
                .ToSelf()
                .InSingletonScope();
        }
    }
}
