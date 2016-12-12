﻿using pdfforge.PDFCreator.Core.StartupInterface;

namespace pdfforge.PDFCreator.Core.Startup.AppStarts
{
    public abstract class AppStartBase : IAppStart
    {
        private readonly ICheckAllStartupConditions _checkAllStartupConditions;

        protected AppStartBase(ICheckAllStartupConditions checkAllStartupConditions)
        {
            _checkAllStartupConditions = checkAllStartupConditions;
        }

        public abstract ExitCode Run();

        public void CheckApplicationConditions()
        {
            _checkAllStartupConditions.CheckAll();
        }
    }
}