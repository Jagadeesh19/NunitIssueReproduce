using System;
using NUnit.Framework;

namespace NunitIssueReproduce;

[Category("Class2")]
public class Class2
{
    [Test]
    public void Test()
    {
        Console.WriteLine("NunitIssueReproduce.Class2" + nameof(Test));
    }
}