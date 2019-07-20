using System;
using MonoDevelop.Components.Commands;
using Xwt;

namespace VSMacAddinSample
{
    public class HelloWorldCommand : CommandHandler
    {
        protected override void Run()
        {
            MessageDialog.ShowMessage("Hello world!");
        }
    }  
}
