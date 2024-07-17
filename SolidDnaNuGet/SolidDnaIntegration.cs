using AngelSix.SolidDna;
using Dna;
using static AngelSix.SolidDna.SolidWorksEnvironment;

namespace SolidDnaNuGet
{
    /// <summary>
    /// Register as a SolidWorks Add-In
    /// </summary>
    public class MyAddinIntegration : AddInIntegration
    {
        /// <summary>
        /// Specific application start-up code
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void ApplicationStartup()
        {
        }

        /// <summary>
        /// Use this to do early intitialization and any configuration of the
        /// PlugInIntegration class properties such as <see cref="PlugInIntegration.useDetachedAppDomain"/>
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void PreConnectToSolidWorks()
        {
        }

        /// <summary>
        /// Steps to take before any plug-in loads
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void PreLoadPlugIns()
        {
        }
    }

    /// <summary>
    /// Registers as a SolidDna PlugIn to be loaded by our AddIn Integration class when the
    /// SolidWorks add-in gets loaded.
    /// 
    /// Note: We can have multiple plug-ins in a single add-in
    /// </summary>
    public class MySolidDnaPlugIn : SolidPlugIn
    {
        #region Region Public Properties

        /// <summary>
        /// My Add-in description
        /// </summary>
        public override string AddInTitle => "AddIn Title";

        /// <summary>
        /// 
        /// </summary>
        public override string AddInDescription => "AddIn Description";

        #endregion

        #region Connect to SolidWorks

        public override void ConnectedToSolidWorks()
        {
            Application.ShowMessageBox("First SolidDna add-in. happy", SolidWorksMessageBoxIcon.Information);
        }

        public override void DisconnectedFromSolidWorks()
        {
        }

        #endregion
    }
}