using Homework8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public abstract class FileWorker
    {
        public double MaxSize { get; set; }

        public abstract string FileFormat { get; set; }

        public abstract void Read();

        public abstract void Write();

        public abstract void Delete();

        public abstract void Edit();
    }
}

public class FileWorkerChild : FileWorker
{
    
    public override string FileFormat
    {
        get { return "txt"; }
        set { }
    }

    public override void Delete()
    {
        Console.WriteLine($"I Can Delete from {FileFormat} file with max storage {MaxSize}");
    }

    public override void Edit()
    {
        Console.WriteLine($"I Can edit from {FileFormat} file with max storage {MaxSize}");

    }

    public override void Read()
    {
        Console.WriteLine($"I Can read from {FileFormat} file with max storage {MaxSize}");
    }

    public override void Write()
    {
        Console.WriteLine($"I Can write to {FileFormat} file with max storage {MaxSize}");
    }
}
