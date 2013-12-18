/*
 * Created by SharpDevelop.
 * User: APetrovsky
 * Date: 12/18/2013
 * Time: 5:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace whatIsWanted
{
    using System.Management.Automation;
    
    /// <summary>
    /// Description of Command2.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "Something")]
    public class Command2 : PSCmdlet
    {
        [Parameter(Mandatory = true,
                   ValueFromPipeline = true,
                   Position = 0)]
        [ValidateNotNull]
        public ISomeClass InputObject { get; set; }
        
        protected override void ProcessRecord()
        {
            WriteObject(this.InputObject);
        }
    }
}
