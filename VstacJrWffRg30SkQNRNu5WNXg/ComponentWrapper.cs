/* THIS IS AUTO-GENERATED CODE THAT WILL BE OVERWRITTEN! DO NOT EDIT!
*  Microsoft SQL Server Integration Services component wrapper
*  This module defines the base class for your component
*  THIS IS AUTO-GENERATED CODE THAT WILL BE OVERWRITTEN! DO NOT EDIT! */

using System;
using System.Data;
using Microsoft.SqlServer.Dts.Pipeline;
using Microsoft.SqlServer.Dts.Pipeline.Wrapper;
using Microsoft.SqlServer.Dts.Runtime.Wrapper;

public class UserComponent: ScriptComponent
{
    public Connections Connections;
    public Variables Variables;
    public UserComponent()
    {
        Connections = new Connections(this);
        Variables = new Variables(this);
    }

    public Salida0Buffer Salida0Buffer;

    public virtual void FinishOutputs()
    {
    }

    private void MarkOutputsFinished()
    {

        if (null != Salida0Buffer)
        {
            Salida0Buffer.SetEndOfRowset();
            Salida0Buffer = null;
        }

    }

    public override void PrimeOutput(int Outputs, int[] OutputIDs, PipelineBuffer[] Buffers, OutputNameMap OutputMap)
    {
       for(int Idx = 0; Idx < Outputs; Idx++)
       {
            if(OutputIDs[Idx] == GetOutputID(OutputMap, @"Salida 0"))
            {
                Salida0Buffer = new Salida0Buffer(Buffers[Idx], GetColumnIndexes(OutputIDs[Idx]), OutputMap);
            }
        }

        CreateNewOutputRows();

        FinishOutputs();
        MarkOutputsFinished();

    }

    public virtual void CreateNewOutputRows()
    {
    }

}

public class Connections
{
    ScriptComponent ParentComponent;

    public Connections(ScriptComponent Component)
    {
        ParentComponent = Component;
    }

}

public class Variables
{
    ScriptComponent ParentComponent;

    public Variables(ScriptComponent Component)
    {
        ParentComponent = Component;
    }

}
