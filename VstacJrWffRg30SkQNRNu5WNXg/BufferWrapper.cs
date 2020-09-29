/* THIS IS AUTO-GENERATED CODE THAT WILL BE OVERWRITTEN! DO NOT EDIT!
*  Microsoft SQL Server Integration Services buffer wrappers
*  This module defines classes for accessing data flow buffers
*  THIS IS AUTO-GENERATED CODE THAT WILL BE OVERWRITTEN! DO NOT EDIT! */



using System;
using System.Data;
using Microsoft.SqlServer.Dts.Pipeline;
using Microsoft.SqlServer.Dts.Pipeline.Wrapper;

public class Salida0Buffer: ScriptBuffer

{
    public Salida0Buffer(PipelineBuffer Buffer, int[] BufferColumnIndexes, OutputNameMap OutputMap)
        : base(Buffer, BufferColumnIndexes, OutputMap)
    {
    }

    public Int32 Estatus
    {
        set
        {
            this[0] = value;
        }
    }
    public bool Estatus_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(0);
            }
            else
            {
                throw new InvalidOperationException("La propiedad IsNull no puede establecerse en False. En su lugar, asigne un valor a la columna.");
            }
        }
    }

    new public void AddRow()
    {
        base.AddRow();
    }

    new public void SetEndOfRowset()
    {
        base.SetEndOfRowset();
    }

    new public bool EndOfRowset()
    {
        return base.EndOfRowset();
    }

}
