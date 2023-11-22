using System.Reflection;

namespace Riders.Shipments;

internal static class AssemblyReference
{
    internal static Assembly Assembly => typeof(AssemblyReference).Assembly;
}
