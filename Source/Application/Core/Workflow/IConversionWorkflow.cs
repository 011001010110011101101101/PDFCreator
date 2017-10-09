﻿using pdfforge.PDFCreator.Conversion.Jobs;
using pdfforge.PDFCreator.Conversion.Jobs.Jobs;
using System;

namespace pdfforge.PDFCreator.Core.Workflow
{
    public interface IConversionWorkflow
    {
        ErrorCode? LastError { get; }

        event EventHandler JobFinished;

        WorkflowResult RunWorkflow(Job job);
    }
}
