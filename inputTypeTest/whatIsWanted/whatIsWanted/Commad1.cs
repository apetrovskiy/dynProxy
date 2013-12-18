/*
 * Created by SharpDevelop.
 * User: APetrovsky
 * Date: 12/18/2013
 * Time: 5:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace whatIsWanted
{
    using System.Management.Automation;
    
    /// <summary>
    /// Description of Commad1.
    /// </summary>
    [Cmdlet(VerbsCommon.New, "Something")]
    public class Commad1 : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            // ISomeClass someClass = new SomeClass();
            ISomeClass someClass = ObjectFactory.GetObject<ISomeClass>();
            WriteObject(someClass);
        }
    }
}
