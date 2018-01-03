using kOS.Safe.Function;
namespace kOS.Safe.Compilation
{
    public class CompilerOptions
    {
        public bool LoadProgramsInSameAddressSpace { get; set; }
        /// <summary>
        /// IsCalledFromRun is true when this compile is being made from
        /// a context in which it was called from a RUN command such that there
        /// is a chance of there being arguments passed as parameters.  If it is
        /// the interpreter context, then this should be false to instruct the
        /// compiler NOT to attempt to look for an arg bottom marker because there
        /// will not be one.
        /// </summary>
        public bool IsCalledFromRun { get; set; }
        public IFunctionManager FuncManager { get; set; }
        public CompilerOptions()
        {
            LoadDefaults();
        }

        private void LoadDefaults()
        {
            LoadProgramsInSameAddressSpace = false;
            FuncManager = null;
            IsCalledFromRun = true;
        }
        
        public bool BuiltInExists(string identifier)
        {
            return (FuncManager == null ) ? false : FuncManager.Exists(identifier);
        }
    }
}
