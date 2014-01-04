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
    public class Command1 : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            // ISomeClass someClass = new SomeClass();
            ISomeClass someClass01 = ObjectFactory.GetObject<ISomeClass>();
            someClass01.StringData = "some class 01";
            SomeClass.StringStaticData = "static data 01";
            WriteObject(someClass01);
            ISomeClass someClass02 = ObjectFactory.GetObject<ISomeClass>();
            someClass02.StringData = "some class 02";
            SomeClass.StringStaticData = "static data 02";
            WriteObject((object)someClass02);
        }
    }
}
