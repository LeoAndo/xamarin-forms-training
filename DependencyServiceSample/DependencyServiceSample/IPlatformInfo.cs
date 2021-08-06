using System;
namespace DependencyServiceSample
{
    public interface IPlatformInfo
    {
        string GetModel();
        string GetVersion();
    }
}
