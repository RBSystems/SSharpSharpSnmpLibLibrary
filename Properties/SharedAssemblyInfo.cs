using System.Reflection;

// The assembly version has following format :
//
// Major.Minor.Build.Revision
//
// You can specify all the values or you can use the default the Revision and
// Build Numbers by using the '*' as shown below:

[assembly: AssemblyVersion ("9.1.000401.01")]
#if !CF && !NETCF
[assembly: AssemblyFileVersion("9.1.000401.01")]
#endif
